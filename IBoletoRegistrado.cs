using CobrancaBBApi.Model;

namespace CobrancaBBApi
{
    public interface IBoletoRegistrado
    {
        Model.BoletoRegistrado RegistrarBoleto(Boleto Boleto);
        BoletoResult PesquisaBoleto(BoletoFiltroPesquisa Parametros);
    }
}
