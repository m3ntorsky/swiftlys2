using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeQuad_t : SchemaClass, IFeQuad_t {

  public FeQuad_t(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<ushort> Node {
    get => new SchemaFixedArray<ushort>(_Handle, 0x22A47BB8CD6694B9, 4, 2, 2);
  }
  public ref float Slack {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x22A47BB8C6554869));
  }
  public ISchemaFixedArray<Vector4D> Shape {
    get => new SchemaFixedArray<Vector4D>(_Handle, 0x22A47BB8E159551A, 4, 16, 4);
  }


}