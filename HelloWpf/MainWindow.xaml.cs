 
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

namespace HelloWpf
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             
            Test test = new Test(txtName.Text);

            test.ActionEvent += Message_ActionEvent;
            //message.Activated += action(ReTry);
            //message.SetText(txtName.Text);
            test.ShowDialog();
        }

        private void Message_ActionEvent(string value)
        {
            textBox.Text = value;
        }

        public static void ReTry()
        {

            MessageBox.Show("成功");
        }
    }
}




