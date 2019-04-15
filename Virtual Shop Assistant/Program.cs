using System;

namespace Virtual_Shop_Assistant
{
    class Startup
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a function category");
            Console.WriteLine("1- Barcodes");
            Console.WriteLine("2- Warehouse Management");
            Console.WriteLine("3- Customer Interactions");
            Console.WriteLine("4- Finance");
            Console.WriteLine("5- Database Management");
            Console.WriteLine("6- User Documentation");
            Console.WriteLine("7- App Documentation");
            Console.WriteLine();
            string userQuerry = Console.ReadLine();
            if (userQuerry == "1")
            {
                Console.Clear();
                Console.WriteLine("Please select a barcode function");
                Console.WriteLine("1- Display barcode database");
                Console.WriteLine("2- Create a new barcode for an existing item");
                Console.WriteLine("3- Display an existing barcode");
                Console.WriteLine("4- Test a barcode");
                Console.WriteLine("5- Delete a barcode");
                Console.WriteLine();
                string userQuerry2 = Console.ReadLine();
                if (userQuerry2 == "1")
                {
                    Barcode.DisplayBarcodeDatabase();
                }
                else if (userQuerry2 == "2")
                {
                    Barcode.CreateBarcodeForExistingItem();
                }
                else if (userQuerry2 == "3")
                {
                    Barcode.DisplayExistingBarcode();
                }
                else if (userQuerry2 == "4")
                {
                    Barcode.TestBarcode();
                }
                else if (userQuerry2 == "5")
                {
                    Barcode.DeleteBarcode();
                }
                else
                {
                    Console.WriteLine("This number is invalid");
                }
            } // Barcode Functions
            else if (userQuerry == "2")
            {
                Console.Clear();
                Console.WriteLine("Please select a warehouse management function");
                Console.WriteLine("1- Display warehouse database");
                Console.WriteLine("2- Create a new item entry with his barcode");
                Console.WriteLine("3- Display an item data");
                Console.WriteLine("4- Delete an item entry");
                Console.WriteLine();
                string userQuerry2 = Console.ReadLine();
                if (userQuerry2 == "1")
                {
                    WarehouseManagement.DisplayWarehouseDatabase();
                }
                else if (userQuerry2 == "2")
                {
                    WarehouseManagement.CreateNewItemEntryWithBarcode();
                }
                else if (userQuerry2 == "3")
                {
                    WarehouseManagement.DisplayItemData();
                }
                else if (userQuerry2 == "4")
                {
                    WarehouseManagement.DeleteItemEntry();
                }
                else
                {
                    Console.WriteLine("This number is invalid");
                }
            } // Warehouse Management Functions
            else if (userQuerry == "3")
            {
                Console.Clear();
                Console.WriteLine("Please select an customer interaction function");
                Console.WriteLine("1- Pay a bill");
                Console.WriteLine("2- Modify a bill");
                Console.WriteLine("3- Consult customer activity");
                Console.WriteLine("4- Consult the customer database");
                Console.WriteLine("5- Transfer a customer data to another customer");
                Console.WriteLine("6- Create a new customer entry");
                Console.WriteLine();
                string userQuerry2 = Console.ReadLine();
                if (userQuerry2 == "1")
                {
                    CustomerInteraction.PayBill();
                }
                else if (userQuerry2 == "2")
                {
                    CustomerInteraction.ModifyBill();
                }
                else if (userQuerry2 == "3")
                {
                    CustomerInteraction.DisplayCustomerData();
                }
                else if (userQuerry2 == "4")
                {
                    CustomerInteraction.DisplayCustomerDatabase();
                }
                else if (userQuerry2 == "5")
                {
                    CustomerInteraction.TransferDataToAnother();
                }
                else if (userQuerry2 == "6")
                {
                    CustomerInteraction.CreateNewCustomerEntry();
                }
                else
                {
                    Console.WriteLine("This number is invalid");
                }
            } // Customer Interaction Functions
            else if (userQuerry == "4")
            {
                Console.Clear();
                Console.WriteLine("Please select a finance function");
                Console.WriteLine("1- Consult last 24 hours report");
                Console.WriteLine("2- Consult last 7 days report");
                Console.WriteLine("3- Consult last 30 days report");
                Console.WriteLine("4- Consult last 12 month report");
                Console.WriteLine("5- Consult a daily report");
                Console.WriteLine("6- Consult a weekly report");
                Console.WriteLine("7- Consult a monthly report");
                Console.WriteLine("8- Consult a year report");
                Console.WriteLine("9- Consult global report");
                Console.WriteLine("10- Consult a custom report");
                Console.WriteLine("11- Add addition expenses on a specific date");
                Console.WriteLine();
                string userQuerry2 = Console.ReadLine();
                if (userQuerry2 == "1")
                {
                    Finance.PastDayReport();
                }
                else if (userQuerry2 == "2")
                {
                    Finance.PastWeekReport();
                }
                else if (userQuerry2 == "3")
                {
                    Finance.PastMonthReport();
                }
                else if (userQuerry2 == "4")
                {
                    Finance.PastYearReport();
                }
                else if (userQuerry2 == "5")
                {
                    Finance.DailyReport();
                }
                else if (userQuerry2 == "6")
                {
                    Finance.WeeklyReport();
                }
                else if (userQuerry2 == "7")
                {
                    Finance.MonthlyReport();
                }
                else if (userQuerry2 == "8")
                {
                    Finance.YearlyReport();
                }
                else if (userQuerry2 == "9")
                {
                    Finance.GlobalReport();
                }
                else if (userQuerry2 == "10")
                {
                    Finance.CustomReport();
                }
                else if (userQuerry2 == "11")
                {
                    Finance.AddExpense();
                }
                else
                {
                    Console.WriteLine("This number is invalid");
                }
            } // Finance Functions
        }
    }
    class Barcode
    {
        /// <summary>
        /// Display barcode database
        /// </summary>
        public static void DisplayBarcodeDatabase()
        {

        }
        /// <summary>
        /// Create a new barcode for an existing item
        /// </summary>
        public static void CreateBarcodeForExistingItem()
        {

        }
        /// <summary>
        /// Display an existing barcode
        /// </summary>
        public static void DisplayExistingBarcode()
        {

        }
        /// <summary>
        /// Test for a barcode
        /// </summary>
        public static void TestBarcode()
        {

        }
        /// <summary>
        /// Delete an existing barcode
        /// </summary>
        public static void DeleteBarcode()
        {

        }
    }
    class WarehouseManagement
    {
        public static void DisplayWarehouseDatabase()
        {

        }
        public static void CreateNewItemEntryWithBarcode()
        {

        }
        public static void DisplayItemData()
        {

        }
        public static void DeleteItemEntry()
        {

        }
    }
    class CustomerInteraction
    {
        /// <summary>
        /// Pay a new bill
        /// </summary>
        public static void PayBill()
        {

        }
        /// <summary>
        /// Modify an already paid bill
        /// </summary>
        public static void ModifyBill()
        {

        }
        /// <summary>
        /// Display an individual customer data
        /// </summary>
        public static void DisplayCustomerData()
        {

        }
        /// <summary>
        /// Display the customer database
        /// </summary>
        public static void DisplayCustomerDatabase()
        {

        }
        /// <summary>
        /// Transfer one customer data to another
        /// </summary>
        public static void TransferDataToAnother()
        {

        }
        /// <summary>
        /// Create a new entry for a new customer
        /// </summary>
        public static void CreateNewCustomerEntry()
        {

        }
    }
    class Finance
    {
        public static void PastDayReport()
        {

        }
        public static void PastWeekReport()
        {

        }
        public static void PastMonthReport()
        {

        }
        public static void PastYearReport()
        {

        }
        public static void DailyReport()
        {

        }
        public static void WeeklyReport()
        {

        }
        public static void MonthlyReport()
        {

        }
        public static void YearlyReport()
        {

        }
        public static void GlobalReport()
        {

        }
        public static void CustomReport()
        {

        }
        public static void AddExpense()
        {

        }
    }
    class DatabaseManagement
    {

    }
    class UserDocumentation
    {

    }
    class AppDocumentation
    {

    }
}
