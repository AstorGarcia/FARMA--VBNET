﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Id_factura = New System.Windows.Forms.TextBox()
        Me.Ven_factura = New System.Windows.Forms.TextBox()
        Me.Dom_factura = New System.Windows.Forms.TextBox()
        Me.Imp_factura = New System.Windows.Forms.TextBox()
        Me.Cant_factura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(193, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Atras"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(193, 71)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Crear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Id_factura
        '
        Me.Id_factura.Location = New System.Drawing.Point(29, 30)
        Me.Id_factura.Name = "Id_factura"
        Me.Id_factura.Size = New System.Drawing.Size(100, 20)
        Me.Id_factura.TabIndex = 2
        '
        'Ven_factura
        '
        Me.Ven_factura.Location = New System.Drawing.Point(29, 193)
        Me.Ven_factura.Name = "Ven_factura"
        Me.Ven_factura.Size = New System.Drawing.Size(100, 20)
        Me.Ven_factura.TabIndex = 3
        '
        'Dom_factura
        '
        Me.Dom_factura.Location = New System.Drawing.Point(29, 154)
        Me.Dom_factura.Name = "Dom_factura"
        Me.Dom_factura.Size = New System.Drawing.Size(100, 20)
        Me.Dom_factura.TabIndex = 4
        '
        'Imp_factura
        '
        Me.Imp_factura.Location = New System.Drawing.Point(29, 110)
        Me.Imp_factura.Name = "Imp_factura"
        Me.Imp_factura.Size = New System.Drawing.Size(100, 20)
        Me.Imp_factura.TabIndex = 5
        '
        'Cant_factura
        '
        Me.Cant_factura.Location = New System.Drawing.Point(29, 73)
        Me.Cant_factura.Name = "Cant_factura"
        Me.Cant_factura.Size = New System.Drawing.Size(100, 20)
        Me.Cant_factura.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Identificacion Factura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cantidad Factura"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Importe Factura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Vencimiento Factura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Domicilio Factura"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(291, 225)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cant_factura)
        Me.Controls.Add(Me.Imp_factura)
        Me.Controls.Add(Me.Dom_factura)
        Me.Controls.Add(Me.Ven_factura)
        Me.Controls.Add(Me.Id_factura)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form4"
        Me.Text = "Cargar Facturas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Id_factura As TextBox
    Friend WithEvents Ven_factura As TextBox
    Friend WithEvents Dom_factura As TextBox
    Friend WithEvents Imp_factura As TextBox
    Friend WithEvents Cant_factura As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
End Class
