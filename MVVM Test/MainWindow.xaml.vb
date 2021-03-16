Class MainWindow

    Public Sub New(ByVal vm As MainWindowViewModel)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        DataContext = vm

    End Sub
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        salutaMi()
    End Sub

    Private Sub salutaMi()

        '   Dim persona As Persona = DirectCast(cmbPersone.SelectedItem, Persona)
        ' txtSaluto.Text = $"Ciao {persona.Nome} {persona.Cognome} "
        Dim x = DirectCast(DataContext, MainWindowViewModel)
        x.Saluta()

    End Sub
End Class
