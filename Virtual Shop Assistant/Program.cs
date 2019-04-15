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
            int userQuerry = Console.Read();
            if (userQuerry == 1)
            {
                Console.Clear();
                Console.WriteLine("Please select a barcode function");
                Console.WriteLine("1- Display barcode database");
                Console.WriteLine("2- Create a new barcode for an existing item");
                Console.WriteLine("3- Display an existing barcode");
                Console.WriteLine("4- Test a barcode");
                Console.WriteLine("5- Delete a barcode");
                Console.WriteLine();
                int userQuerry2 = Console.Read();
                if (userQuerry2 == 1)
                {
                    Barcode.DisplayBarcodeDatabase();
                }
                else if (userQuerry2 == 2)
                {
                    Barcode.CreateBarcodeForExistingItem();
                }
                else if (userQuerry2 == 3)
                {
                    Barcode.DisplayExistingBarcode();
                }
                else if (userQuerry2 == 4)
                {
                    Barcode.TestBarcode();
                }
                else if (userQuerry2 == 5)
                {
                    Barcode.DeleteBarcode();
                }
                else
                {
                    Console.WriteLine("This number is invalid");
                }
            }
            else if (userQuerry == 2)
            {
                Console.Clear();
                Console.WriteLine("Please select a warehouse management function");
                Console.WriteLine("1- Display warehouse database");
                Console.WriteLine("2- Create a new item entry with his barcode");
                Console.WriteLine("3- Display an item data");
                Console.WriteLine("4- Delete an item entry");
                Console.WriteLine();
                int userQuerry2 = Console.Read();
                if (userQuerry2 == 1)
                {
                    WarehouseManagement.DisplayWarehouseDatabase();
                }
                else if (userQuerry2 == 2)
                {
                    WarehouseManagement.CreateNewItemEntryWithBarcode();
                }
                else if (userQuerry2 == 3)
                {
                    WarehouseManagement.DisplayItemData();
                }
                else if (userQuerry2 == 4)
                {
                    WarehouseManagement.DeleteItemEntry();
                }
                else
                {
                    Console.WriteLine("This number is invalid");
                }
            }
        }
    }
    class Barcode
    {
        public static void DisplayBarcodeDatabase()
        {
            Console.WriteLine("Test");
        }
        public static void CreateBarcodeForExistingItem()
        {
            Console.WriteLine("Test");
        }
        public static void DisplayExistingBarcode()
        {
            Console.WriteLine("Test");
        }
        public static void TestBarcode()
        {
            Console.WriteLine("Test");
        }
        public static void DeleteBarcode()
        {
            Console.WriteLine("Test");
        }
    }
    class WarehouseManagement
    {
        public static void DisplayWarehouseDatabase()
        {
            Console.WriteLine("Test");
        }
        public static void CreateNewItemEntryWithBarcode()
        {
            Console.WriteLine("Test");
        }
        public static void DisplayItemData()
        {
            Console.WriteLine("Test");
        }
        public static void DeleteItemEntry()
        {
            Console.WriteLine("Test");
        }
    }
}
