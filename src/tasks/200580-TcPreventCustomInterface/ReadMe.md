# Basic example of Tab Control. 
- The earlier example is not currently working. The objective is to privent a given tab from closing. 
- So in this example we will impliment a custom interface instead of the prisms IConfirmNavigationRequest.
- The interface has two methods, but only one is needed. You can choose the less complicated. The one with a callback is got from the last example. 
```cs
public interface IAllowCloseTheTab
{
    void CheckCloseTab(Action<bool> continuationCallback);
    bool CheckCloseTab();
}
```
- Here in this interface there are two method, but we need only one. Accordingly the folloing method can be adjusted. 

```cs
private static bool CheckCanRemove(bool canRemove, IAllowCloseTheTab? confirmRequestDataContext)
{
    if (confirmRequestDataContext != null)
    {
        //confirmRequestDataContext.CheckCloseTab(result =>
        //{
        //    canRemove = result;
        //});

        // Use the above or below 
        
        canRemove = confirmRequestDataContext.CheckCloseTab();
    }
    return canRemove;
}
```

