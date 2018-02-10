using ACM.Library;
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

        //public Tuple<bool, string> ValidateEmail()
        public OperationResult ValidateEmail()
        {
            // -- Send an email receipt --
            // If the user requested a receipt
            // Get the customer data
            // Ensure a valid email address was provided.
            // If not,
            // request an email address from the user.

            //Tuple<bool, string> result = Tuple.Create(true, "");
            OperationResult result = new OperationResult();

            if (string.IsNullOrWhiteSpace(this.EmailAddress))
            {
                //isValid = false;
                //throw new ArgumentException("Email address is null");
                //result = Tuple.Create(false, "Email address is null");
                result.Success = false;
                result.AddMessage("Email address is null");
            }

            if (result.Success)
            {
                //TODO: replace isValidForm with the real code
                bool isValidFormat = true;
                if (!isValidFormat)
                {
                    //isValid = false;
                    //throw new ArgumentException("Wrong Email address format");
                    //result = Tuple.Create(false, "Wrong Email address format");
                    result.Success = false;
                    result.AddMessage("Wrong Email address format");
                }
            }

            if (result.Success)
            {
                //TODO: replace isValifDomain with the real code
                bool isValidDmain = true;
                if (!isValidDmain)
                {
                    //isValid = false;
                    //throw new ArgumentException("Invalid Email address domain");
                    //result = Tuple.Create(false, "Invalid Email address domain");
                    result.Success = false;
                    result.AddMessage("Invalid Email address domain");
                }
            }
           
            return result;
        }

        /// <summary>
        /// Calculate the percent of the step goal reached
        /// </summary>
        /// <param name="goalSteps"></param>
        /// <param name="actualSteps"></param>
        /// <returns></returns>
        public object CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            decimal steps = 0;
            decimal goal = 0;

            if (string.IsNullOrWhiteSpace(goalSteps)) { throw new ArgumentException("Goal must be entered!", "goalSteps"); }

            if (string.IsNullOrWhiteSpace(actualSteps)) { throw new ArgumentException("Actual steps must be entered!", "actualSteps"); }

            if (!decimal.TryParse(goalSteps, out goal)) { throw new ArgumentException("Goal must be numeric"); }

            if (!decimal.TryParse(actualSteps, out steps)) { throw new ArgumentException("Actual steps must be numeric", "actualSteps"); }

            if (goal <= 0) { throw new ArgumentException("Goal must be greater than zero", "goalSteps"); }

            //return (steps / goal) * 100;

            return CalculatePercentOfGoalSteps(goal, steps);
        }

        public object CalculatePercentOfGoalSteps(decimal goalSteps, decimal actualSteps)
        {
            if (goalSteps <= 0) { throw new ArgumentException("Goal must be greater than zero", "goalSteps"); }

            return Math.Round((actualSteps / goalSteps) * 100, 2);
        }
    }
}

