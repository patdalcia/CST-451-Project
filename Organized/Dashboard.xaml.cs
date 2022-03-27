using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Organized
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public ObservableCollection<Field> Fields { get; set; }
        public Dashboard()
        {
            InitializeComponent();

            User user = (User)App.Current.Properties["Current_User"];

            Binding dashboardWelcomeMessage_Binding = new Binding("Username");
            dashboardWelcomeMessage_Binding.Source = user;

            TextBlock welcomeBlock = (TextBlock)this.FindName("Dashboard_Welcome_Message");
            welcomeBlock.SetBinding(TextBlock.TextProperty, dashboardWelcomeMessage_Binding);

            Fields = new ObservableCollection<Field>();
            Fields.Add(new Field() { Name = "Username", Length = 100, Required = true });
            Fields.Add(new Field() { Name = "Password", Length = 80, Required = true });
            Fields.Add(new Field() { Name = "City", Length = 100, Required = false });
            Fields.Add(new Field() { Name = "State", Length = 40, Required = false });
            Fields.Add(new Field() { Name = "Zipcode", Length = 60, Required = false });

            //Course_Cards.ItemsSource = Fields;

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) { DragMove(); }
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
    public class Field
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public bool Required { get; set; }
    }
}
