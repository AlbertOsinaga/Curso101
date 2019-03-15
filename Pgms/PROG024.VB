' prog024.VB
' Programa: Enums (CType para casting)
' LAOS
' Enero 2004

Option Explicit On
Option Strict On

Imports System

Namespace CursoNet

   Enum Dia
   
      Lunes
      Martes
      Miercoles
      Jueves
      Viernes
      Sabado
      Domingo
   
   End Enum

   class Principal
   
      Shared Sub Main()
      
         ' Dias de la semana
         DiasDeSemana()

      End Sub 
        
      Shared Sub DiasDeSemana()
      
         ' Enum System.Windows.Forms.Day
         Console.WriteLine()
         Console.WriteLine("Enum Dia (Dias de la semana)")
         Console.WriteLine("----------------------------")
         Console.WriteLine("{0}: {1}", Dia.Lunes, Convert.ToInt32(Dia.Lunes)) 
         Console.WriteLine("{0}: {1}", Dia.Martes, Convert.ToInt32(Dia.Martes)) 
         Console.WriteLine("{0}: {1}", Dia.Miercoles, Convert.ToInt32(Dia.Miercoles)) 
         Console.WriteLine("{0}: {1}", Dia.Jueves, Convert.ToInt32(Dia.Jueves)) 
         Console.WriteLine("{0}: {1}", Dia.Viernes, Convert.ToInt32(Dia.Viernes)) 
         Console.WriteLine("{0}: {1}", Dia.Sabado, Convert.ToInt32(Dia.Sabado)) 
         Console.WriteLine("{0}: {1}", Dia.Domingo, Convert.ToInt32(Dia.Domingo)) 

         ' Creando variables (objetos) de tipos Enum
         Console.WriteLine()
         Console.Write("Ingrese un número de día de la semana (0-6): ")
         Dim sDiaElegido As String = Console.ReadLine()   
         Dim diaElegido As Dia = CType( Convert.ToInt32(sDiaElegido), Dia )
         Dim diaAnterior As Dia = CType( diaElegido - 1, Dia )
         Dim diaSiguiente As Dia = CType( diaElegido + 1, Dia )
         If diaElegido = Dia.Lunes Then diaAnterior = Dia.Domingo
         If diaElegido = Dia.Domingo Then diaSiguiente = Dia.Lunes  
         Console.WriteLine()
         Console.WriteLine("Ud. eligió el dia {0} ({1})", diaElegido, Convert.ToInt32(diaElegido)) 
         Console.WriteLine("El dia anterior es {0} ({1})", diaAnterior, Convert.ToInt32(diaAnterior)) 
         Console.WriteLine("El dia siguiente es {0} ({1})", diaSiguiente, Convert.ToInt32(diaSiguiente)) 

      End Sub

   End Class

End Namespace