using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimLocalHierarchy : SchemaClass, IAnimLocalHierarchy {

  public CAnimLocalHierarchy(nint handle) : base(handle) {
  }

  public ref CBufferString Bone {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0x3D14C1ED515646C4));
  }
  public ref CBufferString NewParent {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0x3D14C1ED40620004));
  }
  public ref int StartFrame {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3D14C1ED9134F088));
  }
  public ref int PeakFrame {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3D14C1ED3BAFAFC7));
  }
  public ref int TailFrame {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3D14C1ED3F824524));
  }
  public ref int EndFrame {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3D14C1EDEA91BD07));
  }


}