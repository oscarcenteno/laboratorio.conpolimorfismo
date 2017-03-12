namespace Negocio.Valoraciones.ConTellDontAsk
{   
    public class ValorDeMercado
    {
        decimal elMontoConvertido;
        decimal elPrecioLimpio;

        public ValorDeMercado(DatosDeLaValoracionEnColones losDatos)
        {
            elMontoConvertido = DetermineElMontoConvertido(losDatos);
            elPrecioLimpio = losDatos.PrecioLimpio;
        }

        private static decimal DetermineElMontoConvertido(DatosDeLaValoracionEnColones losDatos)
        {
            return losDatos.MontoConvertido;
        }

        public decimal ComoNumero()
        {
            return elMontoConvertido * (elPrecioLimpio / 100);
        }
    }
}