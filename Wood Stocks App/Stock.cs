

namespace Wood_Stocks_Application
{
    // 2 of 2 classes.
    // 1 of 1 modular programming.
    // 1, 2, & 3 of 3 data types in Stock class: string, int, bool.
    // Fields are encapsulated (private) and only accessable through get/set methods.
    public class Stock
    {
        // 1, 2, 3, & 4 of 4 intstance variables.
        private string ItemCode;
        private string ItemDescription;
        private int CurrentCount;
        private bool OnOrder;

        // Constructor for Stock class passing fields through parameter.
        public Stock(string itemCode, string itemDescription, int currentCount, bool onOrder)
        {
            ItemCode = itemCode;
            ItemDescription = itemDescription;
            CurrentCount = currentCount;
            OnOrder = onOrder;
        }

        // Getting (read) & setting (Write) methods of Stock class. All fields are read-only accept
        // Current Count, that returns a value to be written as an integer. OnOrder property has a
        // method that converts boolean values from true/false to yes/no in the interface display.
        public string GetItemCode()
        {
            return ItemCode;
        }

        public string GetItemDescription()
        {
            return ItemDescription;
        }
        
        public int GetCurrentCount()
        {
            return CurrentCount;
        }

        // Method that enables Current Count to be writable.
        public void SetCurrentCount(int value)
        {
            CurrentCount = value;
        }

        public bool GetOnOrder()
        {
            return OnOrder;
        }

        // Method for conversion of boolean value from true/false to yes/no.
        // returns yes or no instead of true or false values.
        public string GetYesOrNoOnOrder()
        {
            string YesOrNo = OnOrder ? "Yes" : "No";
            return YesOrNo;
        }


    }
}
