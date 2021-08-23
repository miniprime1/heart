using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Heart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MouseDown += MainWindow_MouseDown;

            var menu = new System.Windows.Forms.ContextMenu();

            var noti = new NotifyIcon
            {
                Icon = new Icon("icon.ico"),
                Visible = true,
                Text = "Heart",
                ContextMenu = menu
            };
            var shutdown = new System.Windows.Forms.MenuItem
            {
                Index = 0,
                Text = "Exit"

            };
            var about = new System.Windows.Forms.MenuItem
            {
                Index = 1,
                Text = "About"
            };

            shutdown.Click += (object o, EventArgs e) =>
            {
                System.Windows.Application.Current.Shutdown();
            };
            about.Click += (object o, EventArgs e) =>
            {
                System.Windows.Forms.MessageBox.Show("Heart v1.0 \nCopyright (c) 2020 miniprime1", "About");
            };

            menu.MenuItems.Add(shutdown);
            menu.MenuItems.Add(about);
        }

        private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) this.DragMove();
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }
    }
}
