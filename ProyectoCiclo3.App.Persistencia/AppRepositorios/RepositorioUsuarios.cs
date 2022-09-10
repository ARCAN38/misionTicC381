using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuarios
    {
        List<Usuario> usuarios;
 
    public RepositorioUsuarios()
        {
            usuarios= new List<Usuario>()
            {
                new Usuario{id=1,nombre="Juan",apellidos="Ruiz",direccion= "82-27",telefono= "3114233256"},
                new Usuario{id=1,nombre="Felipe",apellidos="Sandoval",direccion= "34-40",telefono= "3112365365"},
                new Usuario{id=1,nombre="Carolina",apellidos="Neira",direccion= "27-56",telefono= "3116358578"},
            };
        }
 
        public IEnumerable<Usuario> GetAll()
        {
            return usuarios;
        }
 
        public Usuario GetWithId(int id){
            return usuarios.SingleOrDefault(e => e.id == id);
        }
    }
}