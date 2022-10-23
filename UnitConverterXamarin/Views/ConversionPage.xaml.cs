using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverterXamarin.ViewModels;
using UnitConverterXamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverterXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConversionPage : ContentPage
    {
        public ConversionPage()
        {
            InitializeComponent();
            viewModel = this.BindingContext as ConversionViewModel;
        }

        private ConversionViewModel viewModel;

        private async void Entry_Focused(object sender, FocusEventArgs e)
        {
            var entry = (sender as Entry);
            await Task.Delay(100);
            entry.CursorPosition = 0;
            entry.SelectionLength = entry.Text == null ? 0 : entry.Text.Length;
        }

        private void mainAbsoluteLayout_SizeChanged(object sender, EventArgs e)
        {
            AbsoluteLayout.SetLayoutBounds(convPossibleUnitList, new Rectangle(convUnitEntry.X, convUnitEntry.Y + convUnitEntry.Height, convUnitEntry.Width, 300));
        }

        private void resultPrefixPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = sender as Picker;
            var selectedPrefix = (sender as Picker).SelectedItem;
            if (selectedPrefix != null)
            {
                viewModel.UpdateResultPrefix(picker.Parent.BindingContext as VariableWithUnit, selectedPrefix as string);
            }
        }

        private void convPossibleUnitList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
                convUnitEntry.Text = (e.SelectedItem as Unit).ToString();
            convUnitEntry.Unfocus();
        }
    }

    
}