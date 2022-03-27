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
                dataReader.Close();

                

                return true;
            }
            else
            {
                return false;
            }
        }

        private bool VerifyUsers(String username, String password)
        {
            try
            {
                conn.Open();
                int user_id = -1;
                using(var trans = conn.BeginTransaction())
                {
                    try
                    {
                        using(var comm = conn.CreateCommand())
                        {
                            comm.Transaction = trans;
                            comm.CommandText = "SELECT CAST(User_ID as int) as 'User_ID' from Credentials WHERE Username='" + username + "' AND Password='" + password + "'";
                            user_id = (int)comm.ExecuteScalar();

                            if (user_id > 0)
                            {
                                comm.CommandText = "SELECT FirstName as 'firstname', LastName as 'lastname', EmailAddress as 'email' FROM [dbo].[User] WHERE ID = '" + user_id + "'";
                                dataReader = comm.ExecuteReader();

                                while (dataReader.Read())
                                {
                                    User user = new User((string)dataReader["firstname"], (string)dataReader["lastname"], username, (string)dataReader["email"], user_id);
                                    App.Current.Properties["Current_User"] = user;
                                }
                                dataReader.Close();
                                conn.Close();
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }catch(Exception e)
                    {
                        return false;
                    }
                }
            }catch (Exception e)
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
            if(VerifyUsers(UsernameTextBox.Text, PasswordTextBox.Password))
            {

                Dashboard dashboard = new Dashboard();  
                dashboard.Show();   
                this.Close();
                //MessageBox.Show("Login Successful", "Congratulations", MessageBoxButton.OK, MessageBoxImage.Information);
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
