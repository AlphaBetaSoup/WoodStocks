// namespaces for DataBase class.
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using Wood_Stocks_Application;

namespace Wood_Stocks_App
{
    // new class DataBase.
    public class DataBase
    {
        // list of Stock named stockDataBase.
        private List<Stock> stockDataBase;
        // construtor instanciates list of Stock.
        public DataBase()
        {
            stockDataBase = new List<Stock>();
        }
        // AddStockObject method adds stock objects to the stockDataBase.
        public void AddStockObject(Stock stock)
        {
            stockDataBase.Add(stock);
        }
        // RemoveStockObject method removes stock objects from the stockDataBase.
        public void RemoveStockObject(Stock stock)
        {
            stockDataBase.Remove(stock);
        }
        // GetStockObject method gets the index of stockDataBase data.
        public Stock GetStockObject(int index)
        {
            return stockDataBase[index];
        }
        // GetDataBaseSize gets the ammount of elements in stockDataBase.
        public int GetDataBaseSize()
        {
            return stockDataBase.Count;
        }

        public void ReadExternalFileCSV(string filePath)
        {
            // bindData method invoked upon importing file.
            // a new dataTable and list are created.
            // reading data from filePath.
            // 1 of 1 C# Utilities.
           // List<Stock> stockList = new List<Stock>();
            DataTable dataTable = new DataTable();
            // filePath is passed through and all lines of data are read from System.IO.File namesapce.
            string[] lines = File.ReadAllLines(filePath);
            // checks to see if data in lines is greater than 0. 
            // if it is, a new dataTable column is created for each headerWord.
            // the data is put into the first line or the array and separated into new columns where each
            // comma sits.
            // 1 of 3 expressions.
            if (lines.Length > 0)
            {
                // 1 of 2 arrays + standard array processing.
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                // 1 of 2 iterations.
                foreach (var headerWord in headerLabels)
                {
                    dataTable.Columns.Add(new DataColumn(headerWord));
                }
                // the for loop iterates through the rest of the file and places the data into new
                // rows, separating the data into columns by comma.
                // a row is added to the dataTable after each iteration.
                // 2 of 3 operators, increment operator (i++)
                // 2 of 2 iterations.
                for (int i = 1; i < lines.Length; i++)
                {
                    // 2 of 2 arrays + standard array processing.
                    string[] data = lines[i].Split(',');
                    DataRow dataRow = dataTable.NewRow();
                    int columnIndex = 0;
                    foreach (var headerWord in headerLabels)
                    {
                        dataRow[headerWord] = data[columnIndex++];
                    }
                    dataTable.Rows.Add(dataRow);
                }
                // for loop iterates through each row of the dataTable and adds the data in each row
                // to each column.
                // all data is written as a string, currentCount is converted from int to string.
                for (int row = 0; row < dataTable.Rows.Count; row++)
                {
                    var itemCode = (string)dataTable.Rows[row][0];
                    var itemDescription = (string)dataTable.Rows[row][1];
                    var currentCount = int.Parse((string)dataTable.Rows[row][2]);
                    var onOrder = (string)dataTable.Rows[row][3];
                    // onOrder is converted to lower case lettering.
                    var OnOrder = onOrder.ToLower().Equals("yes");
                    // new stockRecord list consists of fields from Stock class.
                    var stockRecord = new Stock(itemCode, itemDescription, currentCount, OnOrder);
                    // stockRecord is added to the stockList.
                    //stockList.Add(stockRecord);                   
                    AddStockObject(stockRecord);                   
                }
            }
        }

        public bool WriteExternalFileCsv(string filePath)
        {
            // variable named result is set to a true value.
            // result is used to check if file writes correctly.
            var result = true;
            // if the filename doesn't have an extension, an extension (.csv) is created and added to the file.
            if (!Path.HasExtension(filePath))
            {
                filePath += ".csv";
            }
            // streamWriter creates new file in selected location.
            var streamWriter = File.CreateText(filePath);

            // if statement checks and executes code block if stockDataBase is not empty.
            if (stockDataBase != null)
            {
                try 
                { 
                    // streamWriter writes header names to new file.
                    streamWriter.WriteLine("Item Code,Item Description,Current Count,On Order");
                    // loop checks stockItems in newListOfStock.
                    for (int i = 0; i < stockDataBase.Count; i++)
                    {
                        // for each item in the newListOfStock, streamWriter gets elements from stockItem and
                        // writes them to the new text file.
                        streamWriter.WriteLine(GetStockObject(i).GetItemCode() + "," +
                        stockDataBase[i].GetItemDescription() + "," +
                        stockDataBase[i].GetCurrentCount() + "," +
                        stockDataBase[i].GetYesOrNoOnOrder());
                    }
                    // to finish writing the file, streamWriter.Close() method must be invoked.
                    streamWriter.Close();
                    // result returns true to SaveFileDialog_FileOk if file is written correctly.
                    result = true;
                }
                // if an error occurs the exception is caught using catch.
                catch (Exception)
                {
                    // streamWriter will close and result will return false to SaveFileDialog_FileOk
                    // indicating that an error occured while saving the file.
                    streamWriter.Close();
                    result = false;
                }
            }
            // result is returned to SaveFileDialog_FileOk.
            return result;
        }

    }
}
