using System.Windows.Forms;
using System;
using System.Drawing;

namespace test_neceho
{
    public class Kalkulacka : Form
    {
        Button zero;
        Button one;
        Button two;
        Button three;
        Button four;
        Button five;
        Button six;
        Button seven;
        Button eight;
        Button nine;

        Button plus;
        Button minus;
        Button result;
        Button times;
        Button divide;
        Button reset;

        TextBox display;

        public string Number1Text;
        public string Number2Text;
        public double Number1;
        public double Number2;
        public double ParticalResult;
        public bool PossibleAddNumber = false;
        public static double Output;
        public string Writenumber;
        public bool FirstNumberInFirstCount = false;
        public bool FirstNumbersInFirstCount = true;
        public bool BOOL = false;
        public string CountOperator;
        public bool FirstOperatorIsSet = false;
        public bool SetOperator = false;

        Button[] buttons = new Button[16];

        public Kalkulacka()
        {
            this.Text = "C";
            this.Width = 204;
            this.Height = 256;

            InicializeMetod();
        }


        public void InicializeMetod()
        {
            int sizeX = 40;
            int sizeY = 40;

            Size buttonsSize = new Size(sizeX, sizeY);

            InitializeComponents();

            SetComponentSize(buttonsSize);

            SetNameComponents();

            AddComponents();

            UseComponents();
        }

        private void ZERO(object sender, EventArgs e)
        {
            if (PossibleAddNumber == true)
            {
                Cleaner();
            }

            if (FirstNumbersInFirstCount == true)
            {
                if (FirstNumberInFirstCount == false)
                {
                    Number1Text = Number1Text + "0";
                }
                else
                {
                    Number2Text = Number2Text + "0";
                }
            }

            else
            {
                Number2Text = Number2Text + "0";
            }

            Writenumber = Writenumber + "0";
            display.Text = Writenumber;
            SetOperator = false;
        }

        private void ONE(object sender, EventArgs e)
        {
            if (PossibleAddNumber == true)
            {
                Cleaner();
            }

            if (FirstNumbersInFirstCount == true)
            {
                if (FirstNumberInFirstCount == false)
                {
                    Number1Text = Number1Text + "1";
                }
                else
                {
                    Number2Text = Number2Text + "1";
                }
            }

            else
            {
                Number2Text = Number2Text + "1";
            }

            Writenumber = Writenumber + "1";
            display.Text = Writenumber;
            SetOperator = false;
        }

        private void TWO(object sender, EventArgs e)
        {
            if (PossibleAddNumber == true)
            {
                Cleaner();
            }

            if (FirstNumbersInFirstCount == true)
            {
                if (FirstNumberInFirstCount == false)
                {
                    Number1Text = Number1Text + "2";
                }
                else
                {
                    Number2Text = Number2Text + "2";
                }
            }

            else
            {
                Number2Text = Number2Text + "2";
            }

            Writenumber = Writenumber + "2";
            display.Text = Writenumber;
            SetOperator = false;
        }

        private void THREE(object sender, EventArgs e)
        {
            if (PossibleAddNumber == true)
            {
                Cleaner();
            }

            if (FirstNumbersInFirstCount == true)
            {
                if (FirstNumberInFirstCount == false)
                {
                    Number1Text = Number1Text + "3";
                }
                else
                {
                    Number2Text = Number2Text + "3";
                }
            }
            else
            {
                Number2Text = Number2Text + "3";
            }

            Writenumber = Writenumber + "3";
            display.Text = Writenumber;
            SetOperator = false;
        }

        private void FOUR(object sender, EventArgs e)
        {
            if (PossibleAddNumber == true)
            {
                Cleaner();
            }

            if (FirstNumbersInFirstCount == true)
            {
                if (FirstNumberInFirstCount == false)
                {
                    Number1Text = Number1Text + "4";
                }
                else
                {
                    Number2Text = Number2Text + "4";
                }
            }

            else
            {
                Number2Text = Number2Text + "4";
            }

            Writenumber = Writenumber + "4";
            display.Text = Writenumber;
            SetOperator = false;
        }

