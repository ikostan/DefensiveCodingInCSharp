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

            // These flags suppose to come from the UI
            var emailReceipt = true;
            bool allowSplitOrders = false;

            /*
            // Add/Save a new customer
            var customerRepository = new CustomerRepository();
            customerRepository.Add(customer);       

            // Save/Add a new Order
            OrderRepository orderRepository = new OrderRepository();
            orderRepository.Add(order);

            // Proceess an order
            InventoryRepository inventoryRepository = new InventoryRepository();
            inventoryRepository.OrderItems(order, allowSplitOrders);

            payment.ProcessPayment(payment); // Process payment

            // Reciept processing (send via email)
            if (emailReceipt)
            {
                customer.ValidateEmail(); //Validate email
                customerRepository.Update(); //?

                //Send an email
                var emailLibrary = new EmailLibrary();
                emailLibrary.SendEmail(customer.EmailAddress, "Here is your receipt");
            }
            */

            var orderController = new OrderController();
            orderController.PlaceOrder(customer, 
                                        order, 
                                        payment,
                                        allowSplitOrders: allowSplitOrders,
                                        emailReceipt: emailReceipt);
        }

    }
}