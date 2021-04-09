using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPageView : ContentPage
    {
        public NavigationPageView()
        {
            InitializeComponent();
        }

        private async void HomePageButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Helpers.Homepage());
        }

        private async void PieOverviewButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Helpers.PieOverview());
        }

        private async void Basket_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Helpers.BasketView());
        }

        private async void Contact_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Helpers.ContactUs());
        }
    }
}