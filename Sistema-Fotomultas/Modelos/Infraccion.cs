using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Fotomultas.Modelos
{
    public class Infraccion
    {
        // Atributos privados (Encapsulamiento)
        private int idInfraccion;
        private DateTime fechaHora;
        private decimal velocidadRegistrada;
        private decimal montoBase;
        private string estado; // "Pendiente", "Pagado", "En Apelación"
        private Vehiculo vehiculoImplicado; // Asociación con la clase Vehiculo
        private string rutaFotoEvidencia; // Guardará la dirección de la foto capturada

        // Propiedades públicas (Getters y Setters)
        public int IdInfraccion
        {
            get { return idInfraccion; }
            set { idInfraccion = value; }
        }

        public DateTime FechaHora
        {
            get { return fechaHora; }
            set { fechaHora = value; }
        }

        public decimal VelocidadRegistrada
        {
            get { return velocidadRegistrada; }
            set { velocidadRegistrada = value; }
        }

        public decimal MontoBase
        {
            get { return montoBase; }
            set { montoBase = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Vehiculo VehiculoImplicado
        {
            get { return vehiculoImplicado; }
            set { vehiculoImplicado = value; }
        }

        public string RutaFotoEvidencia
        {
            get { return rutaFotoEvidencia; }
            set { rutaFotoEvidencia = value; }
        }

        // Constructor vacío
        public Infraccion()
        {
        }

        // Constructor con parámetros para registrar una fotomulta al instante
        public Infraccion(int id, DateTime fecha, decimal velocidad, decimal monto, string estadoInicial, Vehiculo vehiculo, string rutaFoto)
        {
            this.idInfraccion = id;
            this.fechaHora = fecha;
            this.velocidadRegistrada = velocidad;
            this.montoBase = monto;
            this.estado = estadoInicial;
            this.vehiculoImplicado = vehiculo;
            this.rutaFotoEvidencia = rutaFoto;
        }

        // Método virtual: Permite que los hijos modifiquen cómo se calcula el total
        public virtual decimal CalcularMontoTotal()
        {
            return montoBase;
        }
    }
}