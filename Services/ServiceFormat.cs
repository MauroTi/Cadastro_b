using static System.Net.Mime.MediaTypeNames;

namespace Cadastro_b.Services
{
    public class ServiceFormat
    {
        public static string FormatData( string nome,  string endereco,  string telefone)
        {
            string dadosFormatados = $"<span style='font-style: italic; text-transform: uppercase; color: red;'>Nome: {nome}</span><br />" +
                                     $"<span style='font-style: italic; text-transform: uppercase; color: red;'>Endereço: {endereco}</span><br />" +
                                     $"<span style='font-style: italic; text-transform: uppercase; color: red;'>Telefone: {telefone}</span><br />";


            return dadosFormatados;
        }
    }
}
