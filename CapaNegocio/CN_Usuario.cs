﻿using CapaDatos;
using CapaEntidad;
namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario();
        public List<Usuario> Listar()
        {

            return objcd_usuario.Listar();
        }
        public int Registrar(Usuario obj, out string Mensaje )
        {

            return objcd_usuario.Registrar(obj, out Mensaje);
        }

        public bool Editar(Usuario obj, out string Mensaje)
        {

            return objcd_usuario.Editar(obj, out Mensaje);
        }
        public bool Eliminar(Usuario obj, out string Mensaje)
        {

            return objcd_usuario.Eliminar(obj, out Mensaje);
        }
    }
}
