using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
    public delegate void adddelegate();
    class Saving
    {
       

        public void deposit(int amount=500)
        {
            try
            {
                if (amount > 100000)
                {
                    throw new Exception();
                }

                Console.WriteLine("The amount you deposited:" + amount );
            }
            catch (Exception e)
            {
                Console.WriteLine("you can deposit upto 100000 only" + e);
            }
        }
    }
   class current
    {

        public void deposit(int amount1)
        {
            try
            {
                if (amount1 > 200000)
                {
                    throw new Exception();
                }

                Console.WriteLine("The amount you deposited" + amount1);
            }
            catch (Exception e)
            {
                Console.WriteLine("You can deposit upto 200000 only" + e);
            }
        }
    }
    class child
    {

        public void deposit(int amount2)
        {
            try
            {
                if (amount2 > 50000)
                {
                    throw new Exception();
                }
                Console.WriteLine("The amount you deposited " + amount2);
            }
            catch (Exception e)
            {
                Console.WriteLine("you can deposit upto 50000 only " + e);
            }
        }
    }
    class CustomerDetails
    {
        String Customername;
        int accountnumber;
        string branch;
        public void CustomerInput()
        {
            Console.WriteLine("Name of the customer");
            Customername = Console.ReadLine();
            Console.WriteLine("Please enter account number");
            accountnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your bankbranch");
            branch = Console.ReadLine();
            Console.WriteLine("________________________________________________________");
        }
        public void info()
        {
            Console.WriteLine("You are " + Customername + " your account number is " + accountnumber + " and the branch is " + branch);
           
            Console.WriteLine("*______________________________________________*");
        }
        public void atm()
        {

            Console.WriteLine("Money to be credit");
            int avalbal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(avalbal + " is credited to your account \n Thank you");
            
           
            for (int i = 1; i <= 3; i++)
            {

                Console.WriteLine("Enter You Choice:\n 1.Withdrawl\n2.CheckBal\n3.Exit");
                int Choice = Convert.ToInt32(Console.ReadLine());

                if (Choice == 1)
                {
                    Console.WriteLine("amount to withdraw");
                    int withdrawlamount = Convert.ToInt32(Console.ReadLine());
                    if (avalbal >= withdrawlamount)
                    {
                        Console.WriteLine(withdrawlamount + " withdrawn successfully");
                        int Remainbal;
                        Remainbal = avalbal - withdrawlamount;
                        Console.WriteLine(Remainbal + " is remain in your account");
                    }

                    else
                    {
                        Console.WriteLine("Insufficient balance");
                    }
                    if (i >= 3)
                    {
                        Console.WriteLine("You are exceeded your limit today");
                    }
                }
                if (Choice == 2)
                {

                    Console.WriteLine( avalbal + " is remaining in your account");
                }
                if (Choice == 3)
                {
                    Console.WriteLine("Thank you");
                    Environment.Exit(0);
                    Console.ReadKey();
                }
            }
        }
    }
    class List
    {
        public class customerInfo
        {
            public string name
            {
                get; set;
            }
            public int age
            {
                get;
                set;
            }
            public int acnum
            {
                get;
                set;
            }
            public string branch
            {
                get;
                set;
            }
            public int total
            {
                get;
                set;
            }
        };
        class Bank
        {
            public void bankInput()
            {
                Console.WriteLine("ACCOUNT TYPE\n1.Savings\n2.Current\n3.Child");
                

                Console.WriteLine("Enter you Choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Thank you for choosing savings account");
                        Console.WriteLine("Your account limit is 100000");
                        Console.WriteLine("Please enter your details");
                        CustomerDetails c1 = new CustomerDetails();
                        c1.CustomerInput();
                        c1.info();
                        Saving s = new Saving();
                        Console.WriteLine("Enter amount to be deposited in savings account");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        s.deposit(amount);
                        c1.atm();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Thank you for choosing current account");
                        Console.WriteLine("Your account limit is 200000");
                        Console.WriteLine("Please enter your details");
                        CustomerDetails c2 = new CustomerDetails();
                        c2.CustomerInput();
                        c2.info();
                        current c = new current();
                        Console.WriteLine("Enter amount to be deposited in current account");
                        int amount1 = Convert.ToInt32(Console.ReadLine());
                        c.deposit(amount1);
                        c2.atm();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Thank you for choosing Child account");
                        Console.WriteLine("Your account limit is 50000");
                        Console.WriteLine("Please enter your details");
                        CustomerDetails c3 = new CustomerDetails();
                        c3.CustomerInput();
                        c3.info();
                        child ch = new child();
                        Console.WriteLine("Enter amount to be deposit in child account");
                        int childamt = Convert.ToInt32(Console.ReadLine());
                        ch.deposit(childamt);
                        c3.atm();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("This is invalid account");
                        Console.ReadKey();
                        break;




                }


            }

            class Program
            {
                static void Main(string[] args)
                {
                    Bank b = new Bank();
                    b.bankInput();
                    customerInfo cus1 = new customerInfo()
                    {
                        
                        name = "Johncena",
                        age = 23,
                        acnum = 636456789,
                        branch = "Axis/rajajinagar",
                        total = 30000

                    };
                    customerInfo cus2 = new customerInfo()
                    {
                       
                        name = "Virat kohli",
                        age=33,
                        acnum = 656890543,
                        branch = "SBI/ernakulam",
                        total = 100099

                    };
                    customerInfo cus3 = new customerInfo()
                    {
                        
                        name = "Sachin tendulkar",
                        age=54,
                        acnum = 8094567,
                        branch = "hdfc/bandra",
                        total = 130000,
                    };
                    customerInfo cus4 = new customerInfo()
                    {

                        name = "tripple h",
                        age = 25,
                        acnum = 345673,
                        branch = "hdfc/tumkur",
                        total = 100000

                    };
                    customerInfo cus5 = new customerInfo()
                    {
                        
                        name = "Akbar babar",
                        age = 78,
                        acnum = 99906478,
                        branch = "Axis/germany",
                        total = 35000



                    };
                    List<customerInfo> cu = new List<customerInfo>();

                    cu.Add(cus1);
                    cu.Add(cus2);
                    cu.Add(cus3);
                    cu.Add(cus4);
                    cu.Add(cus5);

                    Console.WriteLine("retrieving.........");
                    foreach (customerInfo c in cu)
                    {
                        Console.WriteLine("Name={0},Age={1},Account number={2},Branch={3},Total={4}", c.name, c.age, c.acnum, c.branch, c.total);
                        Console.ReadKey();
                    }
                }


            }
        }
    }
}



