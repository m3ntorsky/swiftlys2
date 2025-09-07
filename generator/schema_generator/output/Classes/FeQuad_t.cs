using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeQuad_t : SchemaClass, IFeQuad_t {

  public FeQuad_t(nint handle) : base(handle) {
  }

  public FeQuad_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<uint16> Node {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0x22A47BB8CD6694B9));
  }
  public ref float Slack {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x22A47BB8C6554869));
  }
  public ISchemaFixedArray<Vector4D> Shape {
    get => new SchemaFixedArray<Vector4D>(_Handle + Schema.GetOffset(0x22A47BB8E159551A));
  }


}