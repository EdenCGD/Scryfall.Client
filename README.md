# Scryfall Client
![NuGet Version](https://img.shields.io/nuget/v/Scryfall.Client)

Scryfall Client is an unofficial .NET library for communicating with the Scryfall API.
This project started as fork of ScryfallAPI.Client by Gonkers.

## Getting Started

## .NET Core Instructions
### Add a service definition to your `startup.cs` file's `ConfigureServices` method.
```c#
services.AddHttpClient<ScryfallApiClient>(client =>
{
    client.BaseAddress = new Uri("https://api.scryfall.com/");
    client.DefaultRequestHeaders.Add("User-Agent", "ScryfallClient/3.0.1");
});
```
Remember to change the user agent value to something that represents your project.
### Add a `ScryfallApiClient` parameter and member to your Controller or Razor Page
```c#
ScryfallApiClient _scryfallApi { get; }

public IndexModel(ScryfallApiClient scryfallApi)
{
    _scryfallApi = scryfallApi ?? throw new ArgumentNullException(nameof(scryfallApi));
}
```
### Use the client
```c#
var randomCard = await _scryfallApi.Cards.GetRandom();
```
