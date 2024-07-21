Module Module1

    Sub Main(args As String())
        'Oggetti'
        Dim scelta As Integer
        Dim GruppiListini As New List(Of Listino) 'lista di listini'
        Dim Listino As New Listino() 'Creo un oggetto listino che contiene i prodotti'

        While True
            Console.WriteLine("Inserisci la tua scelta:  1 - Inserisci Bevanda 2 - Verifica Prodotto")
            Dim input As String = Console.ReadLine()

            If Integer.TryParse(input, scelta) Then
                Select Case scelta
                    Case 1
                        Listino.inserisciBevanda()
                    Case 2
                        Console.WriteLine("Insersci il codice della bevanda")
                        Dim cod = Integer.Parse(Console.ReadLine())
                        If Listino.verificaArticolo(cod) = True Then
                            Console.WriteLine("Prodotto presente nel listino")
                        Else
                            Console.WriteLine("Prodotto non presente nel listino")
                        End If
                    Case 3
                        Listino.visualizzaDettagli()
                    Case Else
                        Console.WriteLine("Opzione non valida. Uscita dal programma.")
                        Exit While
                End Select
            Else
                Console.WriteLine("Input non valido. Inserisci un numero.")
            End If
        End While
    End Sub


End Module
