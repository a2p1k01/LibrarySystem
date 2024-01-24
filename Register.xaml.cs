using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
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

    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private async void registerBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(nameTxt.Text) && !string.IsNullOrEmpty(dateOfBirthTxt.Text) && !string.IsNullOrEmpty(phoneNumberTxt.Text))
            {
                User user = new User(nameTxt.Text, dateOfBirthTxt.Text, phoneNumberTxt.Text);
                FileStream fs = new FileStream(user.PhoneNumber + ".json", FileMode.Append);
                await JsonSerializer.SerializeAsync<User>(fs, user);
                fs.Close();
                MessageBox.Show("Successful!");
                this.Close();
            }
        }
    }
}
