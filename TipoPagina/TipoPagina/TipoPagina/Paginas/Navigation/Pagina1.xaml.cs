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
    public partial class Pagina1 : ContentPage
    {
        public Pagina1()
        {
            InitializeComponent();
        }

        private void MudarPagina2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pagina2());
        }

        private void AbrirModal(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Pagina3());
        }
    }
}