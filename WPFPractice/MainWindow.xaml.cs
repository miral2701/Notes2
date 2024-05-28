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

namespace WPFPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    class Note
    {
        public string Name { get; set; }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          
         
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           string a= Microsoft.VisualBasic.Interaction.InputBox("Enter Version", "", "");
            Note n=new Note() { Name=a};
            listBox1.Items.Add(n);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);

        }
    }
}