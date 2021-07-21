using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using System.Net.Http;
using THR1VEApp.ViewModels;
using Newtonsoft.Json;

namespace THR1VEApp.Views
{
    public partial class AboutPage : ContentPage
    {
        private const string monkeyUrl = "https://montemagno.com/monkeys.json";
        private readonly HttpClient httpClient = new HttpClient();
        public ObservableCollection<Monkey> Monkeys { get; set; } = new
               ObservableCollection<Monkey>();

        public AboutPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            var monkeyJson = await httpClient.GetStringAsync(monkeyUrl);
            var monkeys = JsonConvert.DeserializeObject<Monkey[]>(monkeyJson);

            Monkeys.Clear();

            foreach(var monkey in monkeys)
            {
                Monkeys.Add(monkey);
            }
        }

        private async void OnRegPressed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
            var button = (Button)sender;
        }


    }
}