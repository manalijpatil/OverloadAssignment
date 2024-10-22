using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OverloadAssignment
{
    public class Payment
    {
        // 3. Create a class Payment having a static method payBill
        //If you pay the bill by cash you are not eligible for any discount, method payBill(double amt)
        //If you pay by a mode you get 15% discount on the bill, method  payBill(double amt, String mode)

        private double amt;
        private string mode;
        private static double discount;

        static void PayBill()
        {
            discount = 0;
        }
        public Payment(double amt, string mode)
        {
            discount = amt-discount;
            this.amt = amt;
            this.mode = mode;
        }

        //method overload
         static void PayBill(double amt)
        {
            Console.WriteLine("You pay the bill by cash you are not eligible for any discount");
            Console.WriteLine($"Toal Bill={amt}");
        }
        public static void PayBill(double amt, string mode)
        {
            Console.WriteLine($"You get 15% discount on the bill {amt}");
            discount = amt - (0.15 * amt);
        }
        public string Print()
        {
            return $" Amount={amt}, Mode={mode}";
        }

        //static method
        public static double GetDiscount()
        {
            return discount;
        }

       
    }
}
