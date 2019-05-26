using System;
using System.Windows.Forms;

namespace test_neceho
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new Kalkulacka());
           */
            CoProcessor mujProcessor = new CoProcessor();
            
            mujProcessor.setNewDefinedNumber("8");
            mujProcessor.setNewDefinedNumber("4");
            mujProcessor.setOperator("+");
            string result = mujProcessor.getResult();
            Console.WriteLine(result);
            
            mujProcessor.setNewDefinedNumber("8");
            mujProcessor.setNewDefinedNumber("4");
            mujProcessor.setOperator("-");
            result = mujProcessor.getResult();
            Console.WriteLine(result);
            
            mujProcessor.setNewDefinedNumber("8");
            mujProcessor.setNewDefinedNumber("4");
            mujProcessor.setOperator("*");
            result = mujProcessor.getResult();
            Console.WriteLine(result);
            
            mujProcessor.setNewDefinedNumber("8");
            mujProcessor.setNewDefinedNumber("4");
            mujProcessor.setOperator("/");
            result = mujProcessor.getResult();
            Console.WriteLine(result);

        }
    }
    
}