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
    public class Menu
    {
        //菜式名
        public string menuName { get; set; }
        //菜式图片
        public string menuImage { get; set; }
        //材料
        public string material { get; set; }
        //做法
        public string method { get; set; }
        //相克食物
        public string conflict { get; set; }
        //营养成分
        public string nutrition { get; set; }
    }
}
