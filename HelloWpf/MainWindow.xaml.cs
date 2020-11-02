using log4net;
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
    }

    private void LogBtnClick(object sender, RoutedEventArgs e)
    {
        string strLog = String.Format("[Thread ID:{0}]{1}", AppDomain.GetCurrentThreadId(), "Log4net写入日志配置处理");
        WriteLog(strLog);
    }

    private void WriteLog(string exp = null, string loggerName = "InfoLogger")
    {
        //新建的一个静态类
        LogObject.Log(loggerName).Info(exp);
        LogObject.Log(loggerName).Error(exp);
    }

    public static class LogObject
    {

        public static ILog Log(string LoggerName)
        {   //log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            return LogManager.GetLogger(LoggerName);
        }
    }
}
