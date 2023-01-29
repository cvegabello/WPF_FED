using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using WpfFEDSubMenu.Model;


namespace WpfFEDSubMenu.ViewModel
{
    public class SpecimenViewModel : ViewModelBase
    {

        //private readonly CollectionViewSource TabControlItemsCollection;
        //public ICollectionView TCSourceCollection => TabControlItemsCollection.View;

        public ObservableCollection<TabControlItems> TabItems { get; } = new ObservableCollection<TabControlItems>();
    
                       
            
        //    = new ObservableCollection<TabControlItems>
        //{new TabControlItems { TCName = "As Builts", TCImage = @"../Assets/img_formFED.png" } };


        public SpecimenViewModel()
        {

            //ObservableCollection<TabControlItems> TabItems = new ObservableCollection<TabControlItems>
            //{
            //    new TabControlItems { TCName = "As Builts", TCImage = @"../Assets/img_formFED.png" },
            //    new TabControlItems { TCName = "Specimen History", TCImage = @"../Assets/img_DocUtil.png" }


            //};

            
            TabItems.Add(new TabControlItems { TCName = "As Builts", TCImage = @"../Assets/img_formFED.png" });

            TabItems.Add(new TabControlItems { TCName = "Specimen History", TCImage = @"../Assets/img_DocUtil.png" });
            TabItems.Add(new TabControlItems { TCName = "Sprite Output ", TCImage = @"../Assets/img_FuelOil.png" });
            TabItems.Add(new TabControlItems { TCName = "ILS Values", TCImage = @"../Assets/img_blister.png" });
            TabItems.Add(new TabControlItems { TCName = "Document References", TCImage = @"../Assets/img_PCT.png" });
            TabItems.Add(new TabControlItems { TCName = "Filler/PIN Data", TCImage = @"../Assets/img_RML.png" });
            TabItems.Add(new TabControlItems { TCName = "Gas Puncture", TCImage = @"../Assets/closeBtn_default.png" });




            //TabControlItemsCollection = new CollectionViewSource { Source = TabItems };


        }
    }
}
