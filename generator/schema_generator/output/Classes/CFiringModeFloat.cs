using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFiringModeFloat : SchemaClass, IFiringModeFloat {

  public CFiringModeFloat(nint handle) : base(handle) {
  }

  public CFiringModeFloat(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<float32> Values {
    get => new SchemaFixedArray<float32>(_Handle + Schema.GetOffset(0xB6918247BD8BFD5));
  }


}