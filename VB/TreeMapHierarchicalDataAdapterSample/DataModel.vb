Imports System.Collections.Generic

Namespace TreeMapHierarchicalDataAdapterSample

    Public Class Country

        Public Property Name As String

        Public Property Gdp As Double
    End Class

    Public Class SideOfWorld

        Public Property Name As String

        Private countriesField As List(Of Country) = New List(Of Country)()

        Public ReadOnly Property Countries As List(Of Country)
            Get
                Return countriesField
            End Get
        End Property
    End Class
End Namespace
