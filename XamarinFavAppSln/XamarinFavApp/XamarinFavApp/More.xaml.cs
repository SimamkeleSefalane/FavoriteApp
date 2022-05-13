using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFavApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class More : ContentPage
    {
        private ObservableCollection<MoreItems> _moreItems;
        
        public ObservableCollection<MoreItems> MoreItems
        {
            get { return _moreItems; }
            set { _moreItems = value; }
        }

        public More()
        {
            InitializeComponent();

            _moreItems = new ObservableCollection<MoreItems>();

            var listMore = new MoreItems();
            listMore.MoreName = "Sign Up";
        }
    }
}