﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtJari = New System.Windows.Forms.TextBox()
        Me.txtTi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVol = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLuasP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VOLUME DAN LUAS PERMUKAAN TABUNG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(110, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jari-Jari"
        '
        'txtJari
        '
        Me.txtJari.Location = New System.Drawing.Point(306, 67)
        Me.txtJari.Name = "txtJari"
        Me.txtJari.Size = New System.Drawing.Size(100, 22)
        Me.txtJari.TabIndex = 2
        '
        'txtTi
        '
        Me.txtTi.Location = New System.Drawing.Point(306, 109)
        Me.txtTi.Name = "txtTi"
        Me.txtTi.Size = New System.Drawing.Size(100, 22)
        Me.txtTi.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(110, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tinggi"
        '
        'txtVol
        '
        Me.txtVol.Location = New System.Drawing.Point(306, 202)
        Me.txtVol.Name = "txtVol"
        Me.txtVol.Size = New System.Drawing.Size(100, 22)
        Me.txtVol.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(110, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Volume"
        '
        'txtLuasP
        '
        Me.txtLuasP.Location = New System.Drawing.Point(306, 249)
        Me.txtLuasP.Name = "txtLuasP"
        Me.txtLuasP.Size = New System.Drawing.Size(100, 22)
        Me.txtLuasP.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(110, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Luas Permukaan"
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(317, 151)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(75, 28)
        Me.btnHitung.TabIndex = 9
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(92, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(338, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Create By. Lukman Hakim (201511030)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GreenYellow
        Me.ClientSize = New System.Drawing.Size(565, 339)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtLuasP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtVol)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtJari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtJari As TextBox
    Friend WithEvents txtTi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtVol As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLuasP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents Label6 As Label
End Class
