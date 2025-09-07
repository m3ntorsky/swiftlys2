using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class NodeData_t : SchemaClass, INodeData_t {

  public NodeData_t(nint handle) : base(handle) {
  }

  public NodeData_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Parent {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB09FAAA60AABB9D1));
  }
  public ref Vector Origin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xB09FAAA6F26E589B));
  }
  public ref Vector MinBounds {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xB09FAAA6114799FE));
  }
  public ref Vector MaxBounds {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xB09FAAA6C0B4CE60));
  }
  public ref float MinimumDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB09FAAA6D8B1200E));
  }
  public ref CUtlVector< int32 > ChildNodeIndices {
    get => ref _Handle.AsRef<CUtlVector< int32 >>(Schema.GetOffset(0xB09FAAA63648C692));
  }
  public ref CUtlString WorldNodePrefix {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xB09FAAA662126457));
  }


}