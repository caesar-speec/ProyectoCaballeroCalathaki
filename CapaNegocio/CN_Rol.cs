﻿using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Rol
    {
        public CD_Rol objcd_rol = new CD_Rol();
        public List<Rol> Listar()
        {
            return objcd_rol.Listar();
        }
    }
}
