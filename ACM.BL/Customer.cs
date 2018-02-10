using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    /// <summary>
    /// Manages a single customer.
    /// </summary>
    public class Customer
    {
        public int CustomerId { get; set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void ValidateEmail()
        {
            // -- Send an email receipt --
            // If the user requested a receipt
            // Get the customer data
            // Ensure a valid email address was provided.
            // If not,
            // request an email address from the user.
        }

        public object CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            decimal result = 0;
            decimal steps = 0;
            //var goal = Convert.ToDecimal(goalSteps);

            decimal goal = 0;
            decimal.TryParse(goalSteps, out goal);

            decimal.TryParse(actualSteps, out steps);

            if (goal > 0)
            {
                //result =  (Convert.ToDecimal(actualSteps) / goal) * 100;
                result = (steps / goal) * 100;
            }

            return result;   
        }
    }
}

