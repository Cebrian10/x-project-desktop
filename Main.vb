﻿Imports System.Windows.Documents
Imports FontAwesome.Sharp
Public Class Main
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.Bounds = Screen.PrimaryScreen.Bounds

        ActivateButton(btnHome, RGBColors.Purple, "Home")

        Dim homeForm As New Home()
        homeForm.TopLevel = False
        homeForm.FormBorderStyle = FormBorderStyle.None
        homeForm.Dock = DockStyle.Fill
        PanelContent.Controls.Clear()
        PanelContent.Controls.Add(homeForm)
        homeForm.Show()



    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)
        Me.BackColor = Color.Black ' Establece el color de fondo del formulario a negro
        Me.IsMdiContainer = True
    End Sub

    'Methods'
    Private Sub ActivateButton(senderBtn As Object, customColor As Color, formTitle As String)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(43, 52, 65)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon'
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
            lblFormTitle.Text = formTitle
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(22, 29, 33)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ActivateButton(sender, RGBColors.Purple, "Home")

        Dim homeForm As New Home()
        homeForm.TopLevel = False
        homeForm.FormBorderStyle = FormBorderStyle.None
        homeForm.Dock = DockStyle.Fill
        PanelContent.Controls.Clear()
        PanelContent.Controls.Add(homeForm)
        homeForm.Show()

    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        ActivateButton(sender, RGBColors.Pink, "Inventario")


        Dim inventoryForm As New Inventario()

        inventoryForm.TopLevel = False
        inventoryForm.FormBorderStyle = FormBorderStyle.None
        inventoryForm.Dock = DockStyle.Fill
        PanelContent.Controls.Clear()
        PanelContent.Controls.Add(inventoryForm)

        inventoryForm.Show()
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        ActivateButton(sender, RGBColors.PalePink, "Ventas")

        Dim ventasForm As New Ventas()


        ventasForm.TopLevel = False
        ventasForm.FormBorderStyle = FormBorderStyle.None
        ventasForm.Dock = DockStyle.Fill
        PanelContent.Controls.Clear()
        PanelContent.Controls.Add(ventasForm)

        ' Mostrar el formulario "Ventas"
        ventasForm.Show()

    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        ActivateButton(sender, RGBColors.ShadeBlue, "Clientes")


        Dim clientesForm As New Clientes()


        clientesForm.TopLevel = False
        clientesForm.FormBorderStyle = FormBorderStyle.None
        clientesForm.Dock = DockStyle.Fill
        PanelContent.Controls.Clear()
        PanelContent.Controls.Add(clientesForm)

        clientesForm.Show()

    End Sub

    Private Sub btnTickets_Click(sender As Object, e As EventArgs) Handles btnTickets.Click
        ActivateButton(sender, RGBColors.ShadePink, "Tickets")

        Dim TicketsForm As New Tickets()

        TicketsForm.TopLevel = False
        TicketsForm.FormBorderStyle = FormBorderStyle.None
        TicketsForm.Dock = DockStyle.Fill

        PanelContent.Controls.Clear()
        PanelContent.Controls.Add(TicketsForm)

        TicketsForm.Show()

    End Sub

    Private Sub btnChat_Click(sender As Object, e As EventArgs) Handles btnChat.Click
        ActivateButton(sender, RGBColors.LightBlue, "Chat")

        Dim ChatForm As New Chat()

        ChatForm.TopLevel = False
        ChatForm.FormBorderStyle = FormBorderStyle.None
        ChatForm.Dock = DockStyle.Fill

        PanelContent.Controls.Clear()
        PanelContent.Controls.Add(ChatForm)

        ChatForm.Show()

    End Sub

    Private Sub btnBlog_Click(sender As Object, e As EventArgs) Handles btnBlog.Click
        ActivateButton(sender, RGBColors.SugarCaneGreen, "Blog")

        Dim BlogForm As New Blog()

        BlogForm.TopLevel = False
        BlogForm.FormBorderStyle = FormBorderStyle.None
        BlogForm.Dock = DockStyle.Fill

        PanelContent.Controls.Clear()


        PanelContent.Controls.Add(BlogForm)
        BlogForm.Show()

    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        ActivateButton(sender, RGBColors.Ambar, "Usuarios")

        Dim UsuariosForm As New Usuario()


        UsuariosForm.TopLevel = False
        UsuariosForm.FormBorderStyle = FormBorderStyle.None
        UsuariosForm.Dock = DockStyle.Fill

        PanelContent.Controls.Clear()
        PanelContent.Controls.Add(UsuariosForm)

        UsuariosForm.Show()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        ActivateButton(sender, RGBColors.LimeGreen, "Ayuda")


        Dim AyudaForm As New Ayuda()
        AyudaForm.TopLevel = False
        AyudaForm.FormBorderStyle = FormBorderStyle.None
        AyudaForm.Dock = DockStyle.Fill

        PanelContent.Controls.Clear()

        PanelContent.Controls.Add(AyudaForm)
        AyudaForm.Show()

    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Home.MdiParent = Me
        Home.WindowState = FormWindowState.Normal
        Home.FormBorderStyle = FormBorderStyle.None
        Home.Show()
    End Sub
End Class
