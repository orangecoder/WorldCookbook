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
using WorldCookbook.userControl;

namespace WorldCookbook.view
{
    public partial class MenuDetialViewPage : PhoneApplicationPage
    {
        public MenuDetialViewPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            if(Cache.Instance.nation.menu != null)
            {
                this.PageTitle.Text = Cache.Instance.menu.menuName;
                this.content.DataContext = Cache.Instance.menu;
            }
            base.OnNavigatedTo(e);
        }
    }
}