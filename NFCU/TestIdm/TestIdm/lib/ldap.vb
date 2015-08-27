Imports System.DirectoryServices.Protocols
Imports System.Net
Imports NLog

Namespace ldap

    Public Class LdapConnection
        Private Property _dirIdentifier As LdapDirectoryIdentifier
        Private Property _useSsl As Boolean = False
        Private Property _protocolVersion As Byte = 3
        Private Property _dirCredential As NetworkCredential = Nothing
        Private Property _dirConnection As DirectoryServices.Protocols.LdapConnection
        Private Property _authType As AuthType
        Public ReadOnly Property Connection As DirectoryServices.Protocols.LdapConnection

        Private Shared _log As Logger = LogManager.GetCurrentClassLogger()

        ''' <summary>
        ''' Creates an anonymous connection to the specified LDAP server URL
        ''' </summary>
        ''' <param name="Host"></param>
        ''' <param name="Port"></param>
        ''' <param name="UseSSL"></param>
        ''' <param name="ProtocolVersion"></param>
        Sub New(Host As String,
                Port As Integer,
                Optional UseSSL As Boolean = False,
                Optional ProtocolVersion As Byte = 3)

            _log.Debug("Instantiating anonymous LDAP connection -- Host [{0}] -- Port [{1}] -- Use SSL [{2}] -- Protocol Version [{3}]",
                                     Host,
                                     Port,
                                     UseSSL,
                                     ProtocolVersion)
            _dirIdentifier =
                New LdapDirectoryIdentifier(Host, Port)

            _useSsl = UseSSL

            _protocolVersion = ProtocolVersion

            _authType = AuthType.Anonymous
        End Sub

        ''' <summary>
        ''' Creates a basic authentication connection to the specified LDAP server URL
        ''' </summary>
        ''' <param name="Host"></param>
        ''' <param name="Port"></param>
        ''' <param name="UserDN"></param>
        ''' <param name="UserPassword"></param>
        ''' <param name="UseSSL"></param>
        ''' <param name="ProtocolVersion"></param>
        Sub New(Host As String,
                Port As Integer,
                UserDN As String,
                UserPassword As String,
                Optional UseSSL As Boolean = False,
                Optional ProtocolVersion As Byte = 3)

            _log.Debug("Instantiating authenticated LDAP connection -- Host [{0}] -- Port [{1}] -- Use SSL [{2}] -- Protocol Version [{3}] -- User DN [{4}]",
                                     Host,
                                     Port,
                                     UseSSL,
                                     ProtocolVersion,
                                     UserDN)
            _dirIdentifier =
                New LdapDirectoryIdentifier(Host, Port)

            _dirCredential =
                New NetworkCredential(UserDN, UserPassword)

            _useSsl = UseSSL

            _protocolVersion = ProtocolVersion

            _authType = AuthType.Basic
        End Sub

        Private Sub CreateConnection()

            ' Set credential
            Select Case _authType
                Case AuthType.Anonymous
                    _dirConnection = New DirectoryServices.Protocols.LdapConnection(_dirIdentifier)
                Case AuthType.Basic
                    _dirConnection = New DirectoryServices.Protocols.LdapConnection(_dirIdentifier, _dirCredential)
                Case Else
                    Throw New NotImplementedException("Authentication type [" + _authType.ToString() + "] is not supported.")
            End Select

            ' Set connection specific settings
            With _dirConnection
                .AuthType = _authType
                .SessionOptions.ProtocolVersion = _protocolVersion
                .SessionOptions.SecureSocketLayer = _useSsl
            End With

        End Sub

    End Class

End Namespace
