using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class AmmoTypeInfo_t : SchemaClass, IAmmoTypeInfo_t {

  public AmmoTypeInfo_t(nint handle) : base(handle) {
  }

  public AmmoTypeInfo_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int MaxCarry {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xFC774B09B708280));
  }
  public IRangeInt SplashSize {
    get => new CRangeInt(_Handle + Schema.GetOffset(0xFC774B045E320D3));
  }
  public ref AmmoFlags_t Flags {
    get => ref _Handle.AsRef<AmmoFlags_t>(Schema.GetOffset(0xFC774B0CE6E9C28));
  }
  public ref float Mass {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFC774B0CD83D263));
  }
  public IRangeFloat Speed {
    get => new CRangeFloat(_Handle + Schema.GetOffset(0xFC774B0C631B7EA));
  }


}