        private void FIVE(object sender, EventArgs e)
        {
            if (PossibleAddNumber == true)
            {
                Cleaner();
            }

            if (FirstNumbersInFirstCount == true)
            {
                if (FirstNumberInFirstCount == false)
                {
                    Number1Text = Number1Text + "5";
                }
                else
                {
                    Number2Text = Number2Text + "5";
                }
            }

            else
            {
                Number2Text = Number2Text + "5";
            }

            Writenumber = Writenumber + "5";
            display.Text = Writenumber;
            SetOperator = false;
        }

        private void SIX(object sender, EventArgs e)
        {
            if (PossibleAddNumber == true)
            {
                Cleaner();
            }

            if (FirstNumbersInFirstCount == true)
            {
                if (FirstNumberInFirstCount == false)
                {
                    Number1Text = Number1Text + "6";
                }
                else
                {
                    Number2Text = Number2Text + "6";
                }
            }
            else
            {
                Number2Text = Number2Text + "6";
            }

            Writenumber = Writenumber + "6";
            display.Text = Writenumber;
            SetOperator = false;
        }

        private void SEVEN(object sender, EventArgs e)
        {
            if (PossibleAddNumber == true)
            {
                Cleaner();
            }

            if (FirstNumbersInFirstCount == true)
            {
                if (FirstNumberInFirstCount == false)
                {
                    Number1Text = Number1Text + "7";
                }
                else
                {
                    Number2Text = Number2Text + "7";
                }
            }
            else
            {
                Number2Text = Number2Text + "7";
            }

            Writenumber = Writenumber + "7";
            display.Text = Writenumber;
            SetOperator = false;
        }

        private void EIGHT(object sender, EventArgs e)
        {
            if (PossibleAddNumber == true)
            {
                Cleaner();
            }

            if (FirstNumbersInFirstCount == true)
            {
                if (FirstNumberInFirstCount == false)
                {
                    Number1Text = Number1Text + "8";
                }
                else
                {
                    Number2Text = Number2Text + "8";
                }
            }
            else
            {
                Number2Text = Number2Text + "8";
            }

            Writenumber = Writenumber + "8";
            display.Text = Writenumber;
            SetOperator = false;
        }

        private void NINE(object sender, EventArgs e)
        {
            if (PossibleAddNumber == true)
            {
                Cleaner();
            }

            if (FirstNumbersInFirstCount == true)
            {
                if (FirstNumberInFirstCount == false)
                {
                    Number1Text = Number1Text + "9";
                }
                else
                {
                    Number2Text = Number2Text + "9";
                }
            }
            else
            {
                Number2Text = Number2Text + "9";
            }

            Writenumber = Writenumber + "9";
            display.Text = Writenumber;
            SetOperator = false;
        }

        private void PLUS(object sender, EventArgs e)
        {
            if (FirstOperatorIsSet)
            {
                if (SetOperator == false)
                {
                    ConvertingNumbersToDouble();
                    Counter();
                    ConvertingNumbersToString();
                
                    Number2Text = "";
                    Number1Text = Convert.ToString(Output);
                    Writenumber = Convert.ToString(Output);

                    Writer();
                }
                
            }
            else
            {
                FirstOperatorIsSet = true;
            }

            if (SetOperator == false)
            {
                if (Number1Text != "")
                {
                    FirstNumberInFirstCount = true;
                }

                CountOperator = "+";

                Writenumber = Writenumber + "+";
                display.Text = Writenumber;
                PossibleAddIsFalse();
                SetOperator = true;
            }
        }

        private void MINUS(object sender, EventArgs e)
        {
            if (FirstOperatorIsSet)
            {
                if (SetOperator == false)
                {
                    ConvertingNumbersToDouble();
                    Counter();
                    ConvertingNumbersToString();
                
                    Number2Text = "";
                    Number1Text = Convert.ToString(Output);
                    Writenumber = Convert.ToString(Output);

                    Writer();
                }
            }
            else
            {
                FirstOperatorIsSet = true;
            }

            if (SetOperator == false)
            {
                if (Number1Text != "")
                {
                    FirstNumberInFirstCount = true;
                }

                CountOperator = "-";
                Writenumber = Writenumber + "-";
                display.Text = Writenumber;
                PossibleAddIsFalse();
                SetOperator = true;
            }
        }

