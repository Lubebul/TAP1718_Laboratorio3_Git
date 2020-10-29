using System;

namespace TAP1718_Laboratorio3_Git
{
    class Program
    {   
        public static void Main(string[] args)
        {
            Console.WriteLine("Se leggete questo messaggio, significa che siete tornati indietro nel tempo!");
            Program.Specchio();
        }
        
        private static void Specchio()
        {
            Console.WriteLine("Inserisci una frase ed io la renderò in CAPS (se possibile)\n");
            string aux = Console.ReadLine();
            Console.WriteLine(aux.ToUpper());
            Console.ReadLine();
        }



    }
}
