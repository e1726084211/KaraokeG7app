﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
namespace KaraokeApp.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AcercaDe : PopupPage
    {
        public AcercaDe()
        {
            InitializeComponent();
        }

        private async void btnOk_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAllAsync();
        }
    }
}