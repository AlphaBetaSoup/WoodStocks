// namespaces used for windows form.
using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Wood_Stocks_App;

namespace Wood_Stocks_Application
{
    // 1 of 2 classes.
    // 1 of 1 inheritance.
    public partial class WoodStocks : Form
    {
        // new constructor of DataBase class instanciated in Form
        // and stored in stockDataBase field.
        DataBase stockDataBase = new DataBase();
        // Field named stream created in the Form that uses StreamReader class
        // for displaying xml data in a browser.
        StreamReader stream;

        public WoodStocks()
        {
            // invokes initialising of components for woodStocks form.
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // method invoked to load the form.
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            // when "Import" button is clicked, openFileDialog displays window to select a 
            // file to load. When "Open" is clicked, OpenFileDialog_FileOk method is invoked.
            // 1 of 1 sequences.
            OpenFileDialog.ShowDialog();
            // textBox will display the file name of the selected file in the display of the UI. 
            // 1 of 3 operators, assignment operator (=).
            TextBox.Text = OpenFileDialog.FileName;
        }

        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            // selected fileName in location is opened and assigned to filePath.
            string filePath = OpenFileDialog.FileName;
            // filePath is passed through stockDataBase.ReadExternalFileCSV method
            // in DataBase class to read the data in the file.
            stockDataBase.ReadExternalFileCSV(filePath);           
            // all the rows in DataGridView are cleared with Clear() method invoked.
            DataGridView.Rows.Clear();
            // for loop uses GetDataBaseSize to get the number of elements in stockDataBase
            for (int i = 0; i < stockDataBase.GetDataBaseSize(); i++)
            {
                // a new row that takes string values is added to the dataGrid in every
                // iteration.
                DataGridView.Rows.Add(new string[]
                {
                // stockDataBase.GetStockObject gets the index value and assigns correlating
                // values for each column.
                stockDataBase.GetStockObject(i).GetItemCode(),
                stockDataBase.GetStockObject(i).GetItemDescription(),
                Convert.ToString(stockDataBase.GetStockObject(i).GetCurrentCount()),
                stockDataBase.GetStockObject(i).GetYesOrNoOnOrder()
                });
            }         
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // method invoked when a file is imported into the form or new file is saved.
            // displays file location path way.
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGridView_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            // method checks and arranges currentCount values when column header is clicked.    
            // 3 of 3 operators, equal to operator (==).
            // 2 of 3 expressions.
            if (e.Column.Index == 2)
            {
                int v1 = int.Parse(e.CellValue1.ToString());
                int v2 = int.Parse(e.CellValue2.ToString());
                // compares cell value of v1 and v2, subtracts v2 from v1 and arranges in numeric order.
                e.SortResult = v1 - v2;
                e.Handled = true;
            }
        }

        private void DataGridView_CellAndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // 1 of 1 selections.
            // currentCell is the value of the cell that is imported into the dataGridView.
            string CurrentCell = (string)DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            // checks to see if a number was entered.
            try
            {
                // number parses the currentCell outputting an integer value.
                var number = int.Parse(CurrentCell);
                // checks to see if a number greater than or equal to zero was entered.
                // codeBlock is executed if the value place in the cell is a number of 0 or greater.
                // 3 of 3 expressions.
                if (number >= 0)
                {
                    // code sets the new number in the cell.
                    stockDataBase.GetStockObject(e.RowIndex).SetCurrentCount(number);
                }
                else
                {
                    // code resets the value of the cell to most recent correctly entered value.
                    DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = stockDataBase.GetStockObject(e.RowIndex).GetCurrentCount();
                    // messageBox indicates that an incorrect value was detected and asks the user to put in a valid value.
                    MessageBox.Show("Negative stock figures are not valid entries. \nPlease enter a number. 0 or greater.");
                }           
            }          
            // code block is executed if the value placed in the cell is a character or decimal number.
            catch (FormatException)
            {
                // code resets the value of the cell to most recent correctly entered value.
                DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = stockDataBase.GetStockObject(e.RowIndex).GetCurrentCount();
                // messageBox indicates that an incorrect value was detected and asks the user to put in a valid value.
                MessageBox.Show("Characters, letters and decimals are not valid entries. \nPlease enter a number into the field.");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // when Save button is clicked box displays option for selecting a location to put the file in. 
            // saveFileDialog_FileOk method is invoked upon clicking Save button in box. Cancel button closes box.
            SaveFileDialog.ShowDialog();
        }

        private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {

            // fileName selected in SaveFileDialog is stored in in string variable filePath.
            string filePath = SaveFileDialog.FileName;
            // methods called from DataBase class to write csv and xml file formats.
            var resultCsv = stockDataBase.WriteExternalFileCsv(filePath);
            var resultXml = stockDataBase.WriteExternalFileXml(filePath);
            // validation logic in resultCsv and resultXml checks to see that file is written 
            // to location corretly and displays a message box to indicate whether it was or not.
            // a csv or xml file will will be checked in the if condition.
            if (resultCsv || resultXml)
            {
                MessageBox.Show("The file was saved.");
            }
            else
            {
                MessageBox.Show("An error has occured. Please try again.");
            }
        }        

