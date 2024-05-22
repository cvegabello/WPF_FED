using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using WpfFEDSubMenu.ViewModel;
using WpfFEDSubMenu.Components;
using FED_DOT_NET.Views;



namespace WpfFEDSubMenu.Views
{
    /// <summary>
    /// Interaction logic for SpecimenView.xaml
    /// </summary>
    public partial class SpecimenView : UserControl
    {
        SpecimenViewModel viewModel;
        private ScrollViewer tabHeaderScrollViewer;
        public SpecimenView()
        {
            InitializeComponent();
            viewModel = new SpecimenViewModel();
            this.DataContext = viewModel;
            LoadFrame();
        }

        private void LoadFrame()
        {
            MyFrame.NavigationService.Navigate(new Page1());
            Page2 page2 = new Page2();
            MyFrame2.NavigationService.Navigate(page2);

        }


        private void LoadScrollVwFromResource()
        {
            var resourceDictionary = new ResourceDictionary
            {
                Source = new Uri("pack://application:,,,/FED_DOT_NET;component/Styles_Templates/Templates.xaml")
            };

            //var tabHeader = resourceDictionary["MainTabControlStyle"];
            //tabHeaderScrollViewer = (ScrollViewer)tabHeader["TabHeadersScrollViewer"];
            // Add the ScrollViewer to the visual tree, if necessary
            // For example, adding it to a placeholder in the MainWindow's XAML

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            viewModel.recorrerCollection();
        }

        private void DropDownMessageComponent(object sender, RoutedEventArgs e)
        {
            LabelAndCombo Comp = (LabelAndCombo)sender;
            string CompName = Comp.ComboTag;
            switch (CompName)
            {
                case "Update":
                    MessageBox.Show(CompName + ". Entro por Update");
                    break;

                case "Edit":
                    MessageBox.Show(CompName + ". Entro por Edit");
                    break;
            }
            
        }

        private void ScrollLeftButton_Click(object sender, RoutedEventArgs e)
        {
            
            var resourceDictionary = new ResourceDictionary();
            resourceDictionary.Source = new Uri("pack://application:,,,/FED_DOT_NET;component/Styles_Templates/Templates.xaml");
            var mergeDict = resourceDictionary.MergedDictionaries;
            var styleScrollView = mergeDict.FirstOrDefault(d => d.Contains("MainTabControlStyle"));

            var scrollView = styleScrollView.FindName("TabHeadersScrollVw") as ScrollViewer;

            if (scrollView.HorizontalOffset > 0)
            {
                scrollView.ScrollToHorizontalOffset(scrollView.HorizontalOffset - 20); // Ajusta el valor según la cantidad de desplazamiento deseada
            }
        }

        private void ScrollRightButton_Click(object sender, RoutedEventArgs e)
        {
            ResourceDictionary resourceDictionary = new ResourceDictionary();
            //resourceDictionary.Source = new Uri("Application.Current.Resources", UriKind.RelativeOrAbsolute);
            //resourceDictionary.Source = new Uri("pack://application:,,,/FED_DOT_NET;component/App.xaml", UriKind.RelativeOrAbsolute);
            //var mergeDict = resourceDictionary.MergedDictionaries;
            //var styleScrollView = mergeDict.FirstOrDefault(d => d.Contains("Styles_Templates/Templates.xaml"));

            //var scrollView = (ScrollViewer)resourceDictionary["TabHeadersScrollVw"];

            //var KeyCollectionTemplates = Application.Current.Resources.MergedDictionaries[2].Values[FindResource("MainTabControlStyle")]

            //var scrollView = KeyCollectionTemplates.FindName("TabHeadersScrollVw") as ScrollViewer;

            //foreach (var keyItem in KeyCollectionTemplates)
            //{
            //    var carlos = keyItem;
            //    var scrollView = carlos.First
            //}

            //var styleFound = KeyCollectionTemplates;

            if (tabHeaderScrollViewer.HorizontalOffset < tabHeaderScrollViewer.ScrollableWidth)
            {
                tabHeaderScrollViewer.ScrollToHorizontalOffset(tabHeaderScrollViewer.HorizontalOffset + 20); // Ajusta el valor según la cantidad de desplazamiento deseada
            }
        }

      

        private void StackPanel_MouseUp(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}
