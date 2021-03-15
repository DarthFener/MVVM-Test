Public Interface IPersoneService
    Property Persone As IList(Of Persona)


End Interface
Public Class PersoneService
    Implements IPersoneService
    Private _persone As List(Of Persona) = Nothing
    Public Sub New()
        _persone = New List(Of Persona)
        Dim i(7) As Persona
        i(0) = New Persona
        i(0).Nome = "Mario"
        i(0).Cognome = "Rossi"
        _persone.Add(i(0))
        i(1) = New Persona
        i(1).Nome = "Giovanni"
        i(1).Cognome = "Bianchi"
        _persone.Add(i(1))
        i(2) = New Persona
        i(2).Nome = "Renato"
        i(2).Cognome = "Brambilla"
        _persone.Add(i(2))
        i(3) = New Persona
        i(3).Nome = "Carlo"
        i(3).Cognome = "Verdi"
        _persone.Add(i(3))
    End Sub
    Public Property Persone As IList(Of Persona) Implements IPersoneService.Persone
        Get
            Return _persone
        End Get
        Set(value As IList(Of Persona))

        End Set
    End Property
End Class
