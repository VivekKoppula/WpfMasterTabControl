# Basic example of Tab Control. 
- Adding a close button to the tabs. 
- Set a header template as follows for the shell window. We are simply using existing wpf templating functionality

```xml
<Setter Property="HeaderTemplate">
    <Setter.Value>
        <DataTemplate>
            <Grid>
                <Grid.ColumnDefinitions>
                    <ColumnDefinition />
                    <ColumnDefinition />
                </Grid.ColumnDefinitions>
                <ContentControl VerticalAlignment="Center" HorizontalAlignment="Center"
                                Margin="0,0,7,0" Content="{Binding}"/>
                <Button Grid.Column="1" Content="x"/>
            </Grid>
        </DataTemplate>
    </Setter.Value>
</Setter>
```


- Now run the app and observe. 
