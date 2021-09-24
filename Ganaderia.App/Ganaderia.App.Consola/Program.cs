using System;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;

namespace Ganaderia.App.Consola
{
    class Program
    {

        private static IRepositorioGanadero _repoGanadero = new RepositorioGanadero(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddGanadero();
            GetAllGanaderos();
        }

        private static void AddGanadero() 
        {
            var ganadero = new Ganadero
            {
                Nombres = "Andres",
                Apellidos = "Herrera",
                NumeroTelefono = "3148596563",
                Direccion = "Kra 4 #45-12",
                Correo = "sergio.mintic@ucaldas.edu.co",
                Contrasena = "123456",
                Latitude = 7455,
                Longitud = 5333
            };
            _repoGanadero.AddGanadero(ganadero);
        }

        private static void GetAllGanaderos()
        {
            var ganaderos = _repoGanadero.GetAllGanaderos();

            foreach(Ganadero item in ganaderos)
            {
                Console.WriteLine(item.Nombres);
            }

        }
    }
}
