<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class launcher
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Presupuestos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(31, 114)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 45)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Albaranes"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(31, 253)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 45)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Configuración MySQL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(31, 183)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(144, 44)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Pedidos"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(199, 38)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(143, 45)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Facturación Manual"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(198, 253)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(144, 45)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Configuración Empresas"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(198, 114)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(143, 45)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Clientes"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(199, 183)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(143, 45)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Articulos"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(363, 38)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(142, 45)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "Pedidos Proveedores"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(363, 114)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(142, 45)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "Facturar Albaranes"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 386)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "launcher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shadow"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
End Class
