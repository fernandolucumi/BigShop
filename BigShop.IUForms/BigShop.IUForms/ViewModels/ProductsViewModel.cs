namespace BigShop.UIForms.ViewModels
{
    using BigShop.Common.Models;
    using BigShop.Common.Services;
    using System.Collections.ObjectModel;
    using System.Collections.Generic;
    using Xamarin.Forms;
    using BigShop.IUForms.ViewModels;
    public class ProductsViewModel : BaseViewModel
    {
        private readonly ApiService apiService;
        private ObservableCollection<Product> products;
        private bool isRefreshing;

        public ObservableCollection<Product> Products
        {
            get => products;
            set => SetValue(ref products, value);
        }

        public bool IsRefreshing
        {
            get => isRefreshing;
            set => SetValue(ref isRefreshing, value);
        }

        public ProductsViewModel()
        {
            apiService = new ApiService();
            LoadProducts();
        }

        private async void LoadProducts()
        {
            this.IsRefreshing = true;

            Response response = await apiService.GetListAsync<Product>(
                "https://bigshopweb.azurewebsites.net",
                "/api",
                "/Products");

            this.IsRefreshing = false;

            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Accept");

                return;
            }

            List<Product> myProducts = (List<Product>)response.Result;
            Products = new ObservableCollection<Product>(myProducts);
        }
    }
}
