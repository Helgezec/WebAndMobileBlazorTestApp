# WebAndMobileBlazorTestApp

#### The purpose of this application is to test Blazor pages reusability. 
#### Application demonstrates possible architecture for the application that can be developed for Mobile, Desktop and Web simultaneously.


Blazor pages are located in a separate library and are used by the .NET MAUI application (which can be distributed to **Windows**, **iOS** or **Android**) and by the **Blazor Web Assembly** app.
There is also a WebApi server, that is called from `FetchData` page (in a real-world application this can be a way to access a shared database).

### How to run it?
To run a BlazorWASM you can set a `WebAssembly.Server` project as a startup project in Visual Studio.

To run a MAUI application you will need a WebApi server running, or the app won't be able to fetch data to a `FetchData` page. 
In Visual Studio this can be achieved by setting multiple startup project (so, the `Maui` and the `WebAssembly.Server`). 
Default address for the server is `localhost:7169`, which can be changed in a `MauiProgram.cs` file.
If you are on a Windows machine and don't have Android emulators installed, it is easier to run it as a Windows application.

P.S. Sorry, no containers, I just wanted to test a possible architecture. :)
