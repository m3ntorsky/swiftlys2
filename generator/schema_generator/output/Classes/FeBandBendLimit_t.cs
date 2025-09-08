using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeBandBendLimit_t : SchemaClass, IFeBandBendLimit_t {

  public FeBandBendLimit_t(nint handle) : base(handle) {
  }

  public ref float DistMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB667406005D5EE89));
  }
  public ref float DistMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB6674060F7C250C7));
  }
  public ISchemaFixedArray<ushort> Node {
    get => new SchemaFixedArray<ushort>(_Handle, 0xB6674060CD6694B9, 6, 2, 2);
  }


}