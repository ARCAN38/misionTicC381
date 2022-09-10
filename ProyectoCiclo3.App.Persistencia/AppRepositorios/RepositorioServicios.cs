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
    }
}