using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
        
        int n,conpar= 0,conimpar= 0, max = 0, min = 0;

        for ( int x = 0 ; x < 5 ; x++)
        {
            Console.WriteLine( " ingrese un numero:");
            n = int.Parse ( Console.ReadLine());
            

            if ( n % 2 == 0 ) 
                if ( conpar == 0){
                   max += n ;
                 conpar++;
                }  
             else   if ( max > n)
                    max += n;
            else if ( n % 3 == 0)
                if ( conimpar == 0 ){
                    min += n;
                  conimpar++;    
                }    
             else   if ( min > n)
                    min += n ;
               
        }
        
            Console.WriteLine( "el maximo de los numeros pares es: " + max);
            Console.WriteLine( " el minimo de los numeros impares es: " + min );
        }
    }
}
