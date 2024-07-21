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
        For Each Item As Bevanda In ListaProdotti

            If Item.PCodiceBibita = codice Then

                Console.WriteLine(Item.ToString())
            End If

        Next

    End Sub

    Public Sub stampaListino()
        For Each Item As Bevanda In ListaProdotti

            Console.WriteLine(Item.ToString())

        Next
    End Sub

    Public Function cancellaBibita(codice As Integer) As Boolean

        Dim itemToRemove As Bevanda = Nothing

        For Each Item As Bevanda In ListaProdotti

            If Item.PCodiceBibita = codice Then
                itemToRemove = Item
                Exit For
            End If

        Next

        If itemToRemove IsNot Nothing Then
            ListaProdotti.Remove(itemToRemove)
            Return True
        Else
            Return False
        End If


    End Function


    Public Sub visualizzaBirraIPAA(dscr As String)

        For Each Item As Bevanda In ListaProdotti

            If Item.PDescrizione = dscr Then
                Console.WriteLine("Birra trovata " & Item.ToString())
                Exit For
            End If

        Next


    End Sub


End Class