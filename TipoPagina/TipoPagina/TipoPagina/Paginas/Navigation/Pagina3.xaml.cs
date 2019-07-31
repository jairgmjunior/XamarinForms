using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TipoPagina.Paginas.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina3 : ContentPage
    {
        public Pagina3()
        {
            InitializeComponent();
        }

        private void FecharModal(object sender, EventArgs e)
        {
            //Navigation.PopToRootAsync();
            //Navigation.PopAsync();
            Navigation.PopModalAsync();
        }
    }
}