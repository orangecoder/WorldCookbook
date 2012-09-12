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

namespace WorldCookbook.model
{
    public class Nation
    {
        //国家名
        public string nationName { get; set; }
        //国家图片
        public string nationImage { get; set; }
        //菜式数
        public string menuTotal { get; set; }
        //菜式
        public Menu[] menu { get; set; }

    }
}
