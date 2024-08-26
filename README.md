# HyperBackend
```
dotnet ef migrations add firstMig
dotnet ef database update
dotnet run
```

<img src="https://github.com/user-attachments/assets/c3671907-988b-4500-8f1a-5b0286b9e808" alt="Swagger" title="Swagger">

## ❤️ What We are Building

- [x] 🌟Create a ASP.NET Core Web API project.

- [x] 🌟 The user should have access to a repository of **cars**, **boats**, and **buses** with different colors(red, blue, black, white).
- [x] 🌟 The car should be a **vehicle** (base class).
- [x] 🌟 A vehicle can have a color and buses and boats can be a vehicle.
- [x] 🌟 The car should have **wheels** and **headlights**.

- [x] 🌟 [GET] User should be able to select cars **by color**.
- [x] 🌟 [GET] User should be able to select buses **by color**.
- [x] 🌟 [GET] User should be able to select boats **by color**.
- [x] 🌟 [POST] User should be able to **turn on/off headlights of the car by car’s ID**.
- [x] 🌟 [DELETE] User should be able to delete the car. 


### .NET CLI
> * The Visual Studio Code instructions use the .NET CLI for ASP.NET Core development functions such as project creation.
```
- dotnet new sln --name HyperBackendSln
- dotnet new webapi --name HyperBackend
- dotnet sln add HyperBackend\HyperBackend.csproj
```
> * The project template creates a WeatherForecast API with support for Swagger.
> * Trust the HTTPS development certificate by running the following command:
```
- dotnet dev-certs https --clean
- dotnet dev-certs https --trust
%APPDATA%\Microsoft\UserSecrets
```
> * Run the following command to start the app on the https profile:
```
- dotnet run --launch-profile https
```
> * The output shows messages similar to the following, indicating that the app is running and awaiting requests:
```
...
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: https://localhost:{port}
...
```
> * Ctrl+click the HTTPS URL in the output to test the web app in a browser.
> * The default browser is launched to **https://localhost:<port>/swagger/index.html**, where <port> is the randomly chosen port number displayed in the output.
> * There's no endpoint at https://localhost:<port>, so the browser returns **HTTP 404 Not Found**. Append **/swagger** to the URL, https://localhost:<port>/swagger.
```
https://localhost:<port>/swagger/index.html

OR

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    //app.UseSwaggerUI();
    app.UseSwaggerUI(options => {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}
```
> * After testing the web app in the following instruction, press Ctrl+C in the integrated terminal to shut it down.


```
dotnet add package Microsoft.EntityFrameworkCore --version 6.0.33
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.33
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0.33
dotnet add package AutoMapper --version 11.0.1

dotnet tool install --global dotnet-ef --version 6.*
dotnet restore
dotnet ef migrations add firstMig
dotnet ef database update
```