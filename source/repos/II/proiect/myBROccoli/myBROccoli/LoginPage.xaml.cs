using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Data;
// Înlocuiește System.Data.SqlClient cu:
using Microsoft.Data.SqlClient;


namespace myBROccoli
{
    public sealed partial class LoginPage : Page
    {
        SqlConnection mycon = new SqlConnection();
        public LoginPage()
        {
            this.InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Password;


            if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(password))
            {
                Frame.Navigate(typeof(HomePage));
            }
        }
    }
}