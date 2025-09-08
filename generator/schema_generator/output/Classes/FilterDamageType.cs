using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FilterDamageType : CBaseFilter, IFilterDamageType {

  public FilterDamageType(nint handle) : base(handle) {
  }

  public ref int DamageType {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xEBD649E6AF4EB7BD));
  }


}