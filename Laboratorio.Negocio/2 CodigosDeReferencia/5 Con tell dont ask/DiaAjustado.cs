using System;

namespace Negocio.CodigosDeReferencia.ConTellDontAsk
{
    public class DiaAjustado
    {
        int elDia;

        public DiaAjustado(DatosDelRequerimiento losDatos)
        {
            elDia = losDatos.Dia;
        }

        public string ComoTexto()
        {
            if (elDia < 10)
                return elDia.ToString("D2");
            else
                return elDia.ToString();
        }
    }
}