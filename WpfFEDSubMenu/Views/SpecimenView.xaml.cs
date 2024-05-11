﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using WpfFEDSubMenu.ViewModel;

namespace WpfFEDSubMenu.Views
{
    /// <summary>
    /// Interaction logic for SpecimenView.xaml
    /// </summary>
    public partial class SpecimenView : UserControl
    {
        SpecimenViewModel viewModel;
        public SpecimenView()
        {
            InitializeComponent();
            viewModel = new SpecimenViewModel();
            this.DataContext = viewModel;
        }
               

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            viewModel.recorrerCollection();
        }
    }
}
