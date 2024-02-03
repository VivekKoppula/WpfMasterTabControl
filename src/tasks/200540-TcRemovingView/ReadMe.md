# Basic example of Tab Control. 
- We want to remove the views and not the tab items, from the regions.

- Replace the following 

```cs
tabControl.Items.Remove(tabItem.Content);
```
with the following.

```cs
var region = RegionManager.GetObservableRegion(tabControl).Value;
if (region == null)
    return;
if (region.Views.Contains(tabItem.Content))
    region.Remove(tabItem.Content);
```

- Prism automatically will remove the containing element, which in this case is the TabItem from the hosting control