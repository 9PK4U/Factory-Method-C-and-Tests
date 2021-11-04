using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public class LogItem
    {
        private int objectNumber;
        private string errorMessage;
        public override string ToString()
        {
            return $"Object number: {this.objectNumber}\t{this.errorMessage}";
        }
        public LogItem(int objectNumber, string errorType)
        {
            this.objectNumber = objectNumber;
            this.errorMessage = errorType;

        }
    }
}
