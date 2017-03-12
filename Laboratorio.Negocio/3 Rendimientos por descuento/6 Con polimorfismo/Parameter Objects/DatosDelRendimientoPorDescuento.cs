using System;

namespace Negocio.RendimientosPorDescuento.ConPolimorfismo
{
    public class DatosDelRendimientoPorDescuento
    {
        public decimal ValorFacial { get; set; }
        public decimal ValorTransadoNeto { get; set; }
        public decimal TasaDeImpuesto { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public DateTime FechaActual { get; set; }
        public bool TieneTratamientoFiscal { get; set; }

        public TimeSpan TiempoAlVencimiento => FechaDeVencimiento - FechaActual;

        public decimal ValorTransadoBruto
        {
            get
            {
                if (TieneTratamientoFiscal)
                    return new ValorTransadoBruto(this).ComoNumero();
                else
                    return ValorTransadoNeto;
            }
        }
    }
}