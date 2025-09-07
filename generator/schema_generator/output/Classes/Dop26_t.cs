using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class Dop26_t : SchemaClass, IDop26_t {

  public Dop26_t(nint handle) : base(handle) {
  }

  public Dop26_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<float32> Support {
    get => new SchemaFixedArray<float32>(_Handle + Schema.GetOffset(0xBBAD032FAD766CEA));
  }


}