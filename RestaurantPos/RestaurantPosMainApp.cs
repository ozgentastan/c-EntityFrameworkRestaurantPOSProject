using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestaurantPosCodeFirst;
using System.Diagnostics;
using System.Data.Entity.Infrastructure;
using System.Xml.Serialization;

namespace RestaurantPos
{

    public partial class PosForm : Form
    {
        private RestaurantEntities context;
        private Employee loggedEmployee; // holds the current employee
        //Below dictionary is used to hold unfinished orders using table numbers for keys
        //Value is another dictionary which uses seats for keys and orders for value
        private Dictionary<string, Dictionary<string, Order>> tableOrders = new Dictionary<string, Dictionary<string, Order>>();
        string seat; // holds the current selected seat
        string table; // holds the current selected table
        public PosForm()
        {
            // A lot of initializing until methods
            // We were passing context as parameters for a while which is not correct way to handle taht
            // Could not reorginze everything at the end because we were running out of time
            //Sorry for initializing stuff in 2 different places and not disposing the first context
            InitializeComponent();
            context = new RestaurantEntities();
            context.Employees.Load();
            if (context.Employees.Count() < 1)
            {
                SeedData(context);
            }
            context.Tables.Load();
            if (context.Tables.Count() < 1)
            {
                AddTable();
            }
            InitializeTabControls();
            InitializeViews(context);
            PopulateDataGridView(dataGridViewEntrees, "Entree", "");
            PopulateDataGridView(dataGridViewDesserts, "Dessert", "");
            PopulateDataGridView(dataGridViewDrinks, "Drink", "");
            PopulateDataGridView(dataGridViewAppetizers, "Appetizer", "");
            context.SaveChanges();
            buttonLogin.Click += (s, e) => Login(context);
            buttonSeed.Click += (s, e) => SeedItemData();
            textBoxAppetizers.TextChanged += (s, e) => PopulateDataGridView(dataGridViewAppetizers, "Appetizer", textBoxAppetizers.Text.ToLower());
            textBoxEntrees.TextChanged += (s, e) => PopulateDataGridView(dataGridViewEntrees, "Entree", textBoxEntrees.Text.ToLower());
            textBoxDesserts.TextChanged += (s, e) => PopulateDataGridView(dataGridViewDesserts, "Dessert", textBoxDesserts.Text.ToLower());
            textBoxDrinks.TextChanged += (s, e) => PopulateDataGridView(dataGridViewDrinks, "Drink", textBoxDrinks.Text.ToLower());

            buttonAddTable.Click += (s, e) => AddTable();
            buttonRemoveTable.Click += (s, e) => RemoveTable();


            buttonAddAppetizer.Click += (s, e) => AddItem(context, dataGridViewAppetizers);
            buttonAddDessert.Click += (s, e) => AddItem(context, dataGridViewDesserts);
            buttonAddDrink.Click += (s, e) => AddItem(context, dataGridViewDrinks);
            buttonAddEntree.Click += (s, e) => AddItem(context, dataGridViewEntrees);
            buttonSettle.Click += (s, e) => Settle();
            buttonVoid.Click += (s, e) => Void();
            buttonAddSeat.Click += (s, e) => AddSeat();
            buttonAddItem.Click += (s, e) => AddItemToDb();
            textBoxSearchItem.TextChanged += (s, e) => DisplayManagerItems();




            seat = listBoxSeats.SelectedItem.ToString();
            table = "Table 1";
            listBoxSeats.SelectedIndexChanged += (s, e) => SetSeat();
            listBoxTables.SelectedIndexChanged += (s, e) => SetTable();
            DisplayOrders();
            checkBoxActiveItems.CheckStateChanged += (s, e) => DisplayManagerItems();
        }


        /// <summary>
        /// Seeds employees if there are none so we have a good login
        /// Uses the file we have put in the resources to do that
        /// </summary>
        /// <param name="context"></param>
        private void SeedData(RestaurantEntities context)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "RestaurantPos.Resources.employees.json";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                var serializeResult = JsonConvert.DeserializeObject<List<Employee>>(result);

