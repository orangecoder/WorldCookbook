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
using WorldCookbook.model;
using WorldCookbook.userControl;
using WorldCookbook.helper;

namespace WorldCookbook.userControl
{
    public partial class NationalMenuControl : UserControl
    {
        public NationalMenuControl()
        {
            InitializeComponent();
        }

        private void listNation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Nation nation = this.listNation.SelectedItem as Nation;
            if(nation != null)
            {
                this.listNation.SelectedItem = null;
                Cache.Instance.nation = nation;
                //页面跳转，并通知订阅该事件的控件
                EventSingleton.Instance.NavigateTo("/view/MenuViewPage.xaml");
            }
        }
    }
}
