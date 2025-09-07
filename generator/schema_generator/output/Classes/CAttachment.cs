using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAttachment : SchemaClass, IAttachment {

  public CAttachment(nint handle) : base(handle) {
  }

  public CAttachment(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x5F09808F4D8F5786));
  }
  public ISchemaFixedArray<CUtlString> InfluenceNames {
    get => new SchemaFixedArray<CUtlString>(_Handle + Schema.GetOffset(0x5F09808FFD9B3CB8));
  }
  public ISchemaFixedArray<Quaternion> InfluenceRotations {
    get => new SchemaFixedArray<Quaternion>(_Handle + Schema.GetOffset(0x5F09808FD277168B));
  }
  public ISchemaFixedArray<Vector> InfluenceOffsets {
    get => new SchemaFixedArray<Vector>(_Handle + Schema.GetOffset(0x5F09808F767C44DC));
  }
  public ISchemaFixedArray<float32> InfluenceWeights {
    get => new SchemaFixedArray<float32>(_Handle + Schema.GetOffset(0x5F09808F49916951));
  }
  public ISchemaFixedArray<bool> InfluenceRootTransform {
    get => new SchemaFixedArray<bool>(_Handle + Schema.GetOffset(0x5F09808F5763011C));
  }
  public ref byte Influences {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x5F09808F8E94AB85));
  }
  public ref bool IgnoreRotation {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5F09808FC7A0F33D));
  }


}