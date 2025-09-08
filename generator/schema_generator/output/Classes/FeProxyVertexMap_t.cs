using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeProxyVertexMap_t : SchemaClass, IFeProxyVertexMap_t {

  public FeProxyVertexMap_t(nint handle) : base(handle) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xBBEA9D17CAE8A266));
  }
  public ref float Weight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBBEA9D177B81E7AB));
  }


}