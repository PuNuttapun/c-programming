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

namespace WpfApp_homeWork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bntCal(object sender, RoutedEventArgs e)
        {
            try
            {
                int income = int.Parse(txtIncome.Text);
                int expanse = int.Parse(txtExpanse.Text);
                int target = int.Parse(txtTarget.Text);
                int result = (income - expanse) / target;
                txtDate.Text = result.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                //Console.WriteLine(ex.Message);
                txtIncome.Text = "";
                txtExpanse.Text = "";
                txtTarget.Text = "";
                txtDate.Text = "";
            }

        }
    }
}
