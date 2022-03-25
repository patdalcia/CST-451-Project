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
using System.Data.SqlClient;
using System.Configuration;

namespace Organized
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;
        public MainWindow()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();
        }

        private bool VerifyUser(String username, String password)
        {
            conn.Open();
            command.Connection = conn;
            command.CommandText = "SELECT * from Credentials WHERE Username='" + username + "' AND Password='" + password + "'";
            dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed) { DragMove(); }
        }

        private void Register_Button_Click(object sender, RoutedEventArgs e)
        {
            Register registrationWindow = new Register();
            registrationWindow.Show();

            this.Hide();
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            if(conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
            if(VerifyUser(UsernameTextBox.Text, PasswordTextBox.Password))
            {
                MessageBox.Show("Login Successful", "Congratulations", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Username and Password combination does not match our Records, Please Try Again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Minimize_Icon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Close_Icon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
