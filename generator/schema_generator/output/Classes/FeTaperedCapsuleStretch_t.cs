using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeTaperedCapsuleStretch_t : SchemaClass, IFeTaperedCapsuleStretch_t {

  public FeTaperedCapsuleStretch_t(nint handle) : base(handle) {
  }

  public FeTaperedCapsuleStretch_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<uint16> Node {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0x627474D0CD6694B9));
  }
  public ref ushort CollisionMask {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x627474D00ED3454F));
  }
  public ref ushort Dummy {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x627474D0CD8BAE5F));
  }
  public ISchemaFixedArray<float32> Radius {
    get => new SchemaFixedArray<float32>(_Handle + Schema.GetOffset(0x627474D095FBF7AD));
  }


}