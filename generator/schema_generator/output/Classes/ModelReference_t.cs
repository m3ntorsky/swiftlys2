using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ModelReference_t : SchemaClass, IModelReference_t {

  public ModelReference_t(nint handle) : base(handle) {
  }

  public ref CStrongHandle<InfoForResourceTypeCModel> Model {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeCModel>>(Schema.GetOffset(0x72F202EC1CD79E7A));
  }
  public ref float RelativeProbabilityOfSpawn {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x72F202ECDBFCAD1E));
  }


}