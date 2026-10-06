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

namespace _246k_pr23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User person = new User();

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = person;
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show($"Зарегистрирован: \n{person.Name}\n{person.Email}\n{person.Age} лет");
        }
    }
}