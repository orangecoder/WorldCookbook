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

namespace WorldCookbook.helper
{
    public class EventSingleton
    {
        #region Singleton
        private static readonly EventSingleton instance = new EventSingleton();
        public static EventSingleton Instance { get { return instance; } }
        private EventSingleton() { }
        #endregion

        //<summary>
        //页面跳转事件 主要用于 UserControl 呼叫通知 Page
        //</summary>
        public event EventHandler<TagEventArgs> OnNavigateTo;
        public void NavigateTo(string uri)
        {
            if(OnNavigateTo != null)
            {
                OnNavigateTo(this, new TagEventArgs { Tag = uri});
            }
        }


    }
}
