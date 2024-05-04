# Devexv's IP locator

## Overview
The IP Locator is a console application written in C# that allows users to input an IP address and retrieves its geolocation information using the IPInfo.io API. It displays details such as city, region, country, coordinates, postal code, and ASN (Autonomous System Number). Additionally, it provides a Google Maps link for the exact location.

## Prerequisites
- .NET Core SDK
- Newtonsoft.Json package (installed via NuGet)

## Usage
1. Clone the repository to your local machine.
2. Open the solution in your preferred C# IDE.
3. Build the solution to restore dependencies.
4. Run the application.
5. Enter the target IP address when prompted.
6. The application will fetch and display the geolocation information.
7. Press any key to close the application.

## Dependencies
- Newtonsoft.Json: This library is used for deserializing JSON responses from the IPInfo.io API.

## Notes
- This application utilizes the IPInfo.io API to retrieve geolocation information. Ensure you have a stable internet connection to fetch the data.
- Error handling is implemented to handle cases where the IP address is invalid or the API request fails.

# Made with C# 12 .NET 8.0

# The owner doesn't take any responsibility

### If you are aware of virus you can check it through dnSpy : https://github.com/dnSpy/dnSpy/releases/tag/v6.1.8

[![NuGet version (Newtonsoft.Json)](https://img.shields.io/nuget/v/Newtonsoft.Json.svg?style=flat-square)](https://www.nuget.org/packages/Newtonsoft.Json/)
[![Build status](https://dev.azure.com/jamesnk/Public/_apis/build/status/JamesNK.Newtonsoft.Json?branchName=master)](https://dev.azure.com/jamesnk/Public/_build/latest?definitionId=8)

Json.NET is a popular high-performance JSON framework for .NET

## Serialize JSON

```csharp
Product product = new Product();
product.Name = "Apple";
product.Expiry = new DateTime(2008, 12, 28);
product.Sizes = new string[] { "Small" };

string json = JsonConvert.SerializeObject(product);
// {
//   "Name": "Apple",
//   "Expiry": "2008-12-28T00:00:00",
//   "Sizes": [
//     "Small"
//   ]
// }
```

## Deserialize JSON

```csharp
string json = @"{
  'Name': 'Bad Boys',
  'ReleaseDate': '1995-4-7T00:00:00',
  'Genres': [
    'Action',
    'Comedy'
  ]
}";

Movie m = JsonConvert.DeserializeObject<Movie>(json);

string name = m.Name;
// Bad Boys
```

## LINQ to JSON

```csharp
JArray array = new JArray();
array.Add("Manual text");
array.Add(new DateTime(2000, 5, 23));

JObject o = new JObject();
o["MyArray"] = array;

string json = o.ToString();
// {
//   "MyArray": [
//     "Manual text",
//     "2000-05-23T00:00:00"
//   ]
// }
```

## Links

- [Homepage](https://www.newtonsoft.com/json)
- [Documentation](https://www.newtonsoft.com/json/help)
- [NuGet Package](https://www.nuget.org/packages/Newtonsoft.Json)
- [Release Notes](https://github.com/JamesNK/Newtonsoft.Json/releases)
- [Contributing Guidelines](https://github.com/JamesNK/Newtonsoft.Json/blob/master/CONTRIBUTING.md)
- [License](https://github.com/JamesNK/Newtonsoft.Json/blob/master/LICENSE.md)
- [Stack Overflow](https://stackoverflow.com/questions/tagged/json.net)

## This tool might not be correct, it only counts the ip not the router.
