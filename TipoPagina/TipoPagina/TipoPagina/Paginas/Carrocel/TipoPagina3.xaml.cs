﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TipoPagina.Paginas.Carrocel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TipoPagina3 : ContentPage
    {
        public TipoPagina3()
        {
            InitializeComponent();
        }

        private void MudarPagina(object sender, EventArgs e)
        {
            //App.Current.MainPage = new NavigationPage(new Navigation.Pagina1()) { BarBackgroundColor = Color.BlueViolet };
            App.Current.MainPage = new Tabbed.Abas();
        }
    }
}