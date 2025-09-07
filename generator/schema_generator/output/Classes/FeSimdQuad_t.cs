using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeSimdQuad_t : SchemaClass, IFeSimdQuad_t {

  public FeSimdQuad_t(nint handle) : base(handle) {
  }

  public FeSimdQuad_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<uint16[4]> Node {
    get => new SchemaFixedArray<uint16[4]>(_Handle + Schema.GetOffset(0xB82B061DCD6694B9));
  }
  public ref fltx4 F4Slack {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0xB82B061DBBFE3561));
  }
  public ISchemaFixedArray<FourVectors> Shape {
    get => new SchemaFixedArray<FourVectors>(_Handle + Schema.GetOffset(0xB82B061DE159551A));
  }
  public ISchemaFixedArray<fltx4> F4Weights {
    get => new SchemaFixedArray<fltx4>(_Handle + Schema.GetOffset(0xB82B061DDCFBCC00));
  }


}