# SwiftlyS2

[![License: GPL v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![Build Status](https://img.shields.io/github/actions/workflow/status/swiftly-solution/swiftlys2/build.yml?branch=master)](https://github.com/swiftly-solution/swiftlys2/actions)
[![Discord](https://img.shields.io/discord/1178027657594687608?color=7289da&logo=discord&logoColor=white)](https://swiftlys2.net/discord)

SwiftlyS2 is a powerful scripting framework for Source 2 games, built in C++ with C# plugin support. It provides developers with a comprehensive API to create plugins and extensions for Source 2-based games like Counter-Strike 2.

> [!warning]
> The framework is still under development.

## Features

- **C# Plugin Development**: Write plugins in C# with full .NET support
- **Comprehensive API**: Access to game events, player management, and server control
- **High Performance**: Native C++ core with optimized plugin execution
- **Memory Safety**: Built-in memory management and thread-safe operations
- **Hot Reload**: Reload plugins without restarting the server
- **Cross-Platform**: Supports Windows and Linux
- **Source 2 Ready**: Designed specifically for Source 2 engine games

## Supported Games

- **Counter-Strike 2**

## Quick Start

### Prerequisites

- **Windows**: Visual Studio 2022 with C++ and .NET workloads
- **Linux**: GCC 11+ and .NET 8.0 SDK
- **XMake**

### Building SwiftlyS2

1. **Clone the repository**
   ```bash
   git clone --recurse-submodules https://github.com/swiftly-solution/swiftlys2.git
   cd swiftlys2
   ```

2. **Build the framework**
   ```bash
   # Windows
   xmake -j 4
   
   # Linux
   xmake -j $(nproc)
   ```

3. **Install to game directory**
   ```bash
   # Copy built files to your CS2 server
   cp -r build/package/* /path/to/cs2/game/csgo/
   ```

4. **Start your server**

### Your First Plugin

Create a simple "Hello World" plugin:

```csharp
using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Shared.Plugins;
using SwiftlyS2.Shared;

namespace SwiftlyS2.Plugin;

public partial class PluginClassName : BasePlugin {

  public PluginClassName(ISwiftlyCore core): base(core) {
    
  }

  public override void ConfigureSharedServices(IServiceCollection sharedServices) {
  }

  public override void UseSharedServices(IServiceProvider sharedProvider) {
  }

  public override void Load(bool hotReload)
  {
    Console.WriteLine("Hello World!!");
    // Check examples folder for more information. Don't forget to delete the folder after reading.
  }

  public override void Unload() {
  }
} 
```

## Architecture

```
SwiftlyS2/
├── src/                         # C++ core framework
│   ├── api/                     # C++ API interfaces
│   ├── core/                    # Core framework logic
│   ├── engine/                  # Source 2 engine integration
│   ├── memory/                  # Memory management
│   ├── monitor/                 # Loggers
│   ├── network/                 # Network handling
│   ├── scripting/               # Native Exports
│   ├── sdk/                     # SDK Dumper
│   └── server/                  # Server management
├── managed/                     # C# managed layer
│   └── src/                     # C++ core framework
│       ├── api/                 # C++ API interfaces
│       ├── SwiftlyS2.Core/      # Core C# APIs
│       ├── SwiftlyS2.Generated/ # Generated bindings
│       └── SwiftlyS2.Shared/    # Shared utilities
├── natives/                     # Native definitions
├── generator/                   # Code generation tools
└── vendor/                      # Third-party dependencies
```

## License

This project is licensed under the GNU General Public License v3.0 - see the [LICENSE](LICENSE) file for details.

## Community

- **Discord**: [Join our community](https://swiftlys2.net/discord)
- **Issues**: [Report bugs and request features](https://github.com/swiftly-solution/swiftlys2/issues)

## Acknowledgments

- [Metamod:Source](https://github.com/alliedmodders/metamod-source) - Plugin architecture inspiration
- [HL2SDK](https://github.com/alliedmodders/hl2sdk) - Source engine integration
- All our [contributors](https://github.com/swiftly-solution/swiftlys2/graphs/contributors)

---

<div align="center">
  <strong>Made with ❤️ by the Swiftly Development team</strong>
</div>
