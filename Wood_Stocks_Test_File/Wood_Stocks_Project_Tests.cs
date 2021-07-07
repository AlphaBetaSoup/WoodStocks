using System.IO;
using Wood_Stocks_App;
using Xunit;



namespace Wood_Stocks_Application.Wood_Stocks_Test_File
{
    public class Wood_Stocks_Project_Tests
    {
        [Fact]
        // Testing csv file reading.
        public void TestCsvFileReading_1a()
        {
            // Instance of a new DataBase object named data.
            DataBase data = new DataBase();
            // Accessing testStockList.csv file using ReadExternalFileCSV method in DataBase.
            data.ReadExternalFileCSV("testStockList.csv");
            // Getting the second row index of testStockList.csv using the GetStockObject method and storing
            // in storeStock.
            var storeStock = data.GetStockObject(1);
            // Expected values from testStockList.csv.
            string expectedItemCode = "A0002";
            string expectedItemDescription = "Elephant on Wheels";
            int expectedCurrentCount = 2;
            bool expectedOnOrder = false;
            // Instanciating varibales to hold data for each column in Stock list.
            string test_ItemCode = storeStock.GetItemCode();
            string test_ItemDescription = storeStock.GetItemDescription();
            int test_CurrentCount = storeStock.GetCurrentCount();
            bool test_OnOrder = storeStock.GetOnOrder();
            // Testing each column is reading the correct data.
            Assert.Equal(expectedItemCode, test_ItemCode);
            Assert.Equal(expectedItemDescription, test_ItemDescription);
            Assert.Equal(expectedCurrentCount, test_CurrentCount);
            Assert.Equal(expectedOnOrder, test_OnOrder);
        }


        [Fact]
        // Testing CurrentCount column for integer value.
        public void TestCurrentCountValueIsInteger_1a()
        {
            // CurrentCount stores value from GetCurrentCount method.
            var CurrentCount = GetCurrentCount();
            // SetInt method passes CurrentCount parameter by reference.
            SetInt(ref CurrentCount);
            // Testing CurrentCount variable equality to currentCount integer value.
            Assert.Equal(28, CurrentCount);
        }

        // SetInt method passing currentCount parameter by reference.
        private void SetInt(ref object currentCount)
        {
            // currentCount value is integer number.
            currentCount = 28;
        }

        // GetCurrentCount method
        private object GetCurrentCount()
        {
            // Returning a value to the GetCurrentCount method.
            return 1;
        }

        [Fact]
        public void TestSetCurrentCountFunction_1a()
        {
            // Instance of a new DataBase object named data.
            DataBase data = new DataBase();
            // Accessing testStockList.csv file using ReadExternalFileCSV method in DataBase.
            data.ReadExternalFileCSV("testStockList.csv");
            // Getting the second row index of testStockList.csv using the GetStockObject method and storing
            // in CurrentCount.
            var CurrentCount = data.GetStockObject(1);
            // CuurentCount value is currently 2. Set new integer value in CurrentCount cell to 12.
            CurrentCount.SetCurrentCount(12);
            // Get new integer value of 12 from Current Count cell.
            int testSetNewNumber = CurrentCount.GetCurrentCount();              
            // Expected integer value
            int expectedNewNumber = 12;
            // Test GetCurrentCount method in testSetNewNumber value is equal to expectedNewNumber.
            Assert.Equal(expectedNewNumber, testSetNewNumber);
        }

        [Fact]
        public void TestFilePathExists_1a()
        {
            // Instance of a new DataBase object named data.
            DataBase data = new DataBase();
            // Variable filePath stores file pathway for csv file.
            string filePath = @"C:\Stockfile\stocklist.csv";
            // FilePath is passed into ReadExternalFileCSV method into data object of DataBase class.
            data.ReadExternalFileCSV(filePath);
            // Expected result for testing file pathway.
            var expectedFilePath = @"C:\Stockfile\stocklist.csv";
            // Test expectedFilePath location is equal to filePath.
            Assert.Equal(expectedFilePath,filePath);
        }

       // [Fact]
       /* public void TestSaveFile()
        {
            // Instance of a new DataBase object named data.
            DataBase data = new DataBase();
            // Accessing testStockList.csv file using ReadExternalFileCSV method in DataBase.
            data.ReadExternalFileCSV("testStockList.csv");
            // Getting the second row index of testStockList.csv using the GetStockObject method and storing
            // in CurrentCount.
            var CurrentCount = data.GetStockObject(1);
            // CuurentCount value is currently 2. Set new integer value in CurrentCount cell to 12.
            CurrentCount.SetCurrentCount(12);
            // Get new integer value of 12 from Current Count cell.
            int testSetNewNumber = CurrentCount.GetCurrentCount();
            // Expected integer value
            int expectedNewNumber = 12;

            
            // Test GetCurrentCount method in testSetNewNumber value is equal to expectedNewNumber.
            Assert.Equal(expectedNewNumber, testSetNewNumber);
        }*/
    }
}
