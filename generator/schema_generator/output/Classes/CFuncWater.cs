using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuncWater : CBaseModelEntity, IFuncWater {

  public CFuncWater(nint handle) : base(handle) {
  }

  public IBuoyancyHelper BuoyancyHelper {
    get => new CBuoyancyHelper(_Handle + Schema.GetOffset(0x7DCF4A236BAFFEA7));
  }


}