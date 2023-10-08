<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CajeroAutomatico
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CajeroAutomatico))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCanMonto = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.billete50 = New System.Windows.Forms.TextBox()
        Me.billete20 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.billete10 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.billete5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.billete1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.moneda1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.moneda5 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.moneda10 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.moneda25 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Location = New System.Drawing.Point(84, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(207, 81)
        Me.Panel1.TabIndex = 0
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Image = Global.DSNP073023DSNP016723DSNP0218233_Unidad3.My.Resources.Resources.icons8_initiate_money_transfer
        Me.RadioButton2.Location = New System.Drawing.Point(105, 4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.RadioButton2.Size = New System.Drawing.Size(96, 72)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Depositar"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Image = Global.DSNP073023DSNP016723DSNP0218233_Unidad3.My.Resources.Resources.icons8_request_money
        Me.RadioButton1.Location = New System.Drawing.Point(3, 4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.RadioButton1.Size = New System.Drawing.Size(96, 72)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Retirar"
        Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Bienvenido, seleccione operación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ingrese el monto:"
        '
        'txtCanMonto
        '
        Me.txtCanMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCanMonto.Location = New System.Drawing.Point(113, 138)
        Me.txtCanMonto.Name = "txtCanMonto"
        Me.txtCanMonto.Size = New System.Drawing.Size(141, 29)
        Me.txtCanMonto.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(113, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 38)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Ejecutar Operación"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statLabel1, Me.statLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 419)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(384, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statLabel1
        '
        Me.statLabel1.Name = "statLabel1"
        Me.statLabel1.Size = New System.Drawing.Size(108, 17)
        Me.statLabel1.Text = "Efectivo Disponible"
        '
        'statLabel2
        '
        Me.statLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statLabel2.ForeColor = System.Drawing.Color.Green
        Me.statLabel2.Name = "statLabel2"
        Me.statLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(249, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Denominaciones de Billetes Entregados"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "$50"
        '
        'billete50
        '
        Me.billete50.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.billete50.Location = New System.Drawing.Point(113, 238)
        Me.billete50.Name = "billete50"
        Me.billete50.ReadOnly = True
        Me.billete50.Size = New System.Drawing.Size(55, 22)
        Me.billete50.TabIndex = 9
        Me.billete50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'billete20
        '
        Me.billete20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.billete20.Location = New System.Drawing.Point(113, 273)
        Me.billete20.Name = "billete20"
        Me.billete20.ReadOnly = True
        Me.billete20.Size = New System.Drawing.Size(55, 22)
        Me.billete20.TabIndex = 11
        Me.billete20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(82, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "$20"
        '
        'billete10
        '
        Me.billete10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.billete10.Location = New System.Drawing.Point(113, 308)
        Me.billete10.Name = "billete10"
        Me.billete10.ReadOnly = True
        Me.billete10.Size = New System.Drawing.Size(55, 22)
        Me.billete10.TabIndex = 13
        Me.billete10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(82, 313)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "$10"
        '
        'billete5
        '
        Me.billete5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.billete5.Location = New System.Drawing.Point(113, 343)
        Me.billete5.Name = "billete5"
        Me.billete5.ReadOnly = True
        Me.billete5.Size = New System.Drawing.Size(55, 22)
        Me.billete5.TabIndex = 15
        Me.billete5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(82, 348)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "$5"
        '
        'billete1
        '
        Me.billete1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.billete1.Location = New System.Drawing.Point(113, 378)
        Me.billete1.Name = "billete1"
        Me.billete1.ReadOnly = True
        Me.billete1.Size = New System.Drawing.Size(55, 22)
        Me.billete1.TabIndex = 17
        Me.billete1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(82, 383)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "$1"
        '
        'moneda1
        '
        Me.moneda1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moneda1.Location = New System.Drawing.Point(236, 343)
        Me.moneda1.Name = "moneda1"
        Me.moneda1.ReadOnly = True
        Me.moneda1.Size = New System.Drawing.Size(55, 22)
        Me.moneda1.TabIndex = 25
        Me.moneda1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(195, 348)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "$0.01"
        '
        'moneda5
        '
        Me.moneda5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moneda5.Location = New System.Drawing.Point(236, 308)
        Me.moneda5.Name = "moneda5"
        Me.moneda5.ReadOnly = True
        Me.moneda5.Size = New System.Drawing.Size(55, 22)
        Me.moneda5.TabIndex = 23
        Me.moneda5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(195, 313)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "$0.05"
        '
        'moneda10
        '
        Me.moneda10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moneda10.Location = New System.Drawing.Point(236, 273)
        Me.moneda10.Name = "moneda10"
        Me.moneda10.ReadOnly = True
        Me.moneda10.Size = New System.Drawing.Size(55, 22)
        Me.moneda10.TabIndex = 21
        Me.moneda10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(195, 278)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "$0.10"
        '
        'moneda25
        '
        Me.moneda25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moneda25.Location = New System.Drawing.Point(236, 238)
        Me.moneda25.Name = "moneda25"
        Me.moneda25.ReadOnly = True
        Me.moneda25.Size = New System.Drawing.Size(55, 22)
        Me.moneda25.TabIndex = 19
        Me.moneda25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(195, 243)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "$0.25"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(198, 371)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 36)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CajeroAutomatico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(384, 441)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.moneda1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.moneda5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.moneda10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.moneda25)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.billete1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.billete5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.billete10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.billete20)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.billete50)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCanMonto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CajeroAutomatico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CajeroAutomatico"
        Me.Panel1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCanMonto As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents statLabel1 As ToolStripStatusLabel
    Friend WithEvents statLabel2 As ToolStripStatusLabel
    Public WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents billete50 As TextBox
    Friend WithEvents billete20 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents billete10 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents billete5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents billete1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents moneda1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents moneda5 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents moneda10 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents moneda25 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button2 As Button
End Class
