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
using Microsoft.Phone.Controls;
using WorldCookbook.helper;
using WorldCookbook.data;

namespace WorldCookbook
{
    public partial class MainPage : PhoneApplicationPage
    {
        // 构造函数
        public MainPage()
        {
            InitializeComponent();
            //订阅自定义控件的事件
            EventSingleton.Instance.OnNavigateTo += (s, e) =>
            {
                this.NavigationService.Navigate(new Uri(e.Tag.ToString(), UriKind.Relative));
            };
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            this.NationalMenu.listNation.ItemsSource = Datas.Instance.nation;
            base.OnNavigatedTo(e);
        }
    }
}