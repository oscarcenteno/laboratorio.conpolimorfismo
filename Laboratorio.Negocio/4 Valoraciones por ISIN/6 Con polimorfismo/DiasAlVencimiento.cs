using System;

namespace Negocio.ValoracionesPorISIN.ConPolimorfismo
{
    public class DiasAlVencimiento
    {
        TimeSpan laDiferenciaEntreLasFechas;

        public DiasAlVencimiento(DatosDeLaValoracion losDatos)
        {
            laDiferenciaEntreLasFechas = losDatos.DiferenciaEntreLasFechas;
        }

        public double ComoNumeros()
        {
            return laDiferenciaEntreLasFechas.TotalDays;
        }

    }
}
