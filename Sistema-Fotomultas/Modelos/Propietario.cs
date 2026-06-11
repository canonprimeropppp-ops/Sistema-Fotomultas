using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Fotomultas.Modelos
{
    public class Propietario
    {
        // Atributos privados (Encapsulamiento)
        private int idUsuario;
        private string nombreUsuario;
        private string dui;
        private string nombre;
        private string apellido;
        private string telefono;
        private string correo;
        private string direccion;
        private string pin_Hash;

        // Propiedades públicas (Getters y Setters)
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public string Dui
        {
            get { return dui; }
            set { dui = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Pin_Hash
        {
            get { return pin_Hash; }
            set { pin_Hash = value; }
        }

        // Constructor vacío
        public Propietario()
        {
        }

        // Constructor con parámetros para inicializar datos rápidamente
        public Propietario(int id, string usuario, string pin, string numeroDui, string nom, string ape, string tel, string mail, string dir)
        {
            this.idUsuario = id;
            this.nombreUsuario = usuario;
            this.pin_Hash = pin;
            this.dui = numeroDui;
            this.nombre = nom;
            this.apellido = ape;
            this.telefono = tel;
            this.correo = mail;
            this.direccion = dir;
        }

        // Métodos de Lógica de Negocio
        public void AbonarMulta(decimal monto)
        {
            // Aquí irá la lógica para cambiar el estado de la multa a "PAGADO"
        }

        public void GenerarApelacion()
        {
            // Aquí irá la lógica para cambiar el estado de la multa a "REVISIÓN"
        }
    }
}