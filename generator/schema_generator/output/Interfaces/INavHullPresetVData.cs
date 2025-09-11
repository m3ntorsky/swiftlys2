using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INavHullPresetVData : ISchemaClass {

  
  public ref CUtlVector<CUtlString> NavHulls { get; }
}