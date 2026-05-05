using Microsoft.Data.SqlClient;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;

namespace myBROccoli
{
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
        }

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               
               
                var builder = new SqlConnectionStringBuilder();
                builder.DataSource = @"(LocalDB)\MSSQLLocalDB";
                builder.AttachDBFilename = @"C:\USERS\ARMIN\SOURCE\REPOS\MYBROCCOLI\SOURCE\REPOS\II\PROIECT\MYBROCCOLI\MYBROCCOLI\BROCCOLIDATABASE.MDF"; // pune path-ul găsit
                builder.IntegratedSecurity = true;
                builder.ConnectTimeout = 30;
                builder.TrustServerCertificate = true;

                string connectionString = builder.ConnectionString;

                using (SqlConnection myCon = new SqlConnection(connectionString))
                {
                    myCon.Open();

                    string email = EmailTextBox.Text;
                    string password = PasswordTextBox.Password;

                    string sql = "SELECT COUNT(*) FROM LoginDB WHERE Email = @email AND Password = @parola";

                    using (SqlCommand cmd = new SqlCommand(sql, myCon))
                    {
                        cmd.Parameters.Add(new SqlParameter("@email", email));
                        cmd.Parameters.Add(new SqlParameter("@parola", password));

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            this.Frame.Navigate(typeof(HomePage));
                        }
                        else
                        {
                            await AfiseazaMesaj("Eroare", "Email sau parolă incorectă.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                await AfiseazaMesaj("EROARE", ex.GetType().Name + "\n\n" + ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private async System.Threading.Tasks.Task AfiseazaMesaj(string titlu, string continut)
        {
            ContentDialog dialog = new ContentDialog
            {
                Title = titlu,
                Content = continut,
                CloseButtonText = "Ok",
                XamlRoot = this.XamlRoot
            };

            await dialog.ShowAsync();
        }
    }
}