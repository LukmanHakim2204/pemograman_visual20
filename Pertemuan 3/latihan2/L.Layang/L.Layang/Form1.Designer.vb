<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtD1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtD2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSisiA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSisiB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSIsiC = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSisiD = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.txtLuas = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtKeliling = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(410, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LUAS DAN KELILING LAYANG-LAYANG"
        '
        'txtD1
        '
        Me.txtD1.Location = New System.Drawing.Point(179, 69)
        Me.txtD1.Name = "txtD1"
        Me.txtD1.Size = New System.Drawing.Size(100, 22)
        Me.txtD1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Diagonal 1"
        '
        'txtD2
        '
        Me.txtD2.Location = New System.Drawing.Point(179, 112)
        Me.txtD2.Name = "txtD2"
        Me.txtD2.Size = New System.Drawing.Size(100, 22)
        Me.txtD2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Dianogal 2"
        '
        'txtSisiA
        '
        Me.txtSisiA.Location = New System.Drawing.Point(179, 159)
        Me.txtSisiA.Name = "txtSisiA"
        Me.txtSisiA.Size = New System.Drawing.Size(100, 22)
        Me.txtSisiA.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sisi A"
        '
        'txtSisiB
        '
        Me.txtSisiB.Location = New System.Drawing.Point(406, 68)
        Me.txtSisiB.Name = "txtSisiB"
        Me.txtSisiB.Size = New System.Drawing.Size(100, 22)
        Me.txtSisiB.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(322, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Sisi B"
        '
        'txtSIsiC
        '
        Me.txtSIsiC.Location = New System.Drawing.Point(406, 112)
        Me.txtSIsiC.Name = "txtSIsiC"
        Me.txtSIsiC.Size = New System.Drawing.Size(100, 22)
        Me.txtSIsiC.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(322, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Sisi C"
        '
        'txtSisiD
        '
        Me.txtSisiD.Location = New System.Drawing.Point(406, 160)
        Me.txtSisiD.Name = "txtSisiD"
        Me.txtSisiD.Size = New System.Drawing.Size(100, 22)
        Me.txtSisiD.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(322, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Sisi D"
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(240, 203)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(126, 28)
        Me.btnHitung.TabIndex = 15
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'txtLuas
        '
        Me.txtLuas.Location = New System.Drawing.Point(179, 247)
        Me.txtLuas.Name = "txtLuas"
        Me.txtLuas.Size = New System.Drawing.Size(100, 22)
        Me.txtLuas.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(89, 250)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Luas"
        '
        'txtKeliling
        '
        Me.txtKeliling.Location = New System.Drawing.Point(406, 247)
        Me.txtKeliling.Name = "txtKeliling"
        Me.txtKeliling.Size = New System.Drawing.Size(100, 22)
        Me.txtKeliling.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(322, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Keliling"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(115, 295)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(380, 25)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Create By.Lukman Hakim(201511030)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GreenYellow
        Me.ClientSize = New System.Drawing.Size(617, 353)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtKeliling)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtLuas)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtSisiD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSIsiC)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSisiB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSisiA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtD2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtD1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtD1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtD2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSisiA As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSisiB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSIsiC As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSisiD As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtLuas As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtKeliling As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
