Public Class Form1

    Private Sub TbsecretariaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbsecretariaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TbsecretariaBindingSource.EndEdit()
        Me.TbsecretariaTableAdapter.Update(Me._Novo_a__Aplicativo_Microsoft_Office_AccessDataSet.tbsecretaria)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Novo_a__Aplicativo_Microsoft_Office_AccessDataSet.tbsecretaria' table. You can move, or remove it, as needed.
        Me.TbsecretariaTableAdapter.Fill(Me._Novo_a__Aplicativo_Microsoft_Office_AccessDataSet.tbsecretaria)

    End Sub
End Class
