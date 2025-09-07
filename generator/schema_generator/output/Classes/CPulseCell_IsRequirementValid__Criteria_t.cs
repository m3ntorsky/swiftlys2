using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_IsRequirementValid__Criteria_t : SchemaClass, IPulseCell_IsRequirementValid__Criteria_t {

  public CPulseCell_IsRequirementValid__Criteria_t(nint handle) : base(handle) {
  }

  public CPulseCell_IsRequirementValid__Criteria_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool IsValid {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4D71FFB90E4A2BC1));
  }


}