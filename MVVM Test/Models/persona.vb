Public Class Persona
    Public Property Nome As String
    Public Property Cognome As String
    Public Shared Operator =(ByVal p1 As Persona, ByVal p2 As Persona) As Boolean
        If p1 = Nothing Or p2 = Nothing Then
            Return False
        End If
        If p1.Cognome = p2.Cognome And p1.Nome = p2.Nome Then
            Return True
        Else
            Return False
        End If

    End Operator
    Public Shared Operator <>(ByVal p1 As Persona, ByVal p2 As Persona) As Boolean
        If p1.Cognome <> p2.Cognome Or p1.Nome <> p2.Nome Then
            Return True
        Else
            Return False
        End If

    End Operator
End Class
