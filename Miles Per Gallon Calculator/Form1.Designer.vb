<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMPG
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCarGas = New System.Windows.Forms.Label()
        Me.lblCarMiles = New System.Windows.Forms.Label()
        Me.lblMilesPerGallon = New System.Windows.Forms.Label()
        Me.txtCarGas = New System.Windows.Forms.TextBox()
        Me.txtCarMiles = New System.Windows.Forms.TextBox()
        Me.lblMPG = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(61, 246)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 34)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate MPG"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(233, 246)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 34)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(401, 246)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 34)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCarGas
        '
        Me.lblCarGas.Location = New System.Drawing.Point(103, 26)
        Me.lblCarGas.Name = "lblCarGas"
        Me.lblCarGas.Size = New System.Drawing.Size(109, 28)
        Me.lblCarGas.TabIndex = 3
        Me.lblCarGas.Text = "Gallons of gas the car can hold:"
        '
        'lblCarMiles
        '
        Me.lblCarMiles.Location = New System.Drawing.Point(103, 79)
        Me.lblCarMiles.Name = "lblCarMiles"
        Me.lblCarMiles.Size = New System.Drawing.Size(109, 41)
        Me.lblCarMiles.TabIndex = 4
        Me.lblCarMiles.Text = "Number of miles it can be driven on a full tank:"
        '
        'lblMilesPerGallon
        '
        Me.lblMilesPerGallon.AutoSize = True
        Me.lblMilesPerGallon.Location = New System.Drawing.Point(103, 150)
        Me.lblMilesPerGallon.Name = "lblMilesPerGallon"
        Me.lblMilesPerGallon.Size = New System.Drawing.Size(83, 13)
        Me.lblMilesPerGallon.TabIndex = 5
        Me.lblMilesPerGallon.Text = "Miles per gallon:"
        '
        'txtCarGas
        '
        Me.txtCarGas.Location = New System.Drawing.Point(292, 26)
        Me.txtCarGas.Name = "txtCarGas"
        Me.txtCarGas.Size = New System.Drawing.Size(100, 20)
        Me.txtCarGas.TabIndex = 6
        '
        'txtCarMiles
        '
        Me.txtCarMiles.Location = New System.Drawing.Point(292, 79)
        Me.txtCarMiles.Name = "txtCarMiles"
        Me.txtCarMiles.Size = New System.Drawing.Size(100, 20)
        Me.txtCarMiles.TabIndex = 7
        '
        'lblMPG
        '
        Me.lblMPG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMPG.Location = New System.Drawing.Point(292, 149)
        Me.lblMPG.Name = "lblMPG"
        Me.lblMPG.Size = New System.Drawing.Size(100, 23)
        Me.lblMPG.TabIndex = 8
        '
        'frmMPG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 317)
        Me.Controls.Add(Me.lblMPG)
        Me.Controls.Add(Me.txtCarMiles)
        Me.Controls.Add(Me.txtCarGas)
        Me.Controls.Add(Me.lblMilesPerGallon)
        Me.Controls.Add(Me.lblCarMiles)
        Me.Controls.Add(Me.lblCarGas)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmMPG"
        Me.Text = "Miles Per Gallon Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCarGas As Label
    Friend WithEvents lblCarMiles As Label
    Friend WithEvents lblMilesPerGallon As Label
    Friend WithEvents txtCarGas As TextBox
    Friend WithEvents txtCarMiles As TextBox
    Friend WithEvents lblMPG As Label
End Class
