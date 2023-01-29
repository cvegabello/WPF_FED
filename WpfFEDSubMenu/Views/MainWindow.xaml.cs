using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using WpfFEDSubMenu.ViewModel;

using WpfFEDSubMenu.Views;

namespace WpfFEDSubMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Tg_Btn_Unchecked(object sender, RoutedEventArgs e)
        {
            //img_bg.Opacity = 1;
        }

        private void Tg_Btn_Checked(object sender, RoutedEventArgs e)
        {
            //img_bg.Opacity = 0.3;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

            MenuItem mnu = (MenuItem)sender;

            switch (mnu.Name)

            {

                case "mnuReports":

                    mnuDocuments.IsChecked=false;
                    
                    break;

                case "mnuDocuments":

                    mnuReports.IsChecked = false;

                    break;

                //case "mnuMusic":
                //    mnuDocuments.IsChecked = false;
                //    mnuReports.IsChecked = false;
                                        
                //    break;

            }


        }
                

        private void mnuMusic_SubmenuOpened(object sender, RoutedEventArgs e)
        {
            mnuDocuments.IsChecked = false;
            mnuReports.IsChecked = false;
            Tg_Btn.IsChecked = true;
            popup_tooltip.Visibility = Visibility.Collapsed;
            popup_tooltip.IsOpen = false;
        }

        

        private void mnuHome_MouseLeave(object sender, MouseEventArgs e)
        {
            popup_tooltip.Visibility = Visibility.Collapsed;
            popup_tooltip.IsOpen = false;

        }

        private void mnuHome_MouseEnter(object sender, MouseEventArgs e)
        {
            if ((bool)!Tg_Btn.IsChecked)
            {
                popup_tooltip.PlacementTarget = mnuReports;
                Header.PopupText.Text = "Reports";
                popup_tooltip.Placement = PlacementMode.Left;
                popup_tooltip.IsOpen = true;

            }
        }

        private void mnuMusic_MouseEnter(object sender, MouseEventArgs e)
        {
            if ((bool)!Tg_Btn.IsChecked)
            {
                popup_tooltip.PlacementTarget = mnuImages;
                Header.PopupText.Text = "Images";
                popup_tooltip.Placement = PlacementMode.Left;
                popup_tooltip.IsOpen = true;

            }

        }

        private void mnuMusic_MouseLeave(object sender, MouseEventArgs e)
        {
            popup_tooltip.Visibility = Visibility.Collapsed;
            popup_tooltip.IsOpen = false;
        }

        private void mnuMovies_MouseEnter(object sender, MouseEventArgs e)
        {
            if ((bool)!Tg_Btn.IsChecked)
            {
                popup_tooltip.PlacementTarget = mnuDocuments;
                Header.PopupText.Text = "Documents";
                popup_tooltip.Placement = PlacementMode.Left;
                popup_tooltip.IsOpen = true;

            }

        }

        private void mnuMovies_MouseLeave(object sender, MouseEventArgs e)
        {
            popup_tooltip.Visibility = Visibility.Collapsed;
            popup_tooltip.IsOpen = false;
        }

        private void pnlControlBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowInteropHelper helper = new WindowInteropHelper(this);
            SendMessage(helper.Handle, 161, 2, 0);
            

        }

        private void pnlControlBar_MouseEnter(object sender, MouseEventArgs e)
        {
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
                this.WindowState = WindowState.Maximized;
            else this.WindowState = WindowState.Normal;

        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

       
    }
}
