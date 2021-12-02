using System;
namespace ahorcado
{
    class Program
    {
        static void Main(string[] args)
        {
            int intentos = 0, Ganar = 0;
            string palabra = elegirpalabra();
            char[] palabraChar = palabra.ToCharArray();
            char[] longitud = espacios(palabra);
            string letraingresada = string.Empty;
            char letraingresa = ' ';
            bool gano = false;
            while (gano == false)
            {
                int unale = 0, contador = 0, repite = 0;
                while (unale == 0)
                {
                    ImprimirEspacios(longitud);
                    Console.WriteLine("\nfallaste: ", intentos);
                    Console.Write("\nintroduce una letra: ");
                    letraingresada = Console.ReadLine();
                    if (CompruebaUna(letraingresada))
                    {
                        letraingresa = Convert.ToChar(letraingresada);
                        unale++;
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write("ingresa solo una letra.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                for (int j = 0; j < longitud.Length; j++)
                {
                    if (longitud[j] == letraingresa)
                    {
                        if (repite == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("esa letra ya la ingresaste manco");
                            Console.ReadKey();
                            repite++;
                        }
                        contador++;
                    }
                    else
                    {
                        if (letraingresa == palabraChar[j])
                        {
                            longitud[j] = letraingresa;
                            contador++;
                            Ganar++;
                        }
                    }
                }
                if (contador == 0)
                {
                    intentos++;
                }
                if (intentos == 5)
                {
                    Console.Clear();
                    Console.WriteLine("\nperdistes ya no hay intentos");
                    Console.ReadKey();
                    break;
                }
                if (Ganar == palabraChar.Length)
                {
                    gano = true;
                }
                Console.Clear()
            }
            findeljuego(palabra, intentos, gano);
        }
        static string elegirpalabra()
        {
            Random pala = new Random();
            int n = pala.Next(0,6);
            string[] palabras = { "eduardo", "amanuel", "profesor","algoritmos","perro","gato","marzo"};
            string encontrada;
            encontrada = palabras[n];
            return encontrada;
        }
        static char[] espacios(string palabra)
        {
            char[] longitud = palabra.ToCharArray();
            for (int f = 0; f < palabra.Length; f++)
                longitud[f] = '_';

            return longitud;
        }
        static void ImprimirEspacios(char[] longitud)
        {
            Console.WriteLine();
            for (int i = 0; i < longitud.Length; i++)
                Console.Write(longitud[i] + " ");

            Console.WriteLine();
        }
        static bool CompruebaUna(string letra)
        {
            bool unaLetra = false;
            if (letra.Length == 1)
            unaLetra = true;
            return unaLetra;
        }
        static void findeljuego(string palabra, int intentos, bool gano)
        {
            if (gano == true)
            {
                Console.WriteLine("ganaste te pasaste de crack");
                Console.WriteLine();
                Console.WriteLine("la palabra era: ", palabra.ToUpper());
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("La palabra era: ", palabra.ToUpper());
                Console.ReadKey();
            }
        }
    }
}