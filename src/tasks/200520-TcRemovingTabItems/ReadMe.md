# Basic example of Tab Control. 
- After Adding a close button to the tabs, we need to remove items from the tabs when the x button is clicked. 
- Create a TriggerAction to attach to this button, so when the button is clicked, we can run code to remove the TabItem from the TabControl. So the first thing we to do is make sure you add a reference to System. Windows. Interactivity, because this is where the TriggerAction lives. So we're going to add a new class, I'm going to call it the CloseTabAction, and then it's going to derive from TriggerAction of T, T being the button.

- Add a CloseTabAction class.

- Attach this action to the button click event.

```xml
<Button Grid.Column="1" Content="x">
    <i:Interaction.Triggers>
        <i:EventTrigger EventName="Click">
            <local:CloseTabAction/>
        </i:EventTrigger>
    </i:Interaction.Triggers>
</Button>
```

- Add the necessary namespaces as well. 

```xml
xmlns:i="http://schemas.microsoft.com/expression/2010/interactivity"
xmlns:local="clr-namespace:SimplePrismShell"
xmlns:localViews="clr-namespace:SimplePrismShell.Views"
```

- Now run the app and observe. 
- There is a problem here.
  - 1. Click Navigate A or Navigate B buttons a few times. 
  - 2. Close a few tabs from the newly added tabs on the tab control.
  - 3. Now click again the Navigate A or Navigate B buttons a few times.
  - 4. This time notive that new tabs are not added to the tab control.
- In this example, we saw how we can remove TabItems from the TabControl, and there is a problem. This is because when we're using Prism to inject views, we're injecting those views into a region, which is contained within a region manager. So what we have to solve, the next problem, is removing the views from the regions themselves. If we just remove the TabItem from the TabControl, those views still exist in the region, and therefore you may be thinking you're removing those views, but you're not, they're still in memory, still using resources so you have a memory leak. 
- Step a head to the next example.

