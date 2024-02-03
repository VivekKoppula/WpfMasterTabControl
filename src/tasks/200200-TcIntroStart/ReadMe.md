# Intro Tab control.
- This is a basic start example from which other tab examples will be built.
- The shell window has two buttons and a tab controls.
- The SimplePrismShell.Core has a ViewModelBase which has a Title property. ViewModelBase will be the base class for all the view models.
- The two views are registered with the container in ModuleAModule.cs

```cs
public void RegisterTypes(IContainerRegistry containerRegistry)
{
    containerRegistry.Register<ViewA>();
    containerRegistry.Register<ViewB>();
}
```
- Also a bootstrapper is configured.