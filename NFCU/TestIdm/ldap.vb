Imports Microsoft.VisualBasic
Imports System.Net
Imports System.DirectoryServices.Protocols
Imports System.Net.NetworkCredential


Namespace ldap

    ''' <summary>
    ''' Represents an FQDN and port number
    ''' </summary>
    Public Class ServerUrl
        Private _port As Integer = 389
        Private _host As String = ""

        Public Property Port As Integer
            Get
                Return _port
            End Get
            Set(value As Integer)
                If (value < 0 Or value > 32767) Then
                    Throw New System.ArgumentOutOfRangeException("Port",
                                                                 "Invalid port number [" + Port.ToString + "].  Valid port ranges are between 1 and 32767 inclusive.")
                Else
                    _port = value
                End If
            End Set
        End Property
        Public Property Host As String
            Get
                Return _host
            End Get
            Set(value As String)
                If String.IsNullOrWhiteSpace(value) Then
                    Throw New System.ArgumentNullException("host",
                                                           "Host name must not be null or whitespace")
                End If
            End Set
        End Property
        Sub New(host As String)
            Me.Host = host
        End Sub
        Sub New(host As String, port As Integer)
            Me.Host = host
            Me.Port = port
        End Sub

        ''' <summary>
        ''' Returns a concatenation of this classes host and port properties as host:port
        ''' </summary>
        ''' <returns></returns>
        Public Function ToString() As String
            Return Me.Host + ":" + Me.Port.ToString
        End Function
    End Class

    Public Class LdapConnection
        Private Property _serverUrl As ServerUrl
        Private Property _useSsl As Boolean = False
        Private Property _protocolVersion As Byte = 3
        Private Property _svrCredintial As NetworkCredential = Nothing
        Private Property _connection As System.DirectoryServices.Protocols.LdapConnection
        Private Property _authType As System.DirectoryServices.Protocols.AuthType
        Public ReadOnly Property Connection As System.DirectoryServices.Protocols.LdapConnection

        ''' <summary>
        ''' Creates an anonymous connection to the specified LDAP server URL
        ''' </summary>
        ''' <param name="ServerUrl"></param>
        ''' <param name="UseSSL"></param>
        ''' <param name="ProtocolVersion"></param>
        Sub New(ServerUrl As ServerUrl,
                Optional UseSSL As Boolean = False,
                Optional ProtocolVersion As Byte = 3)
            _serverUrl = ServerUrl
            _useSsl = UseSSL
            _protocolVersion = ProtocolVersion

        End Sub

        ''' <summary>
        ''' Creates a basic authentication connection to the specified LDAP server URL
        ''' </summary>
        ''' <param name="ServerUrl"></param>
        ''' <param name="UserDN"></param>
        ''' <param name="UserPassword"></param>
        ''' <param name="UseSSL"></param>
        ''' <param name="ProtocolVersion"></param>
        Sub New(ServerUrl As ServerUrl,
                UserDN As String,
                UserPassword As String,
                Optional UseSSL As Boolean = False,
                Optional ProtocolVersion As Byte = 3)
            Me._svrCredintial =
                New NetworkCredential(UserDN, UserPassword)
            _serverUrl = ServerUrl
            _useSsl = UseSSL
            _protocolVersion = ProtocolVersion

        End Sub

        Private Sub CreateConnection()



        End Sub

    End Class


    '    Function getLdapConnection([string]  $ldapHost,
    '                            [int32]  $ldapPort,
    '                            [string] $userDn,
    '                            [string] $password,
    '                            [bool]   $useSSL=$False,
    '                            [int]    $protocolVersion=3)
    '{
    '    # Load the assemblies we need
    '    $null = [System.Reflection.Assembly]LoadWithPartialName('System.DirectoryServices.Protocols')
    '    $null = [System.Reflection.Assembly]:LoadWithPartialName('System.Net')

    '    # Create server URL string
    '    $srvUrl = getServerUrlString $ldapHost $ldapPort

    '    # Instantiate an empty credintial object
    '    $srvCred = New-Object System.Net.NetworkCredential


    '    # Set authtype To anon If userDn Or Password were Not supplied, otherwise use Basic Auth
    '    If ([string]: IsNullOrEmpty($userDn) -Or [string]:IsNullOrEmpty($password)) {
    '        Write-Debug "LDAP -- Using Anonymous Authentication"
    '        $srv = New-Object System.DirectoryServices.Protocols.LdapConnection($srvUrl)
    '        $srv.AuthType = [System.DirectoryServices.Protocols.AuthType]:Anonymous
    '    } else {
    '        Write-Debug "LDAP -- Using Basic Authentication -- UserDN [$userDn]"
    '        $srvCred.UserName = $userDn
    '        $srvCred.Password = $password
    '        $srv = New-Object System.DirectoryServices.Protocols.LdapConnection($srvUrl, $srvCred)
    '        $srv.AuthType = [System.DirectoryServices.Protocols.AuthType]:Basic
    '    }

    '    # Protocol version
    '    $srv.SessionOptions.ProtocolVersion = $protocolVersion
    '    Write-Debug "LDAP -- Using LDAP Protocol Version [$protocolVersion]"

    '    # SSL
    '    $srv.SessionOptions.SecureSocketLayer = $useSSL
    '    Write-Debug "LDAP -- Using SSL [$useSSL]"

    '    Return $srv
    '}


End Namespace
