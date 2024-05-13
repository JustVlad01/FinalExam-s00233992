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
using System.Windows.Shapes;


using YourProjectName.Models; 

namespace FinalExam_s00233992
{
    public partial class CustomerResultScreen : Window
    {
        public CustomerResultScreen()
        {
            InitializeComponent();

        }

        public void ShowMatchedCustomers(List<Customer> customers)
        {
            ListBox lb = this.FindName("listBoxCustomers") as ListBox; 
            lb.ItemsSource = customers;
        }
    }

}
