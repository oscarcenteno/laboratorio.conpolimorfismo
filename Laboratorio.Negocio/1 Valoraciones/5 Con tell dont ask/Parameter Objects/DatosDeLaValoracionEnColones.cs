﻿namespace Negocio.Valoraciones.ConTellDontAsk
{
    public class DatosDeLaValoracionEnColones
    {
        public decimal MontoNominal { get; set; }
        public decimal TipoDeCambio { get; set; }
        public decimal PrecioLimpio { get; set; }
        public decimal PorcentajeDeCobertura { get; set; }
        public Monedas TipoDeMoneda { get; set; }
        public decimal MontoConvertido
        {
            get
            {
                if (TipoDeMoneda == Monedas.Colon)
                    return MontoNominal * TipoDeCambio;
                else
                    return MontoNominal;
            }
        }
    }
}