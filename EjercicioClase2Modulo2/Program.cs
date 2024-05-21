using System.Linq;

namespace EjercicioClase2Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizando LINQ resolver las siguientes consignas:

            //Carga de datos
            var lstClientes = new List<Clientes>()
            {
                new Clientes() { Apellido = "Jara", Nombre = "Alejandro" ,CodCliente = 123 , Vip = true},
                new Clientes() { Apellido = "Mossier", Nombre = "Fernando" ,CodCliente = 345 , Vip = false},
                new Clientes() { Apellido = "Bustos", Nombre = "Andres" ,CodCliente = 567 , Vip = true},
                new Clientes() { Apellido = "Dalpiaz", Nombre = "Carla" ,CodCliente = 789 , Vip = true},
                new Clientes() { Apellido = "Miranda", Nombre = "Micaela" ,CodCliente = 112 , Vip = false},
                new Clientes() { Apellido = "De Castillo", Nombre = "Andrea" ,CodCliente = 223 , Vip = false},
            };


            #region Ejercicio1
            // Detectar cual es el numero mas grande e imprimirlo por consola
            Console.WriteLine("EJERCICIO 1:");

            var lstNumeros = new List<int>() { 25,10,99,105, 1, 84, 22};

            Console.WriteLine("El valor mas alto de la lista es " + lstNumeros.Max(x => x) + "\n");
            #endregion

            #region Ejercicio2

            //Ordenar los nombres alfabeticamente
            Console.WriteLine("EJERCICIO 2:");

            var lstNombres = new List<string>() { "Ana", "Alejandro", "Alexis", "Pablo", "Carlos", "Anibal", "Carla", "Susana" };

            List<string> nombresOrdenados = lstNombres.OrderBy(x => x).ToList();

            Console.WriteLine("Los nombres ordenados son:");
            foreach (var item in nombresOrdenados)
            {
                Console.WriteLine(item);
            }


            #endregion

            #region Ejercicio3
            // Utilizando la variable "lstClientes" filtrar los clientes que tengan vip = true e imprimirlo por consola
            Console.WriteLine("\nEJERCICIO 3:");

            List<Clientes> clientesVip = lstClientes.Where(w => w.Vip).ToList();

            Console.WriteLine("Hay " + clientesVip.Count + " clientes vip. Sus nombres son:");

            foreach (var c in clientesVip)
            {
                Console.WriteLine(c.Nombre + " " + c.Apellido);
            }

            #endregion

            #region Ejercicio4 

            //Utilizando la variable "lstClientes" crear una nueva lista donde solo se encuentren los nombres de los clientes e imprimir los nombres
            Console.WriteLine("\nEJERCICIO 4:");
            Console.WriteLine("Los nombres de los clientes son:");
            List<string> nomClientes = lstClientes.Select(s => s.Nombre).ToList();
            foreach (var c in nomClientes) { Console.WriteLine(c); }

            #endregion

            #region Ejercicio5
            //Apartir de la variable "lstClientes" crear una lista que contenga todos los datos pero  modificando los siguientes campos:
            // Nombre tiene que guardarse en mayusculas
            // Apellido tiene que guardarse en mayusculas
            // Vip => se debe evaluar el bool y si es true se debe asignar el texto "Premium" y si es false "Normal"

            /*
             No llegue a la clase consulta, pero en resumen, en este ejercicio no me quedo claro si tenia que crear una nueva variable en 
            la clase Clientes o si tenia como que modificar el tipo de dato que es la variable VIP (osea, cambiarlo de bool a string) y
            asignalre el valor correspondiente. Ante la duda cree una nueva variable y le asigne el valor que corresponde.
            */
            Console.WriteLine("\nEJERCICIO 5:");

            List<Clientes> lClientes = lstClientes;
            lClientes.Select(c => { c.Nombre = c.Nombre.ToUpper(); return c; }).ToList();
            lClientes.Select(c => { c.Apellido = c.Apellido.ToUpper(); return c; }).ToList();
            lClientes.Select(c => { if (c.Vip) c.VipStatus = "Premium"; else c.VipStatus = "Normal"; return c; }).ToList();

            foreach (var item in lClientes)
            {
                Console.WriteLine(item.Nombre + " " + item.Apellido + " y su estado es " + item.VipStatus);
            }


            #endregion
        }
    }
}