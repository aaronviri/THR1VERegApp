using System;
using System.Collections.Generic;
using THR1VEApp.ViewModels;
using THR1VEApp.Views;
using Xamarin.Forms;

namespace THR1VEApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
