<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculoImpuestos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalculoImpuestos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtActivo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtImpuesto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alcaldia Municipal Gerardo Barrios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Unidad de Catastro Empresas"
        '
        'txtActivo
        '
        Me.txtActivo.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActivo.Location = New System.Drawing.Point(102, 93)
        Me.txtActivo.MaxLength = 12
        Me.txtActivo.Name = "txtActivo"
        Me.txtActivo.Size = New System.Drawing.Size(158, 35)
        Me.txtActivo.TabIndex = 2
        Me.txtActivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(115, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Activo según balance"
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Image = Global.DSNP073023DSNP016723DSNP0218233_Unidad3.My.Resources.Resources.calculate
        Me.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCalcular.Location = New System.Drawing.Point(102, 134)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Padding = New System.Windows.Forms.Padding(0, 8, 0, 8)
        Me.btnCalcular.Size = New System.Drawing.Size(158, 92)
        Me.btnCalcular.TabIndex = 4
        Me.btnCalcular.Text = "Calcular Impuesto"
        Me.btnCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(99, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Impuesto Mensual Aplicado:"
        '
        'txtImpuesto
        '
        Me.txtImpuesto.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpuesto.Location = New System.Drawing.Point(102, 278)
        Me.txtImpuesto.MaxLength = 12
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.ReadOnly = True
        Me.txtImpuesto.Size = New System.Drawing.Size(158, 35)
        Me.txtImpuesto.TabIndex = 5
        Me.txtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CalculoImpuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(380, 437)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtImpuesto)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtActivo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CalculoImpuestos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impuestos sobre Actividad Económica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtActivo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtImpuesto As TextBox
End Class
