Imports DevExtreme.AspNet.Data.ResponseModel
Imports Microsoft.AspNetCore.Components
Imports System.Text.Json
Imports DevExtreme.AspNet.Data
Imports DevExpress.Blazor

Namespace CustomData.Data

    Public Class WebApiLookup

        Public Property Text As String

        Public Property Value As String
    End Class

    Public Module CustomDataHelper

        Public Async Function LoadCustomData(ByVal client As HttpClient, ByVal options As DataSourceLoadOptionsBase, ByVal cancellationToken As CancellationToken) As Task(Of LoadResult)
            Dim response = Await client.GetAsync(options.ConvertToGetRequestUri("https://js.devexpress.com/Demos/NetCore/api/DataGridWebApi/CustomersLookup"), cancellationToken)
            response.EnsureSuccessStatusCode()
            Dim responseStream = Await response.Content.ReadAsStreamAsync()
            Return Await JsonSerializer.DeserializeAsync(Of LoadResult)(responseStream, cancellationToken:=cancellationToken)
        End Function
    End Module
End Namespace
