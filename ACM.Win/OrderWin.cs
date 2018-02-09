using ACM.BL;
using Core.Common;
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
       
        private void button1_Click(object sender, EventArgs e)
        {
            PlaceOrder();
        }

        private void PlaceOrder()
        {
            // Populate the customer instance
            var customer = new Customer();

            // Add/Save a new customer
            var customerRepository = new CustomerRepository();
            customerRepository.Add(customer);

            // Populate the order instance
            var order = new Order();

            // Save/Add a new Order
            OrderRepository orderRepository = new OrderRepository();
            orderRepository.Add(order);

            // Proceess an order
            InventoryRepository inventoryRepository = new InventoryRepository();
            bool allowSplitOrders = false;
            inventoryRepository.OrderItems(order, allowSplitOrders);

            // Populate the payment info from the UI
            var payment = new Payment();
            payment.ProcessPayment(payment); // Process payment

            var emailReceipt = true;

            // Reciept processing (send via email)
            if (emailReceipt)
            {
                customer.ValidateEmail(); //Validate email
                customerRepository.Update(); //?

                //Send an email
                var emailLibrary = new EmailLibrary();
                emailLibrary.SendEmail(customer.EmailAddress, "Here is your receipt");
            }

            //var orderController = new OrderController();
            //orderController.PlaceOrder(customer, order, payment, 
            //    allowSplitOrders:false, 
            //    emailReceipt:true);
        }

    }
}