using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con, conprimos= 0 ;

            for (int x = 0 ; x <= 5 ; x++)
            {
            Console.WriteLine( " ingrese un numero: ");
            n= int.Parse( Console.ReadLine());
            con =0;

            for ( int y = 1 ; y <= n ; y ++)
            {
                if ( n % y == 0)
                con++;
            }
                if ( con == 2)
                   conprimos++;
                    
            }


            Console.WriteLine( "los numeros primos son: " + conprimos);            

        }
    }
}
