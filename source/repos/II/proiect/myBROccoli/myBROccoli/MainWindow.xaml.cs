using Microsoft.UI.Xaml;

namespace myBROccoli
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.Title = "myBROccoli - Welcome";
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Password;

          
            if (email == "bro@healthy.com" && password == "broccoli123")
            {
                LoginButton.Content = "Success!";
            }
            else
            {
               
                LoginButton.Content = "Wrong Seeds!";
            }
        }
    }
}