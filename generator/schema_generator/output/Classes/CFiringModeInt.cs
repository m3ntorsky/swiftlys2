using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFiringModeInt : SchemaClass, IFiringModeInt {

  public CFiringModeInt(nint handle) : base(handle) {
  }

  public CFiringModeInt(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<int32> Values {
    get => new SchemaFixedArray<int32>(_Handle + Schema.GetOffset(0x528A6FDFD7175D77));
  }


}