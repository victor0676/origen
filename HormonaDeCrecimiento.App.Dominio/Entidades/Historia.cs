using System;
using System.Collections.Generic;

namespace HormonaDeCrecimiento.App.Dominio
{
    /// <sumary>Class <c>Historia</c>
    /// Modelo de una historia clínica
    /// </sumary>
    public class Historia
    {
        // Identificador único de cada historia
        public int Id{get; set;}

        // Diagnóstico del paciente
        public string Diagnostico{get; set;}

        // Descripción del entorno (casa y habotación) del paciente
        public string Entorno{get; set;}
        
        // Sugerencias de cuidado para el paciente
        public List<SugerenciasCuidado> sugerencias{get; set;}

    }
}