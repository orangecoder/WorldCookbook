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
using WorldCookbook.model;

namespace WorldCookbook.view
{
    public partial class MenuViewPage : PhoneApplicationPage
    {
        public MenuViewPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            if(Cache.Instance.nation != null)
            {
                this.PageTitle.Text = Cache.Instance.nation.nationName;
                this.menuTotal.Text = Cache.Instance.nation.menuTotal;
                this.listMenu.ItemsSource = Cache.Instance.nation.menu;
            }
            base.OnNavigatedTo(e);
        }

        private void listMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Menu menu = this.listMenu.SelectedItem as Menu;
            if(menu != null)
            {
                this.listMenu.SelectedItem = null;
                Cache.Instance.menu = menu;
                this.NavigationService.Navigate(new Uri("/view/MenuDetialViewPage.xaml", UriKind.Relative));
            }
        }
    }
}