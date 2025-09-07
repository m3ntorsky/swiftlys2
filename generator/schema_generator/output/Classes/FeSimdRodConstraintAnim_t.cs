using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeSimdRodConstraintAnim_t : SchemaClass, IFeSimdRodConstraintAnim_t {

  public FeSimdRodConstraintAnim_t(nint handle) : base(handle) {
  }

  public FeSimdRodConstraintAnim_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<uint16[4]> Node {
    get => new SchemaFixedArray<uint16[4]>(_Handle + Schema.GetOffset(0x22AFF313CD6694B9));
  }
  public ref fltx4 F4Weight0 {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0x22AFF3131FFC3579));
  }
  public ref fltx4 F4RelaxationFactor {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0x22AFF313DF311F87));
  }


}