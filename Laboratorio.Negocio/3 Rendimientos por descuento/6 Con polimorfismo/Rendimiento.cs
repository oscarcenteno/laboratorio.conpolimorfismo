namespace Negocio.RendimientosPorDescuento.ConPolimorfismo
{
    public class Rendimiento
    {
        decimal elValorFacial;
        decimal elValorTransadoBruto;

        public Rendimiento(DatosDelRendimientoPorDescuento losDatos)
        {
            elValorFacial = losDatos.ValorFacial;
            elValorTransadoBruto = losDatos.ValorTransadoBruto;
        }

        public decimal ComoNumero()
        {
            return elValorFacial - elValorTransadoBruto;
        }
    }
}