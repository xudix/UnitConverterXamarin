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
    public partial class EditUnitPage : ContentPage
    {
        public EditUnitPage()
        {
            InitializeComponent();
        }

        private async void Entry_Focused(object sender, FocusEventArgs e)
        {
            var entry = (sender as Entry);
            await Task.Delay(100);
            entry.CursorPosition = 0;
            entry.SelectionLength = entry.Text == null ? 0 : entry.Text.Length;
        }

        private void mainAbsoluteLayout_SizeChanged(object sender, EventArgs e)
        {
            AbsoluteLayout.SetLayoutBounds(editUnitPossibleList, new Rectangle(editUnitInput.X, editUnitInput.Y + editUnitInput.Height, editUnitInput.Width, 300));
        }
    }
}