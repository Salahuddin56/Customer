using System;

namespace Customer
{
    class Program
    {
        public class CUSTOMER
        {
            int CustomerID;
            string CustomerName;
            string CustomerAddress;
            int CustomerPhoneNumber;
            string CustomerEmail;

            public CUSTOMER (int id, string name, string address, int phone, string email)
             {
                CustomerID = id;
                CustomerName = name;
                CustomerAddress = address;
                CustomerPhoneNumber = phone;
                CustomerEmail = email;
            }

            public void setcustomerinfo(int id, string name, string address, int phone, string email)
            {
                CustomerID = id;
                CustomerName = name;
                CustomerAddress = address;
                CustomerPhoneNumber = phone;
                CustomerEmail = email;
            }

            public void getcustomerinfo()
            {
                Console.WriteLine("CUSTOMER INFO:");
                Console.WriteLine("-------------");
                Console.WriteLine("Customer ID       : " + CustomerID);
                Console.WriteLine("Customer Name     : " + CustomerName);
                Console.WriteLine("Customer Address  : " + CustomerAddress);
                Console.WriteLine("Customer Phone no : " + CustomerPhoneNumber);
                Console.WriteLine("Customer Email    : " + CustomerEmail);
                Console.WriteLine("\n ");
            }

        }
    

    
        static void Main(string[] args)
        {
            CUSTOMER c1 = new CUSTOMER (201614056, "Salahuddin Elias Khan", "12/A Chandroprova, Nirjhor Residential Area, Dhaka Canttonment", 01913381164, "Salahuddinace56@gmail.com");
            c1.getcustomerinfo();

            c1.setcustomerinfo(201815076, "Raiyan Khan", "150/4 Staff Road, Dhaka Canttonment", 01715053579, "RaiyanRT@gmail.com");
            c1.getcustomerinfo();
            // Hello world
            Console.ReadKey();
         }
    }
}
