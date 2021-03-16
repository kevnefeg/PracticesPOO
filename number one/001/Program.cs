using System;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximo de habitaciones ? ");
            maxx=Convert.ToInt32(Console.ReadLine());
            available = maxx;

            bool continuar = true;
            do
            {
                switch(showmenu())
                {
                    case 1: book(); break;
                    case 2: dispatch(); break;
                    case 3: state(); break;
                    case 4: profits(); break;
                    case 5: continuar = false; break;
                    default: Console.WriteLine("Intente de nuevo "); break;
                }    
            }while(continuar);

        }
        private static int maxx = 0;
        private static int available =0;
        private static int dispatched = 0;
        public static int showmenu()
    {
        Console.WriteLine("Bienvenido!");
        Console.WriteLine("1) Reservar");
        Console.WriteLine("2) Despachar");
        Console.WriteLine("3) Estado actual");
        Console.WriteLine("4) Ganancias");
        Console.WriteLine("5) Salir");
        return Convert.ToInt32(Console.ReadLine());
    }
    public static void book()
    {
        Console.Write("Habitaciones a reservar: ");
        int rooms = Convert.ToInt32(Console.ReadLine());
        if (rooms <= available && rooms > 0)
        {
            available -= rooms;
            Console.WriteLine("Hecho!");
        }
        else
            Console.WriteLine("Error!");
    }
    public static void dispatch()
    {
        Console.Write("Habitaciones a despachar: ");
        int rooms = Convert.ToInt32(Console.ReadLine());
        int occupied = maxx - available;
        if (rooms <= occupied && rooms > 0)
        {
            available += rooms;
            dispatched += rooms;
            Console.WriteLine("Hecho!");
        }
        else
            Console.WriteLine("Error!");
    }
    public static void state()
    {
        Console.WriteLine("Disponibles: " + available);
        int occupied = maxx - available;
        Console.WriteLine("Ocupadas: " + occupied);
    }
    public static void profits()
    {
        int profit = dispatched * 15;
        Console.WriteLine("Habs. despachadas: " + dispatched);
        Console.WriteLine("Ganancias: $" + profit);
    }
}

    }


