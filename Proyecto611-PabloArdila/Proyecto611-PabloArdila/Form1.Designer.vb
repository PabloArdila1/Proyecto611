<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IniciarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoríaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarUsuaioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelInicio = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxTPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxTUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelInicio.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Label2.Location = New System.Drawing.Point(96, 118)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(128, 19)
        Label2.TabIndex = 2
        Label2.Text = "nombre de usuario:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciarToolStripMenuItem, Me.CrearToolStripMenuItem, Me.GenerarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.RegistrarToolStripMenuItem, Me.RealizarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IniciarToolStripMenuItem
        '
        Me.IniciarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SesionToolStripMenuItem, Me.CerrarToolStripMenuItem, Me.UsuarioToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.IniciarToolStripMenuItem.Name = "IniciarToolStripMenuItem"
        Me.IniciarToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.IniciarToolStripMenuItem.Text = "Iniciar"
        '
        'SesionToolStripMenuItem
        '
        Me.SesionToolStripMenuItem.Image = CType(resources.GetObject("SesionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SesionToolStripMenuItem.Name = "SesionToolStripMenuItem"
        Me.SesionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SesionToolStripMenuItem.Text = "Sesión"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Image = CType(resources.GetObject("CerrarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Image = CType(resources.GetObject("UsuarioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'CrearToolStripMenuItem
        '
        Me.CrearToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoríaToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.UsuarioToolStripMenuItem1})
        Me.CrearToolStripMenuItem.Enabled = False
        Me.CrearToolStripMenuItem.Name = "CrearToolStripMenuItem"
        Me.CrearToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.CrearToolStripMenuItem.Text = "Crear"
        '
        'CategoríaToolStripMenuItem
        '
        Me.CategoríaToolStripMenuItem.Name = "CategoríaToolStripMenuItem"
        Me.CategoríaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CategoríaToolStripMenuItem.Text = "Categoría"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'UsuarioToolStripMenuItem1
        '
        Me.UsuarioToolStripMenuItem1.Name = "UsuarioToolStripMenuItem1"
        Me.UsuarioToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.UsuarioToolStripMenuItem1.Text = "Usuario"
        '
        'GenerarToolStripMenuItem
        '
        Me.GenerarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturaToolStripMenuItem, Me.InformeToolStripMenuItem})
        Me.GenerarToolStripMenuItem.Enabled = False
        Me.GenerarToolStripMenuItem.Name = "GenerarToolStripMenuItem"
        Me.GenerarToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.GenerarToolStripMenuItem.Text = "Generar"
        '
        'FacturaToolStripMenuItem
        '
        Me.FacturaToolStripMenuItem.Name = "FacturaToolStripMenuItem"
        Me.FacturaToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.FacturaToolStripMenuItem.Text = "Factura"
        '
        'InformeToolStripMenuItem
        '
        Me.InformeToolStripMenuItem.Name = "InformeToolStripMenuItem"
        Me.InformeToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.InformeToolStripMenuItem.Text = "Informe"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductoToolStripMenuItem1, Me.EmpleadoToolStripMenuItem, Me.ModificarUsuaioToolStripMenuItem})
        Me.EliminarToolStripMenuItem.Enabled = False
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ProductoToolStripMenuItem1
        '
        Me.ProductoToolStripMenuItem1.Name = "ProductoToolStripMenuItem1"
        Me.ProductoToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.ProductoToolStripMenuItem1.Text = "Producto"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.EmpleadoToolStripMenuItem.Text = "Empleado"
        '
        'ModificarUsuaioToolStripMenuItem
        '
        Me.ModificarUsuaioToolStripMenuItem.Name = "ModificarUsuaioToolStripMenuItem"
        Me.ModificarUsuaioToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ModificarUsuaioToolStripMenuItem.Text = "Modificar Usuaio"
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentaToolStripMenuItem})
        Me.RegistrarToolStripMenuItem.Enabled = False
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.RegistrarToolStripMenuItem.Text = "Registrar"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.VentaToolStripMenuItem.Text = "Venta"
        '
        'RealizarToolStripMenuItem
        '
        Me.RealizarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompraToolStripMenuItem})
        Me.RealizarToolStripMenuItem.Enabled = False
        Me.RealizarToolStripMenuItem.Name = "RealizarToolStripMenuItem"
        Me.RealizarToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.RealizarToolStripMenuItem.Text = "realizar"
        '
        'CompraToolStripMenuItem
        '
        Me.CompraToolStripMenuItem.Name = "CompraToolStripMenuItem"
        Me.CompraToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.CompraToolStripMenuItem.Text = "compra"
        '
        'PanelInicio
        '
        Me.PanelInicio.Controls.Add(Me.Button2)
        Me.PanelInicio.Controls.Add(Me.Button1)
        Me.PanelInicio.Controls.Add(Me.TxTPass)
        Me.PanelInicio.Controls.Add(Me.Label3)
        Me.PanelInicio.Controls.Add(Me.TxTUsuario)
        Me.PanelInicio.Controls.Add(Label2)
        Me.PanelInicio.Controls.Add(Me.Label1)
        Me.PanelInicio.Controls.Add(Me.PictureBox1)
        Me.PanelInicio.Location = New System.Drawing.Point(118, 68)
        Me.PanelInicio.Name = "PanelInicio"
        Me.PanelInicio.Size = New System.Drawing.Size(562, 303)
        Me.PanelInicio.TabIndex = 1
        Me.PanelInicio.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(384, 219)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(103, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxTPass
        '
        Me.TxTPass.Location = New System.Drawing.Point(251, 161)
        Me.TxTPass.Name = "TxTPass"
        Me.TxTPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxTPass.Size = New System.Drawing.Size(208, 23)
        Me.TxTPass.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(96, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contraseña:"
        '
        'TxTUsuario
        '
        Me.TxTUsuario.Location = New System.Drawing.Point(251, 118)
        Me.TxTUsuario.Name = "TxTUsuario"
        Me.TxTUsuario.Size = New System.Drawing.Size(208, 23)
        Me.TxTUsuario.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(158, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Datos de Ingreso al sistema"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 110)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelInicio)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelInicio.ResumeLayout(False)
        Me.PanelInicio.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IniciarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoríaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GenerarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarUsuaioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelInicio As Panel
    Friend WithEvents TxTPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxTUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents RealizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompraToolStripMenuItem As ToolStripMenuItem
End Class
