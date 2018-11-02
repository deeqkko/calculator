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
        


        public MainWindow()
        {
            InitializeComponent();
            onScreen = "";
            NumberField.Text = onScreen;
        }


        private void Number_Click(object sender, RoutedEventArgs e)
        {
            onScreen += sender.ToString()[sender.ToString().Length -1].ToString();
            NumberField.Text = onScreen; 
 
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            onScreen = "";
            NumberField.Text = onScreen;
        }

        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            onMem = onScreen;
            onScreen = "";
            NumberField.Text = onScreen;
            calcOperator = 1;
            isComma = false;
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            float.TryParse(onScreen, out oper2);
            float.TryParse(onMem, out oper1);
            Console.WriteLine(oper1);
            Console.WriteLine(oper2);
            if (calcOperator == 1)
            {
                Console.WriteLine("Adding...");
                onScreen = (oper1 + oper2).ToString();
                calcOperator = 0;
                NumberField.Text = onScreen;
            }
            else if (calcOperator == 2)
            {
                Console.WriteLine("Subtracting...");
                onScreen = (oper1 - oper2).ToString();
                calcOperator = 0;
                NumberField.Text = onScreen;
            }

            else if (calcOperator == 3)
            {
                Console.WriteLine("Multiplying...");
                onScreen = (oper1 * oper2).ToString();
                calcOperator = 0;
                NumberField.Text = onScreen;
            }

            else
            {
                Console.WriteLine("Dividing...");
                onScreen = (oper1 / oper2).ToString();
                calcOperator = 0;
                NumberField.Text = onScreen;
            }
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            onMem = onScreen;
            onScreen = "";
            NumberField.Text = onScreen;
            calcOperator = 2;
            isComma = false;
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            onMem = onScreen;
            onScreen = "";
            NumberField.Text = onScreen;
            calcOperator = 3;
            isComma = false;
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            onMem = onScreen;
            onScreen = "";
            NumberField.Text = onScreen;
            calcOperator = 4;
            isComma = false;
        }

        private void Decimal_Click(object sender, RoutedEventArgs e)
        {
            if (NumberField.Text != "" && isComma == false)
            {
                onScreen += ",";
                isComma = true;
            }

        }
    }
}
