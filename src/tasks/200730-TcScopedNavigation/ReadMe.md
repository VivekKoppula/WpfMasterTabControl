# Basic example of Tab Control. 
- This builds from the previous example. 
- The previous example demonistrates an exception that can occur. This example provides a solution to avoid such an exception.
- For each tab that is added to the tab control, a new view is added whtich has a region. Now each view should get its own region manager. So for that we do the following.

- Create a new interface like this.

```cs
public interface ICreateRegionManagerScope
{
    bool CreateRegionManagerScope { get; }
}
```    

- NExt we add a new class called ScopedRegionNavigationContentLoader and this is a [modified class from here](https://github.com/PrismLibrary/Prism/blob/master/src/Wpf/Prism.Wpf/Regions/RegionNavigationContentLoader.cs).
- Some of the modifications we have to do are as follows.



```cs
protected virtual void AddViewToRegion(IRegion region, object view)
{
    region.Add(view, null, CreateRegionManagerScope(view));
}
private bool CreateRegionManagerScope(object view)
{
    bool createRegionManagerScope = false;
    var viewHasScopedRegions = view as ICreateRegionManagerScope;
    if (viewHasScopedRegions != null)
        createRegionManagerScope = viewHasScopedRegions.CreateRegionManagerScope;
    return createRegionManagerScope;
}
private void AutowireViewModel(object viewOrViewModel)
{
    if (viewOrViewModel is FrameworkElement view && view.DataContext is null && ViewModelLocator.GetAutoWireViewModel(view) is null)
    {
        ViewModelLocator.SetAutoWireViewModel(view, true);
    }
}
```
- Next register this new class as follows in the bootstraper class.

```cs
protected override void RegisterTypes(IContainerRegistry containerRegistry)
{
    containerRegistry.RegisterSingleton<IRegionNavigationContentLoader, ScopedRegionNavigationContentLoader>();
}
```

- Finally impliment the interface to a view that has a region in it and which needs its own instance of region manager when ever a new view is created.

```cs
public partial class ViewA : UserControl, ICreateRegionManagerScope
{
    public bool CreateRegionManagerScope
    {
        get { return true; }
    }
}
```
- Now run the app. 
- Now each ViewA will get its own new region manager. But there is a problem. It is as follows.
- Each time a new instance of ViewA is created and injected into the tab control, a new region manage is created. 
- But if you observe the views corresponding view model, ViewAViewModel, it has a dependency on region manager. And this region manager is supplied to this ViewAViewModel object via ctor injection. 
- But the issue here is, the injected region is global one and not the newly crated region manager. So when you click the button on View A, it should create a new view B, but it does not. The global region manager does not have region by name ChildRegion. The global region manager has a region by name TabRegion. So it fails. This is fixed in the next example.
- If you want to check, just change the region name in ViewAViewModel to TabRegion from ChildRegion as follows.
```cs
private void Navigate(string navigationPath)
{
    _regionManager.RequestNavigate("ChildRegion", navigationPath);
}
```
to 
```cs
private void Navigate(string navigationPath)
{
    _regionManager.RequestNavigate("TabRegion", navigationPath);
}
```
- Now run the app again and click the button in View A
- So in summary what we need is access to scoped region manager in ViewAViewModel and not the global one. This will be delt with in the next example.
- 