        private void XmlStyleButton1_Click(object sender, EventArgs e)
        {
            // button for xml style1.
            // if statement checks to see if the stream has a style in it already.
            // if it does it is closed before opening style1. This exists because if 
            // another xml style is already in the browser when selecting this style 
            // the program crashes.
            if (this.stream != null)
            {
                this.stream.Close();
            }
            // XmlWriter class uses create method to create first style display for xml 
            // named "style1.xml" and stores in xmlWriter variable.
            XmlWriterSettings settings = new XmlWriterSettings();
            {
                // encoding is set.
                settings.Encoding = Encoding.Unicode;
                // indentation is set.
                settings.Indent = true;
            }
            XmlWriter xmlWriter = XmlWriter.Create("style1.xml",settings);

            // xmlWriter.WriteStartDocument method enables the xml file to start being written.
            xmlWriter.WriteStartDocument();
            // xmlWriter.WriteStartElement writes root element.
            xmlWriter.WriteStartElement("Stocks");
            // for condition iterates through and gets data in stockDataBase.
            for (int i = 0; i < stockDataBase.GetDataBaseSize(); i++)
            {
                // xmlWriter.WriteStartElement writes parent elements.
                xmlWriter.WriteStartElement("Stock");
                // WriteElementString writes child elements.
                xmlWriter.WriteElementString("ItemCode", stockDataBase.GetStockObject(i).GetItemCode());
                xmlWriter.WriteElementString("ItemDescription", stockDataBase.GetStockObject(i).GetItemDescription());
                xmlWriter.WriteElementString("CurrentCount", Convert.ToString(stockDataBase.GetStockObject(i).GetCurrentCount()));
                xmlWriter.WriteElementString("OnOrder", stockDataBase.GetStockObject(i).GetYesOrNoOnOrder());
                // WriteStartElement writes end of parent element.
                xmlWriter.WriteEndElement();
            }
            // xmlWriter.Flush flushes stream and buffer.
            xmlWriter.Flush();
            // xmlWriter.Close(); finishes and closes the writer.
            xmlWriter.Close();
            // new StreamReader containing "style1.xml" is stored in the stream field.
            this.stream = new StreamReader("style1.xml");
            // webBrowser1.DocumentStream displays stream of "style1.xml" in browser display of application.
            WebBrowser1.DocumentStream = stream.BaseStream;
        }

        private void XmlStyleButton2_Click(object sender, EventArgs e)
        {
            // button for xml style2.
            // if statement checks to see if the stream has a style in it already.
            // if it does it is closed before opening style2. This exists because if 
            // another xml style is already in the browser when selecting this style 
            // the program crashes.
            if (this.stream != null)
            {
                this.stream.Close();
            }
            // XmlWriter class uses create method to create first style display for xml 
            // named "style2.xml" and stores in xmlWriter variable.
            XmlWriter xmlWriter = XmlWriter.Create("style2.xml");
            // xmlWriter.WriteStartDocument method enables the xml file to start being written.
            xmlWriter.WriteStartDocument();
            // WriteStartElement writes root element.
            xmlWriter.WriteStartElement("Stocks");
            // for condition iterates through and gets data in stockDataBase.
            for (int i = 0; i < stockDataBase.GetDataBaseSize(); i++)
            {
                // WriteStartElement writes parent element.
                xmlWriter.WriteStartElement("Stock");
                // WriteElementString writes child elements.
                xmlWriter.WriteAttributeString("OnOrder", stockDataBase.GetStockObject(i).GetYesOrNoOnOrder());
                xmlWriter.WriteAttributeString("CurrentCount", Convert.ToString(stockDataBase.GetStockObject(i).GetCurrentCount()));
                xmlWriter.WriteAttributeString("ItemDescription", stockDataBase.GetStockObject(i).GetItemDescription());
                xmlWriter.WriteAttributeString("ItemCode", stockDataBase.GetStockObject(i).GetItemCode());
                // WriteStartElement writes end of parent element.
                xmlWriter.WriteEndElement();
            }
              // xmlWriter.Flush flushes stream and buffer.
              xmlWriter.Flush();
              // xmlWriter.Close(); finishes and closes the writter.
              xmlWriter.Close();

            // new StreamReader containing "style2.xml" is stroed in the stream field.
            this.stream = new StreamReader("style2.xml");
            // webBrowser1.DocumentStream displays stream of "style1.xml" in browser display of application.
            WebBrowser1.DocumentStream = stream.BaseStream;
        }
    }
}


