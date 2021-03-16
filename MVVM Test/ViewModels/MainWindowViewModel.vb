Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Input

Public Class RelayCommand
    Implements ICommand
    Private executeMethod As Action(Of Object)
    Private canExecuteMethod As Predicate(Of Object)
    Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged

    Public Sub Execute(parameter As Object) Implements ICommand.Execute
        executeMethod.Invoke(parameter)
    End Sub

    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        If canExecuteMethod = Nothing Then
            Return True
        Else
            Return canExecuteMethod.Invoke(parameter)
        End If
    End Function
    Public Sub New(ByVal Execute As Action(Of Object), ByVal CanExecute As Predicate(Of Object))
        executeMethod = Execute
        canExecuteMethod = CanExecute
    End Sub
    Public Sub New(ByVal Execute As Action(Of Object))
        executeMethod = Execute
        canExecuteMethod = Nothing
    End Sub
    Public Sub RaiseCanExecuteChanged()
        RaiseEvent CanExecuteChanged(Me, EventArgs.Empty)

    End Sub
End Class
Public MustInherit Class BaseViewModel
    Implements INotifyPropertyChanged
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Sub NotifyPropertyChanged(<CallerMemberName> Optional propertyName As String = "")
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))

    End Sub
End Class

Public Class MainWindowViewModel
    Inherits BaseViewModel
    Private _Personeservice As IPersoneService
    Private _txtsaluto
    Public Property SalutaCommand As RelayCommand
    Private _personaselezionata As Persona



    Public Sub New(personeService As IPersoneService)
        _Personeservice = personeService
        'SalutaCommand = New RelayCommand(salutaMethod(Nothing), salutaCanExec(Nothing))
        'Dim x As Action = salutaCanExec(Nothing)
        SalutaCommand = New RelayCommand(AddressOf Saluta, AddressOf salutaCanExec)
    End Sub

    Private Function salutaCanExec(obj As Object) As Boolean
        Return PersonaSelezionata IsNot Nothing
    End Function

    Private Sub salutaMethod(obj As Object)
        Saluta()
    End Sub

    Public Property Persone As IList(Of Persona)
        Get
            Return _Personeservice.Persone
        End Get
        Set(value As IList(Of Persona))

        End Set
    End Property
    Public Property PersonaSelezionata As Persona
        Get
            Return _personaselezionata
        End Get
        Set(value As Persona)

            NotifyPropertyChanged()
            SalutaCommand.RaiseCanExecuteChanged()

        End Set
    End Property
    Public Property TextSaluto As String
        Get
            Return _txtsaluto
        End Get
        Set(value As String)
            _txtsaluto = value
            '  RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("TextSaluto"))
            NotifyPropertyChanged()
        End Set
    End Property

    Public Sub Saluta()
        If PersonaSelezionata IsNot Nothing Then
            TextSaluto = $"Ciao {PersonaSelezionata.Nome} {PersonaSelezionata.Cognome}"
        End If
    End Sub
End Class
