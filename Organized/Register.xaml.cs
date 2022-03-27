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
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Organized
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    /// 
    public partial class Register : Window
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;
       
        public Register()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();
        }

        private void Return_To_Login_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow LoginWindow = new MainWindow();
            LoginWindow.Show();

            this.Hide();
        }

        private void Register_Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed) { DragMove(); }
        }

        private void Close_WIndow_Icon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Minimize_WIndow_Icon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Register_Button_Click(object sender, RoutedEventArgs e)
        {
            if (verifyUsername(UsernameTextBox.Text))
            {
                if (RegisterNewUser(FirstNameTextBox.Text, LastNameTextBox.Text, UsernameTextBox.Text, PasswordTextBox.Password, EmailTextBox.Text))
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("There was an error registering your account! Please Review your information and Try Again!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("There was an error registering your account! Your chosen Username is Already Taken! Please Try Again!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private bool RegisterNewUser(String Firstname, String Lastname, String Username, String Password, String EmailAddress)
        {
            try
            {
                int user_id = 0;
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        using(var comm = conn.CreateCommand())
                        {
                            comm.Transaction = trans;
                            comm.CommandText = "INSERT INTO [dbo].[User] ([FirstName], [LastName], [EmailAddress]) VALUES('" + Firstname + "', '" + Lastname + "', '" + EmailAddress + "') SELECT CAST(SCOPE_IDENTITY() as int) as 'UserID'";
                            user_id = (int)comm.ExecuteScalar();
                        }
                        using(var comm = conn.CreateCommand())
                        {
                            comm.Transaction = trans;
                            comm.CommandText = "INSERT INTO [dbo].[Credentials] ([Username], [Password], [User_ID]) VALUES('" + Username + "', '" + Password + "', '" + user_id + "')";
                            comm.ExecuteNonQuery();
                        }
                        //Creating user object and making it globally accessible
                        User user = new User(Firstname, Lastname, Username, EmailAddress, user_id);
                        App.Current.Properties["Current_User"] = user;

                        trans.Commit();
                        conn.Close();
                        return true;
                    }
                    catch(Exception e)
                    {
                        trans.Rollback();
                        conn.Close();
                        return false;
                    }
                }
            }
            catch(Exception e) 
            {
                conn.Close();
                return false;
            }

        }

        private bool verifyUsername(String username)
        {
            try
            {
                conn.Open();
                using(var trans = conn.BeginTransaction())
                {
                    try
                    {
                        using(var comm = conn.CreateCommand())
                        {
                            comm.Transaction = trans;
                            comm.CommandText = "SELECT Username FROM [dbo].[Credentials] WHERE Username = '" + username + "'";
                            dataReader = comm.ExecuteReader();
                            if (dataReader.HasRows)
                            {
                                dataReader.Close();
                                conn.Close();
                                return false;
                            }
                            else
                            {
                                dataReader.Close();
                                conn.Close();
                                return true;
                            }
                        }
                    }catch(Exception e)
                    {
                        conn.Close();
                        return false;
                    }
                }
            }catch(Exception e)
            {
                conn.Close();
                return false;
            }
        }

    }
}
