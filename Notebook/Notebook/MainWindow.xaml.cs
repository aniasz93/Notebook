using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Notebook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ButtonUse btnUse = new ButtonUse();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void logInBtn_Click(object sender, RoutedEventArgs e)
        {
//            btnUse.ChangeWindow(this, logInWnd);
        }

        private void signUpBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            btnUse.ExitBtn();
        }
    }
}
