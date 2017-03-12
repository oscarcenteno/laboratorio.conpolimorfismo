namespace Negocio.RendimientosPorDescuento.ConPolimorfismo
{
    public class TasaBruta
    {
        decimal laTasaDeImpuesto;
        decimal laTasaNeta;

        public TasaBruta(DatosDeLaTasaBruta losDatos)
        {
            laTasaNeta = losDatos.TasaNeta;
            laTasaDeImpuesto = losDatos.TasaDeImpuesto;
        }

        public decimal ComoNumero()
        {
            return laTasaNeta / (1 - (laTasaDeImpuesto / 100));
        }
    }
}