# Ascalon
Ascalon (formerly DebugCore) is a modular, extensible tool providing a system which can create and interact with ConCommands, ConVars.

Ascalon is designed for Unity, but can be run with minimal changes in any C# environment supporting reflections.

## Quick start
Ascalon can be quickly set up by adding it as a submodule to a project, or directly importing it into a Unity/C# project. Examples of how to define ConCommands, ConVars, and ConClasses can be found in `Scripts/StockCommands/BaseCommands.cs`.

To call a ConCommand or ConVar, run `DebugCore.Call("<command> <args>")`.

## Features
- ConCommands
- ConVars
- Command processor
- Networking support
- Flags for access control

## Planned features
- Networking support
    - Default implementations for popular libraries
        - Mirror ✔
        - Photon Bolt
        - Networking for GameObjects
