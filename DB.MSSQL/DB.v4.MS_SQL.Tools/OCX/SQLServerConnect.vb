Imports EPRO.Library.v3._5.Modules
Imports EPRO.Library.v3._5.InputsParsing


Namespace OCX

    ''' <summary>
    ''' Helps to connect to SQL Server
    ''' </summary>
    ''' <remarks></remarks>
    Public Class SQLServerConnect

#Region "Constructors"
        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            AddHandler txtPortNumber.KeyPress, AddressOf TextHandlers.addOrRemove__NumbersOnly__addressOfKeyPress



            Me.AutoSwitchInputWithModes = True

          
        End Sub




        Public Sub LoadControl(ByVal pDisableConfidentialDataEntry As Boolean,
                Optional ByVal pDisplayConfidentialDataEntry As Boolean = True,
                Optional ByVal UserName As String = vbNullString,
                Optional ByVal Password As String = vbNullString,
                Optional ByVal pPort As Int32 = 1433,
                Optional ByVal pDatabase As String = "master",
                Optional ByVal pConnectingVia As SQLConnectingMode = SQLConnectingMode.Both,
                Optional ByVal pServerIP_Name As String = vbNullString)



            With Me.txtServer.Items
                .Clear()

                For Each p As String In ServerHelperDynamicVersion.getInstalledSQLServerInstances()
                    .Add(String.Format("{0}\{1}", My.Computer.Name, p))
                Next


            End With



            Me.DisplayConfidentialDataEntry = pDisplayConfidentialDataEntry
            Me.grpLoginDetails.Visible = Me.DisplayConfidentialDataEntry

            If Not Me.DisplayConfidentialDataEntry Then
                Me.DisableConfidentialDataEntry = True
            Else

                Me.DisableConfidentialDataEntry = pDisableConfidentialDataEntry

            End If

            Me.clearControls()



            If pConnectingVia = SQLConnectingMode.Network Then
                REM NOW Select SQL Server Authentication as default
                Me.cboAuthenticationType.SelectedIndex = 1
            Else
                REM NOW Select Windows Authentication as default
                Me.cboAuthenticationType.SelectedIndex = 0


            End If


            Me.SQLUser = UserName
            Me.SQLUserPassword = Password
            Me.SQLServerPort = pPort
            Me.SQLDatabase = pDatabase
            Me.ServerName_IP = pServerIP_Name


            Me.amConnectingVia = pConnectingVia


            Call cboAuthenticationType_SelectedIndexChanged(cboAuthenticationType, Nothing)

        End Sub

#End Region

        Public Enum ConnectionTypes
            WindowsAuthentication
            SQLServerAuthentication
        End Enum

        Public Enum SQLConnectingMode
            ''' <summary>
            ''' It means it will be over TCP/IP Connection. Use mainly for client machines
            ''' </summary>
            ''' <remarks></remarks>
            Network

            ''' <summary>
            ''' No TCP/IP required and it should allow only windows authentication Mode
            ''' </summary>
            ''' <remarks></remarks>
            Locally


            ''' <summary>
            ''' Allows Both Network and Local
            ''' </summary>
            ''' <remarks></remarks>
            Both


        End Enum


#Region "Events"

        ''' <summary>
        ''' Indicates user clicked cancel
        ''' </summary>
        ''' <remarks></remarks>
        Public Event UserClosing()

        ''' <summary>
        ''' Indicates Connection was a success
        ''' </summary>
        ''' <remarks></remarks>
        Public Event ConnectedSuccessfully()


#End Region


#Region "Properties"

        ''' <summary>
        ''' Indicates if the switch will be working as user changes modes. DEFAULT is true
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AutoSwitchInputWithModes As Boolean

        Public ReadOnly Property ConnectedMode As ServerHelperDynamicVersion.SQLServerConnectionModes
            Get
                Return CType(cboAuthenticationType.SelectedIndex, ServerHelperDynamicVersion.SQLServerConnectionModes)
            End Get
        End Property


        Public Property SQLUser As String = vbNullString
        Public Property SQLUserPassword As String = vbNullString
        Public Property SQLServerPort As Int32
            Get
                Return txtPortNumber.Text.toint32()
            End Get
            Set(value As Int32)
                txtPortNumber.Text = value.ToString()
            End Set
        End Property
        Public Property SQLDatabase As String
            Get
                Return Me.txtDatabaseName.Text
            End Get
            Set(value As String)
                Me.txtDatabaseName.Text = value
            End Set
        End Property

        Public Property ServerName_IP As String
            Get

                Return Me.txtServer.Text

            End Get
            Set(ByVal value As String)
                    Me.txtServer.Text = value
            End Set
        End Property


        ''' <summary>
        ''' Disable/Enable the Authentication Type depending on the Connection Mode
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        Public WriteOnly Property amConnectingVia As SQLConnectingMode
            Set(ByVal value As SQLConnectingMode)
                Select Case value
                    Case Is = SQLConnectingMode.Both
                        cboAuthenticationType.Enabled = True
                    Case Else
                        cboAuthenticationType.Enabled = False

                End Select
            End Set
        End Property

        ''' <summary>
        ''' Indicates if the user name and password would be allowed to be change by the user
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Property DisableConfidentialDataEntry As Boolean = False

        ''' <summary>
        ''' Indicates if the user name and password should be displayed to the user
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Property DisplayConfidentialDataEntry As Boolean = True

