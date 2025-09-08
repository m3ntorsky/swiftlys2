using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetCPOrientationToGroundNormal : CParticleFunctionOperator, IC_OP_SetCPOrientationToGroundNormal {

  public C_OP_SetCPOrientationToGroundNormal(nint handle) : base(handle) {
  }

  public ref float InterpRate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7BC52DA3D3B705A7));
  }
  public ref float MaxTraceLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7BC52DA3543C3798));
  }
  public ref float Tolerance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7BC52DA38C29728E));
  }
  public ref float TraceOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7BC52DA37EF6C397));
  }
  public ISchemaFixedString CollisionGroupName {
    get => new SchemaFixedString(_Handle, 0x7BC52DA3D58A3195, 128, 1, 1);
  }
  public ref ParticleTraceSet_t TraceSet {
    get => ref _Handle.AsRef<ParticleTraceSet_t>(Schema.GetOffset(0x7BC52DA3BD26C5B2));
  }
  public ref int InputCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x7BC52DA3F39A3C14));
  }
  public ref int OutputCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x7BC52DA350DF5703));
  }
  public ref bool IncludeWater {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x7BC52DA3EB8D4646));
  }


}