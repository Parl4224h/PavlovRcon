# PavlovRcon

`PavlovRcon` is a .NET client library for controlling a Pavlov VR server through RCON.

## Installation

```bash
dotnet add package PavlovRcon
```

## Usage

```csharp
using PavlovRcon.Config;
using PavlovRcon.RconClient;

var connection = new RconConnectionInfo(
    Host: "127.0.0.1",
    Port: 9100,
    Password: "your-rcon-password");

await using var client = new RconClient(connection);
await client.ConnectAsync();

var serverInfo = await client.ServerInfo();
```

The client supports connection management, command timeouts, and extension methods for the Pavlov RCON command set. See the `Commands`, `Responses`, and `GameData` namespaces for the available commands and types.

## Requirements

- .NET 10 or later
- A reachable Pavlov server with RCON enabled

## License

This project is licensed under the [MIT License](LICENSE).
