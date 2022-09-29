<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1094678)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Blazor TreeView – How to implement custom filter

This example shows how to implement a custom filter that reacts to the  TreeViewNode’s Text when it is split by a comma and applies custom highlighting.

 ![](CS/TreeViewCustomFilter/image.png)
 
The filter accepts the [NavigationFilterInfo](http://docs.devexpress.com/Blazor/DevExpress.Blazor.NavigationFilterInfo) structure to obtain the [FilterString](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView.FilterString) value and uses a regular expression to parse the filter string. The [NodeTextTemplate](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView.NodeTextTemplate) uses a regular expression to apply custom highlighting.

<!-- default file list -->

## Files to Look At

[Index.razor](CS/TreeViewCustomFilter/Pages/Index.razor)

<!-- default file list end -->

## Documentation

[TreeView - Filter Nodes](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView#filter-nodes)
