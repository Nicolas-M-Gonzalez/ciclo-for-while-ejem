using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0;
            
            Console.WriteLine( " ingrese un numero..");
            n = int.Parse( Console.ReadLine());
            for ( int x= 1 ; x <= n ; x++ )
            {
            

            if ( n % x == 0 )
             con  ++; 
            } 
              
              if ( con == 2)
                Console.WriteLine( "..este numero es primo");
            else
                Console.WriteLine( "...este numero no es primo..");
            
            

            
           
                  
           
            
              
                 
                 

            
        }
    }
}
