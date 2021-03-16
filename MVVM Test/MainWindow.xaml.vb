Class MainWindow

    Public Sub New(ByVal vm As MainWindowViewModel)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        DataContext = vm

    End Sub
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

    End Sub

End Class
