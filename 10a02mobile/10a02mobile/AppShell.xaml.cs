using System;
using System.Collections.Generic;
using _10a02mobile.ViewModels;
using _10a02mobile.Views;
using Xamarin.Forms;

namespace _10a02mobile
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
