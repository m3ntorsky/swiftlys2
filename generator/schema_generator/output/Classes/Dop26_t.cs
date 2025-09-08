using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class Dop26_t : SchemaClass, IDop26_t {

  public Dop26_t(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<float> Support {
    get => new SchemaFixedArray<float>(_Handle, 0xBBAD032FAD766CEA, 26, 4, 4);
  }


}