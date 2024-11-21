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
        Me.Lbljudul = New System.Windows.Forms.Label()
        Me.Txtnama = New System.Windows.Forms.TextBox()
        Me.Btnstart = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbljudul
        '
        Me.Lbljudul.AutoSize = True
        Me.Lbljudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbljudul.Location = New System.Drawing.Point(237, 86)
        Me.Lbljudul.Name = "Lbljudul"
        Me.Lbljudul.Size = New System.Drawing.Size(300, 37)
        Me.Lbljudul.TabIndex = 0
        Me.Lbljudul.Text = "MASUKKAN NAMA"
        '
        'Txtnama
        '
        Me.Txtnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnama.Location = New System.Drawing.Point(267, 198)
        Me.Txtnama.Name = "Txtnama"
        Me.Txtnama.Size = New System.Drawing.Size(244, 35)
        Me.Txtnama.TabIndex = 1
        Me.Txtnama.Text = "Masukkan Nama"
        '
        'Btnstart
        '
        Me.Btnstart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnstart.Location = New System.Drawing.Point(318, 295)
        Me.Btnstart.Name = "Btnstart"
        Me.Btnstart.Size = New System.Drawing.Size(146, 64)
        Me.Btnstart.TabIndex = 2
        Me.Btnstart.Text = "Start"
        Me.Btnstart.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(649, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 98)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Tekan Untuk Form 2"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btnstart)
        Me.Controls.Add(Me.Txtnama)
        Me.Controls.Add(Me.Lbljudul)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbljudul As Label
    Friend WithEvents Txtnama As TextBox
    Friend WithEvents Btnstart As Button
    Friend WithEvents Button1 As Button
End Class
