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

        public Usuario Update(Usuario newUsuario){
            var usuario = usuarios.SingleOrDefault(e => e.id == newUsuario.id);
            if(usuario != null){
                usuario.nombre = newUsuario.nombre;
                usuario.apellidos = newUsuario.apellidos;
                usuario.direccion = newUsuario.direccion;
                usuario.telefono = newUsuario.telefono;
                
            }
        return usuario;
        }

        public Usuario Create(Usuario newUsuario)
        {
           if(usuarios.Count > 0){
             newUsuario.id=usuarios.Max(r => r.id) +1; 
            }else{
               newUsuario.id = 1; 
            }
           usuarios.Add(newUsuario);
           return newUsuario;
        }

        public Usuario Delete(int id)
        {
            var usuario = usuarios.SingleOrDefault(e => e.id == id);
            usuarios.Remove(usuario);
            return usuario;
        }

    }
}
    
