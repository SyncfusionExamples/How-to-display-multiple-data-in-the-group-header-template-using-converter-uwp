# How to display multiple data in the group header template using converter?
This example demonstrates how to display different labels and images in the group header template. The approach uses converters to interpret the group context so that each header can present concise, meaningful information drawn from the grouped items.

See [How to display multiple data in the group header template using converter](https://www.syncfusion.com/kb/9491/how-to-display-multiple-data-in-the-group-header-template-using-converter) for more details.

## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing a “path too long” exception when building this example project, close Visual Studio and rename the repository to a shorter name, then open the solution and build the project again.

## What this sample illustrates ##
- Displaying multiple pieces of data (for example, a primary label and a secondary label) inside each group header without expanding the group.
- Using IValueConverter to extract values from the group context (GroupResult) and turn them into user-friendly text or image sources.
- Surfacing both the grouping key and an additional descriptive value from the first item in the group, enabling clear and compact summaries at the header level.
- Optionally showing a small image or icon per group to reinforce meaning visually while keeping the layout compact.

