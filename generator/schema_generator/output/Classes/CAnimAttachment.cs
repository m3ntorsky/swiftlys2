using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimAttachment : SchemaClass, IAnimAttachment {

  public CAnimAttachment(nint handle) : base(handle) {
  }

  public CAnimAttachment(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<Quaternion> InfluenceRotations {
    get => new SchemaFixedArray<Quaternion>(_Handle + Schema.GetOffset(0xCF918186B393B857));
  }
  public ISchemaFixedArray<VectorAligned> InfluenceOffsets {
    get => new SchemaFixedArray<VectorAligned>(_Handle + Schema.GetOffset(0xCF918186E75BDA68));
  }
  public ISchemaFixedArray<int32> InfluenceIndices {
    get => new SchemaFixedArray<int32>(_Handle + Schema.GetOffset(0xCF9181862FA09BA5));
  }
  public ISchemaFixedArray<float32> InfluenceWeights {
    get => new SchemaFixedArray<float32>(_Handle + Schema.GetOffset(0xCF91818649916951));
  }
  public ref byte NumInfluences {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xCF9181861B36F553));
  }


}