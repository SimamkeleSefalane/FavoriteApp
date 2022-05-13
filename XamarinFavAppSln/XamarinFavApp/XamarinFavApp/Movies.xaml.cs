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
    public partial class Movies : ContentPage
    {
        private ObservableCollection<MoviesList> _moviesLists;


        public ObservableCollection<MoviesList> MovieCollections
        {
            get { return _moviesLists; }

            set { _moviesLists = value; }
        }
        public Movies()
        {
            InitializeComponent();

            _moviesLists = new ObservableCollection<MoviesList>();

            var movieLists = new MoviesList();
            movieLists.MovieName = "The Expandables";
            movieLists.MovieRunTime = "50 Minutes";

            _moviesLists.Add(movieLists);

            movieLists = new MoviesList();
            movieLists.MovieName = "Gone Girl";
            movieLists.MovieRunTime = "1 Hour 45 minutes";

            _moviesLists.Add(movieLists);

            movieLists = new MoviesList();
            movieLists.MovieName = "Till Death";
            movieLists.MovieRunTime = "1 Hour 26 Minutes";

            _moviesLists.Add(movieLists);

            movieLists = new MoviesList();
            movieLists.MovieName = "Everything Everything";
            movieLists.MovieRunTime = "1 Hour 13 Minutes";

            _moviesLists.Add(movieLists);

            movieLists = new MoviesList();
            movieLists.MovieName = "The Color Purple";
            movieLists.MovieRunTime = "2 Hours 13 minutes";

            _moviesLists.Add(movieLists);

            movieLists = new MoviesList();
            movieLists.MovieName = "Burn Notice";
            movieLists.MovieRunTime = "1 Hour 38 minutes";

            _moviesLists.Add(movieLists);

            BindingContext = this;














        }



    }
}