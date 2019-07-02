using ConsultaCep.Service.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ConsultaCep.Service
{
    public class ViaCepService
    {
        private static string _enderecoUrl = "http://viacep.com.br/ws/{0}/json/unicode/";

        public static Endereco BuscarEnderecoViaCep(string cep)
        {
            var novoEndereco = string.Format(_enderecoUrl, cep);

            var wc = new WebClient();
            var endereco = wc.DownloadString(novoEndereco);

            var retorno = JsonConvert.DeserializeObject<Endereco>(endereco);

            return retorno;
        }
    }
}
