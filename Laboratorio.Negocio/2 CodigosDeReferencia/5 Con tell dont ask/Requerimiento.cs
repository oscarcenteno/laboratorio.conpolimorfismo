namespace Negocio.CodigosDeReferencia.ConTellDontAsk
{
    public class Requerimiento
    {
        string laFechaFormateada;
        string elClienteAjustado;
        string elSistemaAjustado;
        string elConsecutivoAjustado;

        public Requerimiento(DatosDelRequerimiento losDatos)
        {
            laFechaFormateada = new FechaFormateada(losDatos).ComoTexto();
            elClienteAjustado = losDatos.ClienteAjustado;
            elSistemaAjustado = losDatos.SistemaAjustado;
            elConsecutivoAjustado = losDatos.ConsecutivoAjustado;
        }

        public string ComoTexto()
        {
            return laFechaFormateada + elClienteAjustado + elSistemaAjustado + elConsecutivoAjustado;
        }
    }
}