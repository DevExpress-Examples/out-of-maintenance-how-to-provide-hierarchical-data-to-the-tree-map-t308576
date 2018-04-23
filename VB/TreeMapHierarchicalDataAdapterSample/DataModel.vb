Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace TreeMapHierarchicalDataAdapterSample
    Public Class Country
        Public Property Name() As String
        Public Property Gdp() As Double
    End Class

    Public Class SideOfWorld
        Public Property Name() As String


        Private countries_Renamed As New List(Of Country)()
        Public ReadOnly Property Countries() As List(Of Country)
            Get
                Return countries_Renamed
            End Get
        End Property
    End Class
End Namespace
