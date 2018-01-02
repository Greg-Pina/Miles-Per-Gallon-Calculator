'********************************
'Greg Pina
'.Net Programming 101-401
'9/23/17
'*********************************

Option Strict On
Public Class FrmMPG

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler clears the numbers.
        txtCarGas.Clear()
        txtCarMiles.Clear()
        lblMPG.Text = String.Empty

        ' Reset the focus
        txtCarGas.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the application
        Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'This creates our variables
        Dim dblCarGas As Double
        Dim dblCarMiles As Double
        Dim dblMPG As Double
        txtCarGas.BackColor = Color.White
        txtCarMiles.BackColor = Color.White


        Try
            'validates if input field data is numeric
            If IsNumeric(txtCarGas.Text) Then
                dblCarGas = CDbl(txtCarGas.Text)
            Else
                MessageBox.Show("Gallons must be numeric")
                txtCarGas.Focus()
                txtCarGas.BackColor = Color.Yellow
                Exit Sub
            End If

            If IsNumeric(txtCarMiles.Text) Then
                dblCarMiles = CDbl(txtCarMiles.Text)
            Else
                MessageBox.Show("Miles must be numeric")
                txtCarMiles.Focus()
                txtCarMiles.BackColor = Color.Yellow
                Exit Sub
            End If


            ' Gets the miles per gallon.
            dblCarGas = CInt(txtCarGas.Text)
            dblCarMiles = CInt(txtCarMiles.Text)

            ' Calculates the miles per gallon.
            dblMPG = dblCarMiles / dblCarGas

            ' Displays the miles per gallon.
            lblMPG.Text = dblMPG.ToString("n")


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
