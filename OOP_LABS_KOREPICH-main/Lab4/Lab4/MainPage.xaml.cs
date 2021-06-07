using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            productsList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Product selectedProduct = (Product)e.SelectedItem;
            ProductPage productPage = new ProductPage();
            productPage.BindingContext = selectedProduct;
            await Navigation.PushAsync(productPage);
        }
        // обработка нажатия кнопки добавления
        private async void CreateProduct(object sender, EventArgs e)
        {
            Product product = new Product();
            ProductPage productPage = new ProductPage();
            productPage.BindingContext = product;
            await Navigation.PushAsync(productPage);
        }
    }
}
