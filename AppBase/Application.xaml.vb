Class Application

    ' Gli eventi a livello di applicazione, ad esempio Startup, Exit e DispatcherUnhandledException,
    ' possono essere gestiti in questo file.
    Protected Overrides Sub OnStartup(e As StartupEventArgs)
        MyBase.OnStartup(e)
        Me.MainWindow = New MainWindowView
        Me.MainWindow.DataContext = New ViewModels.MainWindowViewModel()
        Me.MainWindow.Show()
    End Sub
End Class
