Imports System.Collections.Generic
Imports System.Windows

Namespace TreeMapHierarchicalDataAdapterSample
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            DataContext = PopulateData()
        End Sub

        Private Function PopulateData() As List(Of SideOfWorld)
            Dim worldSides As New List(Of SideOfWorld)()

            Dim americas As SideOfWorld = New SideOfWorld With {.Name = "Americas"}
            worldSides.Add(americas)
            americas.Countries.Add(New Country With {.Name = "United States", .Gdp = 11.384})
            americas.Countries.Add(New Country With {.Name = "United Brazil", .Gdp = 1.799})
            americas.Countries.Add(New Country With {.Name = "United States", .Gdp = 1.572})

            Dim europe As SideOfWorld = New SideOfWorld With {.Name = "Europe"}
            worldSides.Add(europe)
            europe.Countries.Add(New Country With {.Name = "Germany", .Gdp = 3.371})
            europe.Countries.Add(New Country With {.Name = "United Kingdom", .Gdp = 2.582})
            europe.Countries.Add(New Country With {.Name = "France", .Gdp = 2.422})
            europe.Countries.Add(New Country With {.Name = "Italy", .Gdp = 1.809})

            Dim asia As SideOfWorld = New SideOfWorld With {.Name = "Asia"}
            worldSides.Add(asia)
            asia.Countries.Add(New Country With {.Name = "China", .Gdp = 17.968})
            asia.Countries.Add(New Country With {.Name = "Japan", .Gdp = 4.116})
            asia.Countries.Add(New Country With {.Name = "India", .Gdp = 2.864})

            Return worldSides
        End Function
    End Class
End Namespace