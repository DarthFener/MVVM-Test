Class MainWindow
    Private personeService As IPersoneService = Nothing
    Public Sub New(ByVal ps As IPersoneService)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        personeService = ps
        cmbPersone.ItemsSource = personeService.Persone
        cmbPersone.DisplayMemberPath = "Cognome"
    End Sub
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        salutaMi()
    End Sub

    Private Sub salutaMi()

        Dim persona As Persona = DirectCast(cmbPersone.SelectedItem, Persona)
            txtSaluto.Text = $"Ciao {persona.Nome} {persona.Cognome} "


    End Sub
End Class
