Imports System.ComponentModel
Public Class MainWindowViewModel
    Implements INotifyPropertyChanged
    Private _Personeservice As IPersoneService
    Private _txtsaluto
    Public Sub New(personeService As IPersoneService)
        _Personeservice = personeService

    End Sub
    Public Property Persone As IList(Of Persona)
        Get
            Return _Personeservice.Persone
        End Get
        Set(value As IList(Of Persona))

        End Set
    End Property
    Public Property PersonaSelezionata As Persona
    Public Property TextSaluto As String
        Get
            Return _txtsaluto
        End Get
        Set(value As String)
            _txtsaluto = value
            '  RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("TextSaluto"))
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(TextSaluto)))
        End Set
    End Property
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Sub Saluta()
        If PersonaSelezionata IsNot Nothing Then
            TextSaluto = $"Ciao {PersonaSelezionata.Nome} {PersonaSelezionata.Cognome}"
        End If
    End Sub
End Class
