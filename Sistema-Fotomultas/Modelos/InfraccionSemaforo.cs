using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Fotomultas.Modelos
{
    // También hereda de la clase base Infraccion
    public class InfraccionSemaforo : Infraccion
    {
        // Atributos propios de esta clase hija
        private string codigoCamaraSemaforo;
        private bool esGiroDerechaIndebido;

        // Propiedades públicas (Getters y Setters)
        public string CodigoCamaraSemaforo
        {
            get { return codigoCamaraSemaforo; }
            set { codigoCamaraSemaforo = value; }
        }

        public bool EsGiroDerechaIndebido
        {
            get { return esGiroDerechaIndebido; }
            set { esGiroDerechaIndebido = value; }
        }

        // Constructor vacío
        public InfraccionSemaforo()
        {
        }

        // Constructor con parámetros que envía los datos al papá usando "base"
        public InfraccionSemaforo(int id, DateTime fecha, decimal velocidad, decimal monto, string estadoInicial, Vehiculo vehiculo, string rutaFoto, string codigoCamara, bool giroIndebido)
            : base(id, fecha, velocidad, monto, estadoInicial, vehiculo, rutaFoto)
        {
            this.codigoCamaraSemaforo = codigoCamara;
            this.esGiroDerechaIndebido = giroIndebido;
        }

        // POLIMORFISMO: Regla para aumentar el costo si no respetó el giro a la derecha en rojo
        public override decimal CalcularMontoTotal()
        {
            // Si el semáforo estaba en rojo y además hizo un giro a la derecha prohibido, se le suma un recargo fijo de $15.00
            if (esGiroDerechaIndebido)
            {
                return MontoBase + 15.00m;
            }

            return MontoBase; // Multa por pasarse el semáforo normal
        }
    }
}