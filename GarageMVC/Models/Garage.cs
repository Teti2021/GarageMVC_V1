using GarageMVC.Models;
using System.Collections.Generic;

namespace GarajeMVC.Models
{
    public class Garage
    {
        public List<Auto> autos { get; set; }

        public int NumeroGaraje { get; set; }
        public string Descripcion { get; set; }
        public int CapacidadEspacios { get; set; }
        public int EspaciosOcupados { get; set; }

   
        public Garage(int numeroGaraje, string descripcion, int capacidadEspacios, int espaciosOcupados)
        {
            NumeroGaraje = numeroGaraje;
            Descripcion = descripcion;
            CapacidadEspacios = capacidadEspacios;
            EspaciosOcupados = espaciosOcupados;
            autos = new List<Auto>(); 
        }

    
        public void ingresarAuto(Auto auto)
        {
            this.autos.Add(auto);  
            EspaciosOcupados++;
        }

       
        public List<Auto> getAutos()
        {
            return this.autos;  
        }
    }
}
