<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim ServicoLabel As System.Windows.Forms.Label
        Dim SolitacaoLabel As System.Windows.Forms.Label
        Me.TbsecretariaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.TbsecretariaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.CodigoTextBox = New System.Windows.Forms.TextBox
        Me.ServicoTextBox = New System.Windows.Forms.TextBox
        Me.SolitacaoDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ServicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SolitacaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TbsecretariaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Novo_a__Aplicativo_Microsoft_Office_AccessDataSet = New sistemaPIOXII.vb.dbSistemaPioXII
        Me.TbsecretariaTableAdapter = New sistemaPIOXII.vb._Novo_a__Aplicativo_Microsoft_Office_AccessDataSetTableAdapters.tbsecretariaTableAdapter
        CodigoLabel = New System.Windows.Forms.Label
        ServicoLabel = New System.Windows.Forms.Label
        SolitacaoLabel = New System.Windows.Forms.Label
        CType(Me.TbsecretariaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbsecretariaBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbsecretariaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Novo_a__Aplicativo_Microsoft_Office_AccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbsecretariaBindingNavigator
        '
        Me.TbsecretariaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TbsecretariaBindingNavigator.BindingSource = Me.TbsecretariaBindingSource
        Me.TbsecretariaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TbsecretariaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TbsecretariaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TbsecretariaBindingNavigatorSaveItem})
        Me.TbsecretariaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TbsecretariaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TbsecretariaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TbsecretariaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TbsecretariaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TbsecretariaBindingNavigator.Name = "TbsecretariaBindingNavigator"
        Me.TbsecretariaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TbsecretariaBindingNavigator.Size = New System.Drawing.Size(465, 25)
        Me.TbsecretariaBindingNavigator.TabIndex = 0
        Me.TbsecretariaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TbsecretariaBindingNavigatorSaveItem
        '
        Me.TbsecretariaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TbsecretariaBindingNavigatorSaveItem.Image = CType(resources.GetObject("TbsecretariaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TbsecretariaBindingNavigatorSaveItem.Name = "TbsecretariaBindingNavigatorSaveItem"
        Me.TbsecretariaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TbsecretariaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(8, 42)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(42, 13)
        CodigoLabel.TabIndex = 1
        CodigoLabel.Text = "codigo:"
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbsecretariaBindingSource, "codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(56, 39)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoTextBox.TabIndex = 2
        '
        'ServicoLabel
        '
        ServicoLabel.AutoSize = True
        ServicoLabel.Location = New System.Drawing.Point(6, 68)
        ServicoLabel.Name = "ServicoLabel"
        ServicoLabel.Size = New System.Drawing.Size(44, 13)
        ServicoLabel.TabIndex = 3
        ServicoLabel.Text = "servico:"
        '
        'ServicoTextBox
        '
        Me.ServicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbsecretariaBindingSource, "servico", True))
        Me.ServicoTextBox.Location = New System.Drawing.Point(56, 65)
        Me.ServicoTextBox.Name = "ServicoTextBox"
        Me.ServicoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ServicoTextBox.TabIndex = 4
        '
        'SolitacaoLabel
        '
        SolitacaoLabel.AutoSize = True
        SolitacaoLabel.Location = New System.Drawing.Point(183, 39)
        SolitacaoLabel.Name = "SolitacaoLabel"
        SolitacaoLabel.Size = New System.Drawing.Size(52, 13)
        SolitacaoLabel.TabIndex = 5
        SolitacaoLabel.Text = "solitacao:"
        '
        'SolitacaoDateTimePicker
        '
        Me.SolitacaoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TbsecretariaBindingSource, "solitacao", True))
        Me.SolitacaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.SolitacaoDateTimePicker.Location = New System.Drawing.Point(241, 35)
        Me.SolitacaoDateTimePicker.Name = "SolitacaoDateTimePicker"
        Me.SolitacaoDateTimePicker.Size = New System.Drawing.Size(105, 20)
        Me.SolitacaoDateTimePicker.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.ServicoDataGridViewTextBoxColumn, Me.SolitacaoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbsecretariaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(33, 115)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(385, 200)
        Me.DataGridView1.TabIndex = 7
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        '
        'ServicoDataGridViewTextBoxColumn
        '
        Me.ServicoDataGridViewTextBoxColumn.DataPropertyName = "servico"
        Me.ServicoDataGridViewTextBoxColumn.HeaderText = "servico"
        Me.ServicoDataGridViewTextBoxColumn.Name = "ServicoDataGridViewTextBoxColumn"
        '
        'SolitacaoDataGridViewTextBoxColumn
        '
        Me.SolitacaoDataGridViewTextBoxColumn.DataPropertyName = "solitacao"
        Me.SolitacaoDataGridViewTextBoxColumn.HeaderText = "solitacao"
        Me.SolitacaoDataGridViewTextBoxColumn.Name = "SolitacaoDataGridViewTextBoxColumn"
        '
        'TbsecretariaBindingSource
        '
        Me.TbsecretariaBindingSource.DataMember = "tbsecretaria"
        Me.TbsecretariaBindingSource.DataSource = Me._Novo_a__Aplicativo_Microsoft_Office_AccessDataSet
        '
        '_Novo_a__Aplicativo_Microsoft_Office_AccessDataSet
        '
        Me._Novo_a__Aplicativo_Microsoft_Office_AccessDataSet.DataSetName = "_Novo_a__Aplicativo_Microsoft_Office_AccessDataSet"
        Me._Novo_a__Aplicativo_Microsoft_Office_AccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbsecretariaTableAdapter
        '
        Me.TbsecretariaTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 356)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(SolitacaoLabel)
        Me.Controls.Add(Me.SolitacaoDateTimePicker)
        Me.Controls.Add(ServicoLabel)
        Me.Controls.Add(Me.ServicoTextBox)
        Me.Controls.Add(CodigoLabel)
        Me.Controls.Add(Me.CodigoTextBox)
        Me.Controls.Add(Me.TbsecretariaBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TbsecretariaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbsecretariaBindingNavigator.ResumeLayout(False)
        Me.TbsecretariaBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbsecretariaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Novo_a__Aplicativo_Microsoft_Office_AccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _Novo_a__Aplicativo_Microsoft_Office_AccessDataSet As sistemaPIOXII.vb.dbSistemaPioXII
    Friend WithEvents TbsecretariaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbsecretariaTableAdapter As sistemaPIOXII.vb._Novo_a__Aplicativo_Microsoft_Office_AccessDataSetTableAdapters.tbsecretariaTableAdapter
    Friend WithEvents TbsecretariaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TbsecretariaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ServicoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SolitacaoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SolitacaoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
