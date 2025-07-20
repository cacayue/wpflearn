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

namespace BindingForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Student stu;

        public MainWindow()
        {
            InitializeComponent();

            //var binding = new Binding()
            //{
            //    Source = stu,
            //    Path = new PropertyPath("Name"),
            //};

            //BindingOperations.SetBinding(this.textBoxName, TextBox.TextProperty, binding);

            this.textBoxName.SetBinding(TextBox.TextProperty, new Binding("Name")
            {
                Source = stu = new Student()
            });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            stu.Name += " Name";
        }
    }
}