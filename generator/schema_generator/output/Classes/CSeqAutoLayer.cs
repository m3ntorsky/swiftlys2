using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSeqAutoLayer : SchemaClass, ISeqAutoLayer {

  public CSeqAutoLayer(nint handle) : base(handle) {
  }

  public CSeqAutoLayer(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short LocalReference {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x1506328FC8D571D9));
  }
  public ref short LocalPose {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x1506328F70BF8111));
  }
  public ISeqAutoLayerFlag Flags {
    get => new CSeqAutoLayerFlag(_Handle + Schema.GetOffset(0x1506328FDC74A14C));
  }
  public ref float Start {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1506328FA539BEFF));
  }
  public ref float Peak {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1506328F5BAE16B2));
  }
  public ref float Tail {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1506328FCF8F4203));
  }
  public ref float End {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1506328F5B29CFCA));
  }


}