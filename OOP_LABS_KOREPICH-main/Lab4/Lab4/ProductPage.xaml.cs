using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductPage : ContentPage
    {
        public ProductPage()
        {
            InitializeComponent();
        }
        private void SaveProduct(object sender, EventArgs e)
        {
            var product = (Product)BindingContext;
            if (!String.IsNullOrEmpty(product.name))
            {
                App.Database.SaveItem(product);
            }
            this.Navigation.PopAsync();
        }
        private void DeleteProduct(object sender, EventArgs e)
        {
            var product = (Product)BindingContext;
            App.Database.DeleteItem(product.id);
            this.Navigation.PopAsync();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}