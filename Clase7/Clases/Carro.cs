using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7.Clases
{
    internal class Carro
    {
        public string Marca { get; }
        public int Modelo { get; }
        public string VelocidadMax { get; }
        public string Color { get; set; }

        private int Encendido = 0;
        private int velocidad_actual = 0;
        private const int MAXVELOCIDAD = 350;
        public Carro(string _marca, string _color, string _velmax)
        {
            Marca = _marca;
            Color = _color;
            VelocidadMax = _velmax;
            Encendido = 0;
            this.velocidad_actual = 0;
        }

        public string GetVelocidadActual()
        {
            return $"Vamos a {velocidad_actual} KPH";
        }

        public void EncenderMotor()
        {
            if (Encendido == 0)
            {
                Console.WriteLine("Brrrrrumm, automóvil encendido.");
                Encendido = 1;
                this.velocidad_actual = 0;
            }
            else
            {
                Console.WriteLine("¡El carro ya se encuentra encendido!");
            }
        }

        public string acelerar()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"Si el auto está apagado, no podemos acelerar.";
                return mensaje;
            }

            velocidad_actual += 10;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"Está yendo a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual}KPH , ¡Alcanzamos la velocidad máxima!";
            }

            Console.WriteLine(mensaje);
            return mensaje;
        }

        public string acelerar(int CuantosKPH)
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"No se puede acelerar con el carro apagado";
                return mensaje;
            }
            velocidad_actual += CuantosKPH;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"Vamos a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual}KPH Llegaste a la velocidad máxima";
            }

            Console.WriteLine(mensaje);
            return mensaje;

        }
        public string desacelerar(int Cuanto)
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = "El auto está apagado, no podemos desacelerar. ";
                return mensaje;
            }
            velocidad_actual -= Cuanto;
            mensaje = $"Desaceleramos, ahora vamos a {velocidad_actual}KPH";
            if (velocidad_actual == 0)
            {
                mensaje = "Nos detuvimos por completo";
                return mensaje;
            }
            Console.WriteLine(mensaje);
            return mensaje;
        }
        public string frenar()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = "El auto está apagado, no podemos frenar.";
                return mensaje;
            }
            velocidad_actual = velocidad_actual - velocidad_actual;
            if (velocidad_actual == 0)
            {
                mensaje = $"Frenamos por completo.{velocidad_actual}KPH";
                return mensaje;
            }
            Console.WriteLine(mensaje);
            return mensaje;
        }
        public void ApagarMotor()
        {
            if (Encendido == 0)
            {
                Console.WriteLine("Oh oh, el motor ya se encuentra apagado!");
            }
            else if (Encendido == 1)
            {
                Encendido = 0;
                Console.WriteLine("Listo, apagamos el carro!");
            }
        }
    }
}