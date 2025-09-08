using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFiringModeFloat : SchemaClass, IFiringModeFloat {

  public CFiringModeFloat(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<float> Values {
    get => new SchemaFixedArray<float>(_Handle, 0xB6918247BD8BFD5, 2, 4, 4);
  }


}