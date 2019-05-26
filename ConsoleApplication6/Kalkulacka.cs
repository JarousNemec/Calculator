using System.Windows.Forms;
using System.ComponentModel;
using System;
using  System.Drawing;
using System.Security.Cryptography.X509Certificates;

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

        TextBox display;
        CoProcessor _coProcessor = new CoProcessor();
        public string number1Text;
        public string number2Text;
        public string NextnumberText;
        public int number1;
        public int number2;
        public int nextNumber;
        public int FirstResult;
        public int partialResult;
        public int resultNumber;
        public string writenumber;
        public bool count = false;
        public bool FirstNumberInFirstCount=false;
        public bool FirstNumbersInFirstCount = true;
        public string countOperator;
        
        Button[] buttons = new Button[15]; 
        
        public Kalkulacka()
        {
            InicializeMetod();
        }

        public void InicializeMetod()
        {
            int sizeX = 40;
            int sizeY = 40;
            
            Size buttonsSize = new Size(sizeX,sizeY);
            
            initComponents();

            setComponentSize(buttonsSize);
            
            SetNameComponents();

            AddComponents();

            UseComponents();
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
        }

        private void ZERO(object sender, EventArgs e)
        {
            if (FirstNumbersInFirstCount == true)
            {
                if (FirstNumberInFirstCount==false)
                {
                    number1Text = number1Text + "0";
                    FirstNumberInFirstCount = true;
                }
                else
                {
                    number2Text = number2Text + "0";
                }
            }
            else
            {
                NextnumberText = NextnumberText + "0";
            }
            
            writenumber = writenumber + "0";
            display.Text = writenumber;
        }

        private void ONE(object sender, EventArgs e)
        {
            if (_coProcessor.addingFirstParametr()) {
                display.Text = display.Text + "1";
            }
        }

        private void TWO(object sender, EventArgs e)
        {
            if (FirstNumbersInFirstCount == true)
            {
                if (FirstNumberInFirstCount==false)
                {
                    number1Text = number1Text + "2";
                    FirstNumberInFirstCount = true;
                }
                else
                {
                    number2Text = number2Text + "2";
                }
            }
            else
            {
                NextnumberText = NextnumberText + "2";
            }
            writenumber = writenumber + "2";
            display.Text = writenumber;
        }

        private void THREE(object sender, EventArgs e)
        {
            if (FirstNumbersInFirstCount == true)
            {
                if (FirstNumberInFirstCount==false)
                {
                    number1Text = number1Text + "3";
                    FirstNumberInFirstCount = true;
                }
                else
                {
                    number2Text = number2Text + "3";
                }
            }
            else
            {
                NextnumberText = NextnumberText + "3";
            }
            writenumber = writenumber + "3";
            display.Text = writenumber;
        }

        private void FOUR(object sender, EventArgs e)
        {
            if (FirstNumbersInFirstCount == true)
            {
                if (FirstNumberInFirstCount==false)
                {
                    number1Text = number1Text + "4";
                    FirstNumberInFirstCount = true;
                }
                else
                {
                    number2Text = number2Text + "4";
                }
            }
            else
            {
                NextnumberText = NextnumberText + "4";
            }
            writenumber = writenumber + "4";
            display.Text = writenumber;
        }

        private void FIVE(object sender, EventArgs e)
        {
            if (FirstNumbersInFirstCount == true)
            {
                if (FirstNumberInFirstCount==false)
                {
                    number1Text = number1Text + "5";
                    FirstNumberInFirstCount = true;
                }
                else
                {
                    number2Text = number2Text + "5";
                }
            }
            else
            {
                NextnumberText = NextnumberText + "5";
            }
            writenumber = writenumber + "5";
            display.Text = writenumber;
        }

        private void SIX(object sender, EventArgs e)
        {
            if (FirstNumbersInFirstCount == true)
            {
                if (FirstNumberInFirstCount==false)
                {
                    number1Text = number1Text + "6";
                    FirstNumberInFirstCount = true;
                }
                else
                {
                    number2Text = number2Text + "6";
                }
            }
            else
            {
                NextnumberText = NextnumberText + "6";
            }
            writenumber = writenumber + "6";
            display.Text = writenumber;
        }

        private void SEVEN(object sender, EventArgs e)
        {
            if (FirstNumbersInFirstCount == true)
            {
                if (FirstNumberInFirstCount==false)
                {
                    number1Text = number1Text + "7";
                    FirstNumberInFirstCount = true;
                }
                else
                {
                    number2Text = number2Text + "7";
                }
            }
            else
            {
                NextnumberText = NextnumberText + "7";
            }
            writenumber = writenumber + "7";
            display.Text = writenumber;
        }

        private void EIGHT(object sender, EventArgs e)
        {
            if (FirstNumbersInFirstCount == true)
            {
                if (FirstNumberInFirstCount==false)
                {
                    number1Text = number1Text + "8";
                    FirstNumberInFirstCount = true;
                }
                else
                {
                    number2Text = number2Text + "8";
                }
            }
            else
            {
                NextnumberText = NextnumberText + "8";
            }
            writenumber = writenumber + "8";
            display.Text = writenumber;
        }

        private void NINE(object sender, EventArgs e)
        {
            if (FirstNumbersInFirstCount == true)
            {
                if (FirstNumberInFirstCount==false)
                {
                    number1Text = number1Text + "9";
                    FirstNumberInFirstCount = true;
                }
                else
                {
                    number2Text = number2Text + "9";
                }
            }
            else
            {
                NextnumberText = NextnumberText + "9";
            }
            writenumber = writenumber + "9";
            display.Text = writenumber;
        }

        private void PLUS(object sender, EventArgs e)
        {
            _coProcessor.setNewDefinedNumber(display.Text); 
            _coProcessor.setOperator("+");
            display.Text = _coProcessor.getResult();
        }

        private void MINUS(object sender, EventArgs e)
        {
            _coProcessor.setNewDefinedNumber(display.Text);
            _coProcessor.setOperator("-");
            display.Text = _coProcessor.getResult();
        }

        private void DIVIDE(object sender, EventArgs e)
        {
            _coProcessor.setNewDefinedNumber(display.Text);
            _coProcessor.setOperator("/");
            display.Text = _coProcessor.getResult();
        }

        private void TIMES(object sender, EventArgs e)
        {
            _coProcessor.setNewDefinedNumber(display.Text);
            _coProcessor.setOperator("*");
            display.Text = _coProcessor.getResult();
        }

        private void RESULT(object sender, EventArgs e)
        {

        }

        private void AddComponents()
        {
            TableLayoutPanel panel = new TableLayoutPanel();
            Label l = new Label();
            l.Size = new Size(0,0);
            
            
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
            
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.Width = 200;
            panel.Height = 250;
            panel.RowCount = 4;
            panel.ColumnCount = 4;
            display.Size = new Size(200, 200);
            this.Controls.Add(display);
            panel.Location = new Point(0,30);
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
            divide.Text = "/";
            times.Text = "*";
        }

        

        private void setComponentSize(Size buttonsSize)
        {
            foreach (var button in buttons)
            {
                button.Size = buttonsSize;
            }
            
            
        }

        private void initComponents()
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
            
            display = new TextBox();
        }
    }
}