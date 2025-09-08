using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAimMatrixOpFixedSettings_t : ISchemaClass {

  public IAnimAttachment Attachment { get; }
  
  public IAnimInputDamping Damping { get; }
  
  public IPoseHandle PoseCacheHandles { get; }
  
  public ref AimMatrixBlendMode BlendMode { get; }
  
  public ref float MaxYawAngle { get; }
  
  public ref float MaxPitchAngle { get; }
  
  public ref int SequenceMaxFrame { get; }
  
  public ref int BoneMaskIndex { get; }
  
  public ref bool TargetIsPosition { get; }
  
  public ref bool UseBiasAndClamp { get; }
  
  public ref float BiasAndClampYawOffset { get; }
  
  public ref float BiasAndClampPitchOffset { get; }
  
  public IBlendCurve BiasAndClampBlendCurve { get; }
  
}