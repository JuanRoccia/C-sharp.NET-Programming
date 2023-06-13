using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3Ejercicio2
{
    public class EstudianteProfesorPrueba
    {
        static void Main(string[] args)
        {
            // Crear una nueva Persona y saludar
            Persona persona = new Persona();

            // Hacer que la persona salude
            persona.Saludar();

            // Crear un nuevo Estudiante
            Estudiante estudiante = new Estudiante();
            // Establecerle una edad
            estudiante.SetEdad(20);
            // Saludar
            estudiante.Saludar();
            // Mostrar su edad 
            estudiante.VerEdad();
            // Empezar a estudiar
            estudiante.Estudiar();

            // Crear un nuevo Profesor, y hacer que comience a explicar
            Profesor profesor = new Profesor();
            profesor.Explicar();
        }
    }
}
