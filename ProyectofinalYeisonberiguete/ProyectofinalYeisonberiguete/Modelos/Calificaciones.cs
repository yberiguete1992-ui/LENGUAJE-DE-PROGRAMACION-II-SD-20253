using System;
using System.Data;

namespace ProyectofinalYeisonberiguete
{
    public class Calificacion
    {
        public int ID { get; set; }
        public int EstudianteID { get; set; }
        public string NombreEstudiante { get; set; } 
        public int MateriaID { get; set; }
        public string NombreMateria { get; set; } 

        public decimal Calificacion1 { get; set; }
        public decimal Calificacion2 { get; set; }
        public decimal Calificacion3 { get; set; }
        public decimal Calificacion4 { get; set; }
        public decimal Examen { get; set; }

        
        public decimal TotalCalificacion
        {
            get
            {
               
                decimal promedio = (Calificacion1 + Calificacion2 + Calificacion3 + Calificacion4) / 4m;

                
                return Math.Round((promedio * 0.7m) + (Examen * 0.3m), 2);
            }
        }

        public string Clasificacion
        {
            get
            {
                decimal total = this.TotalCalificacion;
                if (total >= 90) return "A";
                if (total >= 80) return "B";
                if (total >= 70) return "C";
                if (total >= 60) return "D";
                return "F";
            }
        }

        public string Estado
        {
            get
            {
                return this.TotalCalificacion >= 70 ? "Aprobado" : "Reprobado";
            }
        }
    }
}