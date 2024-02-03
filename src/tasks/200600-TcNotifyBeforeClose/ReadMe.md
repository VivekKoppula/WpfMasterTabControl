# Basic example of Tab Control. 
- This builds from the previous example. 
- In this example, a notification, or a method clal will happen when a tab is being closed. 
- INoitifyOnTabClose
```cs
    public interface INoitifyOnTabClose
    {
        void OnTabClose(NavigationContext navigationContext);
    }

```

- In the CloseTabAction class, we are calling the following two methods just before removing. Both are not necessary. Only one is needed.
  
```cs
InvokeOnNavigatedFrom(item, navigationContext);
InvokeOnNavigatedFromCustom(item, navigationContext);
```

- The first one is as exmplained in the course. The second one is by a custom implimentation. 