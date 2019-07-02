using ConsultaCep.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConsultaCep
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            txtCep.Focus();

            btnBuscar.Clicked += BuscarCep;
        }

        private void BuscarCep(object sender, EventArgs args)
        {
            var cep = txtCep.Text.Trim();

            try
            {
                if (IsValidCep(cep))
                {
                    var resultado = ViaCepService.BuscarEnderecoViaCep(cep);
                    lbResultado.Text = $"Endereço: {resultado.Localidade}, {resultado.Uf}, {resultado.Logradouro}";
                }
                else
                {
                    DisplayAlert("Atenção", "Cép inválido!", "Ok");
                    txtCep.Text = "";
                    txtCep.Focus();
                }
            }
            catch (Exception e)
            {
                DisplayAlert("Erro", "Não foi possível encontrar o cep", "Ok");
            }

        }

        private bool IsValidCep(string cep)
        {
            //if(cep.Length != 8)
            //{
            //    return false;
            //}
            //else if (!cep.All(char.IsDigit))
            //{
            //    return false;
            //}

            return true;
        }
    }
}
