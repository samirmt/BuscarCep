Public Class frmBuscarCep
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtCep.Text <> "" Then
            Call BuscarCep()
        End If
    End Sub

    Private Sub BuscarCep()
        Using WS = New WSCorreios.AtendeClienteClient()
            Try
                Dim resultado = WS.consultaCEP(txtCep.Text)

                txtEndereco.Text = resultado.[end]
                txtComplemento.Text = resultado.complemento
                txtComplemento2.Text = resultado.complemento2
                txtCidade.Text = resultado.cidade
                txtBairro.Text = resultado.bairro
                txtEstado.Text = resultado.uf
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub


End Class
