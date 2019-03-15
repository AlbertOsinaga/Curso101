// prog096.CS
// Programa: Clase Lista de Strings con indexador
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   // Definición clase StringList
   public class StringList
   {
      // Constructores

      public StringList(params string[] strings)
      {
         // Valida capacidad del array
         if (m_maxElementos < strings.Length)
         {
            // maneja indice malo
            throw new IndexOutOfRangeException("Strings manejados fuera de rango");
         }

         // array para strings
         m_strings = new String[m_maxElementos]; 

         // Copia los strings pasados al constructor
         foreach(string s in strings)
         {
            m_strings[m_count++] = s;
         }
      }

		
      // Métodos públicos
		
      public void Add(string newString)
      {
         if (m_count >= m_strings.Length)
         {
            // maneja indice malo
            throw new IndexOutOfRangeException("(Add) Adicionando un elemento fuera de rango");
         }
         else
         {
	    m_strings[m_count++] = newString;
         }
      }

		
      // Propiedades de instancia
		
      // indexador para acceder a los elementos del string list
      public string this[int indice] 
      {
         get
	 {
	    if (indice < 0 || indice >= m_strings.Length)
            {
               // maneja indice malo
               throw new IndexOutOfRangeException("([]) Accediendo a elemento fuera de rango");
            }

            return m_strings[indice];
         }
	 set
	 {
	    // Adiciona solo a través de Add
	    if (indice >= m_count )
	    {
	       // maneja índice malo
	       throw new IndexOutOfRangeException("([]) Asignando a elemento no adicionado. Use Add!");
            }
            else
            {
               m_strings[indice] = value;
            }
	 }
      } 
   
      // strings ocupados
      public int Count
      {
         get { return m_count; }
      }

		
      // Campos de instancia
		
      private string[] m_strings;
      private int m_count = 0;
      private const int m_maxElementos = 5;
   }
    
   
   // Definición Clase Principal
   class Principal
   {
      static void Main(string[] args)
      {
          // Test de Indexadores
          TestIndexadores(args); 
      }

      static void TestIndexadores(string[] args)
      {
         try
	 {	
	    // Crea list de strings
	    StringList ls = new StringList(args);

  	    // Despliega elementos
            Console.WriteLine();
            Console.WriteLine("Strings:");
            Console.WriteLine("--------");
            for(int i = 0; i < ls.Count; i++)
               Console.WriteLine(ls[i]);
         }
	 catch(IndexOutOfRangeException e)
	 {
	    Console.WriteLine();
	    Console.WriteLine(e.Message); 
	 }
      }
   }   
}