using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantPosCodeFirst
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Browsable(false)]
        public int ItemId { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Item Name")]
        public string ItemName { get; set; }

        [Required]
        [DisplayName("Item Price")]
        public decimal ItemPrice { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Item Category")]
        public string ItemCategory { get; set; }

        [DisplayName("Is Active")]
        public bool ItemIsActive { get; set; }
    }

    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Browsable(false)]
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("First Name")]
        public string EmployeeFirstName { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Last Name")]
        public string EmployeeLastName { get; set; }

        [Required]
        public int EmployeePin { get; set; }

        [Required]
        [DisplayName("Is Manager?")]
        public bool EmployeeIsManager { get; set; }

        [Required]
        [DisplayName("Is Active?")]
        public bool EmployeeIsActive { get; set; }
    }

    public class Table
    {
        [Key]
        [Browsable(false)]
        public int TableId { get; set; }
        public int TableNumber { get; set; }

        public override string ToString()
        {
            return "Table " + TableNumber;
        }
    }

    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItems>();
        }
           
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Browsable(false)]
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }
        public string OrderPayment { get; set;  }

        public virtual Employee Employee { get; set; }

        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }

    public partial class OrderItems
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Browsable(false)]
        public int OrderItemsId { get; set; }
        public virtual Order Order { get; set; }
        public virtual Item Item { get; set; }
    }

}
