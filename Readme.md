<!-- default file list -->
*Files to look at*:

* [DataModel.cs](./CS/TreeMapHierarchicalDataAdapterSample/DataModel.cs) (VB: [DataModel.vb](./VB/TreeMapHierarchicalDataAdapterSample/DataModel.vb))
* **[MainWindow.xaml](./CS/TreeMapHierarchicalDataAdapterSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/TreeMapHierarchicalDataAdapterSample/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/TreeMapHierarchicalDataAdapterSample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/TreeMapHierarchicalDataAdapterSample/MainWindow.xaml.vb))
<!-- default file list end -->
# How to provide hierarchical data to the Tree Map


This example demonstrates how to provide hierarchical data to the Tree Map. To accomplish this task, use the <strong>Hierarchical Data Adapter</strong>.


<h3>Description</h3>

To provide data using the Hierarchical Data Adapter, do the following.<br />Assign a newly created <strong>TreeMapHierarchicalDataAdapter</strong> object to the <strong>TreeMapControl.DataAdapter</strong> property. Then, specify the <strong>DataSource</strong> and <strong>ValueDataMember</strong> properties of the adapter.<br />Finally, build implicit Data Templates for your data types.

<br/>


