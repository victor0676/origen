using System;
using System.Collections.Generic;

namespace HormonaDeCrecimiento.App.Dominio
{
    /// <sumary>Class <c>Paciente</c>
    /// Modelo de un paciente
    /// </sumary>
    public class Paciente : Persona
    {
        // Dirección del paciente
        public string Direccion{get; set;}
        
        // Latitud de la ubicación
        public float Latitud{get; set;}

        // Longitud de la ubicación
        public float Longitud{get; set;}

        // Ciudad de la ubicación
        public string Ciudad{get; set;}

        // Fecha de nacimiento del paciente
        public DateTime FechaNacimiento{get; set;}
        
        // Médicos asignados al paciente
        public List<Medico> medicos{get; set;}

        // Familiar designado para el paciente
        public List<FamiliarDesignado> familiares{get; set;}

        // Historia clínica del paciente
        public List<Historia> Historias{get; set;}

        // Patrones de crecimiento del paciente
        public List<PatronesDeCrecimiento> Patrones{get; set;}

    }
}