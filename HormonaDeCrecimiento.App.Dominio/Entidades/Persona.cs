using System;

namespace HormonaDeCrecimiento.App.Dominio
{
    /// <sumary>Class <c> Persona </c>
    /// Modela una Persona
    /// </sumary>
    public class Persona
    {
        // Identificador único de cada Persona
        public int Id{get;set;}
        
        // Apellidos de la Persona
        public string Apellidos{get;set;}
        
        // Nombres de la Persona
        public string Nombres{get;set;}
        
        // Número telefónico de la Persona
        public string NumeroTelefonico{get;set;}
        
        // Género de la Persona
        public Genero Genero{get;set;}
    }
}