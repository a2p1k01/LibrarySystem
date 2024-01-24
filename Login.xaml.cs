using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LibrarySystem
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(phoneNumberTxt.Text))
            {
                FileStream fs = new FileStream(phoneNumberTxt.Text + ".json", FileMode.Open);
                User? log_user = await JsonSerializer.DeserializeAsync<User>(fs);
                fs.Close();
                if (log_user != null)
                {
                    User.UserName = log_user.Name;
                    MessageBox.Show("Successful!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something wrong!");
                }
            }
        }
    }
}
