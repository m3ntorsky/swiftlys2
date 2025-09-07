using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class HullFlags_t : SchemaClass, IHullFlags_t {

  public HullFlags_t(nint handle) : base(handle) {
  }

  public HullFlags_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool Hull_Human {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6601A7BA756C6ED0));
  }
  public ref bool Hull_SmallCentered {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6601A7BAA57EDD5E));
  }
  public ref bool Hull_WideHuman {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6601A7BAEA8B5AFD));
  }
  public ref bool Hull_Tiny {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6601A7BA637634AD));
  }
  public ref bool Hull_Medium {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6601A7BADB23BDB4));
  }
  public ref bool Hull_TinyCentered {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6601A7BA139ED50D));
  }
  public ref bool Hull_Large {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6601A7BA11910E06));
  }
  public ref bool Hull_LargeCentered {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6601A7BAEE04D78A));
  }
  public ref bool Hull_MediumTall {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6601A7BA332567D3));
  }
  public ref bool Hull_Small {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6601A7BA86608A2A));
  }


}