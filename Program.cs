using System;

namespace GroupProject
{
    class Program
    {
        static void Main(string[] args)
        {

            int customerId;
             string name;
            Console.WriteLine("Hello! Welcome......");
            Console.WriteLine("Please enter your Customer ID");
            customerId=int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your Name");
            name=Console.ReadLine();
            // Console.WriteLine($"Welcome {name} ");
            // Console.WriteLine("Please enter the unit Consumed");
            // unit=decimal.Parse(Console.ReadLine());
            BillCalculator(0.00M,name,customerId);
        }

        private static void BillCalculator(decimal bills,string name,int customerId)
        {
            // int customerId;
           
            decimal unit, bill, charge=0.00M, totalBill,billSubcharge;
             
            // Console.WriteLine("Hello! Welcome......");
            // Console.WriteLine("Please enter your Customer ID");
            // customerId=int.Parse(Console.ReadLine());
            // Console.WriteLine("Please enter your Name");
            // name=Console.ReadLine();
            Console.WriteLine($"Welcome {name} ");
            Console.WriteLine("Please enter the unit Consumed");
            unit=decimal.Parse(Console.ReadLine());

            if(unit<=199)
            {
                charge=1.20M;
            }
            else if(unit>=200 && unit<400)
            {
                charge=1.50M;
            }
            else if(unit>=400&&unit<600)
            {
                charge=1.80M;
            }
            else
            {
                charge=2.00M;
            }

            bill=charge*unit;
            if(bill<100)
            {
                Console.WriteLine("Sorry Minimum bill is 100");
                Continue(bill+bills,name,customerId);
                
            }
            else if(bill>300)
            {
               
              billSubcharge=bill*15/100;
               totalBill=bill+billSubcharge;
               Console.WriteLine($"Customer ID: {customerId.ToString("000")}\nCustomer Name: {name}\nUnit Consumed: {unit}\nAmount Charges @Rs.{charge} per unit : {bill}\nSubchage Amount : {billSubcharge}\nNet Amount Paid By the Customer : {totalBill+bills}");
                Continue(totalBill+bills,name,customerId);

            }
            else
            {
                Console.WriteLine($"Customer ID: {customerId.ToString("000")}\nCustomer Name: {name}\nUnit Consumed: {unit}\nAmount Charges @Rs.{charge} per unit : {bill}\nSubchage Amount : 0\nNet Amount Paid By the Customer : {bill+bills}");
                 Continue(bill+bills,name,customerId);
            }


        }

        private static void Continue(Decimal quantity, string name,int customerId)
        {
            Console.WriteLine("Do you want to continue?");
            Console.WriteLine("Please Enter 'Yes' to continue or 'No' to cancel");
            string continueBill=Console.ReadLine();
            if(continueBill.ToLower()=="yes")
            {
                BillCalculator(quantity,name,customerId);
            }
            else if(continueBill.ToLower()=="no")
            {
                 Console.WriteLine("Thank you!");
                 Console.WriteLine($"Total Amount Paid By {name} : {quantity}");
            }
            else
            {
                Console.WriteLine("invalid Option");
                Continue(quantity,name,customerId);

            }

        }
    }
}
