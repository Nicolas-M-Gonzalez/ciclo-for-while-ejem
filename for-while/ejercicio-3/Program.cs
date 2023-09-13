using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=1, con, numgrupo=0  ;

            while (n >=  0)
            {
               numgrupo++; 
               con= 0;
               Console.WriteLine( " ingrese un numero:");
               n = int.Parse(Console.ReadLine());
                  while ( n > 0)
                {
                  
                  con++;
                  Console.WriteLine( " ingrese otro..");
                  n= int.Parse(Console.ReadLine());
                  
                }
                
                Console.WriteLine( " los numero positivos son: " + con + "en el grupo: "+ numgrupo);
            }
            
        }
    }
}
