using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeSimdQuad_t : SchemaClass, IFeSimdQuad_t {

  public FeSimdQuad_t(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<ushort[4]> Node {
    get => new SchemaFixedArray<ushort[4]>(_Handle, 0xB82B061DCD6694B9, 4, 8, 2);
  }
  public ref fltx4 F4Slack {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0xB82B061DBBFE3561));
  }
  public ISchemaFixedArray<FourVectors> Shape {
    get => new SchemaFixedArray<FourVectors>(_Handle, 0xB82B061DE159551A, 4, 48, 16);
  }
  public ISchemaFixedArray<fltx4> F4Weights {
    get => new SchemaFixedArray<fltx4>(_Handle, 0xB82B061DDCFBCC00, 4, 16, 16);
  }


}