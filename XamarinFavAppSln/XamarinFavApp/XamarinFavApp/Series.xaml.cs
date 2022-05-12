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
    public partial class Series : ContentPage
    {
        private ObservableCollection<SeriesItem> _seriesLists;

        public ObservableCollection<SeriesItem> SeriesList
        {
            get { return _seriesLists; }

            set { _seriesLists = value; }
             
        }
        public Series()
        {
            InitializeComponent();

            _seriesLists = new ObservableCollection<SeriesItem>();

            var seriesLists = new SeriesItem();
            seriesLists.Name = "Suits";
            seriesLists.RunTime = "40 Minutes";

            _seriesLists.Add(seriesLists);

            seriesLists = new SeriesItem();
            seriesLists.Name = "Good Girls";
            seriesLists.RunTime = "55 Minutes";

            SeriesList.Add(seriesLists);

            seriesLists = new SeriesItem();
            seriesLists.Name = "Ginny & Georgia";
            seriesLists.RunTime = "45 Minutes";

            SeriesList.Add(seriesLists);

            BindingContext = this;



        }
    }
}