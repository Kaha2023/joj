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

namespace _2lab_Urvancev
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GO_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(x1.Text);
            Finish.Text += Environment.NewLine + "X = " + x.ToString();
            double y = double.Parse(y2.Text);
            Finish.Text += Environment.NewLine + "Y = " + y.ToString();
            double z = double.Parse(z3.Text);
            Finish.Text += Environment.NewLine + "Z = " + z.ToString();
            double a = (Math.Cos(2) * (x - Math.PI / 6));
            Finish.Text += Environment.NewLine + "" + a.ToString();
            double b = (0.5 + (Math.Pow(Math.Sin(y), 2)));
            Finish.Text += Environment.NewLine + "" + b.ToString();
            double c = (1 + (Math.Pow(z, 2)) / 3 - Math.Pow(z, 2) / 5);
            Finish.Text += Environment.NewLine + "" + c.ToString();
            double t = (a / b) * c;
            Finish.Text += Environment.NewLine + "Результат t = " + t.ToString();
        }      
    }
}
