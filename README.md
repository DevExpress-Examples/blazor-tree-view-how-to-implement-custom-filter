
# Blazor TreeView – How to implement custom filter

This example shows how to implement a custom filter that reacts to the  TreeViewNode’s Text when it is split by a comma and applies custom highlighting.

![](data:image/png;base64,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)

The filter accepts the [NavigationFilterInfo](http://docs.devexpress.com/Blazor/DevExpress.Blazor.NavigationFilterInfo) structure to obtain the [FilterString](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView.FilterString) value and uses a regular expression to parse the filter string. The [NodeTextTemplate](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView.NodeTextTemplate) uses a regular expression to apply custom highlighting.

<!-- default file list -->

## Files to Look At

Index.razor

<!-- default file list end -->

## Documentation

[TreeView – Search](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView#filter-nodes)