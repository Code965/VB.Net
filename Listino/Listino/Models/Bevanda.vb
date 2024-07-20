' Dichiarazione della classe astratta
Public MustInherit Class Bevanda


    Private Shared _idCounter As Integer = 0
    Dim codiceBibita As Integer = 0
    Private descrizione As String
    Private costo As Double

    ' Costruttore della classe astratta
    Public Sub New(descrizione As String, costo As Double)
        Me.codiceBibita = System.Threading.Interlocked.Increment(_idCounter)
        Me.descrizione = descrizione
        Me.costo = costo
    End Sub

    ' Metodo astratto che deve essere implementato nelle classi derivate
    Public Overridable Function ToString() As String

        Return "Codice" & Me.codiceBibita & "Descrizione " & Me.codiceBibita & "Costo " & Me.costo

    End Function

    ' Proprietà per codiceBibita
    Public Property PCodiceBibita As Integer
        Get
            Return Me.codiceBibita
        End Get
        Set(value As Integer)
            Me.codiceBibita = value
        End Set
    End Property

    ' Proprietà per descrizione
    Public Property PDescrizione As String
        Get
            Return Me.descrizione
        End Get
        Set(value As String)
            Me.descrizione = value
        End Set
    End Property

    ' Proprietà per costo
    Public Property PCosto As Double
        Get
            Return Me.costo
        End Get
        Set(value As Double)
            Me.costo = value
        End Set
    End Property

End Class
