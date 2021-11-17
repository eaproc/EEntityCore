

Namespace OCX


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SQLServerConnect
        Inherits System.Windows.Forms.UserControl

        'UserControl1 overrides dispose to clean up the component list.
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SQLServerConnect))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.EPLabel5 = New System.Windows.Forms.Label()
            Me.lblErrorOccured = New System.Windows.Forms.Label()
            Me.EPLabel6 = New System.Windows.Forms.Label()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.cmdCancel = New System.Windows.Forms.Button()
            Me.cmdConnect = New System.Windows.Forms.Button()
            Me.cboAuthenticationType = New System.Windows.Forms.ComboBox()
            Me.grpLoginDetails = New System.Windows.Forms.GroupBox()
            Me.EPLabel2 = New System.Windows.Forms.Label()
            Me.txtPassword = New System.Windows.Forms.TextBox()
            Me.txtUserName = New System.Windows.Forms.TextBox()
            Me.EPLabel3 = New System.Windows.Forms.Label()
            Me.txtDatabaseName = New System.Windows.Forms.TextBox()
            Me.txtServer = New System.Windows.Forms.ComboBox()
            Me.EPLabel4 = New System.Windows.Forms.Label()
            Me.EpLabel8 = New System.Windows.Forms.Label()
            Me.EpLabel7 = New System.Windows.Forms.Label()
            Me.EPLabel1 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtPortNumber = New System.Windows.Forms.TextBox()
            Me.Panel1.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            Me.grpLoginDetails.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.Gray
            Me.Panel1.Controls.Add(Me.EPLabel5)
            Me.Panel1.Controls.Add(Me.lblErrorOccured)
            Me.Panel1.Controls.Add(Me.EPLabel6)
            Me.Panel1.Controls.Add(Me.PictureBox1)
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(482, 109)
            Me.Panel1.TabIndex = 0
            '
            'EPLabel5
            '
            Me.EPLabel5.AutoSize = True
            Me.EPLabel5.BackColor = System.Drawing.Color.Transparent
            Me.EPLabel5.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.EPLabel5.ForeColor = System.Drawing.Color.White
            Me.EPLabel5.Location = New System.Drawing.Point(68, 24)
            Me.EPLabel5.Name = "EPLabel5"
            Me.EPLabel5.Size = New System.Drawing.Size(395, 43)
            Me.EPLabel5.TabIndex = 0
            Me.EPLabel5.Text = "SQL Server Connection"
            '
            'lblErrorOccured
            '
            Me.lblErrorOccured.AutoSize = True
            Me.lblErrorOccured.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblErrorOccured.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.lblErrorOccured.Location = New System.Drawing.Point(72, 89)
            Me.lblErrorOccured.Name = "lblErrorOccured"
            Me.lblErrorOccured.Size = New System.Drawing.Size(271, 18)
            Me.lblErrorOccured.TabIndex = 0
            Me.lblErrorOccured.Text = "Application could NOT Connect to SQL Server!"
            '
            'EPLabel6
            '
            Me.EPLabel6.AutoSize = True
            Me.EPLabel6.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.EPLabel6.ForeColor = System.Drawing.Color.White
            Me.EPLabel6.Location = New System.Drawing.Point(383, 67)
            Me.EPLabel6.Name = "EPLabel6"
            Me.EPLabel6.Size = New System.Drawing.Size(76, 20)
            Me.EPLabel6.TabIndex = 0
            Me.EPLabel6.Text = "SETTINGS"
            '
            'PictureBox1
            '
            Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Me.PictureBox1.Location = New System.Drawing.Point(-37, -35)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(128, 106)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox1.TabIndex = 1
            Me.PictureBox1.TabStop = False
            '
            'Panel2
            '
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.Panel2.Controls.Add(Me.cmdCancel)
            Me.Panel2.Controls.Add(Me.cmdConnect)
            Me.Panel2.Controls.Add(Me.cboAuthenticationType)
            Me.Panel2.Controls.Add(Me.grpLoginDetails)
            Me.Panel2.Controls.Add(Me.txtPortNumber)
            Me.Panel2.Controls.Add(Me.txtDatabaseName)
            Me.Panel2.Controls.Add(Me.txtServer)
            Me.Panel2.Controls.Add(Me.Label1)
            Me.Panel2.Controls.Add(Me.EPLabel4)
            Me.Panel2.Controls.Add(Me.EpLabel8)
            Me.Panel2.Controls.Add(Me.EpLabel7)
            Me.Panel2.Controls.Add(Me.EPLabel1)
            Me.Panel2.Location = New System.Drawing.Point(0, 109)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(482, 339)
            Me.Panel2.TabIndex = 0
            '
            'cmdCancel
            '
            Me.cmdCancel.BackColor = System.Drawing.Color.DimGray
            Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.cmdCancel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancel.ForeColor = System.Drawing.Color.White
            Me.cmdCancel.Location = New System.Drawing.Point(203, 287)
            Me.cmdCancel.Name = "cmdCancel"
            Me.cmdCancel.Size = New System.Drawing.Size(127, 34)
            Me.cmdCancel.TabIndex = 7
            Me.cmdCancel.Text = "Cancel"
            Me.cmdCancel.UseVisualStyleBackColor = False
            '
            'cmdConnect
            '
            Me.cmdConnect.BackColor = System.Drawing.Color.DimGray
            Me.cmdConnect.Cursor = System.Windows.Forms.Cursors.Hand
            Me.cmdConnect.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdConnect.ForeColor = System.Drawing.Color.White
            Me.cmdConnect.Location = New System.Drawing.Point(336, 287)
            Me.cmdConnect.Name = "cmdConnect"
            Me.cmdConnect.Size = New System.Drawing.Size(127, 34)
            Me.cmdConnect.TabIndex = 6
            Me.cmdConnect.Text = "Connect"
            Me.cmdConnect.UseVisualStyleBackColor = False
            '
            'cboAuthenticationType
            '
            Me.cboAuthenticationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboAuthenticationType.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboAuthenticationType.ForeColor = System.Drawing.Color.Black
            Me.cboAuthenticationType.FormattingEnabled = True
            Me.cboAuthenticationType.Location = New System.Drawing.Point(153, 105)
            Me.cboAuthenticationType.Name = "cboAuthenticationType"
            Me.cboAuthenticationType.Size = New System.Drawing.Size(310, 30)
            Me.cboAuthenticationType.TabIndex = 3
            '
            'grpLoginDetails
            '
            Me.grpLoginDetails.Controls.Add(Me.EPLabel2)
            Me.grpLoginDetails.Controls.Add(Me.txtPassword)
            Me.grpLoginDetails.Controls.Add(Me.txtUserName)
            Me.grpLoginDetails.Controls.Add(Me.EPLabel3)
            Me.grpLoginDetails.ForeColor = System.Drawing.Color.Black
            Me.grpLoginDetails.Location = New System.Drawing.Point(19, 186)
            Me.grpLoginDetails.Name = "grpLoginDetails"
            Me.grpLoginDetails.Size = New System.Drawing.Size(444, 88)
            Me.grpLoginDetails.TabIndex = 20
            Me.grpLoginDetails.TabStop = False
            Me.grpLoginDetails.Text = "Login"
            '
            'EPLabel2
            '
            Me.EPLabel2.AutoSize = True
            Me.EPLabel2.ForeColor = System.Drawing.Color.Black
            Me.EPLabel2.Location = New System.Drawing.Point(31, 27)
            Me.EPLabel2.Name = "EPLabel2"
            Me.EPLabel2.Size = New System.Drawing.Size(76, 18)
            Me.EPLabel2.TabIndex = 0
            Me.EPLabel2.Text = "User Name:"
            '
            'txtPassword
            '
            Me.txtPassword.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPassword.ForeColor = System.Drawing.Color.Black
            Me.txtPassword.Location = New System.Drawing.Point(134, 58)
            Me.txtPassword.MaxLength = 20
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(43)
            Me.txtPassword.Size = New System.Drawing.Size(290, 25)
            Me.txtPassword.TabIndex = 5
            Me.txtPassword.Text = "192.168.0.1"
            '
            'txtUserName
            '
            Me.txtUserName.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUserName.ForeColor = System.Drawing.Color.Black
            Me.txtUserName.Location = New System.Drawing.Point(134, 27)
            Me.txtUserName.MaxLength = 20
            Me.txtUserName.Name = "txtUserName"
            Me.txtUserName.Size = New System.Drawing.Size(290, 25)
            Me.txtUserName.TabIndex = 4
            Me.txtUserName.Text = "192.168.0.1"
            '
            'EPLabel3
            '
            Me.EPLabel3.AutoSize = True
            Me.EPLabel3.ForeColor = System.Drawing.Color.Black
            Me.EPLabel3.Location = New System.Drawing.Point(31, 58)
            Me.EPLabel3.Name = "EPLabel3"
            Me.EPLabel3.Size = New System.Drawing.Size(67, 18)
            Me.EPLabel3.TabIndex = 0
            Me.EPLabel3.Text = "Password:"
            '
            'txtDatabaseName
            '
            Me.txtDatabaseName.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDatabaseName.ForeColor = System.Drawing.Color.Black
            Me.txtDatabaseName.Location = New System.Drawing.Point(153, 64)
            Me.txtDatabaseName.MaxLength = 25
            Me.txtDatabaseName.Name = "txtDatabaseName"
            Me.txtDatabaseName.Size = New System.Drawing.Size(310, 25)
            Me.txtDatabaseName.TabIndex = 2
            Me.txtDatabaseName.Text = "192.168.0.1"
            '
            'txtServer
            '
            Me.txtServer.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtServer.ForeColor = System.Drawing.Color.Black
            Me.txtServer.Location = New System.Drawing.Point(153, 28)
            Me.txtServer.MaxLength = 25
            Me.txtServer.Name = "txtServer"
            Me.txtServer.Size = New System.Drawing.Size(310, 25)
            Me.txtServer.TabIndex = 1
            Me.txtServer.Text = "192.168.0.1"
            '
            'EPLabel4
            '
            Me.EPLabel4.AutoSize = True
            Me.EPLabel4.ForeColor = System.Drawing.Color.Black
            Me.EPLabel4.Location = New System.Drawing.Point(16, 109)
            Me.EPLabel4.Name = "EPLabel4"
            Me.EPLabel4.Size = New System.Drawing.Size(131, 18)
            Me.EPLabel4.TabIndex = 0
            Me.EPLabel4.Text = "Authentication Type:"
            '
            'EpLabel8
            '
            Me.EpLabel8.AutoSize = True
            Me.EpLabel8.ForeColor = System.Drawing.Color.Black
            Me.EpLabel8.Location = New System.Drawing.Point(16, 64)
            Me.EpLabel8.Name = "EpLabel8"
            Me.EpLabel8.Size = New System.Drawing.Size(67, 18)
            Me.EpLabel8.TabIndex = 0
            Me.EpLabel8.Text = "Database:"
            '
            'EpLabel7
            '
            Me.EpLabel7.AutoSize = True
            Me.EpLabel7.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.EpLabel7.ForeColor = System.Drawing.Color.Black
            Me.EpLabel7.Location = New System.Drawing.Point(155, 8)
            Me.EpLabel7.Name = "EpLabel7"
            Me.EpLabel7.Size = New System.Drawing.Size(117, 16)
            Me.EpLabel7.TabIndex = 0
            Me.EpLabel7.Text = "like MyPC\SQLExpress"
            '
            'EPLabel1
            '
            Me.EPLabel1.AutoSize = True
            Me.EPLabel1.ForeColor = System.Drawing.Color.Black
            Me.EPLabel1.Location = New System.Drawing.Point(16, 28)
            Me.EPLabel1.Name = "EPLabel1"
            Me.EPLabel1.Size = New System.Drawing.Size(119, 18)
            Me.EPLabel1.TabIndex = 0
            Me.EPLabel1.Text = "Server Name or IP:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Location = New System.Drawing.Point(16, 153)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(64, 18)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "TCP Port:"
            '
            'txtPortNumber
            '
            Me.txtPortNumber.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPortNumber.ForeColor = System.Drawing.Color.Black
            Me.txtPortNumber.Location = New System.Drawing.Point(153, 153)
            Me.txtPortNumber.MaxLength = 25
            Me.txtPortNumber.Name = "txtPortNumber"
            Me.txtPortNumber.Size = New System.Drawing.Size(310, 25)
            Me.txtPortNumber.TabIndex = 2
            Me.txtPortNumber.Text = "192.168.0.1"
            '
            'SQLServerConnect
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.Panel1)
            Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.MaximumSize = New System.Drawing.Size(483, 448)
            Me.MinimumSize = New System.Drawing.Size(483, 448)
            Me.Name = "SQLServerConnect"
            Me.Size = New System.Drawing.Size(483, 448)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.grpLoginDetails.ResumeLayout(False)
            Me.grpLoginDetails.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents EPLabel1 As System.Windows.Forms.Label
        Friend WithEvents txtServer As System.Windows.Forms.ComboBox
        Friend WithEvents txtPassword As System.Windows.Forms.TextBox
        Friend WithEvents EPLabel3 As System.Windows.Forms.Label
        Friend WithEvents txtUserName As System.Windows.Forms.TextBox
        Friend WithEvents EPLabel2 As System.Windows.Forms.Label
        Friend WithEvents grpLoginDetails As System.Windows.Forms.GroupBox
        Friend WithEvents cboAuthenticationType As System.Windows.Forms.ComboBox
        Friend WithEvents EPLabel4 As System.Windows.Forms.Label
        Friend WithEvents cmdCancel As System.Windows.Forms.Button
        Friend WithEvents cmdConnect As System.Windows.Forms.Button
        Friend WithEvents EPLabel5 As System.Windows.Forms.Label
        Friend WithEvents EPLabel6 As System.Windows.Forms.Label
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents lblErrorOccured As System.Windows.Forms.Label
        Friend WithEvents txtDatabaseName As System.Windows.Forms.TextBox
        Friend WithEvents EpLabel8 As System.Windows.Forms.Label
        Friend WithEvents EpLabel7 As System.Windows.Forms.Label
        Friend WithEvents txtPortNumber As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label

    End Class

End Namespace