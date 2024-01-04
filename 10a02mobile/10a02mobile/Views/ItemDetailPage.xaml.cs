using System.ComponentModel;
using Xamarin.Forms;
using _10a02mobile.ViewModels;

namespace _10a02mobile.Views
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