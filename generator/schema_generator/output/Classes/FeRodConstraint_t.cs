using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeRodConstraint_t : SchemaClass, IFeRodConstraint_t {

  public FeRodConstraint_t(nint handle) : base(handle) {
  }

  public FeRodConstraint_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<uint16> Node {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0xC672146DCD6694B9));
  }
  public ref float MaxDist {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC672146DC9FFDD57));
  }
  public ref float MinDist {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC672146D2C1C02AD));
  }
  public ref float Weight0 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC672146D65561D21));
  }
  public ref float RelaxationFactor {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC672146D357F3BFF));
  }


}