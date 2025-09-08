using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PointDefinitionWithTimeValues_t : PointDefinition_t, IPointDefinitionWithTimeValues_t {

  public PointDefinitionWithTimeValues_t(nint handle) : base(handle) {
  }

  public ref float TimeDuration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF2BE4F108B84C052));
  }


}