using ACM.Library;
using Core.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderController
    {
        private CustomerRepository customerRepository { get; set; }
        private OrderRepository orderRepository { get; set; }
        private InventoryRepository inventoryRepository { get; set; }
        private EmailLibrary emailLibrary { get; set; }

        public OrderController()
        {
            customerRepository = new CustomerRepository();
            orderRepository = new OrderRepository();
            inventoryRepository = new InventoryRepository();
            emailLibrary = new EmailLibrary();
        }

        public OperationResult PlaceOrder(Customer customer, 
                                Order order, 
                                Payment payment, 
                                bool allowSplitOrders, 
                                bool emailReceipt)
        {
            //Assertions of the INVARIANTS
            Debug.Assert(customerRepository !=null, "CustomerRepository is null");
            Debug.Assert(orderRepository != null, "OrderRepository is null");
            Debug.Assert(inventoryRepository != null, "InventoryRepository is null");
            Debug.Assert(emailLibrary != null, "EmailLibrary is null");


            if (customer == null)
            {
                throw new ArgumentNullException("Customer istance is null");
            }

            if (order == null)
            {
                throw new ArgumentNullException("Order istance is null");
            }

            if (payment == null)
            {
                throw new ArgumentNullException("Payment istance is null");
            }

            var operationResult = new OperationResult();

            //Those are INVARIANTS
            customerRepository.Add(customer);           
            orderRepository.Add(order);
            inventoryRepository.OrderItems(order, allowSplitOrders);        
            payment.ProcessPayment();

            if (emailReceipt)
            {
                //string message;
                var isValidEmail = customer.ValidateEmail();
                //operationResult.Success = isValidEmail.Success;

                if (isValidEmail.Success)
                {
                    customerRepository.Update();
                    emailLibrary.SendEmail(customer.EmailAddress,
                                            "Here is your receipt");
                }
                else
                {
                    if (isValidEmail.MessageList.Any())
                    {
                        operationResult.MessageList.Add(isValidEmail.MessageList[0]);
                        System.Diagnostics.Debug.WriteLine(isValidEmail.MessageList[0]);
                    }
                }
            }

            return operationResult;
        }
    }
}
