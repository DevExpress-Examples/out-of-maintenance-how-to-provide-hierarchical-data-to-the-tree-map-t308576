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

'INSTANT VB NOTE: The field countries was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private countries_Conflict As New List(Of Country)()
		Public ReadOnly Property Countries() As List(Of Country)
			Get
				Return countries_Conflict
			End Get
		End Property
	End Class
End Namespace
