using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeSpringIntegrator_t : SchemaClass, IFeSpringIntegrator_t {

  public FeSpringIntegrator_t(nint handle) : base(handle) {
  }

  public FeSpringIntegrator_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<uint16> Node {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0xFC6DF38BCD6694B9));
  }
  public ref float SpringRestLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFC6DF38B28C609E8));
  }
  public ref float SpringConstant {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFC6DF38B9346E79E));
  }
  public ref float SpringDamping {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFC6DF38B20E775D0));
  }
  public ref float NodeWeight0 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFC6DF38B6E62FEA1));
  }


}