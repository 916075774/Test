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

namespace HelloWpf 
{
    /// <summary>
    /// Test.xaml 的交互逻辑
    /// </summary>
    public partial class Test : Window
    {
        public string DeviceID { get; set; }

        public Test()
        {
            InitializeComponent();
        }

        public Test(string deviceID)
        {
            InitializeComponent();

            txtTest.Text = deviceID;
        }

        public void SetText(string deviceID)
        {
            DeviceID = deviceID;
            txtTest.Text = DeviceID;
        }
 

        public event Action<string> ActionEvent;

        private void Button_Click(object sender, EventArgs e)
        {
            //触发事件
            ActionEvent(txtBoxChild.Text);
            this.Close();
        }
    }

    //public delegate void TransfDelegate(String value);
 
}
