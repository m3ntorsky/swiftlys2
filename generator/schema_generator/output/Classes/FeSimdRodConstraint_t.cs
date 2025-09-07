using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeSimdRodConstraint_t : SchemaClass, IFeSimdRodConstraint_t {

  public FeSimdRodConstraint_t(nint handle) : base(handle) {
  }

  public FeSimdRodConstraint_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<uint16[4]> Node {
    get => new SchemaFixedArray<uint16[4]>(_Handle + Schema.GetOffset(0x596F7846CD6694B9));
  }
  public ref fltx4 F4MaxDist {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0x596F7846287D425F));
  }
  public ref fltx4 F4MinDist {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0x596F7846C67A2525));
  }
  public ref fltx4 F4Weight0 {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0x596F78461FFC3579));
  }
  public ref fltx4 F4RelaxationFactor {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0x596F7846DF311F87));
  }


}