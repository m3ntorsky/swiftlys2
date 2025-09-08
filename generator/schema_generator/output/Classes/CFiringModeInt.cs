using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFiringModeInt : SchemaClass, IFiringModeInt {

  public CFiringModeInt(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<int> Values {
    get => new SchemaFixedArray<int>(_Handle, 0x528A6FDFD7175D77, 2, 4, 4);
  }


}