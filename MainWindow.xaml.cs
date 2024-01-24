using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibrarySystem
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<Book> books = new ObservableCollection<Book>();

        public MainWindow()
        {
            InitializeComponent();
            usernameBlk.Text = User.UserName;
            lvBooks.ItemsSource = books;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            new Login().ShowDialog();
            usernameBlk.Text = User.UserName;
            books.Add(new Book("Война и Мир", "Заставляют читать в 11 классе", "Л.Н. Толстой", 1868));
            lvBooks.Items.Refresh();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            new Register().ShowDialog();
        }
    }
}