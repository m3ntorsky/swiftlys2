using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmRootMotionData : SchemaClass, INmRootMotionData {

  public CNmRootMotionData(nint handle) : base(handle) {
  }

  public CNmRootMotionData(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CTransform > Transforms {
    get => ref _Handle.AsRef<CUtlVector< CTransform >>(Schema.GetOffset(0x2E2BC46D88C82C58));
  }
  public ref int NumFrames {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x2E2BC46DF764C355));
  }
  public ref float AverageLinearVelocity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2E2BC46D497EE0D4));
  }
  public ref float AverageAngularVelocityRadians {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2E2BC46D11C83D0F));
  }
  public ref CTransform TotalDelta {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0x2E2BC46D71CA0F99));
  }


}