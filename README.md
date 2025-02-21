

# Chess Library: Chess960 Addition

This branch adds Chess960 support to the C# Chess Library

## Features

- Can choose between Class Chess PvP and Chess960 PvP

## Getting Started

Here is how to get started: 

1. Clone the repository
2. Open the solution file in Visual Studio
3. Build and run sample applications

## Sample Applications

### Console Application

The console application provides a simple interface for playing between two players. You simply have to enter your move in the prompt and if it is valid, the game state will be printed out onto the CLI window.

### Windows Forms Application

This application provides a more fully-featured interface for demonstrating the chess library in a windows desktop app:
- Classic Chess PvP: Control both players and test the functionality of a full chess match with reset and undo capabilities
- Chess960 PvP: Control both players and test the functionality of a full chess960 match with reset and undo capabilities
- Host Server: Host a UDP classic chess server on you local machine on a custom port, upon starting the server a client interface is automatically connected to it.
- Join Server: Join a UDP classic chess server by entering a host's IP and port number

## Contributing

If you would like to contribute, feel free to open an issue or pull request to the original repository. 
https://github.com/ruskpr/chess
