using System;
using System.Windows.Forms;

namespace test_neceho
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new Kalkulacka());
        }
    }
}