using ACM.BL;
using System;
using System.Windows.Forms;

namespace ACM.Win
{
    public partial class OrderWin : Form
    {

        public OrderWin()
        {
            InitializeComponent();
        }
       
        /// <summary>
        /// Button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            PlaceOrder();
        }

        /// <summary>
        /// Place a new order
        /// </summary>
        private void PlaceOrder()
        {        
            // Populate the customer instance
            var customer = new Customer();

            // Populate the order instance
            var order = new Order();

            // Populate the payment info from the UI
            var payment = new Payment();
            //payment.PaymentType = 1;

            // These flags suppose to come from the UI
            var emailReceipt = true;
            bool allowSplitOrders = false;

            var orderController = new OrderController();

            try
            {
                orderController.PlaceOrder(customer,
                                       order,
                                       payment,
                                       allowSplitOrders,
                                       emailReceipt);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message, 
                                "Error", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
                //throw;
            }          
        }
    }
}