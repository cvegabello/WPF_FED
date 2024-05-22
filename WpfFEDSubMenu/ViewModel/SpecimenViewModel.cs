using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using WpfFEDSubMenu.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;



namespace WpfFEDSubMenu.ViewModel
{
    public class SpecimenViewModel : ViewModelBase
    {

        //private readonly CollectionViewSource TabControlItemsCollection;
        //public ICollectionView TCSourceCollection => TabControlItemsCollection.View;

        public ObservableCollection<TabControlItems> TabItems { get; set; } = new ObservableCollection<TabControlItems>();
        //private ObservableCollection<TabControlItems> _TabItems;
        //public ObservableCollection<TabControlItems> TabItems
        //{
        //    get
        //    {
        //        return _TabItems;
        //    }
        //    set
        //    {
        //        _TabItems = value;
        //        OnPropertyChanged(nameof(TabItems));
        //    } 
        //} 
        






        public ObservableCollection<TabControlItems> TabItems2 { get; set; } = new ObservableCollection<TabControlItems>();
        public ObservableCollection<TabControlItems> TabItems3 { get; set; } = new ObservableCollection<TabControlItems>();
        public ObservableCollection<TabControlItems> TabItems4 { get; set; } = new ObservableCollection<TabControlItems>();
        public ObservableCollection<ItemsCarlosCombo1> Specimens { get; set; } = new ObservableCollection<ItemsCarlosCombo1>();
        public ObservableCollection<ItemsCarlosCombo2> Types { get; set; } = new ObservableCollection<ItemsCarlosCombo2>();

        //public ObservableCollection<ItemsCarlos> CarlosItems { get; set; } = new ObservableCollection<ItemsCarlos>();
        //private bool _IsReadOnly;
        //public bool IsReadOnly
        //{
        //    get
        //    {
        //        return _IsReadOnly;
        //    }
        //    set
        //    {
        //        _IsReadOnly = value;
        //        OnPropertyChanged(nameof(IsReadOnly));
        //    }
        //}


