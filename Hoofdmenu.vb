Public Class Hoofdmenu
    Private Sub Hoofdmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Test")
    End Sub

    'Effect: Deze functie switcht panels
    Sub switchPanel(panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    'Effect: Pakt de naam van het geselecteerd item en verstuurd deze naar de 'switchPanel' functie
    'MOET VEEL EFFICIENTER
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim Treeselect As Char = TreeView1.SelectedNode.Name

        If TreeView1.SelectedNode.Name = "NA1_Spanningsdeler" Then
            switchPanel(NA2_Spanningsdeler)
        End If
    End Sub

    'Effect: Na het klikken op de textbox zal een popup in het scherm komen
    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click
        MessageBox.Show("Gemaakt door Almer de Vries // NHL Stenden Elektrotechniek // V0.1 early Alpha")
    End Sub
End Class
