using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBuoyancyHelper : SchemaClass, IBuoyancyHelper {

  public CBuoyancyHelper(nint handle) : base(handle) {
  }

  public CBuoyancyHelper(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlStringToken FluidType {
    get => ref _Handle.AsRef<CUtlStringToken>(Schema.GetOffset(0x7A9E77003D45CF5F));
  }
  public ref float FluidDensity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7A9E7700DABBC5A3));
  }
  public ref float NeutrallyBuoyantGravity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7A9E77007EFB6975));
  }
  public ref float NeutrallyBuoyantLinearDamping {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7A9E7700F2B7E456));
  }
  public ref float NeutrallyBuoyantAngularDamping {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7A9E770013DF82F1));
  }
  public ref bool NeutrallyBuoyant {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x7A9E7700D0DF6ADF));
  }
  public ref CUtlVector< float32 > FractionOfWheelSubmergedForWheelFriction {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x7A9E77009D5C3295));
  }
  public ref CUtlVector< float32 > WheelFrictionScales {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x7A9E77005D5150ED));
  }
  public ref CUtlVector< float32 > FractionOfWheelSubmergedForWheelDrag {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x7A9E7700E1C2C831));
  }
  public ref CUtlVector< float32 > WheelDrag {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x7A9E7700E95C5D6E));
  }


}