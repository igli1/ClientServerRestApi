# Client-Server REST API Application

This repository contains a simple client-server REST API application built with .NET. The server exposes an API endpoint to handle incoming log data, and the client sends log messages to the server.

---

## Prerequisites

- .NET SDK 8.0 installed on your machine.

---

## Configuration

Before running the client, ensure the server URL is correctly configured in the client application.

### Server URL Configuration
1. Open the `Program.cs` file in the **Client** project.
2. Locate the following line:
   ```csharp
   var serverUrl = "http://localhost:5001/api/Log/Post";
