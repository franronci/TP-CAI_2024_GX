﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{   
    //Se intenta respetar tipos de datos provisto en la consigna
    public class DatosProveedorWS
    {
        Guid _id;
        String _nombre;
        String _apellido;
        String _email;
        String _cuit;
        String _fechaAlta;
        DateTime? _fechaBaja;
        public DatosProveedorWS()
        {
        }

        public DatosProveedorWS(Guid Id, string Nombre, string Apellido, string Email, String CUIT, string FechaAlta, DateTime? FechaBaja)
        {
            _id = Id;
            _nombre = Nombre;
            _apellido = Apellido;
            _email = Email;
            _cuit = CUIT;
            _fechaAlta = FechaAlta;
            _fechaBaja = FechaBaja;
        }

        public Guid Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Email { get => _email; set => _email = value; }
        public String CUIT { get => _cuit; set => _cuit = value; }
        public string FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime? FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }

    }
}
