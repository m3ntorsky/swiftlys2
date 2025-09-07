using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSeqPoseParamDesc : SchemaClass, ISeqPoseParamDesc {

  public CSeqPoseParamDesc(nint handle) : base(handle) {
  }

  public CSeqPoseParamDesc(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CBufferString Name {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0x9276634463D22D49));
  }
  public ref float Start {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9276634405A20B85));
  }
  public ref float End {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x927663449616A27C));
  }
  public ref float Loop {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x92766344DE666C85));
  }
  public ref bool Looping {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9276634425449B0D));
  }


}