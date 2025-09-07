using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CResponseCriteriaSet : SchemaClass, IResponseCriteriaSet {

  public CResponseCriteriaSet(nint handle) : base(handle) {
  }

  public CResponseCriteriaSet(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int NumPrefixedContexts {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x96E39114B653ABCA));
  }
  public ref bool OverrideOnAppend {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x96E391140E1014F0));
  }


}