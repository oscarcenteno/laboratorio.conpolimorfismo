using System;

namespace Negocio.CodigosDeReferencia.ConPolimorfismo
{
    public class AñoAjustado
    {
        int elAño;

        public AñoAjustado(DatosDelRequerimiento losDatos)
        {
            elAño = losDatos.Año;
        }

        public string ComoTexto()
        {
            if (elAño < 1000)
                return elAño.ToString("D4");
            else
                return elAño.ToString();
        }
    }
}
