# _Rock, Paper, Scissors_

#### _C# Testing practice for Epicodus_, _Mar. 4, 2020_

#### By _**Michelle Morin**_

## Description

_This application allows two players to play rock, paper, scissors. Each player selects "rock", "paper", or "scissors" at the same time, and the application returns the result of the game. Rock, paper, scissors has the following rules:_
* _Rock v. scissors = rock wins_
* _Rock v. paper = paper wins_
* _Paper v. scissors = scissors wins_
* _When both players choose the same object, the game is a draw_

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
| Application returns that game is a draw if both inputs are the same | game.CheckWin("rock", "rock") | "It's a draw!" |
| When one input is "rock" and another input is "scissors", the application returns the player who chose rock as the winner | "rock", "scissors" | "Player 1" |
| When one input is "scissors" and the other input is "paper", the application returns the player who chose scissors as the winner | "scissors", "paper" | "Player 1" |
| When one input is "rock" and the other input is "paper", the application returns the player who chose paper as the winner | "rock", "paper" | "Player 2" |

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone`` followed by the URL to this repository.
* ``cd`` followed by the repository name.

_Confirm that you have navigated to the correct directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Run this console application by entering the following command in Terminal (macOS) or PowerShell (Windows):_
* ``dotnet run``

_To view/edit the source code of this application, open the contents of this directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

## Technologies Used
* _Git_
* _C#_
* _.NET Core 2.2_
* _dotnet script_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Michelle Morin, Eric Settels_**