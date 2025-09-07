using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_ExampleCriteria__Criteria_t : SchemaClass, IPulseCell_ExampleCriteria__Criteria_t {

  public CPulseCell_ExampleCriteria__Criteria_t(nint handle) : base(handle) {
  }

  public CPulseCell_ExampleCriteria__Criteria_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float FloatValue1 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9C86EC19138B644B));
  }
  public ref float FloatValue2 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9C86EC19148B65DE));
  }
  public ref bool MyBool {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9C86EC19BAFBA8C7));
  }


}