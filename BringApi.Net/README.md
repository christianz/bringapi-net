# printnode-net
A C# library for communicating with the PrintNode API

## Getting started
Some of the methods described below require you to define a client Url that points to the app or service you're calling Bring from.

## Get information for a specific postal code
```csharp
var postalCodeService = new BringPostalCodeService();

var result = await postalCodeService.GetPostalCode("http://my.website.com", "3616"); // Default country is Norway

Console.WriteLine(result.Result);
```

`KONGSBERG`

```csharp
var result = await postalCodeService.GetPostalCode("http://my.website.com", "2412", BringCountry.Denmark);

Console.WriteLine(result.Result);
```

`København NV`

