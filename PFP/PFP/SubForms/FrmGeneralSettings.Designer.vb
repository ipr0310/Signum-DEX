﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGeneralSettings
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TBDEXNETPort = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBTCPAPIPort = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChBxTCPAPI = New System.Windows.Forms.CheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CoBxNode = New System.Windows.Forms.ComboBox()
        Me.CoBxRefresh = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CoBxPayType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChBxCheckXItemTX = New System.Windows.Forms.CheckBox()
        Me.BtSaveSettings = New System.Windows.Forms.Button()
        Me.ChBxAutoSendPaymentInfo = New System.Windows.Forms.CheckBox()
        Me.TBPaymentInfo = New System.Windows.Forms.TextBox()
        Me.GrpBxSeller = New System.Windows.Forms.GroupBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.RBPayPalOrder = New System.Windows.Forms.RadioButton()
        Me.RBPayPalEMail = New System.Windows.Forms.RadioButton()
        Me.TBPayPalEMail = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.BtCheckPayPalBiz = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TBPayPalAPISecret = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TBPayPalAPIUser = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtBitcoinAddresses = New System.Windows.Forms.Button()
        Me.BtBitcoindPath = New System.Windows.Forms.Button()
        Me.LVBitcoinAddress = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TBBitcoinAPIPass = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBBitcoinAPIUser = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TBBitcoinWallet = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBBitcoinAPINode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBBitcoinArgs = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBBitcoindPath = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GrpBxSeller.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TBDEXNETPort)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TBTCPAPIPort)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.ChBxTCPAPI)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.CoBxNode)
        Me.GroupBox3.Controls.Add(Me.CoBxRefresh)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(347, 124)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Default Settings"
        '
        'TBDEXNETPort
        '
        Me.TBDEXNETPort.Location = New System.Drawing.Point(105, 67)
        Me.TBDEXNETPort.Name = "TBDEXNETPort"
        Me.TBDEXNETPort.Size = New System.Drawing.Size(63, 20)
        Me.TBDEXNETPort.TabIndex = 24
        Me.TBDEXNETPort.Text = "8131"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "DEXNET Port:"
        '
        'TBTCPAPIPort
        '
        Me.TBTCPAPIPort.Location = New System.Drawing.Point(105, 93)
        Me.TBTCPAPIPort.Name = "TBTCPAPIPort"
        Me.TBTCPAPIPort.Size = New System.Drawing.Size(63, 20)
        Me.TBTCPAPIPort.TabIndex = 22
        Me.TBTCPAPIPort.Text = "8130"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "TCP API Port:"
        '
        'ChBxTCPAPI
        '
        Me.ChBxTCPAPI.AutoSize = True
        Me.ChBxTCPAPI.Location = New System.Drawing.Point(174, 95)
        Me.ChBxTCPAPI.Name = "ChBxTCPAPI"
        Me.ChBxTCPAPI.Size = New System.Drawing.Size(103, 17)
        Me.ChBxTCPAPI.TabIndex = 19
        Me.ChBxTCPAPI.Text = "TCP API Enable"
        Me.ChBxTCPAPI.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(174, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(44, 13)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Minutes"
        '
        'CoBxNode
        '
        Me.CoBxNode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CoBxNode.FormattingEnabled = True
        Me.CoBxNode.Location = New System.Drawing.Point(105, 40)
        Me.CoBxNode.Name = "CoBxNode"
        Me.CoBxNode.Size = New System.Drawing.Size(220, 21)
        Me.CoBxNode.TabIndex = 13
        '
        'CoBxRefresh
        '
        Me.CoBxRefresh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CoBxRefresh.FormattingEnabled = True
        Me.CoBxRefresh.Items.AddRange(New Object() {"1", "4", "10"})
        Me.CoBxRefresh.Location = New System.Drawing.Point(105, 13)
        Me.CoBxRefresh.Name = "CoBxRefresh"
        Me.CoBxRefresh.Size = New System.Drawing.Size(63, 21)
        Me.CoBxRefresh.TabIndex = 12
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 43)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 13)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Primary-API-Node:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Refreshrate:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Paytype:"
        '
        'CoBxPayType
        '
        Me.CoBxPayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CoBxPayType.FormattingEnabled = True
        Me.CoBxPayType.Location = New System.Drawing.Point(60, 42)
        Me.CoBxPayType.Name = "CoBxPayType"
        Me.CoBxPayType.Size = New System.Drawing.Size(265, 21)
        Me.CoBxPayType.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Infotext:"
        '
        'ChBxCheckXItemTX
        '
        Me.ChBxCheckXItemTX.AutoSize = True
        Me.ChBxCheckXItemTX.Location = New System.Drawing.Point(6, 95)
        Me.ChBxCheckXItemTX.Name = "ChBxCheckXItemTX"
        Me.ChBxCheckXItemTX.Size = New System.Drawing.Size(270, 17)
        Me.ChBxCheckXItemTX.TabIndex = 16
        Me.ChBxCheckXItemTX.Text = "automatically check XItem transaction and finish AT"
        Me.ChBxCheckXItemTX.UseVisualStyleBackColor = True
        '
        'BtSaveSettings
        '
        Me.BtSaveSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtSaveSettings.ForeColor = System.Drawing.Color.White
        Me.BtSaveSettings.Location = New System.Drawing.Point(12, 405)
        Me.BtSaveSettings.Name = "BtSaveSettings"
        Me.BtSaveSettings.Size = New System.Drawing.Size(758, 30)
        Me.BtSaveSettings.TabIndex = 9
        Me.BtSaveSettings.Text = "save settings"
        Me.BtSaveSettings.UseVisualStyleBackColor = False
        '
        'ChBxAutoSendPaymentInfo
        '
        Me.ChBxAutoSendPaymentInfo.AutoSize = True
        Me.ChBxAutoSendPaymentInfo.Location = New System.Drawing.Point(6, 19)
        Me.ChBxAutoSendPaymentInfo.Name = "ChBxAutoSendPaymentInfo"
        Me.ChBxAutoSendPaymentInfo.Size = New System.Drawing.Size(319, 17)
        Me.ChBxAutoSendPaymentInfo.TabIndex = 4
        Me.ChBxAutoSendPaymentInfo.Text = "automatically send encrypted payment information to the buyer"
        Me.ChBxAutoSendPaymentInfo.UseVisualStyleBackColor = True
        '
        'TBPaymentInfo
        '
        Me.TBPaymentInfo.Location = New System.Drawing.Point(60, 69)
        Me.TBPaymentInfo.Name = "TBPaymentInfo"
        Me.TBPaymentInfo.Size = New System.Drawing.Size(265, 20)
        Me.TBPaymentInfo.TabIndex = 7
        '
        'GrpBxSeller
        '
        Me.GrpBxSeller.BackColor = System.Drawing.Color.Transparent
        Me.GrpBxSeller.Controls.Add(Me.TabControl2)
        Me.GrpBxSeller.ForeColor = System.Drawing.Color.White
        Me.GrpBxSeller.Location = New System.Drawing.Point(12, 275)
        Me.GrpBxSeller.Name = "GrpBxSeller"
        Me.GrpBxSeller.Size = New System.Drawing.Size(347, 124)
        Me.GrpBxSeller.TabIndex = 10
        Me.GrpBxSeller.TabStop = False
        Me.GrpBxSeller.Text = "PayPal Settings (Sandbox)"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(3, 16)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(341, 105)
        Me.TabControl2.TabIndex = 6
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.RBPayPalOrder)
        Me.TabPage4.Controls.Add(Me.RBPayPalEMail)
        Me.TabPage4.Controls.Add(Me.TBPayPalEMail)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(333, 79)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Payment informations"
        '
        'RBPayPalOrder
        '
        Me.RBPayPalOrder.AutoSize = True
        Me.RBPayPalOrder.Location = New System.Drawing.Point(5, 32)
        Me.RBPayPalOrder.Name = "RBPayPalOrder"
        Me.RBPayPalOrder.Size = New System.Drawing.Size(243, 17)
        Me.RBPayPalOrder.TabIndex = 12
        Me.RBPayPalOrder.Text = "create a PayPal Order (need PayPal Business)"
        Me.RBPayPalOrder.UseVisualStyleBackColor = True
        Me.RBPayPalOrder.Visible = False
        '
        'RBPayPalEMail
        '
        Me.RBPayPalEMail.AutoSize = True
        Me.RBPayPalEMail.Checked = True
        Me.RBPayPalEMail.Location = New System.Drawing.Point(5, 7)
        Me.RBPayPalEMail.Name = "RBPayPalEMail"
        Me.RBPayPalEMail.Size = New System.Drawing.Size(93, 17)
        Me.RBPayPalEMail.TabIndex = 10
        Me.RBPayPalEMail.TabStop = True
        Me.RBPayPalEMail.Text = "PayPal E-Mail:"
        Me.RBPayPalEMail.UseVisualStyleBackColor = True
        '
        'TBPayPalEMail
        '
        Me.TBPayPalEMail.Location = New System.Drawing.Point(104, 6)
        Me.TBPayPalEMail.Name = "TBPayPalEMail"
        Me.TBPayPalEMail.Size = New System.Drawing.Size(214, 20)
        Me.TBPayPalEMail.TabIndex = 7
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.BtCheckPayPalBiz)
        Me.TabPage5.Controls.Add(Me.Label13)
        Me.TabPage5.Controls.Add(Me.TBPayPalAPISecret)
        Me.TabPage5.Controls.Add(Me.Label14)
        Me.TabPage5.Controls.Add(Me.TBPayPalAPIUser)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(333, 79)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Business API"
        '
        'BtCheckPayPalBiz
        '
        Me.BtCheckPayPalBiz.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtCheckPayPalBiz.Location = New System.Drawing.Point(76, 53)
        Me.BtCheckPayPalBiz.Name = "BtCheckPayPalBiz"
        Me.BtCheckPayPalBiz.Size = New System.Drawing.Size(75, 23)
        Me.BtCheckPayPalBiz.TabIndex = 4
        Me.BtCheckPayPalBiz.Text = "check"
        Me.BtCheckPayPalBiz.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "API-User:"
        '
        'TBPayPalAPISecret
        '
        Me.TBPayPalAPISecret.Location = New System.Drawing.Point(76, 32)
        Me.TBPayPalAPISecret.Name = "TBPayPalAPISecret"
        Me.TBPayPalAPISecret.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.TBPayPalAPISecret.Size = New System.Drawing.Size(242, 20)
        Me.TBPayPalAPISecret.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "API-Secret:"
        '
        'TBPayPalAPIUser
        '
        Me.TBPayPalAPIUser.Location = New System.Drawing.Point(76, 6)
        Me.TBPayPalAPIUser.Name = "TBPayPalAPIUser"
        Me.TBPayPalAPIUser.Size = New System.Drawing.Size(242, 20)
        Me.TBPayPalAPIUser.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ChBxAutoSendPaymentInfo)
        Me.GroupBox1.Controls.Add(Me.CoBxPayType)
        Me.GroupBox1.Controls.Add(Me.TBPaymentInfo)
        Me.GroupBox1.Controls.Add(Me.ChBxCheckXItemTX)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 127)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Default Non-Cryptocurrency Settings"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BtBitcoinAddresses)
        Me.GroupBox2.Controls.Add(Me.BtBitcoindPath)
        Me.GroupBox2.Controls.Add(Me.LVBitcoinAddress)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TBBitcoinAPIPass)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TBBitcoinAPIUser)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TBBitcoinWallet)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TBBitcoinAPINode)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TBBitcoinArgs)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TBBitcoindPath)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(365, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 387)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bitcoin Settings (Testnet)"
        '
        'BtBitcoinAddresses
        '
        Me.BtBitcoinAddresses.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtBitcoinAddresses.ForeColor = System.Drawing.Color.White
        Me.BtBitcoinAddresses.Location = New System.Drawing.Point(115, 172)
        Me.BtBitcoinAddresses.Name = "BtBitcoinAddresses"
        Me.BtBitcoinAddresses.Size = New System.Drawing.Size(169, 21)
        Me.BtBitcoinAddresses.TabIndex = 27
        Me.BtBitcoinAddresses.Text = "bitcoin address settings"
        Me.BtBitcoinAddresses.UseVisualStyleBackColor = False
        '
        'BtBitcoindPath
        '
        Me.BtBitcoindPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtBitcoindPath.Enabled = False
        Me.BtBitcoindPath.ForeColor = System.Drawing.Color.White
        Me.BtBitcoindPath.Location = New System.Drawing.Point(362, 20)
        Me.BtBitcoindPath.Name = "BtBitcoindPath"
        Me.BtBitcoindPath.Size = New System.Drawing.Size(34, 21)
        Me.BtBitcoindPath.TabIndex = 26
        Me.BtBitcoindPath.Text = "..."
        Me.BtBitcoindPath.UseVisualStyleBackColor = False
        '
        'LVBitcoinAddress
        '
        Me.LVBitcoinAddress.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.LVBitcoinAddress.FullRowSelect = True
        Me.LVBitcoinAddress.GridLines = True
        Me.LVBitcoinAddress.HideSelection = False
        Me.LVBitcoinAddress.Location = New System.Drawing.Point(12, 196)
        Me.LVBitcoinAddress.Name = "LVBitcoinAddress"
        Me.LVBitcoinAddress.Size = New System.Drawing.Size(384, 181)
        Me.LVBitcoinAddress.TabIndex = 25
        Me.LVBitcoinAddress.UseCompatibleStateImageBehavior = False
        Me.LVBitcoinAddress.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Address"
        Me.ColumnHeader1.Width = 368
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 180)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Bitcoin Addresses:"
        '
        'TBBitcoinAPIPass
        '
        Me.TBBitcoinAPIPass.Location = New System.Drawing.Point(115, 124)
        Me.TBBitcoinAPIPass.Name = "TBBitcoinAPIPass"
        Me.TBBitcoinAPIPass.Size = New System.Drawing.Size(281, 20)
        Me.TBBitcoinAPIPass.TabIndex = 23
        Me.TBBitcoinAPIPass.Text = "bitcoin"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Bitcoin API Pass:"
        '
        'TBBitcoinAPIUser
        '
        Me.TBBitcoinAPIUser.Location = New System.Drawing.Point(115, 98)
        Me.TBBitcoinAPIUser.Name = "TBBitcoinAPIUser"
        Me.TBBitcoinAPIUser.Size = New System.Drawing.Size(281, 20)
        Me.TBBitcoinAPIUser.TabIndex = 21
        Me.TBBitcoinAPIUser.Text = "bitcoin"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Bitcoin API User:"
        '
        'TBBitcoinWallet
        '
        Me.TBBitcoinWallet.Enabled = False
        Me.TBBitcoinWallet.Location = New System.Drawing.Point(115, 150)
        Me.TBBitcoinWallet.Name = "TBBitcoinWallet"
        Me.TBBitcoinWallet.Size = New System.Drawing.Size(281, 20)
        Me.TBBitcoinWallet.TabIndex = 19
        Me.TBBitcoinWallet.Text = "DEXWALLET"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Bitcoin Wallet:"
        '
        'TBBitcoinAPINode
        '
        Me.TBBitcoinAPINode.Location = New System.Drawing.Point(115, 72)
        Me.TBBitcoinAPINode.Name = "TBBitcoinAPINode"
        Me.TBBitcoinAPINode.Size = New System.Drawing.Size(281, 20)
        Me.TBBitcoinAPINode.TabIndex = 17
        Me.TBBitcoinAPINode.Text = "http://127.0.0.1:18332"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Bitcoin API Node :"
        '
        'TBBitcoinArgs
        '
        Me.TBBitcoinArgs.Enabled = False
        Me.TBBitcoinArgs.Location = New System.Drawing.Point(115, 46)
        Me.TBBitcoinArgs.Name = "TBBitcoinArgs"
        Me.TBBitcoinArgs.Size = New System.Drawing.Size(281, 20)
        Me.TBBitcoinArgs.TabIndex = 15
        Me.TBBitcoinArgs.Text = "-testnet -rpcuser=bitcoin -rpcpassword=bitcoin -txindex"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Bitcoind arguments:"
        '
        'TBBitcoindPath
        '
        Me.TBBitcoindPath.Enabled = False
        Me.TBBitcoindPath.Location = New System.Drawing.Point(115, 20)
        Me.TBBitcoindPath.Name = "TBBitcoindPath"
        Me.TBBitcoindPath.Size = New System.Drawing.Size(241, 20)
        Me.TBBitcoindPath.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Bitcoind Path:"
        '
        'FrmGeneralSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.PFP.My.Resources.Resources.signum_back3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(783, 445)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpBxSeller)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtSaveSettings)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmGeneralSettings"
        Me.Text = "FrmGeneralSettings"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GrpBxSeller.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ChBxTCPAPI As CheckBox
    Friend WithEvents ChBxCheckXItemTX As CheckBox
    Friend WithEvents Label20 As Label
    Friend WithEvents CoBxNode As ComboBox
    Friend WithEvents CoBxRefresh As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtSaveSettings As Button
    Friend WithEvents ChBxAutoSendPaymentInfo As CheckBox
    Friend WithEvents TBPaymentInfo As TextBox
    Friend WithEvents GrpBxSeller As GroupBox
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents RBPayPalOrder As RadioButton
    Friend WithEvents RBPayPalEMail As RadioButton
    Friend WithEvents TBPayPalEMail As TextBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents BtCheckPayPalBiz As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents TBPayPalAPISecret As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TBPayPalAPIUser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBTCPAPIPort As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBDEXNETPort As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CoBxPayType As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TBBitcoindPath As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBBitcoinWallet As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TBBitcoinAPINode As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBBitcoinArgs As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents LVBitcoinAddress As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Label12 As Label
    Friend WithEvents TBBitcoinAPIPass As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TBBitcoinAPIUser As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BtBitcoindPath As Button
    Friend WithEvents BtBitcoinAddresses As Button
End Class
