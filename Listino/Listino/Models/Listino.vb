Imports System

Public Class Listino

    Dim ListaProdotti as new List(of Bevanda)

    'Costruttore vuoto'
    Public Sub New()

    End Sub



    'Metodi'


    Public Sub inserisciBevanda()

        Dim a as Integer
        Console.Write("Cosa vuoi aggiungere? 1 - Vino 2 - Birra")

        a = Integer.Parse(Console.ReadLine())

        if a = 1 Then
            ' Dim c = Integer.TryParse(Console.ReadLine())
            Console.WriteLine("Inserisci la descrizione")
            Dim d = Console.ReadLine()
            Console.WriteLine("Inserisci il costo")

            Dim co = Double.Parse(Console.ReadLine())
            Console.WriteLine("Inserisci l'anno")

            Dim Ann = Console.ReadLine()
            Dim vino as new Vino(d,co,Ann)

            ListaProdotti.add(vino)
        else if a = 2 Then
            ' Dim c = Integer.TryParse(Console.ReadLine())
            Console.WriteLine("Inserisci la descrizione")

            Dim d = Console.ReadLine()
            Console.WriteLine("Inserisci il costo")

            Dim co = Double.Parse(Console.ReadLine())
            Console.WriteLine("Inserisci la tipologia")

            Dim Ti = Console.ReadLine()

            Dim bi as new Birra(d,co,Ti)

            ListaProdotti.add(bi)
        else
            Console.WriteLine("Non hai inserito un valore valido")
        End If
    End Sub

    Public Function verificaArticolo(codice As Integer) As Boolean

        For Each Item As Bevanda In ListaProdotti

            If Item.PCodiceBibita = codice Then

                Return True
                Exit For

            End If

        Next



    End Function


    Public Sub visualizzaDettagli(codice As Integer)

    End Sub

    Public Sub stampaListino()

    End Sub

    Public Function cancellaBibita()

    End Function

End Class