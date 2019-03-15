// prog097.CS
// Programa: Clase Cuentas con indexador String
// LAOS
// Enero 2004

using System;

namespace CursoNet
{
   // Definición de la clase Cuenta
   class Cuenta
   {
       // Constructor

       public Cuenta(string numeroCta, string nombreCta)
       {
          m_numero = numeroCta;
          m_nombre = nombreCta;
       } 


       // Métodos públicos

       public override string ToString()
       {
           return "Cuenta: " + m_numero + " de " + m_nombre;  
       }


       // Propiedades de instancia

       public string Numero
       {
          get { return m_numero; }
          set { m_numero = value; }
       } 
       public string Nombre
       {
          get { return m_nombre; }
          set { m_nombre = value; }
       } 


       // Campos de instancia

       private string m_numero;
       private string m_nombre;
   }


   // Definición clase Cuentas
   class Cuentas
   {
      // Constructores

      public Cuentas(params string[] strs)
      {
         // array de cuentas
         m_ctas = new Cuenta[strs.Length]; 

         // Copia Cuentas al array interno
         for(int i = 0; i < strs.Length; i += 2)
         {
            m_ctas[m_count++] = new Cuenta(strs[i], strs[i + 1]);
         }
      }

		
      // Métodos públicos
		
      public void Add(Cuenta newCta)
      {
         if (m_count >= m_ctas.Length)
         {
            // maneja indice malo
            throw new IndexOutOfRangeException("(Add) Adicionando un elemento fuera de rango");
         }
         else
         {
            m_ctas[m_count].Numero = newCta.Numero;
            m_ctas[m_count++].Nombre = newCta.Nombre;
         }
      }

		
      // Propiedades de instancia
		
      public Cuenta this[int indice] 
      {
         get
	 {
	    if (indice < 0 || indice >= m_ctas.Length)
            {
               // maneja indice malo
               throw new IndexOutOfRangeException("([]) Accediendo a elemento fuera de rango");
            }

            return m_ctas[indice];
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
               m_ctas[indice].Numero = value.Numero;
               m_ctas[indice].Nombre = value.Nombre;
            }
	 }
      } 
   
      public Cuenta this[string numero] 
      {
         get
	 {
            int indice = 0;
            foreach(Cuenta cta in m_ctas)
            {
               if(cta.Numero == numero)
                  break;

               indice++; 
            }           	

            if (indice < 0 || indice >= m_ctas.Length)
            {
               // maneja indice malo
               throw new IndexOutOfRangeException("([]) Accediendo a elemento fuera de rango");
            }

            return m_ctas[indice];
         }
	 set
	 {
            int indice = 0;
            foreach(Cuenta cta in m_ctas)
            {
               if(cta.Numero == numero)
                  break;

               indice++; 
            }           	

	    // Adiciona solo a través de Add
	    if (indice >= m_count )
	    {
	       // maneja índice malo
	       throw new IndexOutOfRangeException("([]) Asignando a elemento no adicionado. Use Add!");
            }
            else
            {
               m_ctas[indice].Numero = value.Numero;
               m_ctas[indice].Nombre = value.Nombre;
            }
	 }
      } 
   
      // strings ocupados
      public int Count
      {
         get { return m_count; }
      }

		
      // Campos de instancia
		
      private Cuenta[] m_ctas;
      private int m_count = 0;
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
	    // Crea lista de cuentas
	    Cuentas ctas = new Cuentas(args);

  	    // Despliega elementos
            Console.WriteLine();
            Console.WriteLine("Cuentas:");
            Console.WriteLine("-------");
            for(int i = 0; i < ctas.Count; i++)
               Console.WriteLine(ctas[i]);

            // Mientras no sea asterisco busca cuenta y despliega
            Console.WriteLine();
            Console.Write("Número de cuenta: ");
            string numcta = Console.ReadLine();
            while(numcta !=  "*")
            {
               Console.WriteLine(ctas[numcta]);              
               Console.WriteLine();
               Console.Write("Número de cuenta: ");
               numcta = Console.ReadLine();
            } 
         }
	 catch(IndexOutOfRangeException e)
	 {
	    Console.WriteLine();
	    Console.WriteLine(e.Message); 
	 }
      }
   }   
}