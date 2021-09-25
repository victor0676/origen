using System;

namespace HormonaDeCrecimiento.App.Dominio
{
    /// <sumary>Class <c>Familiar Designado</c>
    /// Modelo de un familiarDesignado
    /// </sumary>
    public class FamiliarDesignado : Persona
    {
        // Parentesco con el paciente
        public string Parentesco{get; set;}
        
        // Correo electrónico del familiar
        public string Correo{get; set;}
    }
}