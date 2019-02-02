using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string currInput = string.Empty, currOperator = string.Empty;
        private string argA = string.Empty, argB = string.Empty;
        private bool argBUsed = false, argAUsed = false, allowANeg = false, operatorSelected = false;
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_ce_Click(object sender, RoutedEventArgs e)
        {
            if (!argAUsed)
            {
                argA = "0";
                tb_display.Text = argA;
            }
            else
            {
                argB = "0";
                tb_display.Text = argB;
            }

        }

        private void Btn_plusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (!argAUsed || allowANeg)
            {
                if (argA.Contains("-"))
                {
                    argA = argA.Substring(1);
                }
                else if (argA != "0")
                {
                    argA = "-" + argA;
                }
                allowANeg = false;
                tb_display.Text = argA;
            }
            else
            {
                if (argB.Contains("-"))
                {
                    argB = argB.Substring(1);
                }
                else if (argB != "0")
                {
                    argB = "-" + argB;
                }
                tb_display.Text = argB;
            }
        }

        private void Btn_plus_Click(object sender, RoutedEventArgs e)
        {
            if (!argAUsed)
            {
                currOperator = " + ";
                argAUsed = true;
               
            }
            else if (!argBUsed)
            {
                currOperator = " + ";
                argBUsed = true;
            }
            else
            {
                Btn_equals_Click(sender, e);
                currOperator = " + ";
       
            }
            
            
               
        }

        private void Btn_1_Click(object sender, RoutedEventArgs e)
        {
            if (!argAUsed)
            {
                if (argA == "0")
                {
                    argA = "1";
                }
                else
                {
                    argA += "1";
                }
                tb_display.Text = argA;
            }
            else
            {
                if (argB == "0")
                {
                    argB = "1";
                }
                else
                {
                    argB += "1";
                }
                tb_display.Text = argB;
            }

        }

        private void Btn_2_Click(object sender, RoutedEventArgs e)
        {
            if (!argAUsed)
            {
                if (argA == "0")
                {
                    argA = "2";
                }
                else
                {
                    argA += "2";
                }
                tb_display.Text = argA;
            }
            else
            {
                if (argB == "0")
                {
                    argB = "2";
                }
                else
                {
                    argB += "2";
                }
                tb_display.Text = argB;
            }
        }

        private void Btn_3_Click(object sender, RoutedEventArgs e)
        {
            if (!argAUsed)
            {
                if (argA == "0")
                {
                    argA = "3";
                }
                else
                {
                    argA += "3";
                }
                tb_display.Text = argA;
            }
            else
            {
                if (argB == "0")
                {
                    argB = "3";
                }
                else
                {
                    argB += "3";
                }
                tb_display.Text = argB;
            }
        }

        private void Btn_minus_Click(object sender, RoutedEventArgs e)
        {
            if (!argAUsed)
            {
                currOperator = " - ";
                argAUsed = true;
               
            }
            else if (!argBUsed)
            {
                currOperator = " - ";
                argBUsed = true;
            }
            else 
            {
                Btn_equals_Click(sender, e);
                currOperator = " - ";
               
            }
            
        }

        private void Btn_4_Click(object sender, RoutedEventArgs e)
        {
            if (!argAUsed)
            {
                if (argA == "0")
                {
                    argA = "4";
                }
                else
                {
                    argA += "4";
                }
                tb_display.Text = argA;
            }
            else
            {
                if (argB == "0")
                {
                    argB = "4";
                }
                else
                {
                    argB += "4";
                }
                tb_display.Text = argB;
            }
        }

        private void Btn_5_Click(object sender, RoutedEventArgs e)
        {
            if (!argAUsed)
            {
                if (argA == "0")
                {
                    argA = "5";
                }
                else
                {
                    argA += "5";
                }
                tb_display.Text = argA;
            }
            else
            {
                if (argB == "0")
                {
                    argB = "5";
                }
                else
                {
                    argB += "5";
                }
                tb_display.Text = argB;
            }
        }

        private void Btn_6_Click(object sender, RoutedEventArgs e)
        {
            if (!argAUsed)
            {
                if (argA == "0")
                {
                    argA = "6";
                }
                else
                {
                    argA += "6";
                }
                tb_display.Text = argA;
            }
            else
            {
                if (argB == "0")
                {
                    argB = "6";
                }
                else
                {
                    argB += "6";
                }
                tb_display.Text = argB;
            }
        }

        private void Btn_multiply_Click(object sender, RoutedEventArgs e)
        {
            if (!argAUsed)
            {
                currOperator = " * ";
                argAUsed = true;
                
            }
            else if (!argBUsed)
            {
                currOperator = " * ";
                argBUsed = true;
            }
            else
            {
                Btn_equals_Click(sender, e);
                currOperator = " * ";
                
            }
            
        }

        private void Btn_7_Click(object sender, RoutedEventArgs e)
        {
            if (!argAUsed)
            {
                if (argA == "0")
                {
                    argA = "7";
                }
                else
                {
                    argA += "7";
                }
                tb_display.Text = argA;
            }
            else
            {
                if (argB == "0")
                {
                    argB = "7";
                }
                else
                {
                    argB += "7";
                }
                tb_display.Text = argB;
            }
        }

        private void Btn_8_Click(object sender, RoutedEventArgs e)
        {
            if (!argAUsed)
            {
                if (argA == "0")
                {
                    argA = "8";
                }
                else
                {
                    argA += "8";
                }
                
                tb_display.Text = argA;
            }
            else
            {
                if (argB == "0")
                {
                    argB = "8";
                }
                else
                {
                    argB += "8";
                }
                tb_display.Text = argB;
            }
        }

        private void Btn_9_Click(object sender, RoutedEventArgs e)
        {
            if (!argAUsed)
            {
                if (argA == "0")
                {
                    argA = "9";
                }
                else
                {
                    argA += "9";
                }
                tb_display.Text = argA;
            }
            else
            {
                if (argB == "0")
                {
                    argB = "9";
                }
                else
                {
                    argB += "9";
                }
                tb_display.Text = argB;
            }
        }

        private void Btn_divide_Click(object sender, RoutedEventArgs e)
        {
           
            if (!argAUsed)
            {
                currOperator = " / ";
                argAUsed = true;
                
            }
            else if(!argBUsed)
            {
                currOperator = " / ";
                argBUsed = true;
            }
            else
            {
                Btn_equals_Click(sender, e);
                currOperator = " / ";  
            }
        }

        private void Btn_0_Click(object sender, RoutedEventArgs e)
        {
            if (!argAUsed)
            {
                if(argA != "0")
                {
                    argA += "0";
                }
                tb_display.Text = argA;
            }
            else
            {
                if(argB != "0")
                {
                    argB += "0";
                }
                tb_display.Text = argB;
            }
        }

        private void Button_dec_Click(object sender, RoutedEventArgs e)
        {
            if (!argAUsed)
            {
                if(!argA.Contains("."))
                {
                    argA += ".";
                } 
                tb_display.Text = argA;
            }
            else
            {
                if (!argB.Contains("."))
                {
                    argB += ".";
                }
                tb_display.Text = argB;
            }
        }

        private void Btn_equals_Click(object sender, RoutedEventArgs e)
        {

            if ((sender.ToString().Split(' ')[1] == "="))
            {
                argBUsed = false;
            }
            currInput = argA + currOperator + argB;
            object result = Parser.Library.Parser.parseString(currInput);
            argA = result.ToString();
            tb_display.Text = argA;
                       
            argB = "0";
            allowANeg = true;
            
            if (argA == "OVERFLOW" || argA == "UNDERFLOW" || argA == "DIV BY 0")
            {
                btn_0.IsEnabled = false;
                btn_1.IsEnabled = false;
                btn_2.IsEnabled = false;
                btn_3.IsEnabled = false;
                btn_4.IsEnabled = false;
                btn_5.IsEnabled = false;
                btn_6.IsEnabled = false;
                btn_7.IsEnabled = false;
                btn_8.IsEnabled = false;
                btn_9.IsEnabled = false;
                btn_ce.IsEnabled = false;
                btn_dec.IsEnabled = false;
                btn_plus.IsEnabled = false;
                btn_minus.IsEnabled = false;
                btn_multiply.IsEnabled = false;
                btn_divide.IsEnabled = false;
                btn_plusMinus.IsEnabled = false;
                btn_equals.IsEnabled = false;
                tb_display.Background = Brushes.Red;
            }


        }

        private void Btn_c_Click(object sender, RoutedEventArgs e)
        {
            currInput = "";
            argA = "0";
            argB = "0";  
            argAUsed = false;
            allowANeg = false;
            operatorSelected = false;
            tb_display.Text = argA;

            btn_0.IsEnabled = true;
            btn_1.IsEnabled = true;
            btn_2.IsEnabled = true;
            btn_3.IsEnabled = true;
            btn_4.IsEnabled = true;
            btn_5.IsEnabled = true;
            btn_6.IsEnabled = true;
            btn_7.IsEnabled = true;
            btn_8.IsEnabled = true;
            btn_9.IsEnabled = true;
            btn_ce.IsEnabled = true;
            btn_dec.IsEnabled = true;
            btn_plus.IsEnabled = true;
            btn_minus.IsEnabled = true;
            btn_multiply.IsEnabled = true;
            btn_divide.IsEnabled = true;
            btn_plusMinus.IsEnabled = true;
            btn_equals.IsEnabled = true;
            tb_display.Background = Brushes.AliceBlue;
        }
        
    }
}
