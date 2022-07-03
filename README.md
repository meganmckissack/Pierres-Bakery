#### By _**Megan McKissack**_

## Description

This is a console application that mimics a simple bakery that allows you to select between two types of baked goods and returns the price based on the bakery's current deals.

## Technologies Used

- _C#_
- _.NET_
- _MSTest_

## Setup/Installation Requirements

- using your terminal, clone or download this repository to your computer
- install the [.NET 5 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/5.0) to have access to the C# language if you don't already have it installed
- you'll also need to install the dotnet script in your terminal using the command `dotnet tool install -g dotnet-script` and configure your bash enviroment variables using the command `echo 'export PATH=$PATH:~/.dotnet/tools' >> ~/.bash_profile` or `echo 'export PATH=$PATH:~/.dotnet/tools' >> ~/.zshrc` if your using zsh instead of bash
- Open files in your favorite text editor or IDE
- cd into the PierresBakery folder and run the command `dotnet restore` to install the necessary packages to run the program
  - repeat this process for the PierresBakery.Tests folder as well to install the necessary testing packages
- To use the application, navigate to the PierresBakery folder and use the command `dotnet run` to start and interact with the application
- To test run unit tests on the application, navigate to the PierresBakery.Tests folder and run the command `dotnet test`

## Known Bugs

_none_

## License

_MIT_

Copyright (c) _July 2, 2022_ _Megan McKissack_
