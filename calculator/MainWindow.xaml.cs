using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string onScreen;
        public string onMem;
        public int calcOperator;
        public float oper1;
        public float oper2;
        public bool isComma = false;
        public bool afterEqualorClear = false;
        


        public MainWindow()
        {
            InitializeComponent();
            onScreen = "0";
            afterEqualorClear = true;
            NumberField.Text = onScreen;
        }


        private void Number_Click(object sender, RoutedEventArgs e)
        {
            if (afterEqualorClear == true)
            {
                onScreen = sender.ToString()[sender.ToString().Length - 1].ToString();
                afterEqualorClear = false;
            }
            else
            {
                onScreen += sender.ToString()[sender.ToString().Length - 1].ToString();
            }
            NumberField.Text = onScreen; 
 
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            onScreen = "0";
            afterEqualorClear = true;
            isComma = false;
            NumberField.Text = onScreen;
        }

       

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            afterEqualorClear = true;
            isComma = false;
            float.TryParse(onScreen, out oper2);
            float.TryParse(onMem, out oper1);
            Console.WriteLine(oper1);
            Console.WriteLine(oper2);
            if (calcOperator == 1)
            {
                Console.WriteLine("Adding...");
                onScreen = (oper1 + oper2).ToString(); 
            }
            else if (calcOperator == 2)
            {
                Console.WriteLine("Subtracting...");
                onScreen = (oper1 - oper2).ToString();              
            }

            else if (calcOperator == 3)
            {
                Console.WriteLine("Multiplying...");
                onScreen = (oper1 * oper2).ToString();  
            }

            else if (calcOperator == 4)
            {
                Console.WriteLine("Dividing...");
                onScreen = (oper1 / oper2).ToString();  
            }
            else
            {
                NumberField.Text = onScreen;
            }
            calcOperator = 0;
            NumberField.Text = onScreen;
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            onMem = onScreen;
            isComma = false;
            onScreen = "";
            NumberField.Text = onScreen;
            Console.WriteLine(sender.ToString()[sender.ToString().Length - 1].ToString());
            if (sender.ToString()[sender.ToString().Length - 1].ToString() == "+") { calcOperator = 1; }
            else if (sender.ToString()[sender.ToString().Length - 1].ToString() == "-") { calcOperator = 2; }
            else if (sender.ToString()[sender.ToString().Length - 1].ToString() == "x") { calcOperator = 3; }
            else if (sender.ToString()[sender.ToString().Length - 1].ToString() == "/") { calcOperator = 4; }
            else { calcOperator = 0; }
        }

        private void Decimal_Click(object sender, RoutedEventArgs e)
        {
            if (isComma == false)
            {
                onScreen += ",";
                isComma = true;
            }

        }
    }
}
