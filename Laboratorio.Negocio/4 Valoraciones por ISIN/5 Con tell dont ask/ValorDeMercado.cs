namespace Negocio.ValoracionesPorISIN.ConTellDontAsk
{
    public class ValorDeMercado
    {
        decimal elMontoConvertido;
        decimal elPrecioLimpioDelVectorDePrecios;

        public ValorDeMercado(DatosDeLaValoracion losDatos)
        {
            elMontoConvertido = losDatos.MontoConvertido;
            elPrecioLimpioDelVectorDePrecios = losDatos.PrecioLimpioDelVectorDePrecios;
        }

        public decimal ComoNumero()
        {
            return elMontoConvertido * (elPrecioLimpioDelVectorDePrecios / 100);
        }
    }
}