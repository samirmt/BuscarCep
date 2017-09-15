<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarCep
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCep = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtComplemento2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CEP:"
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(15, 25)
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(100, 20)
        Me.txtCep.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(134, 25)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(102, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(15, 83)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(221, 20)
        Me.txtEndereco.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Endereço:"
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(12, 122)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(221, 20)
        Me.txtComplemento.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Complemento:"
        '
        'txtComplemento2
        '
        Me.txtComplemento2.Location = New System.Drawing.Point(12, 162)
        Me.txtComplemento2.Name = "txtComplemento2"
        Me.txtComplemento2.Size = New System.Drawing.Size(221, 20)
        Me.txtComplemento2.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Complemento2"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(12, 205)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(221, 20)
        Me.txtBairro.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Bairro:"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(12, 244)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(139, 20)
        Me.txtCidade.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Cidade:"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(157, 244)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(79, 20)
        Me.txtEstado.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(154, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Estado:"
        '
        'frmBuscarCep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 277)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtComplemento2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtComplemento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtCep)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmBuscarCep"
        Me.Text = "Buscar CEP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCep As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtComplemento As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtComplemento2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label8 As Label
End Class
