# GenericEventArgs
Lightweight implementation of generic EventArgs

### How to install

[NuGet Package](https://www.nuget.org/packages/CynCeyd.GenericEventArgs/)

You can pull the NuGet package using 

```
Install-Package CynCeyd.GenericEventArgs
```

or alternatively using the dotnet cli

```
dotnet add package CynCeyd.GenericEventArgs --version 1.0.1
```

### EventArgs<TEventData> and ReadOnlyEventArgs<TEventData>
To create a simple generic EventArgs<TEventData>, define an event like so:

```csharp
public EventHandler<EventArgs<Foo>> Bar;
```

When raising the event:

```csharp

protected void RaiseBar(){
  OnBar(new EventArgs<Foo>(new Foo()));
}

protected virtual void OnBar(EventArgs<Foo> e){
  Bar?.Invoke(this, e);
}

```

Please notice that EventArgs<TEventData>s property Data has both public getters and setters. 

If you prefer an immutable version use ReadOnlyEventArgs<TEventData>. The procedure is identical, except for the protected setter for the Data property.

### CancelEventArgs<TEventData> and ReadOnlyCancelEventArgs<TEventData>

There is also an implementation of the generic EventArgs that is cancelable. It adds the Property Cancel to the EventArgs and may be processes according to your requirements.

### Interfaces

Depending on your needs, you might want to implement the underlying interfaces by yourself:

IEventArgs<TEventData> contains 
  
```csharp 
TEventData Data { get; set; } 
```

IReadOnlyEventArgs<TEventData> contains 
```csharp 
TEventData Data { get; }   
```
  
ICancelEventArgs<TEventData> contains 
```csharp 
bool Cancel { get; set; } 
```
