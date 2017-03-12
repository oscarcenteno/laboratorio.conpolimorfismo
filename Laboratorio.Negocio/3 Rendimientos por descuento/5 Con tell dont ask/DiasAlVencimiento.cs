using System;

namespace Negocio.RendimientosPorDescuento.ConTellDontAsk
{
    public class DiasAlVencimiento
    {
        TimeSpan elTiempoAlVencimiento;

        public DiasAlVencimiento(DatosDelRendimientoPorDescuento losDatos)
        {
            elTiempoAlVencimiento = losDatos.TiempoAlVencimiento;
        }

        public decimal ComoNumero()
        {
            return elTiempoAlVencimiento.Days;
        }
    }
}