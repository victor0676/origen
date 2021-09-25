using System;

namespace HormonaDeCrecimiento.App.Dominio
{
    /// <sumary>Class <c>PatronesDeCrecimiento</c>
    /// Modelo de los Patrones de Crecimiento del Paciente
    /// </sumary>
    public class PatronesDeCrecimiento
    {
        // Identificador de registro de cada patrón
        public int Id{get; set;}
        
        // Fecha y hora en la que se realiza la medición
        public DateTime FechaHora{get; set;}

        // Valor numerico del patrón
        public float Valor{get; set;}
        
        // Tipo del patrón de crecimiento

        public TipoPatron TipoPatron{get; set;}
    }
}