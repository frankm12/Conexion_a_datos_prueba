using Capa_de_datos;
using System;
using System.Data;
using System.Data.SqlClient;


namespace Capa_modelo_de_negocio
{
    public class Negocios
    {
        private Class1 personaDAL = new Class1();

        public void AgregarPersona(string nombre, string apellido)
        {
            // Validaciones o reglas de negocio (opcional)
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                throw new ArgumentException("Nombre y Apellido no pueden estar vacíos.");
            }

            // Llamar a la capa DAL para insertar los datos
            personaDAL.InsertarPersona(nombre, apellido);
        }
    }
}

