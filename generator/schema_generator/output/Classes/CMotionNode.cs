using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMotionNode : SchemaClass, IMotionNode {

  public CMotionNode(nint handle) : base(handle) {
  }

  public CMotionNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xB29D04644D8F5786));
  }
  public IAnimNodeID Id {
    get => new AnimNodeID(_Handle + Schema.GetOffset(0xB29D0464B4B6E980));
  }


}