using Microsoft.Extensions.Logging;
using Spectre.Console;
using SwiftlyS2.Core.Plugins;
using SwiftlyS2.Shared;
using SwiftlyS2.Shared.Commands;

namespace SwiftlyS2.Core.Services;

internal class CoreCommandService {
  private ILogger<CoreCommandService> _Logger { get; init; }

  private ICommandService _CommandService { get; init; }
  private PluginManager _PluginManager { get; init; }
  private ProfileService _ProfileService { get; init; }

  public CoreCommandService(ILogger<CoreCommandService> logger, ISwiftlyCore core, PluginManager pluginManager, ProfileService profileService) {
    _Logger = logger;
    _CommandService = core.Command;
    _PluginManager = pluginManager;
    _ProfileService = profileService;
    _CommandService.RegisterCommand("sw", OnCommand, true);
  }

  private void OnCommand(ICommandContext context) {
    try {
    if (context.IsSentByPlayer) {
      context.Reply("This command can only be used in console.");
      return;
    }
    var args = context.Args;
    if (args.Length == 0) {
      context.Reply("Not enough param");
      return;
    }

    switch (args[0]) {
      case "plugins":
        OnPluginsCommand(context);
        break;
      case "profile":
        OnProfileCommand(context);
        break;
      default:
        context.Reply("Unknown command");
        break;
      }
    } catch (Exception e) {
      _Logger.LogError(e, "Error executing command");
    }
  }

  private void OnProfileCommand(ICommandContext context) {
    File.WriteAllText("profile.json", _ProfileService.GenerateJSONPerformance(""));
    context.Reply("Profile saved to profile.json");
  }

  private void OnPluginsCommand(ICommandContext context) {
    var args = context.Args;
    if (args.Length == 1) {
      context.Reply("Available commands: list, load, unload, reload");
      return;
    }

    switch (args[1]) {
      case "list":
        var table = new Table().AddColumn("Name").AddColumn("Status");
        foreach (var plugin in _PluginManager.GetPlugins()) {
          table.AddRow(plugin.Manifest.Id, plugin.Status?.ToString() ?? "Unknown");
        }
        AnsiConsole.Write(table);
        break;
      case "load":
        _PluginManager.LoadPluginById(args[2]);
        break;
      case "unload":
        _PluginManager.UnloadPlugin(args[2]);
        break;
      case "reload":
        _PluginManager.ReloadPlugin(args[2]);
        break;
      default:
        context.Reply("Unknown command");
        break;
    }
  }
}