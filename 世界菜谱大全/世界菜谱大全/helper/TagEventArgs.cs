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

namespace 世界菜谱大全.helper
{
    public class TagEventArgs : EventArgs
    {
        public TagEventArgs() { }

        public object Tag { get; set; }
    }
}
