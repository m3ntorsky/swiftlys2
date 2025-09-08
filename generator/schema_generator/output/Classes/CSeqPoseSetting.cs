using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSeqPoseSetting : SchemaClass, ISeqPoseSetting {

  public CSeqPoseSetting(nint handle) : base(handle) {
  }

  public ref CBufferString PoseParameter {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0x5EC3BE449DD21486));
  }
  public ref CBufferString Attachment {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0x5EC3BE4439471F5F));
  }
  public ref CBufferString ReferenceSequence {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0x5EC3BE44A84D180E));
  }
  public ref float Value {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5EC3BE448DFCB984));
  }
  public ref bool X {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5EC3BE44B2ABAD67));
  }
  public ref bool Y {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5EC3BE44B1ABABD4));
  }
  public ref bool Z {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5EC3BE44B4ABB08D));
  }
  public ref int Type {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x5EC3BE4421B39888));
  }


}