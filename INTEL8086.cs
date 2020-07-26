using System;
using System.Runtime.InteropServices;

namespace INTEL8086
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 1;
            Console.WriteLine("INTEL8086 MOV SIM");
            string ax = "-", bx = "-", cx = "-", dx = "-";
            Console.WriteLine("AX:{0} BX:{1} CX:{2} DX:{3}", ax, bx, cx, dx);


            do
            {
                Console.WriteLine("Wybierz 1 jeżeli chcesz wprowadzić wartość, w celu wykonania rozkazu MOV wybierz 2; wyjście: wybierz 3");
                z = int.Parse(Console.ReadLine());

                if (z == 1)
                {
                    Console.WriteLine("Wprowadź wartość: AX wybierz 1, BX wybierz 2, CX wybierz 3, DX wybierz 4");
                    int x = int.Parse(Console.ReadLine());
                    if (x == 1) { ax = Console.ReadLine(); }
                    else if (x == 2) { bx = Console.ReadLine(); }
                    else if (x == 3) { cx = Console.ReadLine(); }
                    else if (x == 4) { dx = Console.ReadLine(); }
                    else { Console.WriteLine("Podano złą watość"); }
                }
                else if (z == 2)
                {
                    Console.WriteLine("Wprowadź pierwszy parametr: AX wybierz 1, BX wybierz 2, CX wybierz 3, DX wybierz 4");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Wprowadź drugi parametr: AX wybierz 1, BX wybierz 2, CX wybierz 3, DX wybierz 4");
                    int h = int.Parse(Console.ReadLine());
                    if (y == 1 || h == 2) { bx = ax; }
                    else if (y == 1 || h == 3) { cx = ax; }
                    else if (y == 1 || h == 4) { dx = ax; }
                    else if (y == 2 || h == 1) { ax = bx; }
                    else if (y == 2 || h == 3) { cx = bx; }
                    else if (y == 2 || h == 4) { dx = bx; }
                    else if (y == 3 || h == 1) { ax = cx; }
                    else if (y == 3 || h == 2) { bx = cx; }
                    else if (y == 3 || h == 4) { dx = cx; }
                    else if (y == 4 || h == 1) { ax = dx; }
                    else if (y == 4 || h == 2) { bx = dx; }
                    else if (y == 4 || h == 3) { cx = dx; }
                    else { Console.WriteLine("Nieprawidłowa wartość"); }
                }
                else { Console.WriteLine("Nieprawidłowa wartość"); }

                Console.WriteLine("AX:{0} BX:{1} CX:{2} DX:{3}", ax, bx, cx, dx);
            } while (z != 0);
        }
    }
}
