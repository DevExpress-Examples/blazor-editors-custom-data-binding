Imports DevExtreme.AspNet.Data
Imports DevExtreme.AspNet.Mvc
Imports Microsoft.AspNetCore.Mvc
Imports CustomData.Data.Northwind

Namespace CustomData.Data

    <Route("api /[controller] /[action]")>
    Public Class DataGridWebApiController
        Inherits Controller

        Private _nwind As NorthwindContext

        <HttpGet>
        Public Function CustomersLookup(ByVal loadOptions As DataSourceLoadOptions) As Object
            Dim lookup = From i In _nwind.Customers Let text = i.CompanyName & " (" + i.Country & ")" Order By i.CompanyName Select New With {.Value = i.CustomerId, text}
            Return DataSourceLoader.Load(lookup, loadOptions)
        End Function
    ' ...
    End Class
End Namespace
