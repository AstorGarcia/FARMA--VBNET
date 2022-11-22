<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.ListaFacturas = New System.Windows.Forms.ListBox()
        Me.ListaRecetas = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.holausu = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListaFacturas
        '
        Me.ListaFacturas.FormattingEnabled = True
        Me.ListaFacturas.Location = New System.Drawing.Point(36, 90)
        Me.ListaFacturas.Name = "ListaFacturas"
        Me.ListaFacturas.Size = New System.Drawing.Size(154, 251)
        Me.ListaFacturas.TabIndex = 0
        '
        'ListaRecetas
        '
        Me.ListaRecetas.FormattingEnabled = True
        Me.ListaRecetas.Location = New System.Drawing.Point(225, 90)
        Me.ListaRecetas.Name = "ListaRecetas"
        Me.ListaRecetas.Size = New System.Drawing.Size(154, 251)
        Me.ListaRecetas.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(438, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Cargar Recetas Manualmente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(438, 246)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 35)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cargar Facturas Manualmente"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Hola,"
        '
        'holausu
        '
        Me.holausu.AutoSize = True
        Me.holausu.Location = New System.Drawing.Point(93, 29)
        Me.holausu.Name = "holausu"
        Me.holausu.Size = New System.Drawing.Size(39, 13)
        Me.holausu.TabIndex = 5
        Me.holausu.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Lista Facturas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(259, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Lista Recetas"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(562, 368)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.holausu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListaRecetas)
        Me.Controls.Add(Me.ListaFacturas)
        Me.Name = "Form2"
        Me.Text = "Listas FARMA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListaFacturas As ListBox
    Friend WithEvents ListaRecetas As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents holausu As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
