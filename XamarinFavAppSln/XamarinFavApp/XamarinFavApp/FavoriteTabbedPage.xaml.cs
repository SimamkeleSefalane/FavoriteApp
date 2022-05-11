using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFavApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FavoriteTabbedPage : TabbedPage
    {
        public FavoriteTabbedPage()
        {
            InitializeComponent();

            var homePage = new HomePage();
         //   var file = new FileImageSource();
         ///   file.File = "HomePageIcon.png";
            homePage.IconImageSource = "HomePageIcon.png";


            Children.Add(homePage);

            var moviesPage = new Movies();
            //   var file = new FileImageSource();
            ///   file.File = "HomePageIcon.png";
            moviesPage.IconImageSource = "moviesIcon.png";


            Children.Add(moviesPage);
            Children.Add(new Series());
            Children.Add(new Downloads());
            Children.Add(new More());
        }
    }
}