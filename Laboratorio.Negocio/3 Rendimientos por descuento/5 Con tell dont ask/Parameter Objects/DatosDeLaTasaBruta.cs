namespace Negocio.RendimientosPorDescuento.ConTellDontAsk
{
    public class DatosDeLaTasaBruta
    {
        public decimal ValorFacial { get; set; }
        public decimal ValorTransadoNeto { get; set; }
        public decimal TasaDeImpuesto { get; set; }
        public decimal DiasAlVencimiento { get; set; }

        public decimal TasaNeta => (ValorFacial - ValorTransadoNeto) / (ValorTransadoNeto * (DiasAlVencimiento / 365)) * 100;
    }
}