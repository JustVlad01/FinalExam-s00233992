using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using YourProjectName.Models;

namespace FinalExam_s00233992
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadCustomersAndBookings();
        }

        private void LoadCustomersAndBookings()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "Tom Jones", ContactNumber = "0861234567" },
                new Customer { Name = "Mary Smith", ContactNumber = "0865463214" },
                new Customer { Name = "Jo Doyle", ContactNumber = "0871221222" }
            };

            var bookings = new List<Booking>
            {
                new Booking { BookingId = 1, BookingsDate = DateTime.Now, NumberOfParticipants = 2, Customer = customers[0] },
                new Booking { BookingId = 2, BookingsDate = DateTime.Now.AddDays(1), NumberOfParticipants = 2, Customer = customers[1] },
                new Booking { BookingId = 3, BookingsDate = DateTime.Now.AddDays(2), NumberOfParticipants = 6, Customer = customers[2] }
            };

            listBoxCustomers.ItemsSource = bookings;
        }

        private void SearchButton_click(object sender, RoutedEventArgs e)
        {
            var name = txtCustomerName.Text;
           
            var contact = txtContactNumber.Text;

            var matchedCustomers = Customers.Where(c => c.Name.Contains(name) && c.ContactNumber.Contains(contact)).ToList();

            // Open CustomerResultScreen with the matched customers
            var resultScreen = new CustomerResultScreen();
            resultScreen.ShowMatchedCustomers(matchedCustomers);
            resultScreen.Show();
        }

    }
}
