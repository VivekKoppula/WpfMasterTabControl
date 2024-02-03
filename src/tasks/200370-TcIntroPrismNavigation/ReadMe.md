# Basic example of Tab Control. 
- How to add view to a tab in a tab control.
- The final approach is to use Prism Navigation feature. This is simple and best approach. The problems discussed for ealire example no longer exist.

```cs
void Navigate(string navigationPath)
{
    _regionManager.RequestNavigate("TabRegion", navigationPath);
}
```

- Also take note of the following RegisterTypes in the ModuleAModule class. Earlier it was Register, now its RegisterForNavigation method.

```cs
public void RegisterTypes(IContainerRegistry containerRegistry)
{
    containerRegistry.RegisterForNavigation<ViewA>();
    containerRegistry.RegisterForNavigation<ViewB>();
    //containerRegistry.Register<ViewB>();
}
```

- Now run the app.