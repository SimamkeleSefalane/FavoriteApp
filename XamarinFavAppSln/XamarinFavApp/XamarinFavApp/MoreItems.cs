using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinFavApp
{
    public class MoreItems
    {
        public string MoreName { get; set; }

        public string MoreIcon { get; set; }

        public static implicit operator ObservableCollection<object>(MoreItems v)
        {
            throw new NotImplementedException();
        }
    }
}