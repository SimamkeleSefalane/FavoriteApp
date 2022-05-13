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

            Children.Add(new HomePage());
            Children.Add(new Movies());
            Children.Add(new Series());
            Children.Add(new Downloads());
            Children.Add(new More());
        }
    }
}