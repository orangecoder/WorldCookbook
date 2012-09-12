using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using WorldCookbook.model;
using Microsoft.Phone.Shell;

namespace WorldCookbook.userControl
{
    public class Cache
    {
        #region Singleton
        private static readonly Cache instance = new Cache();
        public static Cache Instance { get { return instance; } }
        public Cache() { } 
        #endregion

        public Nation nation
        {
            get
            {
                return PhoneApplicationService.Current.State.ContainsKey("nation") ?
                    PhoneApplicationService.Current.State["nation"] as Nation : null;
            }
            set
            {
                PhoneApplicationService.Current.State["nation"] = value;
            }
        }

        public Menu menu
        {
            get
            {
                return PhoneApplicationService.Current.State.ContainsKey("menu") ?
                    PhoneApplicationService.Current.State["menu"] as Menu : null;
            }
            set
            {
                PhoneApplicationService.Current.State["menu"] = value;
            }
        }

    }
}
