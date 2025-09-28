using Microsoft.Extensions.Configuration;

namespace SwiftlyS2.Shared.Services;

public interface IPluginConfigurationService {  


  /// <summary>
  /// Get the path to the configuration file.
  /// </summary>
  /// <param name="path">The name of the configuration file, including the extension.</param>
  /// <returns>The path to the configuration file.</returns>
  public string GetConfigPath(string name);

  /// <summary>
  /// Initialize the configuration file with a template.
  /// To use this, you must package a templates folder in the plugin, with the template file in it.
  /// </summary>
  /// <param name="name">The name of the configuration file.</param>
  /// <param name="templateName">The name of the template file.</param>
  public IPluginConfigurationService InitializeByTemplate(string name, string templateName);

  /// <summary>
  /// Initialize the json configuration file with a class as template.
  /// </summary>
  /// <typeparam name="T">The type of the configuration model.</typeparam>
  /// <param name="name">The name of the configuration file.</param>
  /// <param name="sectionName">The name of the section in the configuration file.</param>
  public IPluginConfigurationService InitializeJson<T>(string name, string sectionName) where T : class, new();

  /// <summary>
  /// Create a configuration builder.
  /// </summary>
  /// <returns>The configuration builder.</returns>
  public IConfigurationBuilder CreateBuilder();


  /// <summary>
  /// Configure the internal configuration builder.
  /// </summary>
  /// <param name="configureBuilder">The action to configure the configuration builder.</param>
  public IPluginConfigurationService Configure(Action<IConfigurationBuilder> configureBuilder);

  /// <summary>
  /// Get the configuration root.
  /// </summary>
  public IConfigurationRoot Root { get; }

}