using System;
namespace ahorcado
{
    class Program
    {
        static void Main(string[] args)
        {
            int intentos = 0, Ganar = 0;
            string palabra = elegirPalabra();
            char[] palabraChar = palabra.ToCharArray();
            char[] longitud = espacios(palabra);
            string letraingresa = string.Empty;
            char letraingresachar = ' ';
            bool gano = false;

            while (gano == false)
            {
                int unale = 0, contador = 0, repite = 0;

                while (unale == 0)
                {
                    horcado(intentos);
                    espacios(longitud);

                    Console.WriteLine("\nfallaste: {0}", intentos);
                    Console.Write("\nIntroduce una letra: ");
                    letraingresa = Console.ReadLine();
                    if (CompruebaUna(letraingresa))
                    {
                        letraingresachar = Convert.ToChar(letraingresa);
                        unale++;
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write("Solo una letra.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                for (int k = 0; k < longitud.Length; k++)
                {
                    if (longitud[k] == letraingresachar)
                    {
                        if (repite == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Letra ya encontrada");
                            Console.ReadKey();
                            repite++;
                        }
                        contador++;
                    }
                    else
                    {
                        if (letraingresachar == palabraChar[k])
                        {
                            longitud[k] = letraingresachar;
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
                    horcado(intentos);
                    Console.WriteLine("\nperdistes ya no  te quedad intentos");
                    Console.ReadKey();
                    break;
                }
                if (Ganar == palabraChar.Length)
                {
                    gano = true;
                }
                Console.Clear();
                
            }
            finjuego(palabra, intentos, gano);
        }
        static string elegirPalabra()
        {
              Console.WriteLine("inserte palabra para jugar");
            string palabra = Console.ReadLine();
            int n == palabra;

            string encontrada;

            encontrada = palabra[n];
            return encontrada;
        }
        static char[] espacios(string palabra)
        {
            char[] longitud = palabra.ToCharArray();

            for (int a = 0; a < palabra.Length; a++)
                longitud[a] = '_';

            return longitud;
        }
        static void espacios(char[] longitud)
        {
            Console.WriteLine();

            for (int i = 0; i < longitud.Length; i++)
                Console.Write(longitud[i] + " ");

            Console.WriteLine();
        }
        static bool CompruebaUna(string letra)
        {
        
            bool Unaletra = false;

            if (letra.Length == 1)
                Unaletra = true;

            return Unaletra;
        }
        static void finjuego(string palabra, int intentos, bool gano)
        {
            if (gano == true)
            {
                horcado(intentos);
                Console.WriteLine();
                Console.WriteLine("ganaste crack");
                Console.WriteLine();
                Console.WriteLine("La palabra era: ", palabra.ToUpper());
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