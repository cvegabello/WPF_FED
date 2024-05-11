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
using WpfFEDSubMenu.Model;

namespace WpfFEDSubMenu.Components
{
    /// <summary>
    /// Interaction logic for LabelAndCombo.xaml
    /// </summary>
    public partial class LabelAndCombo : UserControl
    {


        public string LabelText
        {
            get { return (string)GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LabelText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelTextProperty =
            DependencyProperty.Register("LabelText", typeof(string), typeof(LabelAndCombo), new PropertyMetadata(string.Empty));



        public string ComboTag
        {
            get { return (string)GetValue(ComboTagProperty); }
            set { SetValue(ComboTagProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ComboName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ComboTagProperty =
            DependencyProperty.Register("ComboTag", typeof(string), typeof(LabelAndCombo), new PropertyMetadata(string.Empty));

        public string ComboText
        {
            get { return (string)GetValue(ComboTextProperty); }
            set { SetValue(ComboTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ComboName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ComboTextProperty =
            DependencyProperty.Register("ComboText", typeof(string), typeof(LabelAndCombo), new PropertyMetadata(string.Empty));




        public Object ComboItemSource
        {
            get { return (Object)GetValue(ComboItemSourceProperty); }
            set { SetValue(ComboItemSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ComboItemSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ComboItemSourceProperty =
            DependencyProperty.Register("ComboItemSource", typeof(Object), typeof(LabelAndCombo), new PropertyMetadata(null));




        public string ComboDisplayMemberPath
        {
            get { return (string)GetValue(ComboDisplayMemberPathProperty); }
            set { SetValue(ComboDisplayMemberPathProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ComboDisplayMemberPath.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ComboDisplayMemberPathProperty =
            DependencyProperty.Register("ComboDisplayMemberPath", typeof(string), typeof(LabelAndCombo), new PropertyMetadata(string.Empty));



        public bool ComboIsReadOnly
        {
            get { return (bool)GetValue(ComboIsReadOnlyProperty); }
            set { SetValue(ComboIsReadOnlyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ComboIsReadOnly.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ComboIsReadOnlyProperty =
            DependencyProperty.Register("ComboIsReadOnly", typeof(bool), typeof(LabelAndCombo), new PropertyMetadata(true));




        public double ComboHeight
        {
            get { return (double)GetValue(ComboHeightProperty); }
            set { SetValue(ComboHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ComboHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ComboHeightProperty =
            DependencyProperty.Register("ComboHeight", typeof(double), typeof(LabelAndCombo), new PropertyMetadata(20.0));




        public double ComboWidth
        {
            get { return (double)GetValue(ComboWidthProperty); }
            set { SetValue(ComboWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ComboWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ComboWidthProperty =
            DependencyProperty.Register("ComboWidth", typeof(double), typeof(LabelAndCombo), new PropertyMetadata(130.0));




        public double ComboFontSize
        {
            get { return (double)GetValue(ComboFontSizeProperty); }
            set { SetValue(ComboFontSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ComboFontSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ComboFontSizeProperty =
            DependencyProperty.Register("ComboFontSize", typeof(double), typeof(LabelAndCombo), new PropertyMetadata(12.0));




        public LabelAndCombo()
        {
            InitializeComponent();
        }
    }
}
