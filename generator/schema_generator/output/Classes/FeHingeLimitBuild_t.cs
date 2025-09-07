using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeHingeLimitBuild_t : SchemaClass, IFeHingeLimitBuild_t {

  public FeHingeLimitBuild_t(nint handle) : base(handle) {
  }

  public FeHingeLimitBuild_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<uint16> Node {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0x50E120ADCD6694B9));
  }
  public ref uint Flags {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x50E120ADB8D52E48));
  }
  public ref float LimitCW {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x50E120ADC3D20C44));
  }
  public ref float LimitCCW {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x50E120ADA6C794ED));
  }


}