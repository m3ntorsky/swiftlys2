using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILODComponentUpdater : IAnimComponentUpdater {

  
  public ref int ServerLOD { get; }
}