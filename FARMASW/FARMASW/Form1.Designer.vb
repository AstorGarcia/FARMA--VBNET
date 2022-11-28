<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.register = New System.Windows.Forms.Label()
        Me.usu = New System.Windows.Forms.TextBox()
        Me.contra = New System.Windows.Forms.TextBox()
        Me.usuariolog = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Ingresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'register
        '
        Me.register.AutoSize = True
        Me.register.Location = New System.Drawing.Point(151, 120)
        Me.register.Name = "register"
        Me.register.Size = New System.Drawing.Size(60, 13)
        Me.register.TabIndex = 0
        Me.register.Text = "Registrarse"
        '
        'usu
        '
        Me.usu.Location = New System.Drawing.Point(118, 153)
        Me.usu.Name = "usu"
        Me.usu.Size = New System.Drawing.Size(160, 20)
        Me.usu.TabIndex = 1
        '
        'contra
        '
        Me.contra.Location = New System.Drawing.Point(118, 199)
        Me.contra.Name = "contra"
        Me.contra.Size = New System.Drawing.Size(160, 20)
        Me.contra.TabIndex = 2
        Me.contra.UseSystemPasswordChar = True
        '
        'usuariolog
        '
        Me.usuariolog.AutoSize = True
        Me.usuariolog.Location = New System.Drawing.Point(44, 156)
        Me.usuariolog.Name = "usuariolog"
        Me.usuariolog.Size = New System.Drawing.Size(46, 13)
        Me.usuariolog.TabIndex = 3
        Me.usuariolog.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contraseña:"
        '
        'Ingresar
        '
        Me.Ingresar.Location = New System.Drawing.Point(145, 232)
        Me.Ingresar.Name = "Ingresar"
        Me.Ingresar.Size = New System.Drawing.Size(85, 23)
        Me.Ingresar.TabIndex = 5
        Me.Ingresar.Text = "Ingresar"
        Me.Ingresar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, -50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(356, 167)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(371, 267)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Ingresar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.usuariolog)
        Me.Controls.Add(Me.contra)
        Me.Controls.Add(Me.usu)
        Me.Controls.Add(Me.register)
        Me.Name = "Form1"
        Me.Text = "FARMA"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents register As Label
    Friend WithEvents usu As TextBox
    Friend WithEvents contra As TextBox
    Friend WithEvents usuariolog As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Ingresar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
