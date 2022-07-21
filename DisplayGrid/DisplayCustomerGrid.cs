using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace DisplayGrid
{
    public partial class DisplayCustomerGrid : Form
    {
        //constructor
        public DisplayCustomerGrid()
        {
            InitializeComponent();
        }

        //Entity Framework DbContext
        private Northwind.NorthwindEntities1 dbcontext =
            new Northwind.NorthwindEntities1();

        //Load data from db into DataGridView
        private void DisplayCustomerGrid_Load(object sender, EventArgs e)
        {
            //Load Customer table ordered by CompanyName
            dbcontext.Customers
                .OrderBy(Customers => Customers.CompanyName)
                .Load();

            //Specify DataSource for customerBindingSource
            customerBindingSource.DataSource = dbcontext.Customers.Local;
        }


        //Click event handler for Save Button
        private void customerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            Validate(); //Validate input fields
            customerBindingSource.EndEdit(); //Complete current edit

            //TryCatch to save changes
            try
            {
                dbcontext.SaveChanges(); //Write changes to DB file
            }
            catch (DbEntityValidationException)
            {
                MessageBox.Show("CustomerID and Company Name must contain values",
                    "Entity Validation Exception");
            }
        }
    }
}
