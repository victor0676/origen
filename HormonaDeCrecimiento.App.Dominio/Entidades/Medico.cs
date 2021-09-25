using System;

namespace HormonaDeCrecimiento.App.Dominio
{
    /// <sumary>Class <c>Medico</c>
    /// Modelo de un médico
    /// </sumary>
    public class Medico : Persona
    {
        // Nombre de la especialidad médica
        public String Especialidad{get; set;}
        
        // Código único del médico
        public String Codigo{get; set;}

        // Registro único de talento humano
        public String RegistroRethus{get; set;}
        
    }
}