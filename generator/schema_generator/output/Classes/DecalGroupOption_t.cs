using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class DecalGroupOption_t : SchemaClass, IDecalGroupOption_t {

  public DecalGroupOption_t(nint handle) : base(handle) {
  }

  public ref CStrongHandle<opyable<InfoForResourceTypeIMaterial2> Material {
    get => ref _Handle.AsRef<CStrongHandle<opyable<InfoForResourceTypeIMaterial2>>(Schema.GetOffset(0x9F3DB78B888CE42E));
  }
  public ref CGlobalSymbol SequenceName {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x9F3DB78B7462AF30));
  }
  public ref float Probability {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9F3DB78B9ABB533A));
  }
  public ref bool EnableAngleBetweenNormalAndGravityRange {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9F3DB78B5C382DAE));
  }
  public ref float MinAngleBetweenNormalAndGravity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9F3DB78B8EB6C526));
  }
  public ref float MaxAngleBetweenNormalAndGravity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9F3DB78B44368314));
  }


}