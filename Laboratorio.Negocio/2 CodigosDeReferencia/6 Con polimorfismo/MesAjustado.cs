namespace Negocio.CodigosDeReferencia.ConPolimorfismo
{
    public class MesAjustado
    {
        int elMes;

        public MesAjustado(DatosDelRequerimiento losDatos)
        {
             elMes = losDatos.Mes;
        }

        public string ComoTexto()
        {
            if (elMes < 10)
                return elMes.ToString("D2");
            else
                return elMes.ToString();
        }
    }
}