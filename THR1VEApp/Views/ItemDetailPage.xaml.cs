using System.ComponentModel;
using THR1VEApp.ViewModels;
using Xamarin.Forms;

namespace THR1VEApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}