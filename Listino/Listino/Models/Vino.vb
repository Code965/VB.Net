Public Class Vino
    Inherits Bevanda

    Private anno As String

    ' Costruttore della classe Birra
    Public Sub New(descrizione As String, costo As Double, anno As String)

        MyBase.New(descrizione, costo)
        Me.anno = anno
        
    End Sub

    ' Proprietà per la anno
    Public Property AnnoVino As String
        Get
            Return Me.anno
        End Get
        Set(value As String)
            Me.anno = value
        End Set
    End Property

    ' Implementazione del metodo ToString
    Public  Overrides Function ToString() As String
        Return "Codice: " & MyBase.PCodiceBibita & " Descrizione: " & MyBase.PDescrizione & " Costo: " & MyBase.PCosto & " anno: " & Me.AnnoVino
    End Function

End Class
