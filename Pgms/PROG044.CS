// prog044.CS
// Programa: Sentencia de control switch
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   class Principal
   {
      static void Main()
      {
         // Arroja suerte de acuerdo a un número del 1 al 9
         SacaSuerte();
      }

      static void SacaSuerte()
      {
          // variables locales
          const string Digitos = "123456789";
          string sNumero;
          int nNumero;
       
          // pide un número al usuario
          Console.WriteLine();
          Console.WriteLine("Introduzca su número preferido (1 a 9): ");
          sNumero = Console.ReadLine();

          // Si número es válido 
          if (sNumero.Length == 1  &&  Digitos.IndexOf(sNumero) >= 0)
          { 
              // Indica datos de adivinanza
              nNumero = Int32.Parse(sNumero); 
              switch (nNumero)
              {
                 case 1:  
               
                 Console.WriteLine("Su día de suerte es el lunes!");
                 Console.WriteLine("El color que le dá suerte es el rojo!");
                 Console.WriteLine("Su destino está vinculado al planeta Marte");
                 break;

                 case 2:
  
                 Console.WriteLine("Su día de suerte es el martes!");
                 Console.WriteLine("El color que le dá suerte es el azul!");
                 Console.WriteLine("Su destino está vinculado al planeta Venus");
                 break;
            
                 case 3:
            
                 Console.WriteLine("Su día de suerte es el miércoles!");
                 Console.WriteLine("El color que le dá suerte es el amarillo!");
                 Console.WriteLine("Su destino está vinculado al planeta Saturno");
                 break;           
  
                 case 4:
           
                 Console.WriteLine("Su día de suerte es el jueves!");
                 Console.WriteLine("El color que le dá suerte es el verde!");
                 Console.WriteLine("Su destino está vinculado al planeta Júpiter");
                 break;
 
                 case 5:
                 case 6:
           
                 Console.WriteLine("Su día de suerte es el viernes!");
                 Console.WriteLine("El color que le dá suerte es el azul!");
                 Console.WriteLine("Su destino está vinculado al planeta Plutón");
                 break;

                 case 7:
                 case 8:
           
                 Console.WriteLine("Su día de suerte es el sábado!");
                 Console.WriteLine("El color que le dá suerte es el rosado!");
                 Console.WriteLine("Su destino está vinculado al planeta Mercurio");
                 break;
 
                 default:		//case 9
           
                 Console.WriteLine("Su día de suerte es el domingo!");
                 Console.WriteLine("El color que le dá suerte es el naranja!");
                 Console.WriteLine("Su destino está vinculado al planeta Neptuno");
                 break;
              }

              // Despedida
              Console.WriteLine("Buena suerte!");
          }      
 
         // Si número es inválido
          else 
             Console.WriteLine("Lo lamentamos! Solo se aceptan números del 1 al 9");
      }
   }
}