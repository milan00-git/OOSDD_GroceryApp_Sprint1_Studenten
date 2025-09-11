using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using System.Collections.ObjectModel;

// .NET 8.0 geïnstalleerd, weg uit Visual Studio preview versie

namespace Grocery.App.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        public ObservableCollection<Product> Products { get; set; }

        public ProductViewModel(IProductService productService)
        {
            Products = new(productService.GetAll());
        }

    }
}
