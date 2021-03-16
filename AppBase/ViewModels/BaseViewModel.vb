Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Public MustInherit Class BaseViewModel
    Implements INotifyPropertyChanged
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Sub NotifyPropertyChanged(<CallerMemberName> Optional propertyName As String = "")
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))

    End Sub
    Protected ReadOnly Property IsDesignMode
        Get
            Return DesignerProperties.GetIsInDesignMode(New System.Windows.DependencyObject())
        End Get

    End Property
End Class
