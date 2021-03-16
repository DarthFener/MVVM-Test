﻿Class Application

    ' Gli eventi a livello di applicazione, ad esempio Startup, Exit e DispatcherUnhandledException,
    ' possono essere gestiti in questo file.
    Protected Overrides Sub OnStartup(e As StartupEventArgs)
        MyBase.OnStartup(e)
        '  Dim MyWindow As MainWindow = New MainWindow(New PersoneService())
        Dim personeService As PersoneService = New PersoneService()
        Dim mainWindowViewModel As MainWindowViewModel = New MainWindowViewModel(personeService)
        Dim myWindow As MainWindow = New MainWindow(mainWindowViewModel)
        myWindow.Show()
    End Sub

End Class
