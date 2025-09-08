using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetParentControlPointsToChildCP : IParticleFunctionPreEmission {

  public ref int ChildGroupID { get; }
  
  public ref int ChildControlPoint { get; }
  
  public ref int NumControlPoints { get; }
  
  public ref int FirstSourcePoint { get; }
  
  public ref bool SetOrientation { get; }
  
}