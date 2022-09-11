using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;

namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioServicios
    {
        List<Servicio> servicios;
 
    public RepositorioServicios()
        {
            servicios= new List<Servicio>()
            {
                new Servicio{id=1,origen="Bogota",destino="Medellin",fecha= "06/09/2022", hora="9:30am", encomienda= "Caja"},
                new Servicio{id=2,origen="Cali",destino="Barranquilla",fecha= "22/08/2022", hora="11:30", encomienda= "Caja"},
                new Servicio{id=3,origen="Tolima",destino="Pasto",fecha= "15/08/2022", hora= "13:00pm", encomienda= "Caja"}
            };
        }
 
        public IEnumerable<Servicio> GetAll()
        {
            return servicios;
        }
 
        public Servicio GetWithId(int id){
            return servicios.SingleOrDefault(e => e.id == id);
        }

        public Servicio Update(Servicio newServicio){
            var servicio = servicios.SingleOrDefault(e => e.id == newServicio.id);
            if(servicio != null){
                servicio.origen = newServicio.origen;
                servicio.destino = newServicio.destino;
                servicio.fecha = newServicio.fecha;
                servicio.hora = newServicio.hora;
                servicio.encomienda = newServicio.encomienda;
            }
        return servicio;
        }

        public Servicio Create(Servicio newServicio)
        {
           if(servicios.Count > 0){
             newServicio.id=servicios.Max(r => r.id) +1; 
            }else{
               newServicio.id = 1; 
            }
           servicios.Add(newServicio);
           return newServicio;
        }

        public Servicio Delete(int id)
        {
            var servicio = servicios.SingleOrDefault(e => e.id == id);
            servicios.Remove(servicio);
            return servicio;
        }

    }
}
    
