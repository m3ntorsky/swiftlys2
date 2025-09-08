using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmTarget : SchemaClass, INmTarget {

  public CNmTarget(nint handle) : base(handle) {
  }

  public ref CTransform Transform {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0xA3F5A45E3A9A393B));
  }
  public ref CGlobalSymbol BoneID {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0xA3F5A45E88DFA0E2));
  }
  public ref bool IsBoneTarget {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA3F5A45E3C414BA2));
  }
  public ref bool IsUsingBoneSpaceOffsets {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA3F5A45EA6050C83));
  }
  public ref bool HasOffsets {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA3F5A45ED8AA05D9));
  }
  public ref bool IsSet {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA3F5A45E4307E3B3));
  }


}