using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using BTVN.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BTVN.Session2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BT2 : Page
    {
        public BT2()
        {
            this.InitializeComponent();

            var item1 = new MenuItem() { Name = "Home", MemnuPage = "homepage", Icon = "\uE80F" }; // abstract property
            var item2 = new MenuItem() { Name = "Contact", MemnuPage = "contact", Icon = "\uE717" };
            var item3 = new MenuItem() { Name = "Customer", MemnuPage = "customer", Icon = "\uE716" };
            var item4 = new MenuItem() { Name = "Mail", MemnuPage = "mail", Icon = "\uE715" };
            Menu.Items.Add(item1);
            Menu.Items.Add(item2);
            Menu.Items.Add(item3);
            Menu.Items.Add(item4);
        }

        private void IconClick_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SP.IsPaneOpen = !SP.IsPaneOpen;
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem selected = (MenuItem)Menu.SelectedItem;  // item mà được chọn để nhấn vào
            switch (selected.MemnuPage)
            {
                case "homepage": MainFrame.Navigate(typeof(FormDemo.Home)); break;
                case "contact": MainFrame.Navigate(typeof(FormDemo.Contact)); break;
                case "customer": MainFrame.Navigate(typeof(FormDemo.Customer)); break;
                case "mail": MainFrame.Navigate(typeof(FormDemo.Mail)); break;
            }
        }
    }
}
