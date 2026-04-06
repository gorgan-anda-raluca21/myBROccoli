using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace myBROccoli
{
    public sealed partial class LoginPage : Page
    {
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