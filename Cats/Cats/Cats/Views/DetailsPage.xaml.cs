﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cats.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cats.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        Models.Cat SelectedCat;

        public DetailsPage(Models.Cat selectedCat)
        {

            InitializeComponent();
            this.SelectedCat = selectedCat;
            BindingContext = this.SelectedCat;

            ButtonWebSite.Clicked += ButtonWebSite_Clicked;




        }
        private void ButtonWebSite_Clicked(object sender, EventArgs e)
        {
            if (SelectedCat.Website.StartsWith("http"))
            {
                Device.OpenUri(new Uri(SelectedCat.Website));
            }

        }
    }
}
