using Expander.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expander.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private IList<Item> _items;
        public IList<Item> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Items = new List<Item> 
            { 
                new Item { ImageSource = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/de/Larus_canus1.jpg/1024px-Larus_canus1.jpg" },
                new Item { ImageSource = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1f/Common_Gull_Larus_canus%2C_Vaxholm_Sweden_1.jpg/1280px-Common_Gull_Larus_canus%2C_Vaxholm_Sweden_1.jpg" }

            };
        }
    }
}
