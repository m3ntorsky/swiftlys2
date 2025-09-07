using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FilterHealth : CBaseFilter, IFilterHealth {

  public FilterHealth(nint handle) : base(handle) {
  }

  public FilterHealth(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool AdrenalineActive {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4DD06C81671CFB30));
  }
  public ref int HealthMin {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4DD06C8117D5C166));
  }
  public ref int HealthMax {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4DD06C8129E96574));
  }


}