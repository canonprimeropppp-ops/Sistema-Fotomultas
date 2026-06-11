using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Fotomultas.Modelos
{
    // El ":" significa que hereda de la clase base Infraccion
    public class InfraccionVelocidad : Infraccion
    {
        // Atributo propio de esta clase hija
        private decimal limiteVelocidadPermitido;

        // Propiedad pública (Getter y Setter)
        public decimal LimiteVelocidadPermitido
        {
            get { return limiteVelocidadPermitido; }
            set { limiteVelocidadPermitido = value; }
        }

        // Constructor vacío
        public InfraccionVelocidad()
        {
        }

        // Constructor con parámetros que envía los datos al papá usando "base"
        public InfraccionVelocidad(int id, DateTime fecha, decimal velocidad, decimal monto, string estadoInicial, Vehiculo vehiculo, string rutaFoto, decimal limite)
            : base(id, fecha, velocidad, monto, estadoInicial, vehiculo, rutaFoto)
        {
            this.limiteVelocidadPermitido = limite;
        }

        // POLIMORFISMO: Modificamos el cálculo del monto total si superó por mucho el límite
        public override decimal CalcularMontoTotal()
        {
            // Si la velocidad registrada supera por más de 30 km/h el límite, se le aplica un recargo del 50%
            if ((VelocidadRegistrada - limiteVelocidadPermitido) > 30)
            {
                return MontoBase * 1.50m; // Multa más grave
            }

            return MontoBase; // Multa normal
        }
    }
}