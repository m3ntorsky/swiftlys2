using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class sndopvarlatchdata_t : SchemaClass, Isndopvarlatchdata_t {

  public sndopvarlatchdata_t(nint handle) : base(handle) {
  }

  public sndopvarlatchdata_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge Stack {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x8347C0D511ACB037));
  }
  public ref CUtlSymbolLarge Operator {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x8347C0D55D107B55));
  }
  public ref CUtlSymbolLarge Opvar {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x8347C0D508A9F41F));
  }
  public ref float Val {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8347C0D5E31D0C86));
  }
  public ref Vector Pos {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x8347C0D5DE9CFC5D));
  }


}