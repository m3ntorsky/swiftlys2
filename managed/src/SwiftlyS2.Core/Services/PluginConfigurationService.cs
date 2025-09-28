using System.Data.Common;
using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.Services;
using SwiftlyS2.Shared.Services;

namespace SwiftlyS2.Core.Services;

internal class PluginConfigurationService : IPluginConfigurationService {

  private ConfigurationService _ConfigurationService { get; init; }
  private CoreContext _Id { get; init; }
  private IConfigurationBuilder? _Builder { get; set; }
  private IConfigurationRoot? _Root { get; set; }

  public PluginConfigurationService(CoreContext id, ConfigurationService configurationService) {
    _Id = id;
    _ConfigurationService = configurationService;
  }

  public string GetRoot() {
    var dir = Path.Combine(_ConfigurationService.GetConfigRoot(), "plugins", _Id.Name);
    if (!Directory.Exists(dir)) {
      Directory.CreateDirectory(dir);
    }
    return dir;
  }

  public string GetConfigPath(string name) {
    return Path.Combine(GetRoot(), name);
  }

  public IPluginConfigurationService InitializeByTemplate(string name, string templatePath) {

    var configPath = GetConfigPath(name);

    if (File.Exists(configPath)) {
      return this;
    }

    var dir = Path.GetDirectoryName(configPath);
    if (dir is not null) {
      Directory.CreateDirectory(dir);
    }
    File.Create(configPath).Close();

    var templateAbsPath = Path.Combine(_Id.BaseDirectory, "templates", templatePath);

    if (!File.Exists(templateAbsPath)) {
      throw new FileNotFoundException($"Template file not found: {templateAbsPath}");
    }

    File.Copy(templateAbsPath, configPath);
    return this;
  }

  public IPluginConfigurationService InitializeJson<T>(string name, string sectionName) where T : class, new() {
    
    var configPath = GetConfigPath(name);

    if (File.Exists(configPath)) {
      return this;
    }

    var dir = Path.GetDirectoryName(configPath);
    if (dir is not null) {
      Directory.CreateDirectory(dir);
    }
    File.Create(configPath).Close();

    var config = new T();

    var wrapped = new Dictionary<string, object?>
    {
      [sectionName] = config
    };

    var options = new JsonSerializerOptions {
      WriteIndented = true,
      PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    };

    var configJson = JsonSerializer.Serialize(wrapped, options);
    File.WriteAllText(configPath, configJson);

    return this;
  }

  public IConfigurationBuilder CreateBuilder() {
    return new ConfigurationBuilder()
      .SetBasePath(GetRoot());
  }

  public IPluginConfigurationService Configure(Action<IConfigurationBuilder> configureBuilder) {
    _Builder = CreateBuilder();
    configureBuilder(_Builder);
    _Root = _Builder.Build();
    return this;
  }

  public string GetDatabaseCredentials(string connectionName) {
    if(NativeDatabase.ConnectionExists(connectionName)) {
      return NativeDatabase.GetCredentials(connectionName);
    }
    return NativeDatabase.GetDefaultConnectionCredentials();
  }

  public IConfigurationRoot Root {
    get {
      if (_Root is null) {
        throw new InvalidOperationException("Configuration is not configured yet!");
      }
      return _Root;
    }
  }


}