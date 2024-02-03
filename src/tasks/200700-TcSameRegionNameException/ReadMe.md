# Basic example of Tab Control. 
- This builds from the previous example. 
- This is to demonistrate an exception that can occur. The solution to how to avoid such an exception will be shown in a subsequent example.
- Launch the app using Visual Studio 2022. When you click Navigate A button multiple times you get this exception.

> ArgumentException: Region with the given name is already registered: ChildRegion.

- The region manager has a regions collection. The names of the regions in this collection must be unique.
- View A has a region with name Child Region. 
- When the tab control is injected with multiple tabs of View A, then it means multiple regions with same name ChildRegion. This leads to the exception.
- Take a look at other [example here](https://github.com/AvtsVivek/PrismMultipleShells/tree/main/src/apps/200200-DuplicateRegionException). And the [explanation here](https://github.com/AvtsVivek/PrismMultipleShells/tree/main/src/tasks/200200-DuplicateRegionException) 