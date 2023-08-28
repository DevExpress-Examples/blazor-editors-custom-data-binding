Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations

Namespace CustomData.Data.Northwind

    Public Partial Class Employee

        Public Property EmployeeId As Integer

        <Required>
        Public Property LastName As String

        <Required>
        Public Property FirstName As String

        <Required>
        Public Property Title As String

        Public Property TitleOfCourtesy As String

        Public Property BirthDate As Nullable(Of System.DateTime)

        <Required>
        <Range(GetType(DateTime), "1/1/2000", "1/1/2020", ErrorMessage:="HireDate must be between {1:d} and {2:d}")>
        Public Property HireDate As Nullable(Of System.DateTime)

        Public Property Address As String

        Public Property City As String

        Public Property Region As String

        Public Property PostalCode As String

        Public Property Country As String

        Public Property HomePhone As String

        Public Property Extension As String

        Public Property Photo As Byte()

        Public Property Notes As String

        Public Property ReportsTo As Nullable(Of Integer)

        Public Property PhotoPath As String

        Public Overridable Property Orders As ICollection(Of Order)

        Public ReadOnly Property Text As String
            Get
                Return $"{FirstName} {LastName} ({Title})"
            End Get
        End Property

        Public ReadOnly Property ImageFileName As String
            Get
                Return $"Employees/{EmployeeId}.jpg"
            End Get
        End Property
    End Class
End Namespace
