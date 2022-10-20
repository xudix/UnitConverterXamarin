using System;
using System.Collections.Generic;
using UnitConverterXamarin.ViewModels;
using UnitConverterXamarin.Views;
using Xamarin.Forms;

namespace UnitConverterXamarin
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