        private void DIVIDE(object sender, EventArgs e)
        {
            if (FirstOperatorIsSet)
            {
                if (SetOperator == false)
                {
                    ConvertingNumbersToDouble();
                    Counter();
                    ConvertingNumbersToString();
                
                    Number2Text = "";
                    Number1Text = Convert.ToString(Output);
                    Writenumber = Convert.ToString(Output);

                    Writer();
                }
            }
            else
            {
                FirstOperatorIsSet = true;
            }

            if (SetOperator == false)
            {
                if (Number1Text != "")
                {
                    FirstNumberInFirstCount = true;
                }

                CountOperator = "/";
                Writenumber = Writenumber + "/";
                display.Text = Writenumber;
                PossibleAddIsFalse();
                SetOperator = true;
            }
        }

        private void TIMES(object sender, EventArgs e)
        {
            if (FirstOperatorIsSet)
            {
                if (SetOperator == false)
                {
                    ConvertingNumbersToDouble();
                    Counter();
                    ConvertingNumbersToString();
                
                    Number2Text = "";
                    Number1Text = Convert.ToString(Output);
                    Writenumber = Convert.ToString(Output);

                    Writer();
                }
            }
            else
            {
                FirstOperatorIsSet = true;
            }

            if (SetOperator == false)
            {
                if (Number1Text != "")
                {
                    FirstNumberInFirstCount = true;
                }

                CountOperator = "*";
                Writenumber = Writenumber + "*";
                display.Text = Writenumber;
                PossibleAddIsFalse();
                SetOperator = true;
            }
        }

        private void RESULT(object sender, EventArgs e)
        {
            ConvertingNumbersToDouble();
            if (BOOL == false)
            {
                BOOL = true;
            }
            else
            {
                Number1 = Output;
            }

            Counter();

            Writenumber = Convert.ToString(Output);
            display.Text = Writenumber;

            Writer();

            Number2Text = "";
            FirstOperatorIsSet = false;
            PossibleAddNumber = true;
        }

        private void RESET(object sender, EventArgs e)
        {
            Cleaner();
            Writer();
            FirstOperatorIsSet = false;
            display.Text = "0";
        }

        private void Writer()
        {
            Console.Clear();
            Console.WriteLine("output " + Output);
            Console.WriteLine("n1     " + Number1);
            Console.WriteLine("n2     " + Number2);
            Console.WriteLine("P.Res. "+ParticalResult);
            Console.WriteLine("n1T    " + Number1Text);
            Console.WriteLine("n2T    " + Number2Text);
            Console.WriteLine("cO     " + CountOperator);
            Console.WriteLine("wn     " + Writenumber);
            Console.WriteLine("bool   " + BOOL);
        }

        private void ConvertingNumbersToDouble()
        {
            if (Number1Text == "")
                Number1 = 0;
            else
            {
                Number1 = Convert.ToDouble(Number1Text);
            }

            if (Number2Text == "")
                Number2 = 0;
            else
            {
                Number2 = Convert.ToDouble(Number2Text);
            }
        }

        private void ConvertingNumbersToString()
        {
            if (Number1 == 0)
            {
                Number1Text = "";
            }
            else
            {
                Number1Text = Convert.ToString(Number1);
            }

            if (Number2 == 0)
            {
                Number2Text = "";
            }
            else
            {
                Number2Text = Convert.ToString(Number2);
            }
        }

        public void Counter()
        {
            if (CountOperator == "+")
            {
                Output = (Number1 + Number2);
            }

            else if (CountOperator == "-")
            {
                Output = (Number1 - Number2);
            }

            else if (CountOperator == "/")
            {
                Output = (Number1 / Number2);
            }

            else if (CountOperator == "*")
            {
                Output = (Number1 * Number2);
            }
        }

