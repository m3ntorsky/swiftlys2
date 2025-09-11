using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFootCycleDefinition : ISchemaClass {

  
  public ref Vector StancePositionMS { get; }
  
  public ref Vector MidpointPositionMS { get; }
  
  public ref float StanceDirectionMS { get; }
  
  public ref Vector ToStrideStartPos { get; }
  
  public IAnimCycle StanceCycle { get; }
  
  public IFootCycle FootLiftCycle { get; }
  
  public IFootCycle FootOffCycle { get; }
  
  public IFootCycle FootStrikeCycle { get; }
  
  public IFootCycle FootLandCycle { get; }
}