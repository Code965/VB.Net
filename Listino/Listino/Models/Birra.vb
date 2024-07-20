Public Class Birra
    Inherits Bevanda

    Private tipologia As String

    ' Costruttore della classe Birra
    Public Sub New(descrizione As String, costo As Double, tipologia As String)

        MyBase.New(descrizione, costo)
        Me.tipologia = tipologia

    End Sub

    ' Proprietà per la tipologia
    Public Property Tipo As String
        Get
            Return Me.tipologia
        End Get
        Set(value As String)
            Me.tipologia = value
        End Set
    End Property

    ' Implementazione del metodo ToString
    Public Overrides Function ToString() As String
        Return "Codice: " & MyBase.PCodiceBibita.ToString() & " Descrizione: " & MyBase.PDescrizione & " Costo: " & MyBase.PCosto.ToString() & " Tipologia: " & Me.Tipo
    End Function

End Class