        private void Cleaner()
        {
            Number1Text = "";
            Number2Text = "";
            Number1 = 0;
            Number2 = 0;
            CountOperator = "";
            Writenumber = "";
            PossibleAddNumber = false;
            Output = 0;
            BOOL = false;
            FirstNumberInFirstCount = false;
            FirstNumbersInFirstCount = true;
        }

        private void PossibleAddIsFalse()
        {
            PossibleAddNumber = false;
        }

        private void AddComponents()
        {
            TableLayoutPanel panel = new TableLayoutPanel();
            Label l = new Label();
            l.Size = new Size(0, 0);


            panel.Controls.Add(seven);
            panel.Controls.Add(eight);
            panel.Controls.Add(nine);
            panel.Controls.Add(divide);

            panel.Controls.Add(four);
            panel.Controls.Add(five);
            panel.Controls.Add(six);
            panel.Controls.Add(times);

            panel.Controls.Add(one);
            panel.Controls.Add(two);
            panel.Controls.Add(three);
            panel.Controls.Add(minus);

            panel.Controls.Add(l);
            panel.Controls.Add(zero);
            panel.Controls.Add(result);
            panel.Controls.Add(plus);
            reset.Location = new Point(5, 173);
            this.Controls.Add(reset);

            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.Width = 188;
            panel.Height = 188;
            panel.RowCount = 4;
            panel.ColumnCount = 4;
            display.Size = new Size(188, 20);
            panel.Location = new Point(0, 30);
            this.Controls.Add(display);
            panel.Location = new Point(0, 30);
            this.Controls.Add(panel);
        }

        private void SetNameComponents()
        {
            zero.Text = "0";
            one.Text = "1";
            two.Text = "2";
            three.Text = "3";
            four.Text = "4";
            five.Text = "5";
            six.Text = "6";
            seven.Text = "7";
            eight.Text = "8";
            nine.Text = "9";

            plus.Text = "+";
            minus.Text = "-";
            result.Text = "=";
            reset.Text = "R";
            divide.Text = "/";
            times.Text = "*";
        }

        private void SetComponentSize(Size buttonsSize)
        {
            foreach (var button in buttons)
            {
                button.Size = buttonsSize;
            }
        }

        private void InitializeComponents()
        {
            zero = new Button();
            one = new Button();
            two = new Button();
            three = new Button();
            four = new Button();
            five = new Button();
            six = new Button();
            seven = new Button();
            eight = new Button();
            nine = new Button();

            plus = new Button();
            minus = new Button();
            result = new Button();
            times = new Button();
            divide = new Button();
            reset = new Button();

            buttons[0] = zero;
            buttons[1] = one;
            buttons[2] = two;
            buttons[3] = three;
            buttons[4] = four;
            buttons[5] = five;
            buttons[6] = six;
            buttons[7] = seven;
            buttons[8] = eight;
            buttons[9] = nine;
            buttons[10] = plus;
            buttons[11] = minus;
            buttons[12] = times;
            buttons[13] = divide;
            buttons[14] = result;
            buttons[15] = reset;

            display = new TextBox();
        }

        private void UseComponents()
        {
            zero.Click += new EventHandler(ZERO);
            one.Click += new EventHandler(ONE);
            two.Click += new EventHandler(TWO);
            three.Click += new EventHandler(THREE);
            four.Click += new EventHandler(FOUR);
            five.Click += new EventHandler(FIVE);
            six.Click += new EventHandler(SIX);
            seven.Click += new EventHandler(SEVEN);
            eight.Click += new EventHandler(EIGHT);
            nine.Click += new EventHandler(NINE);

            plus.Click += new EventHandler(PLUS);
            minus.Click += new EventHandler(MINUS);
            divide.Click += new EventHandler(DIVIDE);
            times.Click += new EventHandler(TIMES);
            result.Click += new EventHandler(RESULT);
            reset.Click += new EventHandler(RESET);
        }
    }
}