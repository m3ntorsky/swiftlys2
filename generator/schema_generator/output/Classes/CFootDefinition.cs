using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFootDefinition : SchemaClass, IFootDefinition {

  public CFootDefinition(nint handle) : base(handle) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xAA3BA2A34D8F5786));
  }
  public ref CUtlString AnkleBoneName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xAA3BA2A3A8A2DEF9));
  }
  public ref CUtlString ToeBoneName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xAA3BA2A39C96209A));
  }
  public ref Vector BallOffset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xAA3BA2A3E3376F1B));
  }
  public ref Vector HeelOffset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xAA3BA2A3306AE608));
  }
  public ref float FootLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xAA3BA2A308C0C9F7));
  }
  public ref float BindPoseDirectionMS {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xAA3BA2A34413B862));
  }
  public ref float TraceHeight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xAA3BA2A3EFB858CF));
  }
  public ref float TraceRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xAA3BA2A39A33E452));
  }


}