using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoGrupal1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String usuario;
            int dni;
            int dniAdulto;
            int edad;
            String destino;
            int claseVuelo;
            int equipajeMano;
            int equipajeBodega;
            int viajePerro;
            int cantidad;
            float pesoEquipaje;
            float pesoAdicional;
            const float PRECIO_ADICIONAL = 10;
            float costoAdicional = 0;

            Console.WriteLine("Bienvenido");

            //1

            Console.WriteLine("Ingrese su nombre: ");
            usuario = Console.ReadLine();

            Console.WriteLine("Ingrese su DNI: ");
            dni = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su destino: ");
            destino = Console.ReadLine();

            Console.WriteLine("Clase del vuelo a elegir: 1. Económica 2. Ejecutiva 3. Primera clase: ");
            claseVuelo = int.Parse(Console.ReadLine());

            Console.WriteLine("Indique si posee equipaje de mano: 1. Si 2. No: ");
            equipajeMano = int.Parse(Console.ReadLine());

            Console.WriteLine("Indique si tiene equipaje en bodega facturado: 1. Si 2. No: ");
            equipajeBodega = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Viaja con perro?: 1. Si 2. No: ");
            viajePerro = int.Parse(Console.ReadLine());

            //2. 

            if (edad >= 2 && edad <= 5)
            {
                Console.WriteLine("El menor debe viajar acompañado de un adulto. Ingrese el DNI del adulto: ");
                dniAdulto = int.Parse(Console.ReadLine());
            }

            //3. 

            if (edad >= 5 && edad <= 11)
            {
                Console.WriteLine("¿Solicitar el servicio de Menor no acompañado?: 1. Si 2.No ");
                int servicio = int.Parse(Console.ReadLine());

                if (servicio == 1)
                {
                    Console.WriteLine("Servicio adquirido!.");
                }
                else
                {
                    Console.WriteLine("Ingrese el DNI del adulto responsable: ");
                    dniAdulto = int.Parse(Console.ReadLine());
                }
            }

            //4. 

            if (equipajeMano == 1)
            {
                Console.WriteLine("Ingrese cantidad de equipaje de mano: ");
                cantidad = int.Parse(Console.ReadLine());

                if (cantidad > 3)
                {
                    Console.WriteLine("Excede la cantidad permitida por pasajero.");
                }
            }

            //5

            if (equipajeBodega == 2)
            {
                Console.WriteLine("Ingrese el peso de su equipaje de bodega: ");
                pesoEquipaje = float.Parse(Console.ReadLine());

                if (claseVuelo == 1)
                {
                    Console.WriteLine("Su clase de vuelo permite peso de equipaje hasta 5kg");
                    if (pesoEquipaje > 5)
                    {
                        pesoAdicional = pesoEquipaje - 5;
                        costoAdicional = pesoAdicional * PRECIO_ADICIONAL;
                    }
                }
                else if (claseVuelo == 2)
                {
                    Console.WriteLine("Su clase de vuelo permite peso de equipaje hasta 10kg");
                    if (pesoEquipaje > 10)
                    {
                        pesoAdicional = pesoEquipaje - 10;
                        costoAdicional = pesoAdicional * PRECIO_ADICIONAL;
                    }
                }
                else
                {
                    Console.WriteLine("Su clase de vuelo permite peso de equipaje hasta 20kg");
                    if (pesoEquipaje > 20)
                    {
                        pesoAdicional = pesoEquipaje - 20;
                        costoAdicional = pesoAdicional * PRECIO_ADICIONAL;
                    }
                }

                if (costoAdicional == 0)
                {
                    Console.WriteLine("No excede limite de peso");
                }
                else
                {
                    Console.WriteLine("Excede el limite de peso de equipaje. Debera abonar un costo adicional");
                }

            }

            //6.

            if (viajePerro == 1)
            {
                Console.WriteLine("¿Aegura que su perro viaje con su chaleco? 1. Si 2. No ");
                int chaleco = int.Parse(Console.ReadLine());
                Console.WriteLine("¿Posee correa o algún accesorio para su seguridad? 1. Si 2. No");
                int correa = int.Parse(Console.ReadLine());
            }

            //7. 

            Console.WriteLine("Verifique que los datos ingresados sean correctos: ");
            Console.WriteLine($"Nombre: {usuario}. DNI: {dni}. Edad: {edad}. Destino: {destino}.");

            if (claseVuelo == 3)
            {
                Console.WriteLine("Clase de vuelo: Primera Clase");
            }
            else if (claseVuelo == 2)
            {
                Console.WriteLine("Clase de vuelo: Ejecutiva");
            }
            else
            {
                Console.WriteLine("Clase de vuelo: Económico");
            }

            Random rnd = new Random();
            char letraUno = (char)rnd.Next('A', 'Z' + 1);
            char letraDos = (char)rnd.Next('A', 'Z' + 1);
            int numAleatorio = rnd.Next(10001, 100000);

            Console.WriteLine($"Su numero de tarjeta de embarque es: {letraUno}{letraDos}{numAleatorio}");
            Console.WriteLine("Emitido el: " + DateTime.Now);

            if (costoAdicional > 0)
            {
                Console.WriteLine($"Costo adicional por exceso de equipaje: ${costoAdicional}");
            }
            else
            {
                Console.WriteLine("Sin costo adicional por equipaje.");
            }

            //8. 
            Console.WriteLine($"Que tenga buen viaje! disfrute de {destino}.");
        }
    }
}
