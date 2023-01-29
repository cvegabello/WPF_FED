using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using WpfFEDSubMenu.Model;

namespace WpfFEDSubMenu.ViewModel
{
    public class SwitchBoardViewModel : ViewModelBase
    {
        private readonly CollectionViewSource SwitchBoardItemsCollection;
        public ICollectionView SwitchBoardSourceCollection => SwitchBoardItemsCollection.View;

        public SwitchBoardViewModel()
        {
            ObservableCollection<SwitchBoardItems> switchBoardItems = new ObservableCollection<SwitchBoardItems>
            {
                new SwitchBoardItems { SwitchName = " View / Edit Fuel Element Database", SwitchImage = @"../Assets/img_formFED.png" },
                new SwitchBoardItems { SwitchName = "Documents                                  and Utilities", SwitchImage = @"../Assets/img_DocUtil.png" },
                new SwitchBoardItems { SwitchName = "Fuel - Poison  - Powder Lots ", SwitchImage = @"../Assets/img_FuelOil.png" },
                new SwitchBoardItems { SwitchName = "  Specimen with Blisters or XRP/PDR", SwitchImage = @"../Assets/img_blister.png" },
                new SwitchBoardItems { SwitchName = "PCT Switchboard", SwitchImage = @"../Assets/img_PCT.png" },
                new SwitchBoardItems { SwitchName = "RML Switchboard", SwitchImage = @"../Assets/img_RML.png" },
                new SwitchBoardItems { SwitchName = "Exit FED", SwitchImage = @"../Assets/closeBtn_default.png" }
                
            };

            SwitchBoardItemsCollection = new CollectionViewSource { Source = switchBoardItems };


        }

    }
}
