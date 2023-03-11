using System;
using System.Security.Cryptography.X509Certificates;

namespace dictonary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> BoatList = new Dictionary<string, string>(); 
            Dictionary<string, Int32> DepartmentList = new Dictionary<string, Int32>(); 
            Dictionary<string, float> PriceList = new Dictionary<string, float>();

            BoatList.Add("Honda", "Motor");
            BoatList.Add("Tiara", "Yaht");
            BoatList.Add("Yamaha", "Motor");
            BoatList.Add("Lund", "Fishing");
            BoatList.Add("Wakeboard", "Accessory");

            Console.WriteLine("Boatlist keys");
            Dictionary<string, string>.KeyCollection  Keys = BoatList.Keys;    
            foreach (string key in Keys)
            {
                Console.WriteLine("key: {0}", key);
            }
            Console.WriteLine();

            Console.WriteLine("BoatList values");
            Dictionary<string, string>.ValueCollection Values = BoatList.Values;
            foreach (string value in Values)
            {
                Console.WriteLine("Value: {0}", value); 
            }
            Console.WriteLine();

            Console.WriteLine("BoatList key/value pairs");
            foreach (KeyValuePair<string, string> kp in BoatList)
            {
                Console.WriteLine($"Key: {kp.Key} Value: {kp.Value}");
            }
            Console.WriteLine();
            BoatList["Honda"] = "Superior Motor";
            BoatList["Lund"] = "Boat";
            BoatList.Remove("Wakeboard");

            Console.WriteLine("------Revised BoatList key/value pairs------");
            foreach (KeyValuePair<string, Int32> kp in DepartmentList)
            {
                Console.WriteLine($"Key: {kp.Key} Value: {kp.Value}");
            }
            Console.WriteLine();

            DepartmentList.Add("Part", 1);
            DepartmentList.Add("Sales", 4);
            DepartmentList.Add("Service", 2);
            DepartmentList.Add("Leisure Boat", 3);
            bool addDept = true;
            while(addDept)
            {
                Console.WriteLine("Enter the name of Department you wish to add");
                string deptName = Console.ReadLine();
                if (DepartmentList.ContainsKey(deptName))
                {
                    DepartmentList.Remove(deptName);
                }
                Console.WriteLine("Enter the department number you wish to add");
                Int32 deptNum = Int32.Parse(Console.ReadLine());
                DepartmentList.Add(deptName, deptNum);
                Console.WriteLine("The department has been added");
                Console.WriteLine("Add another? (y for yes, any key for no)");
                string answer = Console.ReadLine();
                if (answer == "y")
                    continue;
                else
                    addDept = false;
            }
            Console.WriteLine($"There are {DepartmentList.Count} departments in the list");
            foreach (KeyValuePair <string, string> kp in BoatList)
            {
                Console.WriteLine($"Department Name: {kp.Key} Number: {kp.Value}");
                
            }
            Console.WriteLine();
            PriceList.Add("Motor", 20000f);
            PriceList.Add("Yaht", 1500000f);
            PriceList.Add("Fishing Boat", 40000f);
            PriceList.Add("Accessories", 500f);
            PriceList.Add("Leisure Boats", 40000f);
            PriceList.Add("Sales", 100f);
            PriceList.Add("Parts", 50f);
            PriceList.Add("service", 150f);

            Console.WriteLine("Prices for different departments");
            foreach (KeyValuePair<string, float> kp in PriceList)
            {
                Console.WriteLine($"Category: {kp.Key} Price: " + String.Format("{0:C}", kp.Value));
            }
            Console.WriteLine();


        }
    }
}
