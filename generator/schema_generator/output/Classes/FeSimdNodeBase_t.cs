using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeSimdNodeBase_t : SchemaClass, IFeSimdNodeBase_t {

  public FeSimdNodeBase_t(nint handle) : base(handle) {
  }

  public FeSimdNodeBase_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<uint16> Node {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0x8B863723CD6694B9));
  }
  public ISchemaFixedArray<uint16> NodeX0 {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0x8B86372381C7FEB9));
  }
  public ISchemaFixedArray<uint16> NodeX1 {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0x8B86372380C7FD26));
  }
  public ISchemaFixedArray<uint16> NodeY0 {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0x8B8637237BC5B6B0));
  }
  public ISchemaFixedArray<uint16> NodeY1 {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0x8B8637237CC5B843));
  }
  public ISchemaFixedArray<uint16> Dummy {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0x8B863723CD8BAE5F));
  }
  public IFourQuaternions Adjust {
    get => new FourQuaternions(_Handle + Schema.GetOffset(0x8B8637230F6C0983));
  }


}