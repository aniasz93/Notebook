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
using System.Windows.Shapes;

namespace Notebook
{
    /// <summary>
    /// Interaction logic for LogInWindow.xaml
    /// </summary>
    public partial class LogInWindow : Window
    {
        private ButtonUse btnUse = new ButtonUse();
        private MainWindow mainWnd = new MainWindow();

        public LogInWindow()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            btnUse.ExitBtn();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            logintxt.Text = "";
            passtxt.Clear();

            btnUse.ChangeWindow(this, mainWnd);
        }
    }
}
