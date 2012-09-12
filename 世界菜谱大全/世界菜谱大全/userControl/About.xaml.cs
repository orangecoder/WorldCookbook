using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Tasks;

namespace 世界菜谱大全.userControl
{
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
        }

        private void link_Weibo_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask weiboTask = new WebBrowserTask { Uri = new Uri("http://weibo.com/xiaoping888", UriKind.Absolute) };
            weiboTask.Show();
        }

        private void link_Email_Click(object sender, RoutedEventArgs e)
        {
            EmailComposeTask emailTask = new EmailComposeTask
            {
                To = "vsopping@163.com",
                Subject = "I've a question here",
            };
            emailTask.Show();
        }
    }
}
