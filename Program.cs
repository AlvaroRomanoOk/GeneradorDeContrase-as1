using System;

namespace GeneradorContrasenas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generador de Contraseñas Básico");
            Console.WriteLine("================================");

            Console.Write("Longitud de la contraseña: ");
            int longitud = int.Parse(Console.ReadLine());

            string contrasenaGenerada = GenerarContrasena(longitud);

            Console.WriteLine("Contraseña generada: " + contrasenaGenerada);

            Console.ReadKey();
        }

        static string GenerarContrasena(int longitud)
        {
            const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var rnd = new Random();
            char[] contrasena = new char[longitud];

            for (int i = 0; i < longitud; i++)
            {
                contrasena[i] = caracteres[rnd.Next(caracteres.Length)];
            }

            return new string(contrasena);
        }
    }
}
