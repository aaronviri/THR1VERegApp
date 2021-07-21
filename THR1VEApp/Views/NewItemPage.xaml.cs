using System;
using System.Collections.Generic;
using System.ComponentModel;
using THR1VEApp.Models;
using THR1VEApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace THR1VEApp.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}