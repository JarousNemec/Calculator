using System;

namespace test_neceho
{
    public class CoProcessor
    {
        private string cislo1 = "";
        private string cislo2 = "";
        private string countOperator = "";
        private string result = "";

        
        
        public string getResult()
        {
            if (cislo1.Equals("") || cislo2.Equals(""))
            {
                return cislo1 + " " + countOperator;

            }

            int first = Convert.ToInt32(cislo1);
            int second = Convert.ToInt32(cislo2);
            if (countOperator.Equals("+"))
            {
                result = "" + (first + second);
            }
            if (countOperator.Equals("-"))
            {
                result = "" + (first - second);
            }
            if (countOperator.Equals("/"))
            {
                result = "" + (first / second);
            }
            if (countOperator.Equals("*"))
            {
                result = "" + (first * second);
            }
            return result;
        }

        public void setOperator(string s)
        {
            countOperator = s;
        }

        public void setNewDefinedNumber(string displayText)
        {
            if (cislo1.Equals(""))
            {
                cislo1 = displayText;
            }
            else
            {
                cislo2 = displayText;
            }
        }

        public bool addingFirstParametr()
        {
            return countOperator.Equals("");
        }
    }
}