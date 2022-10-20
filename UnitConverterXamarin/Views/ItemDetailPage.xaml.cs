using System.ComponentModel;
using UnitConverterXamarin.ViewModels;
using Xamarin.Forms;

namespace UnitConverterXamarin.Views
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