using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTriggerBuoyancy : CBaseTrigger, ITriggerBuoyancy {

  public CTriggerBuoyancy(nint handle) : base(handle) {
  }

  public IBuoyancyHelper BuoyancyHelper {
    get => new CBuoyancyHelper(_Handle + Schema.GetOffset(0xE9698D106BAFFEA7));
  }

  public void FluidDensityUpdated() {
    Schema.Update(_Handle, 0xE9698D10DABBC5A3);
  }
}