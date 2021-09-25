using System;

namespace HormonaDeCrecimiento.App.Dominio
{
    /// <sumary>Class <c>SugerenciasCuidado</c>
    /// Modelo de una Sugerencia de cuidado
    /// </sumary>
    public class SugerenciasCuidado
    {
        // Identificador único de la sugerencia
        public int Id{get; set;}
        
        // Fecha y hora en quese realiza la sugerencia
        public DateTime FechaHora{get; set;}

        // Descripción de la sugerencia
        public String Descripcion{get; set;}

        // Cantidad de hormonas que se debe aplicar
        public string CantidadHormonas{get;set;}
    }
}