                context.Employees.AddRange(serializeResult);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// This is for seeding items in a menu
        /// Opens a file dialog, seeds the data using json de serializer
        /// Then calls out display methods so we can show fresh data in data grids
        /// </summary>
        private void SeedItemData()
        {
            using (RestaurantEntities context = new RestaurantEntities())
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    InitialDirectory = Application.StartupPath,
                    Filter = "Json files (*.json)|*.json",
                    FilterIndex = 2,
                    RestoreDirectory = true
                })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (Stream stream = openFileDialog.OpenFile())
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            try
                            {
                                string result = reader.ReadToEnd();
                                var serializeResult = JsonConvert.DeserializeObject<List<Item>>(result);

                                context.Items.AddRange(serializeResult);
                                context.SaveChanges();
                                DisplayManagerItems();
                                PopulateDataGridView(dataGridViewEntrees, "Entree", "");
                                PopulateDataGridView(dataGridViewDesserts, "Dessert", "");
                                PopulateDataGridView(dataGridViewDrinks, "Drink", "");
                                PopulateDataGridView(dataGridViewAppetizers, "Appetizer", "");
                            }
                            catch
                            {
                                MessageBox.Show("Please use a correct file");
                            }
                        }
                    }
                }
            }
        }

        //To hide tab controls before login in
        private void InitializeTabControls()
        {
            tabControl.TabPages.Remove(tabPageOrders);
            tabControl.TabPages.Remove(tabPageCompletedOrders);
            tabControl.TabPages.Remove(tabPageManager);
        }

        /// <summary>
        /// Finds a user using the provided pin number
        /// Then enables correct tab controls depending on user role
        /// </summary>
        /// <param name="context"></param>
        private void Login(RestaurantEntities context)
        {
            try
            {
                int pin = int.Parse(textBoxLoginPin.Text.ToString());
                context.Employees.Load();
                var result = context.Employees
                    .Where(e => e.EmployeeIsActive == true && e.EmployeePin == pin)
                    .FirstOrDefault();

                if (result != null)
                {
                    textBoxLoginPin.Clear();
                    loggedEmployee = result;
                    if (result.EmployeeIsManager)
                    {
                        tabControl.TabPages.Add(tabPageOrders);
                        tabControl.TabPages.Add(tabPageCompletedOrders);
                        tabControl.TabPages.Add(tabPageManager);
                        tabControl.TabPages.Remove(tabPageLogin);

                    }
                    else
                    {
                        tabControl.TabPages.Add(tabPageOrders);
                        tabControl.TabPages.Add(tabPageCompletedOrders);
                        tabControl.TabPages.Remove(tabPageLogin);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Pin Number");
                    textBoxLoginPin.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong Pin Number");
                textBoxLoginPin.Clear();
            }


        }

        /// <summary>
        /// Second place to initialize views this time using context
        /// Sets everything up
        /// </summary>
        /// <param name="context"></param>
        private void InitializeViews(RestaurantEntities context)
        {
            //context.Employees.Load();
            context.Employees.Load();
            context.Items.Load();
            context.Tables.Load();

            InitializeListBoxCategories();
            InitializeComboBoxCategories();

            dataGridViewEmployees.DataSource = context.Employees.Local.ToBindingList();
            dataGridViewEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployees.AllowUserToDeleteRows = false;
            dataGridViewEmployees.CellValueChanged += (s, e) => AddOrUpdateEmployee(e);
            dataGridViewEmployees.RowValidated += (s, e) => AddOrUpdateEmployee(e);

            DisplayManagerItems();


            listBoxSeats.Items.Add("None");
            listBoxSeats.SetSelected(0, true);

            if (context.Tables.Count() < 1)
            {
                AddTable();
            }

            DisplayTable();
            DisplayListBoxTables();
            labelPrice.Text = "$0.00";
        }


        private void InitializeComboBoxCategories()
        {
            comboBoxItemCategory.Items.AddRange(new string[] { "Appetizer", "Entree", "Dessert", "Drink" });

            comboBoxItemCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void InitializeListBoxCategories()
        {

            listBoxCategories.Items.AddRange(new string[] { "All", "Appetizer", "Entree", "Dessert", "Drink" });
            listBoxCategories.SetSelected(0, true);
            listBoxCategories.SelectedIndexChanged += (s, e) => DisplayManagerItems();

        }

        /// <summary>
        /// This is for showing items based on their categories and 
        /// using the search string provided by on the orders screen
        /// </summary>
        /// <param name="dataGridView">Which grid view to display</param>
        /// <param name="category">Item Category</param>
        /// <param name="filter">Search filter</param>
        public void PopulateDataGridView(DataGridView dataGridView, string category, string filter)
        {
            using (RestaurantEntities context = new RestaurantEntities())
            {
                dataGridView.ReadOnly = true;
                dataGridView.AllowUserToAddRows = false;
                dataGridView.AllowUserToDeleteRows = false;
                dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView.ColumnCount = 3;
                dataGridView.Columns[0].Name = "Name";
                dataGridView.Columns[1].Name = "Price";
                dataGridView.Columns[2].Visible = false;
                dataGridView.RowHeadersVisible = false;
                dataGridView.Rows.Clear();
                context.Items.Load();
                var items = context.Items.Local
                    .Where(i => i.ItemCategory == category && i.ItemName.ToLower().Contains(filter)
                    && i.ItemIsActive == true)
                    .ToList();
                foreach (var item in items)
                {
                    dataGridView.Rows.Add(item.ItemName, item.ItemPrice, item.ItemId);
                }

                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        /// <summary>
        /// Adds a table to the database, using the database because number of tables
        /// should almost always be the same amount
        /// calls display methods afterwards to show fresh data
        /// </summary>
        public void AddTable()
        {
            using (RestaurantEntities context = new RestaurantEntities())
            {
                context.Tables.Load();
                int tableNumber = context.Tables.Local.Count + 1;
                Table table = new Table
                {
                    TableNumber = tableNumber
                };
                context.Tables.Add(table);
                context.SaveChanges();
                context.Entry(table).Reload();

                Dictionary<string, Order> tableOrder = new Dictionary<string, Order>();
                Order order = new Order();
                tableOrder["None"] = order;
                tableOrders[table.ToString()] = tableOrder;

                DisplayListBoxTables();
                DisplayTable();
            }
        }

        public void RemoveTable()
        {
            using (RestaurantEntities context = new RestaurantEntities())
            {
                context.Tables.Load();
                if (context.Tables.Local.Count < 2)
                {
                    MessageBox.Show("Must have at least 1 table");
                    return;
                }

                var lastTables = context.Tables
                           .OrderByDescending(t => t.TableNumber)
                           .Take(1);

                Table lastTable = lastTables.First();

                context.Tables.Attach(lastTable);
                context.Tables.Remove(lastTable);
                context.SaveChanges();

                DisplayTable();
                DisplayListBoxTables();
            }
        }

        /// <summary>
        /// Adds selected item in item datagridview to current order
        /// uses nested dictionaries for table and seats
        /// first dictionary uses table number for key and has a value of secondary dictionary
        /// second dictionary uses seat name or number for key and has a value of Order
        /// </summary>
        /// <param name="context"></param>
        /// <param name="dataGridView"></param>
        public void AddItem(RestaurantEntities context, DataGridView dataGridView)
        {

            List<int> itemIds = new List<int>();
            context.Items.Load();
            foreach (DataGridViewRow selectedItem in dataGridView.SelectedRows)
            {
                itemIds.Add(int.Parse(selectedItem.Cells[2].Value.ToString()));
            }

            Order order = new Order();


            var result = context.Items
                .Where(i => itemIds.Any(id => id == i.ItemId))
                .ToList();

            Dictionary<string, Order> tableOrder = new Dictionary<string, Order>();
            if (tableOrders.ContainsKey(table))
            {
                tableOrder = tableOrders[table];
                order = tableOrder[seat];
            }


            foreach (Item item in result)
            {
                OrderItems orderItems = new OrderItems
                {
                    Item = item,
                    Order = order
                };
                order.OrderItems.Add(orderItems);
            }

            tableOrder[seat] = order;
            tableOrders[table] = tableOrder;

            DisplayOrderSummary();
        }

        /// <summary>
        /// Finishes the order for that table-seat
        /// Uses the nested dictionary to find which order to settle
        /// then calls display methods to refresh datagridviews
        /// </summary>
        public void Settle()
        {
            using (RestaurantEntities context = new RestaurantEntities())
            {
                Order order;
                try
                {
                    order = tableOrders[table][seat];
                }
                catch
                {
                    MessageBox.Show("Please add some items first");
                    return;
                }

                if (order.OrderItems.Count < 1)
                {
                    MessageBox.Show("Please add some items first");
                    return;
                }
                order.Employee = loggedEmployee;
                order.OrderDate = DateTime.Now;

                try
                {
                    var checkedButton = groupBoxPayment.Controls.OfType<RadioButton>()
                                          .FirstOrDefault(r => r.Checked);

                    order.OrderPayment = checkedButton.Text;
                }
                catch
                {
                    MessageBox.Show("Please select payment method");
                    return;
                }


                context.Orders.Add(order);
                context.SaveChanges();
                tableOrders[table][seat] = new Order();
                DisplayOrderSummary();
                DisplayOrders();
            }
        }

        /// <summary>
        /// Gets the order from our nested dictionary using selected table and seat
        /// then shows those items in datagridview 
        /// </summary>
        public void DisplayOrderSummary()
        {
            decimal totalPrice;
            try
            {
                var orderItems = tableOrders[table][seat].OrderItems;
                var toDisplay = orderItems.Select(i => i.Item)
                    .ToList();
                dataGridViewOrderSummary.DataSource = toDisplay;
                totalPrice = toDisplay.Sum(i => i.ItemPrice);
                labelPrice.Text = totalPrice.ToString("C");
            }
            catch
            {
                dataGridViewOrderSummary.DataSource = null;
                labelPrice.Text = "$0.00";
            }
            finally
            {
                dataGridViewOrderSummary.AllowUserToAddRows = false;
                dataGridViewOrderSummary.ReadOnly = true;
                dataGridViewOrderSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                buttonDeleteFromOder.Click += (s, e) => DeleteItemFromOrder();
            }


        }

        /// <summary>
        /// Sets which table is being currently viewed by using the listboxtables
        /// </summary>
        public void SetTable()
        {
            table = listBoxTables.SelectedItem.ToString();
            DisplayOrderSummary();
            DisplaySeatListBox();
        }

        /// <summary>
        /// Sets which seat is being currently viewed by using the listboxseats 
        /// </summary>
        public void SetSeat()
        {
            seat = listBoxSeats.SelectedItem.ToString();
            DisplayOrderSummary();

        }

        /// <summary>
        /// Adds a new seat, uses the name if it is provided
        /// otherwise it is based on numbers
        /// also creates an empty order for the nested dictionary
        /// </summary>
        public void AddSeat()
        {
            string seatName = textBoxSeat.Text.Trim();

            Order order = new Order();
            Dictionary<string, Order> tableOrder = new Dictionary<string, Order>();
            try
            {
                tableOrder = tableOrders[table];
            }
            catch
            {
                tableOrder["None"] = new Order();
            }


            if (String.IsNullOrEmpty(seatName))
            {
                int seatCount = listBoxSeats.Items.Count;
                seatName = "Seat " + seatCount.ToString();
                tableOrder[seatName] = order;
                tableOrders[table] = tableOrder;
            }
            else
            {
                tableOrder[seatName] = order;
                tableOrders[table] = tableOrder;
            }
            DisplaySeatListBox();
        }

        /// <summary>
        /// Display method for our seat list box
        /// </summary>
        public void DisplaySeatListBox()
        {
            List<string> seats = new List<string>();
            try
            {
                seats.AddRange(tableOrders[table].Keys.ToList());
                listBoxSeats.Items.Clear();

                foreach (string seat in seats)
                {
                    listBoxSeats.Items.Add(seat);
                }
            }
            catch
            {

                listBoxSeats.Items.Clear();
                listBoxSeats.Items.Add("None");
            }

            try
            {
                listBoxSeats.SetSelected(0, true);
            }
            catch
            {
                listBoxSeats.Items.Add("None");
            }
            finally
            {
                seat = "None";
            }
        }



        private void AddItemToDb()
        {
            using (RestaurantEntities context = new RestaurantEntities())
            {
                if (textBoxItemName.Text.Trim().Length == 0 ||
                 textBoxItemPrice.Text.Trim().Length == 0 ||
                 comboBoxItemCategory.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Item information is missing.");
                    return;
                }
                try
                {
                    var timer = new Timer
                    {
                        Interval = 1500
                    };
                    Item newItem = new Item()
                    {
                        ItemName = textBoxItemName.Text,
                        ItemPrice = decimal.Parse(textBoxItemPrice.Text),
                        ItemCategory = comboBoxItemCategory.Text,
                        ItemIsActive = true
                    };
                    context.Items.Add(newItem);
                    context.SaveChanges();
                    labelItemStatus.Text = "Item Added Succesfully";
                    timer.Tick += (s, ev) =>
                    {
                        labelItemStatus.Text = "";
                        timer.Stop();
                    };
                    timer.Start();
                    timer.Dispose();
                    DisplayManagerItems();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Exception Found: " + ex);
                    return;
                }
            }


        }

        private void AddOrUpdateEmployee(DataGridViewCellEventArgs e)
        {

            Employee newEmployee = context.Employees.Local.ElementAtOrDefault(e.RowIndex);

            Debug.WriteLine("AddOrUpdateEmployee()"
                   + " RowIndex: "
                   + e.RowIndex
                   + " ColumnIndex: "
                   + e.ColumnIndex
                   + " Row Count: "
                   + dataGridViewEmployees.Rows.Count
                   + " NewRowIndex: "
                   + dataGridViewEmployees.NewRowIndex
                   + " Changes: "
                   + context.ChangeTracker.HasChanges()
                   + " Employee: "
                   + newEmployee);

            // NOTE: ChangeTracker will crash on cascade delete for Department,
            // so it needs to be handled in DeleteDepartment() correctly.

            if (context.ChangeTracker.HasChanges() == false || newEmployee == null)
                return;

            // only process added or modified entries

            DbEntityEntry entry = context.Entry<Employee>(newEmployee);

            var timer = new Timer
            {
                Interval = 1500 // it will Tick in 1.5 seconds
            };
            timer.Dispose();

            if (entry.State == EntityState.Added)
            {

                if ((context.Employees.FirstOrDefault(d => d.EmployeeFirstName == newEmployee.EmployeeFirstName) != null
                    && context.Employees.FirstOrDefault(d => d.EmployeeLastName == newEmployee.EmployeeLastName) != null)
                    || newEmployee.EmployeeFirstName == null
                    || newEmployee.EmployeeLastName == null
                    )
                {
                    MessageBox.Show("Employee cannot be added, already exists, or missing/incorrect fields");
                    context.Employees.Remove(newEmployee);
                    labelStatus.Text = "";
                }
                try
                {
                    context.SaveChanges();
                    labelStatus.Text = "Employee Saved Succesfully";
                    timer.Tick += (s, ev) =>
                    {
                        labelStatus.Text = "";
                        timer.Stop();
                    };
                    timer.Start();

                    dataGridViewEmployees.Refresh();
                }
                catch
                {
                    MessageBox.Show("Error: Cannot update the database - exiting");
                    Environment.Exit(1);
                }

            }
            else if (entry.State == EntityState.Modified)
            {
                if (newEmployee.EmployeeFirstName == null || newEmployee.EmployeeLastName == null)
                {
                    MessageBox.Show("Employee LastName and First Name Can not be null");
                    entry.State = EntityState.Unchanged;
                }

                try
                {
                    context.SaveChanges();
                    labelStatus.Text = "Employee Modified Succesfully";
                    timer.Tick += (s, ev) =>
                    {
                        labelStatus.Text = "";
                        timer.Stop();
                    };
                    timer.Start();

                    dataGridViewEmployees.Refresh();
                }
                catch
                {
                    MessageBox.Show("Error: Cannot update the database - exiting");
                    Environment.Exit(1);
                }

            }

        }

        private void DisplayOrders()
        {
            using (RestaurantEntities context = new RestaurantEntities())
            {
                dataGridViewCompleteOrders.ReadOnly = true;
                dataGridViewCompleteOrders.AllowUserToAddRows = false;
                dataGridViewCompleteOrders.AllowUserToDeleteRows = false;
                dataGridViewCompleteOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewCompleteOrders.MultiSelect = false;
                dataGridViewCompleteOrders.ColumnCount = 6;
                dataGridViewCompleteOrders.Columns[0].Name = "Date";
                dataGridViewCompleteOrders.Columns[1].Name = "Payment";
                dataGridViewCompleteOrders.Columns[2].Name = "Server First Name";
                dataGridViewCompleteOrders.Columns[3].Name = "Server Last Name";
                dataGridViewCompleteOrders.Columns[4].Name = "Total Price";
                dataGridViewCompleteOrders.Columns[5].Name = "id";
                dataGridViewCompleteOrders.Columns[5].Visible = false;
                dataGridViewCompleteOrders.RowHeadersVisible = false;
                dataGridViewCompleteOrders.Rows.Clear();
                context.Orders.Load();
                var orders = context.Orders.Local
                    .OrderByDescending(o => o.OrderId)
                    .ToList();
                foreach (var order in orders)
                {
                    decimal totalPrice = 0;
                    var items = order.OrderItems.ToList();
                    foreach (var item in items)
                    {
                        totalPrice += item.Item.ItemPrice;
                    }
                    dataGridViewCompleteOrders.Rows.Add(order.OrderDate, order.OrderPayment,
                        order.Employee.EmployeeFirstName, order.Employee.EmployeeLastName,
                        totalPrice, order.OrderId);
                }

                dataGridViewCompleteOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewCompleteOrders.SelectionChanged += (s, e) => DisplayOrderItems();


            }
        }

        public void DisplayOrderItems()
        {
            using (RestaurantEntities context = new RestaurantEntities())
            {
                try
                {
                    string orderId = dataGridViewCompleteOrders.SelectedRows[0].Cells[5].Value.ToString();
                    dataGridViewOrderItems.ReadOnly = true;
                    dataGridViewOrderItems.AllowUserToAddRows = false;
                    dataGridViewOrderItems.AllowUserToDeleteRows = false;
                    dataGridViewOrderItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridViewOrderItems.ColumnCount = 3;
                    dataGridViewOrderItems.Columns[0].Name = "Name";
                    dataGridViewOrderItems.Columns[1].Name = "Price";
                    dataGridViewOrderItems.Columns[2].Name = "Category";
                    dataGridViewOrderItems.RowHeadersVisible = false;
                    dataGridViewOrderItems.Rows.Clear();
                    context.Orders.Load();
                    var order = context.Orders.Local.Where(o => o.OrderId == int.Parse(orderId)).FirstOrDefault();
                    var items = order.OrderItems.ToList();
                    foreach (var item in items)
                    {
                        dataGridViewOrderItems.Rows.Add(item.Item.ItemName, item.Item.ItemPrice, item.Item.ItemCategory);
                    }
                    dataGridViewOrderItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch { }
            }
        }

        public void DisplayManagerItems()
        {
            using (RestaurantEntities context = new RestaurantEntities())
            {
                string filter, category = "";
                bool active = true;
                if (String.IsNullOrEmpty(textBoxSearchItem.Text.Trim()))
                {
                    filter = "";
                }
                else
                {
                    filter = textBoxSearchItem.Text;
                }

                switch (listBoxCategories.SelectedItem.ToString())
                {
                    case "Appetizer":
                        category = "Appetizer";
                        break;
                    case "All":
                        category = "";
                        break;
                    case "Entree":
                        category = "Entree";
                        break;
                    case "Drink":
                        category = "Drink";
                        break;
                    case "Dessert":
                        category = "Dessert";
                        break;
                }

                if (checkBoxActiveItems.Checked == true)
                {
                    active = true;
                }
                else
                {
                    active = false;
                }
                context.Items.Where(i => i.ItemName.ToLower().Contains(filter) &&
                                        i.ItemCategory.Contains(category) &&
                                        i.ItemIsActive == active)
                                        .Load();

                dataGridViewItems.DataSource = context.Items.Local.ToBindingList();
                dataGridViewItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewItems.AllowUserToDeleteRows = false;
                dataGridViewItems.AllowUserToAddRows = false;
                dataGridViewItems.RowHeadersVisible = false;
                dataGridViewItems.CellValueChanged += (s, e) => UpdateItem(e);

            }
        }

        /// <summary>
        /// removes order and items for the selected table
        /// </summary>
        public void Void()
        {
            Dictionary<string, Order> tableOrder = new Dictionary<string, Order>();
            tableOrder["None"] = new Order();
            tableOrders[table] = tableOrder;
            DisplayOrderSummary();
            DisplaySeatListBox();
        }

        public void DeleteItemFromOrder()
        {
            var order = tableOrders[table][seat];
            var orderItems = order.OrderItems.ToList();
            foreach (DataGridViewRow selectedRow in dataGridViewOrderSummary.SelectedRows)
            {
                Item selectedItem = selectedRow.DataBoundItem as Item;

                foreach (OrderItems item in orderItems)
                {
                    if (item.Item.Equals(selectedItem))
                    {
                        orderItems.Remove(item);
                        break;
                    }

                }
            }
            tableOrders[table][seat].OrderItems = orderItems;
            DisplayOrderSummary();
        }

        public void UpdateItem(DataGridViewCellEventArgs e)
        {
            using (RestaurantEntities context = new RestaurantEntities())
            {

                Item item = dataGridViewItems.Rows[e.RowIndex].DataBoundItem as Item;

                var result = context.Items.Single(i => i.ItemId == item.ItemId);
                if (result != null)
                {
                    if (result.ItemName != item.ItemName || result.ItemPrice != item.ItemPrice)
                    {
                        labelItemStatus.Text = "Cannot change Item name or price";
                        DisplayManagerItems();
                    }
                    else
                    {
                        result.ItemIsActive = item.ItemIsActive;
                        result.ItemCategory = item.ItemCategory;
                        context.SaveChanges();
                        labelItemStatus.Text = "Item Updated Successfully";
                        DisplayManagerItems();
                    }

                }
            }

        }

        public void DisplayTable()
        {
            using (RestaurantEntities context = new RestaurantEntities())
            {
                context.Tables.Load();
                dataGridViewTables.DataSource = context.Tables.Local.ToBindingList();
                dataGridViewTables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewTables.RowHeadersVisible = false;

            }
        }

        public void DisplayListBoxTables()
        {
            using (RestaurantEntities context = new RestaurantEntities())
            {
                context.Tables.Load();
                listBoxTables.DataSource = context.Tables.Local.ToBindingList();
            }
        }
    }
}
