using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q.1>add method overloadf5
            Console.WriteLine("1. WAP to overload add method");
            Add a1 = new Add();
            Console.WriteLine(a1.Addition(12, 54));
            Console.WriteLine(a1.Addition(12, 54,78));
            Console.WriteLine(a1.Addition(12.6, 54));
            Console.WriteLine(a1.Addition(12.5, 54.4));
            //Q.2>
            Console.WriteLine("2. WAP to overload constructor in Employee class\r\n");
            Employee e1 = new Employee(1,"nick",56444);
            Console.WriteLine(e1.DisplayData());
            Employee e2 = new Employee("keya", 45000);
            Console.WriteLine(e2.DisplayData());

            //Q.3>
            Console.WriteLine("3. Create a class Payment having a static method payBill\r\nIf you pay the bill by cash you are not eligible for any discount  , method payBill(double amt)\r\nIf you pay by a  mode you get 15% discount on the bill  , method  payBill(double amt, String mode)\r\n");
            Payment p1 = new Payment(3000, "Paypal");
            Payment.PayBill(3000, "Paypal");
            Console.WriteLine("Discount=" + Payment.GetDiscount());
        }
    }
}
