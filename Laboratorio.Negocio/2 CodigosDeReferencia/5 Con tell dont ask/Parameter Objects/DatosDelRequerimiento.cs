using System;

namespace Negocio.CodigosDeReferencia.ConTellDontAsk
{
    public class DatosDelRequerimiento
    {
        public DateTime Fecha { get; set; }
        public short Cliente { get; set; }
        public short Sistema { get; set; }
        public string Consecutivo { get; set; }

        public int Año => Fecha.Year;
        public int Dia => Fecha.Day;
        public int Mes => Fecha.Month;
        public string ConsecutivoAjustado
        {
            get
            {
                if (Consecutivo.Length < 12)
                    return Consecutivo.PadLeft(12, '0');
                else
                    return Consecutivo;
            }
        }

        public string ClienteAjustado
        {
            get
            {
                if (Cliente < 100)
                    return Cliente.ToString("D3");
                else
                    return Cliente.ToString();
            }
        }

        public string SistemaAjustado
        {
            get
            {
                if (Sistema < 10)
                    return Sistema.ToString("D2");
                else
                    return Sistema.ToString();
            }
        }
    }
}