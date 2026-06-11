using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Fotomultas.Modelos
{
    public class Vehiculo
    {
        // Atributos privados (Encapsulamiento)
        private string placa;
        private string marca;
        private string modelo;
        private string color;
        private Propietario dueno; // Asociación directa con la clase Propietario

        // Propiedades públicas (Getters y Setters)
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Propietario Dueno
        {
            get { return dueno; }
            set { dueno = value; }
        }

        // Constructor vacío
        public Vehiculo()
        {
        }

        // Constructor con parámetros para inicializar el vehículo con su dueño
        public Vehiculo(string numeroPlaca, string marcaVehiculo, string modeloVehiculo, string colorVehiculo, Propietario objetoPropietario)
        {
            this.placa = numeroPlaca;
            this.marca = marcaVehiculo;
            this.modelo = modeloVehiculo;
            this.color = colorVehiculo;
            this.dueno = objetoPropietario;
        }
    }
}