Imports <xmlns="http://servers">

Namespace Xml
    Public Class Servers
        Private Property ServersDoc As XDocument =
            XDocument.Load("Servers.xml")

        Private _environments As List(Of String) =
            New List(Of String)

        Public ReadOnly Property Environments As List(Of String)
            Get
                If _environments.Count = 0 Then
                    Dim envs = From env In ServersDoc...<environment>
                               Select env.@name
                    For Each env In envs
                        _environments.Add(env.ToString)
                    Next
                    _environments.Sort()
                End If
                Return _environments
            End Get
        End Property


        Sub New()

        End Sub
    End Class
End Namespace