        public SpecimenViewModel()
        {

            Specimens.Add(new ItemsCarlosCombo1 { ICName = "Carlos", ICLastName = "Vega" });
            Specimens.Add(new ItemsCarlosCombo1 { ICName = "Santiago", ICLastName = "Vega" });
            Specimens.Add(new ItemsCarlosCombo1 { ICName = "Thomas", ICLastName = "Vega" });
            Specimens.Add(new ItemsCarlosCombo1 { ICName = "Graciela", ICLastName = "Vega" });
            Specimens.Add(new ItemsCarlosCombo1 { ICName = "Alejandro", ICLastName = "Vega" });
            Specimens.Add(new ItemsCarlosCombo1 { ICName = "Sandra", ICLastName = "Vega" });
            Specimens.Add(new ItemsCarlosCombo1 { ICName = "John", ICLastName = "Vega" });
            Specimens.Add(new ItemsCarlosCombo1 { ICName = "Sofia", ICLastName = "Vega" });
            Specimens.Add(new ItemsCarlosCombo1 { ICName = "Matias", ICLastName = "Vega" });

            Types.Add(new ItemsCarlosCombo2 { ICName = "LOCO", ICLastName = "Vega" });
            Types.Add(new ItemsCarlosCombo2 { ICName = "BOBO", ICLastName = "Vega" });
            Types.Add(new ItemsCarlosCombo2 { ICName = "INTELIGENTE", ICLastName = "Vega" });
            Types.Add(new ItemsCarlosCombo2 { ICName = "REBRUTO", ICLastName = "Vega" });
            Types.Add(new ItemsCarlosCombo2 { ICName = "PILO", ICLastName = "Vega" });



            TabItems.Add(new TabControlItems { TCName = "asbuilts", TCImage = "Hola", TagCombo="Update", dataSourceCombo= Specimens, DisplayMemberPath="ICName", IsReadOnly = true, WidthCombo = 130 });
            TabItems.Add(new TabControlItems { TCName = "Specimen History", TCImage = "Pepe", TagCombo = "Edit", dataSourceCombo = Types, DisplayMemberPath = "ICName", IsReadOnly = true, WidthCombo = 130 });
            TabItems.Add(new TabControlItems { TCName = "Sprite Output ", TCImage = @"FuelOil.png", TagCombo = "Update", IsReadOnly = true, WidthCombo = 130 });
            TabItems.Add(new TabControlItems { TCName = "ILS Values", TCImage = @"img_blister.png", TagCombo = "Edit" , IsReadOnly = true , WidthCombo = 130});
            TabItems.Add(new TabControlItems { TCName = "Document References", TCImage = @"../Assets/img_PCT.png", TagCombo = "Update", WidthCombo = 130});
            TabItems.Add(new TabControlItems { TCName = "Filler/PIN Data", TCImage = @"../Assets/img_RML.png", TagCombo = "Update" , WidthCombo = 130});
            TabItems.Add(new TabControlItems { TCName = "Gas Puncture", TCImage = @"../Assets/closeBtn_default.png", TagCombo = "Update", WidthCombo = 130 });
            TabItems2.Add(new TabControlItems { TCName = "Carlos", TCImage = @"../Assets/img_FuelOil.png", TagCombo = "Update", WidthCombo = 110 });
            TabItems2.Add(new TabControlItems { TCName = "Sandra", TCImage = @"../Assets/img_blister.png" , TagCombo = "Update", WidthCombo = 110 });
            TabItems2.Add(new TabControlItems { TCName = "John", TCImage = @"../Assets/img_PCT.png",TagCombo = "Update", WidthCombo = 110 });
            TabItems2.Add(new TabControlItems { TCName = "Monica", TCImage = @"../Assets/img_RML.png" , TagCombo = "Update", WidthCombo = 110 });
            TabItems2.Add(new TabControlItems { TCName = "Thomas", TCImage = @"../Assets/closeBtn_default.png", TagCombo = "Update", WidthCombo = 110 });
            TabItems2.Add(new TabControlItems { TCName = "As Builts", TCImage = @"../Assets/img_formFED.png" , TagCombo = "Update", WidthCombo = 110 });
            TabItems2.Add(new TabControlItems { TCName = "Specimen History", TCImage = @"../Assets/img_DocUtil.png", TagCombo = "Update", dataSourceCombo = Specimens, DisplayMemberPath = "ICLastName",IsReadOnly = true, WidthCombo = 110 });
            TabItems3.Add(new TabControlItems { TCName = "Sprite Output ", TCImage = @"../Assets/img_FuelOil.png", TagCombo = "Editar", WidthCombo = 130 });
            TabItems3.Add(new TabControlItems { TCName = "ILS Values", TCImage = @"../Assets/img_blister.png", TagCombo = "Update" , WidthCombo = 130});
            TabItems3.Add(new TabControlItems { TCName = "Document References", TCImage = @"../Assets/img_PCT.png", TagCombo = "Update", WidthCombo = 130 });
            TabItems3.Add(new TabControlItems { TCName = "Filler/PIN Data", TCImage = @"../Assets/img_RML.png", TagCombo = "Update" , WidthCombo = 130});
            TabItems3.Add(new TabControlItems { TCName = "Gas Puncture", TCImage = @"../Assets/closeBtn_default.png", TagCombo = "Editar" , WidthCombo = 130});
            TabItems3.Add(new TabControlItems { TCName = "Carlos", TCImage = @"../Assets/img_FuelOil.png", TagCombo = "Update" , WidthCombo = 130});
            TabItems3.Add(new TabControlItems { TCName = "Sandra", TCImage = @"../Assets/img_blister.png", TagCombo = "Update" , WidthCombo = 130});
            TabItems4.Add(new TabControlItems { TCName = "John", TCImage = @"../Assets/img_PCT.png", TagCombo = "Update", WidthCombo = 130 });
            TabItems4.Add(new TabControlItems { TCName = "Monica", TCImage = @"../Assets/img_RML.png", TagCombo = "Update" , WidthCombo = 130});
            TabItems4.Add(new TabControlItems { TCName = "Thomas", TCImage = @"../Assets/closeBtn_default.png", TagCombo = "Edit", dataSourceCombo = Specimens , WidthCombo = 130});




            //TabControlItemsCollection = new CollectionViewSource { Source = TabItems };

        


    }


        public void recorrerCollection()
        {
            foreach (var item in TabItems)
            {
                if (item != null)
                {
                    if (item.TagCombo == "Update")
                    {
                        item.IsReadOnly = false;
                    }
                }
            }
        }

        public void ScrollLeftButton()
        {
            //if (TabHeadersScrollVw.HorizontalOffset > 0)
            //{
            //    TabHeadersScrollVw.ScrollToHorizontalOffset(TabHeadersScrollVw.HorizontalOffset - 20); // Ajusta el valor según la cantidad de desplazamiento deseada
            //}
        }



    }
}
