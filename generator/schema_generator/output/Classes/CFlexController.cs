using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFlexController : SchemaClass, IFlexController {

  public CFlexController(nint handle) : base(handle) {
  }

  public CFlexController(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x5265FDF16750BACB));
  }
  public ref CUtlString Type {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x5265FDF1B580AB00));
  }
  public ref float Min {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5265FDF1C98F4557));
  }
  public ref float Max {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5265FDF1D7A2E319));
  }


}