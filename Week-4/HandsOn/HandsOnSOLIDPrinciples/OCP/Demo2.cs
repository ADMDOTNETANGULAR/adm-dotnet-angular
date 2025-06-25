using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnSOLIDPrinciples.OCP
{
    #region Code with out OCP
    /*
     *Let’s take an example of bank accounts like regular savings, salary savings, 
     *corporate, etc. for different customers. As for each customer type, 
     *there are different rules and different interest rates. 
     *The code below violates the OCP principle if the bank introduces a new Account type. 
     *Said code modifies this method for adding a new account type. 
     */
    //public class Account
    //{
    //    public decimal Interest { get; set; }
    //    public decimal Balance { get; set; }
    //    // members and function declaration
    //    public decimal CalcInterest(string accType)
    //    {

    //        if (accType == "Regular") // savings
    //        {
    //            Interest = (Balance * 4) / 100;
    //            if (Balance < 1000) Interest -= (Balance * 2) / 100;
    //            if (Balance < 50000) Interest += (Balance * 4) / 100;
    //        }
    //        else if (accType == "Salary") // salary savings
    //        {
    //            Interest = (Balance * 5) / 100;
    //        }
    //        else if (accType == "Corporate") // Corporate
    //        {
    //            Interest = (Balance * 3) / 100;
    //        }
    //        return Interest;
    //    }
    //}
    #endregion
    #region Code with OCP
    interface IAccount
    {
        // members and function declaration, properties
        decimal Balance { get; set; }
        decimal CalcInterest();
    }
    //regular savings account 
    public class RegularSavingAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;
        public decimal CalcInterest()
        {
            decimal Interest = (Balance * 4) / 100;
            if (Balance < 1000) Interest -= (Balance * 2) / 100;
            if (Balance < 50000) Interest += (Balance * 4) / 100;

            return Interest;
        }
    }
    //Salary savings account 
    public class SalarySavingAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;
        public decimal CalcInterest()
        {
            decimal Interest = (Balance * 5) / 100;
            return Interest;
        }
    }
    //Corporate Account
    public class CorporateAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;
        public decimal CalcInterest()
        {
            decimal Interest = (Balance * 3) / 100;
            return Interest;
        }
    }
    #endregion
    internal class Demo2
    {
    }
}
