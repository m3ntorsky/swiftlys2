using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IWayPointHelperUpdateNode : IUnaryUpdateNode {

  public ref float StartCycle { get; }
  
  public ref float EndCycle { get; }
  
  public ref bool OnlyGoals { get; }
  
  public ref bool PreventOvershoot { get; }
  
  public ref bool PreventUndershoot { get; }
  
}