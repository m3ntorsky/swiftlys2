using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEmitTagActionUpdater : IAnimActionUpdater {

  
  public ref int TagIndex { get; }
  
  public ref bool IsZeroDuration { get; }
}