#End Region

#Region "Methods"



        ''' <summary>
        ''' Clear all controls and load default data
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub clearControls()
            Me.txtUserName.Text = vbNullString
            Me.txtPassword.Text = vbNullString
            Me.txtServer.Text = vbNullString


            Me.cboAuthenticationType.Items.Clear()

            For Each Item As ConnectionTypes In getConnectionTypes()
                Me.cboAuthenticationType.Items.Add(
                    getConnectionType(Item)
                    )

            Next
            Me.cboAuthenticationType.SelectedIndex = -1


        End Sub

        ''' <summary>
        ''' Converts ConnectionTypes to Strings
        ''' </summary>
        ''' <param name="ConnType"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function getConnectionType(ByVal ConnType As ConnectionTypes) As String
            Select Case ConnType

                Case Is = ConnectionTypes.WindowsAuthentication
                    Return "Windows Authentication"


                Case Is = ConnectionTypes.SQLServerAuthentication
                    Return "SQL Server Authentication"

            End Select

            Return String.Empty

        End Function

        ''' <summary>
        ''' Get the Connection Types Enumeration as Array
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function getConnectionTypes() As ConnectionTypes()
            Return {ConnectionTypes.WindowsAuthentication,
                                                   ConnectionTypes.SQLServerAuthentication
                                                  }
        End Function



#End Region




        Private Sub ctlSQLServerConnect_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
            REM Force Fixed Size
            'If Me.Size <> New System.Drawing.Size(483, 382) Then Me.Size = New System.Drawing.Size(483, 382)

        End Sub

        Private Sub cboAuthenticationType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAuthenticationType.SelectedIndexChanged

            lblErrorOccured.Text = vbNullString

            If Me.cboAuthenticationType.Text = getConnectionType(ConnectionTypes.WindowsAuthentication) Then
                If Me.AutoSwitchInputWithModes Then

                    txtUserName.Enabled = False
                    txtPassword.Enabled = False
                    txtPortNumber.Enabled = False

                End If


                If txtServer.Text = String.Empty Then txtServer.Text = My.Computer.Name & "\sqlexpress"
                ' txtServer.Enabled = False

            Else

                txtPortNumber.Enabled = True
                txtServer.Enabled = True

                If Not Me.DisableConfidentialDataEntry Then
                    txtUserName.Enabled = True
                    txtPassword.Enabled = True
                Else
                    txtUserName.Enabled = False
                    txtPassword.Enabled = False
                End If

            End If


            If txtUserName.Text = vbNullString AndAlso Me.DisplayConfidentialDataEntry Then
                txtUserName.Text = Me.SQLUser

            End If
            If txtPassword.Text = vbNullString AndAlso Me.DisplayConfidentialDataEntry Then

                txtPassword.Text = SQLUserPassword

            End If


        End Sub



        Private Sub cmdConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConnect.Click

            Me.cmdConnect.Text = "Connecting ..."
            Me.cmdConnect.Enabled = False

            If Me.DisplayConfidentialDataEntry Then
                Me.SQLUser = txtUserName.Text
                Me.SQLUserPassword = txtPassword.Text
            End If

            lblErrorOccured.Text = vbNullString


            If Me.cboAuthenticationType.SelectedIndex = ConnectionTypes.WindowsAuthentication Then

                Using ServerTemp As New MS_SQL.Server("Master", Me.ServerName_IP)
                    If ServerTemp.CanConnect Then

                        RaiseEvent ConnectedSuccessfully()

                    Else
                        lblErrorOccured.Text = "Application Could NOT Connect to Database"

                    End If
                End Using

            Else

                Using ServerTemp As New Client(txtServer.Text,
                                                            Me.SQLServerPort,
                                                            Me.SQLUser,
                                                             Me.SQLUserPassword,
                                                             Me.SQLDatabase,
                                                             False)
                    If ServerTemp.CanConnect Then

                        RaiseEvent ConnectedSuccessfully()

                    Else
                        lblErrorOccured.Text = "Application Could NOT Connect to Database"

                    End If

                End Using

            End If



            Me.cmdConnect.Text = "Connect"
            Me.cmdConnect.Enabled = True

        End Sub

        Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
            REM Raise Close Operation Event
            RaiseEvent UserClosing()

        End Sub

        Private Sub txtUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserName.TextChanged, _
                                                                                                                txtPassword.TextChanged, _
                                                                                                                txtServer.TextChanged, txtDatabaseName.TextChanged, txtPortNumber.TextChanged

            lblErrorOccured.Text = vbNullString
        End Sub

    End Class



End Namespace

