Public Class frmPrincipalEscola
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetConnection()
    End Sub

    Private Sub SolicitaçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitaçõesToolStripMenuItem.Click
        Dim frmAbreSolicitacao = New frmSolicitacao()
        frmAbreSolicitacao.MdiParent = Me
        frmAbreSolicitacao.Show()
    End Sub
End Class