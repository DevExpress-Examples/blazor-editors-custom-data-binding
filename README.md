# Data Editors for Blazor - Custom data binding

This example demonstrates how to bind DevExpress Blazor [ListBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2), [ComboBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2), and [TagBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2) to a remote Web API service and use the `CustomData` property to implement custom data load logic.

![Data Editors - Custom data binding](CustomData.gif)

## Overview

To bind an editor to data stored on a remote service and loaded through a Web Api, complete the following steps:

1. Add a reference to the [DevExtreme.AspNet.Data](https://github.com/DevExpress/DevExtreme.AspNet.Data/blob/master/README.md) library to your project.

2. Assign the data type to a component's `T` parameter.

3. Use a component's `CustomData` property to implement an ansynchronous function. This function returns a [Task\<LoadResult>](https://devexpress.github.io/DevExtreme.AspNet.Data/net/api/DevExtreme.AspNet.Data.ResponseModel.LoadResult.html) object and accepts the following parameteres:

    * The [DataSourceLoadOptionBase](https://devexpress.github.io/DevExtreme.AspNet.Data/net/api/DevExtreme.AspNet.Data.DataSourceLoadOptionsBase.html) object.
    * The [CalcellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken?view=net-7.0) object.

4. On a remote service, implement an [API controller](https://docs.devexpress.com/AspNetCore/401020/devextreme-based-controls/concepts/bind-controls-to-data/api-controllers) and create a `LoadResult` object based on load options.


## Files to Review

- [ListBox.razor](CS/CustomData/Shared/ListBox.razor)
- [ComboBox.razor](CS/CustomData/Shared/ComboBox.razor)
- [TagBox.razor](CS/CustomData/Shared/TagBox.razor)
- [WebApiLookup.cs](CS/CustomData/Data/WebApiLookup.cs)
- [Program.cs](CS/CustomData/Program.cs)

## Documentation

### ListBox

- [Bind to Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2#bind-to-data)
- [CustomData](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2.CustomData)

### ComboBox

- [Bind to Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2#bind-to-data)
- [CustomData](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2.CustomData)

### TagBox

- [Bind to Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2#bind-to-data)
- [CustomData](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2.CustomData)
