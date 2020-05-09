namespace RestaurantPos
{
    partial class PosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxLoginPin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.buttonDeleteFromOder = new System.Windows.Forms.Button();
            this.buttonVoid = new System.Windows.Forms.Button();
            this.buttonSettle = new System.Windows.Forms.Button();
            this.groupBoxPayment = new System.Windows.Forms.GroupBox();
            this.radioButtonDebit = new System.Windows.Forms.RadioButton();
            this.radioButtonCredit = new System.Windows.Forms.RadioButton();
            this.radioButtonCash = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxSeats = new System.Windows.Forms.ListBox();
            this.buttonAddSeat = new System.Windows.Forms.Button();
            this.textBoxSeat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddDrink = new System.Windows.Forms.Button();
            this.textBoxDrinks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewDrinks = new System.Windows.Forms.DataGridView();
            this.buttonAddDessert = new System.Windows.Forms.Button();
            this.textBoxDesserts = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewDesserts = new System.Windows.Forms.DataGridView();
            this.buttonAddEntree = new System.Windows.Forms.Button();
            this.textBoxEntrees = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewEntrees = new System.Windows.Forms.DataGridView();
            this.buttonAddAppetizer = new System.Windows.Forms.Button();
            this.textBoxAppetizers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewAppetizers = new System.Windows.Forms.DataGridView();
            this.labelOrderSummary = new System.Windows.Forms.Label();
            this.dataGridViewOrderSummary = new System.Windows.Forms.DataGridView();
            this.listBoxTables = new System.Windows.Forms.ListBox();
            this.tabPageCompletedOrders = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewOrderItems = new System.Windows.Forms.DataGridView();
            this.dataGridViewCompleteOrders = new System.Windows.Forms.DataGridView();
            this.tabPageManager = new System.Windows.Forms.TabPage();
            this.checkBoxActiveItems = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxSearchItem = new System.Windows.Forms.TextBox();
            this.labelItemStatus = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonSeed = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBoxItemCategory = new System.Windows.Forms.ComboBox();
            this.textBoxItemPrice = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.buttonRemoveTable = new System.Windows.Forms.Button();
            this.buttonAddTable = new System.Windows.Forms.Button();
            this.dataGridViewTables = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.tabPageOrders.SuspendLayout();
            this.groupBoxPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesserts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntrees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppetizers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderSummary)).BeginInit();
            this.tabPageCompletedOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompleteOrders)).BeginInit();
            this.tabPageManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageLogin);
            this.tabControl.Controls.Add(this.tabPageOrders);
            this.tabControl.Controls.Add(this.tabPageCompletedOrders);
            this.tabControl.Controls.Add(this.tabPageManager);
            this.tabControl.Location = new System.Drawing.Point(1, 1);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1129, 718);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageLogin.Controls.Add(this.label12);
            this.tabPageLogin.Controls.Add(this.buttonLogin);
            this.tabPageLogin.Controls.Add(this.textBoxLoginPin);
            this.tabPageLogin.Controls.Add(this.label1);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 25);
            this.tabPageLogin.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageLogin.Size = new System.Drawing.Size(1121, 689);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Login";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(476, 318);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 28);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // textBoxLoginPin
            // 
            this.textBoxLoginPin.Location = new System.Drawing.Point(476, 286);
            this.textBoxLoginPin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLoginPin.Name = "textBoxLoginPin";
            this.textBoxLoginPin.Size = new System.Drawing.Size(132, 22);
            this.textBoxLoginPin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 289);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PIN";
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageOrders.Controls.Add(this.buttonDeleteFromOder);
            this.tabPageOrders.Controls.Add(this.buttonVoid);
            this.tabPageOrders.Controls.Add(this.buttonSettle);
            this.tabPageOrders.Controls.Add(this.groupBoxPayment);
            this.tabPageOrders.Controls.Add(this.label8);
            this.tabPageOrders.Controls.Add(this.listBoxSeats);
            this.tabPageOrders.Controls.Add(this.buttonAddSeat);
            this.tabPageOrders.Controls.Add(this.textBoxSeat);
            this.tabPageOrders.Controls.Add(this.label7);
            this.tabPageOrders.Controls.Add(this.labelPrice);
            this.tabPageOrders.Controls.Add(this.label6);
            this.tabPageOrders.Controls.Add(this.buttonAddDrink);
            this.tabPageOrders.Controls.Add(this.textBoxDrinks);
            this.tabPageOrders.Controls.Add(this.label5);
            this.tabPageOrders.Controls.Add(this.dataGridViewDrinks);
            this.tabPageOrders.Controls.Add(this.buttonAddDessert);
            this.tabPageOrders.Controls.Add(this.textBoxDesserts);
            this.tabPageOrders.Controls.Add(this.label4);
            this.tabPageOrders.Controls.Add(this.dataGridViewDesserts);
            this.tabPageOrders.Controls.Add(this.buttonAddEntree);
            this.tabPageOrders.Controls.Add(this.textBoxEntrees);
            this.tabPageOrders.Controls.Add(this.label3);
            this.tabPageOrders.Controls.Add(this.dataGridViewEntrees);
            this.tabPageOrders.Controls.Add(this.buttonAddAppetizer);
            this.tabPageOrders.Controls.Add(this.textBoxAppetizers);
            this.tabPageOrders.Controls.Add(this.label2);
            this.tabPageOrders.Controls.Add(this.dataGridViewAppetizers);
            this.tabPageOrders.Controls.Add(this.labelOrderSummary);
            this.tabPageOrders.Controls.Add(this.dataGridViewOrderSummary);
            this.tabPageOrders.Controls.Add(this.listBoxTables);
            this.tabPageOrders.Location = new System.Drawing.Point(4, 25);
            this.tabPageOrders.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageOrders.Size = new System.Drawing.Size(1121, 689);
            this.tabPageOrders.TabIndex = 1;
            this.tabPageOrders.Text = "Orders";
            // 
            // buttonDeleteFromOder
            // 
            this.buttonDeleteFromOder.Location = new System.Drawing.Point(649, 260);
            this.buttonDeleteFromOder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteFromOder.Name = "buttonDeleteFromOder";
            this.buttonDeleteFromOder.Size = new System.Drawing.Size(183, 28);
            this.buttonDeleteFromOder.TabIndex = 32;
            this.buttonDeleteFromOder.Text = "Delete Selected Items";
            this.buttonDeleteFromOder.UseVisualStyleBackColor = true;
            // 
            // buttonVoid
            // 
            this.buttonVoid.Location = new System.Drawing.Point(991, 224);
            this.buttonVoid.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVoid.Name = "buttonVoid";
            this.buttonVoid.Size = new System.Drawing.Size(100, 28);
            this.buttonVoid.TabIndex = 31;
            this.buttonVoid.Text = "Void";
            this.buttonVoid.UseVisualStyleBackColor = true;
            // 
            // buttonSettle
            // 
            this.buttonSettle.Location = new System.Drawing.Point(853, 224);
            this.buttonSettle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSettle.Name = "buttonSettle";
            this.buttonSettle.Size = new System.Drawing.Size(100, 28);
            this.buttonSettle.TabIndex = 30;
            this.buttonSettle.Text = "Settle";
            this.buttonSettle.UseVisualStyleBackColor = true;
            // 
            // groupBoxPayment
            // 
            this.groupBoxPayment.Controls.Add(this.radioButtonDebit);
            this.groupBoxPayment.Controls.Add(this.radioButtonCredit);
            this.groupBoxPayment.Controls.Add(this.radioButtonCash);
            this.groupBoxPayment.Location = new System.Drawing.Point(853, 71);
            this.groupBoxPayment.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxPayment.Name = "groupBoxPayment";
            this.groupBoxPayment.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxPayment.Size = new System.Drawing.Size(93, 108);
            this.groupBoxPayment.TabIndex = 29;
            this.groupBoxPayment.TabStop = false;
            this.groupBoxPayment.Text = "Payment";
            // 
            // radioButtonDebit
            // 
            this.radioButtonDebit.AutoSize = true;
            this.radioButtonDebit.Location = new System.Drawing.Point(8, 80);
            this.radioButtonDebit.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonDebit.Name = "radioButtonDebit";
            this.radioButtonDebit.Size = new System.Drawing.Size(62, 21);
            this.radioButtonDebit.TabIndex = 23;
            this.radioButtonDebit.TabStop = true;
            this.radioButtonDebit.Text = "Debit";
            this.radioButtonDebit.UseVisualStyleBackColor = true;
            // 
            // radioButtonCredit
            // 
            this.radioButtonCredit.AutoSize = true;
            this.radioButtonCredit.Location = new System.Drawing.Point(8, 52);
            this.radioButtonCredit.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCredit.Name = "radioButtonCredit";
            this.radioButtonCredit.Size = new System.Drawing.Size(66, 21);
            this.radioButtonCredit.TabIndex = 22;
            this.radioButtonCredit.TabStop = true;
            this.radioButtonCredit.Text = "Credit";
            this.radioButtonCredit.UseVisualStyleBackColor = true;
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.Location = new System.Drawing.Point(8, 23);
            this.radioButtonCash.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(61, 21);
            this.radioButtonCash.TabIndex = 21;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "Cash";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 273);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Seats";
            // 
            // listBoxSeats
            // 
            this.listBoxSeats.FormattingEnabled = true;
            this.listBoxSeats.ItemHeight = 16;
            this.listBoxSeats.Location = new System.Drawing.Point(9, 293);
            this.listBoxSeats.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSeats.Name = "listBoxSeats";
            this.listBoxSeats.Size = new System.Drawing.Size(100, 100);
            this.listBoxSeats.TabIndex = 27;
            // 
            // buttonAddSeat
            // 
            this.buttonAddSeat.Location = new System.Drawing.Point(307, 290);
            this.buttonAddSeat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddSeat.Name = "buttonAddSeat";
            this.buttonAddSeat.Size = new System.Drawing.Size(79, 28);
            this.buttonAddSeat.TabIndex = 26;
            this.buttonAddSeat.Text = "Add";
            this.buttonAddSeat.UseVisualStyleBackColor = true;
            // 
            // textBoxSeat
            // 
            this.textBoxSeat.Location = new System.Drawing.Point(165, 293);
            this.textBoxSeat.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSeat.Name = "textBoxSeat";
            this.textBoxSeat.Size = new System.Drawing.Size(132, 22);
            this.textBoxSeat.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 273);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Add Seat";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(939, 18);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(91, 17);
            this.labelPrice.TabIndex = 20;
            this.labelPrice.Text = "dollarAmount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(849, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total Price:";
            // 
            // buttonAddDrink
            // 
            this.buttonAddDrink.Location = new System.Drawing.Point(1040, 426);
            this.buttonAddDrink.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddDrink.Name = "buttonAddDrink";
            this.buttonAddDrink.Size = new System.Drawing.Size(68, 28);
            this.buttonAddDrink.TabIndex = 18;
            this.buttonAddDrink.Text = "Add";
            this.buttonAddDrink.UseVisualStyleBackColor = true;
            // 
            // textBoxDrinks
            // 
            this.textBoxDrinks.Location = new System.Drawing.Point(929, 428);
            this.textBoxDrinks.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDrinks.Name = "textBoxDrinks";
            this.textBoxDrinks.Size = new System.Drawing.Size(101, 22);
            this.textBoxDrinks.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(925, 409);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Drinks - Search";
            // 
            // dataGridViewDrinks
            // 
            this.dataGridViewDrinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDrinks.Location = new System.Drawing.Point(929, 462);
            this.dataGridViewDrinks.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDrinks.Name = "dataGridViewDrinks";
            this.dataGridViewDrinks.RowHeadersWidth = 51;
            this.dataGridViewDrinks.Size = new System.Drawing.Size(179, 213);
            this.dataGridViewDrinks.TabIndex = 15;
            // 
            // buttonAddDessert
            // 
            this.buttonAddDessert.Location = new System.Drawing.Point(791, 426);
            this.buttonAddDessert.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddDessert.Name = "buttonAddDessert";
            this.buttonAddDessert.Size = new System.Drawing.Size(79, 28);
            this.buttonAddDessert.TabIndex = 14;
            this.buttonAddDessert.Text = "Add";
            this.buttonAddDessert.UseVisualStyleBackColor = true;
            // 
            // textBoxDesserts
            // 
            this.textBoxDesserts.Location = new System.Drawing.Point(649, 428);
            this.textBoxDesserts.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDesserts.Name = "textBoxDesserts";
            this.textBoxDesserts.Size = new System.Drawing.Size(132, 22);
            this.textBoxDesserts.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(645, 409);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Desserts - Search";
            // 
            // dataGridViewDesserts
            // 
            this.dataGridViewDesserts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDesserts.Location = new System.Drawing.Point(649, 462);
            this.dataGridViewDesserts.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDesserts.Name = "dataGridViewDesserts";
            this.dataGridViewDesserts.RowHeadersWidth = 51;
            this.dataGridViewDesserts.Size = new System.Drawing.Size(272, 213);
            this.dataGridViewDesserts.TabIndex = 11;
            // 
            // buttonAddEntree
            // 
            this.buttonAddEntree.Location = new System.Drawing.Point(427, 426);
            this.buttonAddEntree.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddEntree.Name = "buttonAddEntree";
            this.buttonAddEntree.Size = new System.Drawing.Size(79, 28);
            this.buttonAddEntree.TabIndex = 10;
            this.buttonAddEntree.Text = "Add";
            this.buttonAddEntree.UseVisualStyleBackColor = true;
            // 
            // textBoxEntrees
            // 
            this.textBoxEntrees.Location = new System.Drawing.Point(285, 428);
            this.textBoxEntrees.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEntrees.Name = "textBoxEntrees";
            this.textBoxEntrees.Size = new System.Drawing.Size(132, 22);
            this.textBoxEntrees.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 409);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Entrees - Search";
            // 
            // dataGridViewEntrees
            // 
            this.dataGridViewEntrees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntrees.Location = new System.Drawing.Point(285, 462);
            this.dataGridViewEntrees.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEntrees.Name = "dataGridViewEntrees";
            this.dataGridViewEntrees.RowHeadersWidth = 51;
            this.dataGridViewEntrees.Size = new System.Drawing.Size(356, 213);
            this.dataGridViewEntrees.TabIndex = 7;
            // 
            // buttonAddAppetizer
            // 
            this.buttonAddAppetizer.Location = new System.Drawing.Point(151, 426);
            this.buttonAddAppetizer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddAppetizer.Name = "buttonAddAppetizer";
            this.buttonAddAppetizer.Size = new System.Drawing.Size(79, 28);
            this.buttonAddAppetizer.TabIndex = 6;
            this.buttonAddAppetizer.Text = "Add";
            this.buttonAddAppetizer.UseVisualStyleBackColor = true;
            // 
            // textBoxAppetizers
            // 
            this.textBoxAppetizers.Location = new System.Drawing.Point(9, 428);
            this.textBoxAppetizers.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAppetizers.Name = "textBoxAppetizers";
            this.textBoxAppetizers.Size = new System.Drawing.Size(132, 22);
            this.textBoxAppetizers.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 409);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Appetizers - Search";
            // 
            // dataGridViewAppetizers
            // 
            this.dataGridViewAppetizers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppetizers.Location = new System.Drawing.Point(9, 462);
            this.dataGridViewAppetizers.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewAppetizers.Name = "dataGridViewAppetizers";
            this.dataGridViewAppetizers.RowHeadersWidth = 51;
            this.dataGridViewAppetizers.Size = new System.Drawing.Size(268, 213);
            this.dataGridViewAppetizers.TabIndex = 3;
            // 
            // labelOrderSummary
            // 
            this.labelOrderSummary.AutoSize = true;
            this.labelOrderSummary.Location = new System.Drawing.Point(161, 7);
            this.labelOrderSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrderSummary.Name = "labelOrderSummary";
            this.labelOrderSummary.Size = new System.Drawing.Size(108, 17);
            this.labelOrderSummary.TabIndex = 2;
            this.labelOrderSummary.Text = "Order Summary";
            // 
            // dataGridViewOrderSummary
            // 
            this.dataGridViewOrderSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderSummary.Location = new System.Drawing.Point(165, 39);
            this.dataGridViewOrderSummary.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOrderSummary.Name = "dataGridViewOrderSummary";
            this.dataGridViewOrderSummary.RowHeadersWidth = 51;
            this.dataGridViewOrderSummary.Size = new System.Drawing.Size(667, 213);
            this.dataGridViewOrderSummary.TabIndex = 1;
            // 
            // listBoxTables
            // 
            this.listBoxTables.FormattingEnabled = true;
            this.listBoxTables.ItemHeight = 16;
            this.listBoxTables.Location = new System.Drawing.Point(9, 7);
            this.listBoxTables.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxTables.Name = "listBoxTables";
            this.listBoxTables.Size = new System.Drawing.Size(100, 244);
            this.listBoxTables.TabIndex = 0;
            // 
            // tabPageCompletedOrders
            // 
            this.tabPageCompletedOrders.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageCompletedOrders.Controls.Add(this.label10);
            this.tabPageCompletedOrders.Controls.Add(this.label9);
            this.tabPageCompletedOrders.Controls.Add(this.dataGridViewOrderItems);
            this.tabPageCompletedOrders.Controls.Add(this.dataGridViewCompleteOrders);
            this.tabPageCompletedOrders.Location = new System.Drawing.Point(4, 25);
            this.tabPageCompletedOrders.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCompletedOrders.Name = "tabPageCompletedOrders";
            this.tabPageCompletedOrders.Size = new System.Drawing.Size(1121, 689);
            this.tabPageCompletedOrders.TabIndex = 2;
            this.tabPageCompletedOrders.Text = "Completed Orders";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 332);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Items";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Completed Orders";
            // 
            // dataGridViewOrderItems
            // 
            this.dataGridViewOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderItems.Location = new System.Drawing.Point(40, 352);
            this.dataGridViewOrderItems.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            this.dataGridViewOrderItems.RowHeadersWidth = 51;
            this.dataGridViewOrderItems.Size = new System.Drawing.Size(603, 185);
            this.dataGridViewOrderItems.TabIndex = 1;
            // 
            // dataGridViewCompleteOrders
            // 
            this.dataGridViewCompleteOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompleteOrders.Location = new System.Drawing.Point(40, 50);
            this.dataGridViewCompleteOrders.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCompleteOrders.Name = "dataGridViewCompleteOrders";
            this.dataGridViewCompleteOrders.RowHeadersWidth = 51;
            this.dataGridViewCompleteOrders.Size = new System.Drawing.Size(927, 185);
            this.dataGridViewCompleteOrders.TabIndex = 0;
            // 
            // tabPageManager
            // 
            this.tabPageManager.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageManager.Controls.Add(this.checkBoxActiveItems);
            this.tabPageManager.Controls.Add(this.label26);
            this.tabPageManager.Controls.Add(this.textBoxSearchItem);
            this.tabPageManager.Controls.Add(this.labelItemStatus);
            this.tabPageManager.Controls.Add(this.labelStatus);
            this.tabPageManager.Controls.Add(this.buttonSeed);
            this.tabPageManager.Controls.Add(this.label20);
            this.tabPageManager.Controls.Add(this.buttonAddItem);
            this.tabPageManager.Controls.Add(this.label19);
            this.tabPageManager.Controls.Add(this.comboBoxItemCategory);
            this.tabPageManager.Controls.Add(this.textBoxItemPrice);
            this.tabPageManager.Controls.Add(this.label18);
            this.tabPageManager.Controls.Add(this.textBoxItemName);
            this.tabPageManager.Controls.Add(this.label17);
            this.tabPageManager.Controls.Add(this.label16);
            this.tabPageManager.Controls.Add(this.dataGridViewItems);
            this.tabPageManager.Controls.Add(this.listBoxCategories);
            this.tabPageManager.Controls.Add(this.buttonRemoveTable);
            this.tabPageManager.Controls.Add(this.buttonAddTable);
            this.tabPageManager.Controls.Add(this.dataGridViewTables);
            this.tabPageManager.Controls.Add(this.label15);
            this.tabPageManager.Controls.Add(this.dataGridViewEmployees);
            this.tabPageManager.Controls.Add(this.label11);
            this.tabPageManager.Location = new System.Drawing.Point(4, 25);
            this.tabPageManager.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageManager.Name = "tabPageManager";
            this.tabPageManager.Size = new System.Drawing.Size(1121, 689);
            this.tabPageManager.TabIndex = 3;
            this.tabPageManager.Text = "Manager";
            // 
            // checkBoxActiveItems
            // 
            this.checkBoxActiveItems.AutoSize = true;
            this.checkBoxActiveItems.Checked = true;
            this.checkBoxActiveItems.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActiveItems.Location = new System.Drawing.Point(333, 297);
            this.checkBoxActiveItems.Name = "checkBoxActiveItems";
            this.checkBoxActiveItems.Size = new System.Drawing.Size(105, 21);
            this.checkBoxActiveItems.TabIndex = 34;
            this.checkBoxActiveItems.Text = "Active Items";
            this.checkBoxActiveItems.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(445, 298);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(57, 17);
            this.label26.TabIndex = 33;
            this.label26.Text = "Search:";
            // 
            // textBoxSearchItem
            // 
            this.textBoxSearchItem.Location = new System.Drawing.Point(510, 295);
            this.textBoxSearchItem.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchItem.Name = "textBoxSearchItem";
            this.textBoxSearchItem.Size = new System.Drawing.Size(207, 22);
            this.textBoxSearchItem.TabIndex = 32;
            // 
            // labelItemStatus
            // 
            this.labelItemStatus.AutoSize = true;
            this.labelItemStatus.Location = new System.Drawing.Point(141, 512);
            this.labelItemStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelItemStatus.Name = "labelItemStatus";
            this.labelItemStatus.Size = new System.Drawing.Size(0, 17);
            this.labelItemStatus.TabIndex = 30;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(9, 244);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 17);
            this.labelStatus.TabIndex = 28;
            // 
            // buttonSeed
            // 
            this.buttonSeed.Location = new System.Drawing.Point(190, 292);
            this.buttonSeed.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSeed.Name = "buttonSeed";
            this.buttonSeed.Size = new System.Drawing.Size(117, 28);
            this.buttonSeed.TabIndex = 27;
            this.buttonSeed.Text = "Add From File";
            this.buttonSeed.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(141, 304);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 17);
            this.label20.TabIndex = 23;
            this.label20.Text = "Items";
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(636, 556);
            this.buttonAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(127, 28);
            this.buttonAddItem.TabIndex = 22;
            this.buttonAddItem.Text = "Add Item";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(463, 540);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 17);
            this.label19.TabIndex = 21;
            this.label19.Text = "Item Category";
            // 
            // comboBoxItemCategory
            // 
            this.comboBoxItemCategory.FormattingEnabled = true;
            this.comboBoxItemCategory.Location = new System.Drawing.Point(467, 560);
            this.comboBoxItemCategory.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxItemCategory.Name = "comboBoxItemCategory";
            this.comboBoxItemCategory.Size = new System.Drawing.Size(160, 24);
            this.comboBoxItemCategory.TabIndex = 20;
            // 
            // textBoxItemPrice
            // 
            this.textBoxItemPrice.Location = new System.Drawing.Point(313, 560);
            this.textBoxItemPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxItemPrice.Name = "textBoxItemPrice";
            this.textBoxItemPrice.Size = new System.Drawing.Size(132, 22);
            this.textBoxItemPrice.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(309, 540);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 17);
            this.label18.TabIndex = 18;
            this.label18.Text = "Item Price";
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Location = new System.Drawing.Point(145, 560);
            this.textBoxItemName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(132, 22);
            this.textBoxItemName.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(141, 540);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 17);
            this.label17.TabIndex = 16;
            this.label17.Text = "Item Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 304);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 17);
            this.label16.TabIndex = 15;
            this.label16.Text = "Item Category";
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(145, 324);
            this.dataGridViewItems.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowHeadersWidth = 51;
            this.dataGridViewItems.Size = new System.Drawing.Size(592, 185);
            this.dataGridViewItems.TabIndex = 14;
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.ItemHeight = 16;
            this.listBoxCategories.Location = new System.Drawing.Point(13, 324);
            this.listBoxCategories.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(109, 116);
            this.listBoxCategories.TabIndex = 13;
            // 
            // buttonRemoveTable
            // 
            this.buttonRemoveTable.Location = new System.Drawing.Point(961, 247);
            this.buttonRemoveTable.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveTable.Name = "buttonRemoveTable";
            this.buttonRemoveTable.Size = new System.Drawing.Size(117, 28);
            this.buttonRemoveTable.TabIndex = 12;
            this.buttonRemoveTable.Text = "Remove Table";
            this.buttonRemoveTable.UseVisualStyleBackColor = true;
            // 
            // buttonAddTable
            // 
            this.buttonAddTable.Location = new System.Drawing.Point(836, 247);
            this.buttonAddTable.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddTable.Name = "buttonAddTable";
            this.buttonAddTable.Size = new System.Drawing.Size(117, 28);
            this.buttonAddTable.TabIndex = 11;
            this.buttonAddTable.Text = "Add Table";
            this.buttonAddTable.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTables
            // 
            this.dataGridViewTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTables.Location = new System.Drawing.Point(836, 55);
            this.dataGridViewTables.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTables.Name = "dataGridViewTables";
            this.dataGridViewTables.RowHeadersWidth = 51;
            this.dataGridViewTables.Size = new System.Drawing.Size(240, 185);
            this.dataGridViewTables.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(832, 36);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 17);
            this.label15.TabIndex = 9;
            this.label15.Text = "Tables";
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(13, 64);
            this.dataGridViewEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.RowHeadersWidth = 51;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(724, 185);
            this.dataGridViewEmployees.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 36);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Add or Edit Employees:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(616, 289);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Pin: 7021";
            // 
            // PosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 718);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PosForm";
            this.Text = "Restaurant Pos";
            this.tabControl.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.tabPageLogin.PerformLayout();
            this.tabPageOrders.ResumeLayout(false);
            this.tabPageOrders.PerformLayout();
            this.groupBoxPayment.ResumeLayout(false);
            this.groupBoxPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesserts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntrees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppetizers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderSummary)).EndInit();
            this.tabPageCompletedOrders.ResumeLayout(false);
            this.tabPageCompletedOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompleteOrders)).EndInit();
            this.tabPageManager.ResumeLayout(false);
            this.tabPageManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageLogin;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.ListBox listBoxTables;
        private System.Windows.Forms.Button buttonAddDrink;
        private System.Windows.Forms.TextBox textBoxDrinks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewDrinks;
        private System.Windows.Forms.Button buttonAddDessert;
        private System.Windows.Forms.TextBox textBoxDesserts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewDesserts;
        private System.Windows.Forms.Button buttonAddEntree;
        private System.Windows.Forms.TextBox textBoxEntrees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewEntrees;
        private System.Windows.Forms.Button buttonAddAppetizer;
        private System.Windows.Forms.TextBox textBoxAppetizers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewAppetizers;
        private System.Windows.Forms.Label labelOrderSummary;
        private System.Windows.Forms.DataGridView dataGridViewOrderSummary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxSeats;
        private System.Windows.Forms.Button buttonAddSeat;
        private System.Windows.Forms.TextBox textBoxSeat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonDebit;
        private System.Windows.Forms.RadioButton radioButtonCredit;
        private System.Windows.Forms.RadioButton radioButtonCash;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonVoid;
        private System.Windows.Forms.Button buttonSettle;
        private System.Windows.Forms.GroupBox groupBoxPayment;
        private System.Windows.Forms.TabPage tabPageCompletedOrders;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewOrderItems;
        private System.Windows.Forms.DataGridView dataGridViewCompleteOrders;
        private System.Windows.Forms.TabPage tabPageManager;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBoxItemCategory;
        private System.Windows.Forms.TextBox textBoxItemPrice;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.Button buttonRemoveTable;
        private System.Windows.Forms.Button buttonAddTable;
        private System.Windows.Forms.DataGridView dataGridViewTables;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button buttonSeed;
        private System.Windows.Forms.TextBox textBoxLoginPin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelItemStatus;
        private System.Windows.Forms.Button buttonDeleteFromOder;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBoxSearchItem;
        private System.Windows.Forms.CheckBox checkBoxActiveItems;
        private System.Windows.Forms.Label label12;
    }
}

