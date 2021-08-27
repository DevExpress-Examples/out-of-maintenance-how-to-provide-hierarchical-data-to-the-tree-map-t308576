<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128572110/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T308576)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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


