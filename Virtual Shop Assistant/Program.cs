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
            else if (userQuerry == "5")
            {
                Console.Clear();
                Console.WriteLine("Please select a database management function");
                Console.WriteLine("1- Display a database");
                Console.WriteLine("2- Display a joined database");
                Console.WriteLine("3- Display the database list");
                Console.WriteLine("4- Display an older version of an database");
                Console.WriteLine("5- Display an joined version of older databases");
                Console.WriteLine("6- Display an database version list");
                Console.WriteLine();
                string userQuerry2 = Console.ReadLine();
                if (userQuerry2 == "1")
                {
                    DatabaseManagement.DisplayActualDatabase();
                }
                else if (userQuerry2 == "2")
                {
                    DatabaseManagement.DisplayJoinedDatabase();
                }
                else if (userQuerry2 == "3")
                {
                    DatabaseManagement.DisplayDatabaseList();
                }
                else if (userQuerry2 == "4")
                {
                    DatabaseManagement.DisplayOldDatabase();
                }
                else if (userQuerry2 == "5")
                {
                    DatabaseManagement.DisplayOldJoinedDatabase();
                }
                else if (userQuerry2 == "6")
                {
                    DatabaseManagement.DisplayDatabaseVersionList();
                }
                else
                {
                    Console.WriteLine("This number is invalid");
                }
            } // Database Management Functions
            else if (userQuerry == "6")
            {
                Console.Clear();
                Console.WriteLine("Please select a user documentation function");
                Console.WriteLine("1- Display the whole document list");
                Console.WriteLine("2- Display all document matching some categories");
                Console.WriteLine("3- Display a document attributes");
                Console.WriteLine("4- Display a document content");
                Console.WriteLine("5- Modify a document");
                Console.WriteLine("6- Modify a document attributes");
                Console.WriteLine("7- Create a document");
                Console.WriteLine("8- Create a category");
                Console.WriteLine("9- Duplicate a document");
                Console.WriteLine("10- Delete a document");
                Console.WriteLine("11- Delete a category but keep its files");
                Console.WriteLine("12- Delete a category and all its files");
                Console.WriteLine();
                string userQuerry2 = Console.ReadLine();
                if (userQuerry2 == "1")
                {
                    UserDocumentation.DisplayListAllDocuments();
                }
                else if (userQuerry2 == "2")
                {
                    UserDocumentation.DisplayListMatchingDocuments();
                }
                else if (userQuerry2 == "3")
                {
                    UserDocumentation.DisplayDocumentAttributes();
                }
                else if (userQuerry2 == "4")
                {
                    UserDocumentation.DisplayDocument();
                }
                else if (userQuerry2 == "5")
                {
                    UserDocumentation.ModifyDocument();
                }
                else if (userQuerry2 == "6")
                {
                    UserDocumentation.ModifyDocumentAttributes();
                }
                else if (userQuerry2 == "7")
                {
                    UserDocumentation.CreateDocument();
                }
                else if (userQuerry2 == "8")
                {
                    UserDocumentation.CreateCategory();
                }
                else if (userQuerry2 == "9")
                {
                    UserDocumentation.DuplicateDocument();
                }
                else if (userQuerry2 == "10")
                {
                    UserDocumentation.DeleteDocument();
                }
                else if (userQuerry2 == "11")
                {
                    UserDocumentation.DeleteCategoryKeepFiles();
                }
                else if (userQuerry2 == "12")
                {
                    UserDocumentation.DeleteCategoryDeleteFiles();
                }
                else
                {
                    Console.WriteLine("This number is invalid");
                }
            } // User Documentation Functions
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
        /// <summary>
        /// Display the warehouse database
        /// </summary>
        public static void DisplayWarehouseDatabase()
        {

        }
        /// <summary>
        /// Create a new item entry and create his own barcode
        /// </summary>
        public static void CreateNewItemEntryWithBarcode()
        {

        }
        /// <summary>
        /// Display every data of an selected item
        /// </summary>
        public static void DisplayItemData()
        {

        }
        /// <summary>
        /// Delete an item from the list. This item will however still be visible on older database backup
        /// </summary>
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
        /// <summary>
        /// Display last 24 hours report
        /// </summary>
        public static void PastDayReport()
        {

        }
        /// <summary>
        /// Display last 7 days report
        /// </summary>
        public static void PastWeekReport()
        {

        }
        /// <summary>
        /// Display last 30 days report
        /// </summary>
        public static void PastMonthReport()
        {

        }
        /// <summary>
        /// Display last 365 days report
        /// </summary>
        public static void PastYearReport()
        {

        }
        /// <summary>
        /// Display an report of the selected day
        /// </summary>
        public static void DailyReport()
        {

        }
        /// <summary>
        /// Display an report of that selected week
        /// </summary>
        public static void WeeklyReport()
        {

        }
        /// <summary>
        /// Display an monthly report of the selected month
        /// </summary>
        public static void MonthlyReport()
        {

        }
        /// <summary>
        /// Display an report of that selected year
        /// </summary>
        public static void YearlyReport()
        {

        }
        /// <summary>
        /// Display an report of the whole history saved
        /// </summary>
        public static void GlobalReport()
        {

        }
        /// <summary>
        /// Display an report between two specified date that the user will choose
        /// </summary>
        public static void CustomReport()
        {

        }
        /// <summary>
        /// Add external output, marked as "other" category, and can be seen in reports
        /// </summary>
        public static void AddExpense()
        {

        }
    }
    class DatabaseManagement
    {
        /// <summary>
        /// Display the actual version of an database
        /// </summary>
        public static void DisplayActualDatabase()
        {

        }
        /// <summary>
        /// Display a joined version of multiple database following the SQL Database "Join" function
        /// </summary>
        public static void DisplayJoinedDatabase()
        {

        }
        /// <summary>
        /// Display the database list
        /// </summary>
        public static void DisplayDatabaseList()
        {

        }
        /// <summary>
        /// Display an older version of an database
        /// </summary>
        public static void DisplayOldDatabase()
        {

        }
        /// <summary>
        /// Combination of "DisplayOldDatabase" function and "DisplayJoinedDatabase" function
        /// </summary>
        public static void DisplayOldJoinedDatabase()
        {

        }
        /// <summary>
        /// Display the list of version for a database
        /// </summary>
        public static void DisplayDatabaseVersionList()
        {

        }
    }
    class UserDocumentation
    {
        /// <summary>
        /// Display a list of all documents
        /// </summary>
        public static void DisplayListAllDocuments()
        {

        }
        /// <summary>
        /// Display a list of all matching documents, filtered using categories
        /// </summary>
        public static void DisplayListMatchingDocuments()
        {

        }
        /// <summary>
        /// Display a document attributes
        /// </summary>
        public static void DisplayDocumentAttributes()
        {

        }
        /// <summary>
        /// Display a document content
        /// </summary>
        public static void DisplayDocument()
        {

        }
        /// <summary>
        /// Modify a document content
        /// </summary>
        public static void ModifyDocument()
        {

        }
        /// <summary>
        /// Modify a document attributes
        /// </summary>
        public static void ModifyDocumentAttributes()
        {

        }
        /// <summary>
        /// Create a document
        /// </summary>
        public static void CreateDocument()
        {

        }
        /// <summary>
        /// Create a category
        /// </summary>
        public static void CreateCategory()
        {

        }
        /// <summary>
        /// Duplicate a document
        /// </summary>
        public static void DuplicateDocument()
        {

        }
        /// <summary>
        /// Delete a document
        /// </summary>
        public static void DeleteDocument()
        {

        }
        /// <summary>
        /// Delete a category but keep the files from deletion
        /// </summary>
        public static void DeleteCategoryKeepFiles()
        {

        }
        /// <summary>
        /// Delete a category and all the files that are part of it
        /// </summary>
        public static void DeleteCategoryDeleteFiles()
        {

        }
    }
    class AppDocumentation
    {

    }
}
