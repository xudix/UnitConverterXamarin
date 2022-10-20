using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnitConverterXamarin.Models;
using UnitConverterXamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverterXamarin.Views
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