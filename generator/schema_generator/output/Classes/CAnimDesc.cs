using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimDesc : SchemaClass, IAnimDesc {

  public CAnimDesc(nint handle) : base(handle) {
  }

  public CAnimDesc(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CBufferString Name {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0xF48A66664D8F5786));
  }
  public IAnimDesc_Flag Flags {
    get => new CAnimDesc_Flag(_Handle + Schema.GetOffset(0xF48A6666DC74A14C));
  }
  public ref float Fps {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF48A6666BDD34AA8));
  }
  public IAnimEncodedFrames Data {
    get => new CAnimEncodedFrames(_Handle + Schema.GetOffset(0xF48A66661621C725));
  }
  public ref CUtlVector< CAnimMovement > MovementArray {
    get => ref _Handle.AsRef<CUtlVector< CAnimMovement >>(Schema.GetOffset(0xF48A6666A7A8E615));
  }
  public ref CTransform XInitialOffset {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0xF48A6666BAB8D6AA));
  }
  public ref CUtlVector< CAnimEventDefinition > EventArray {
    get => ref _Handle.AsRef<CUtlVector< CAnimEventDefinition >>(Schema.GetOffset(0xF48A6666B9FB599C));
  }
  public ref CUtlVector< CAnimActivity > ActivityArray {
    get => ref _Handle.AsRef<CUtlVector< CAnimActivity >>(Schema.GetOffset(0xF48A666638F0ACE1));
  }
  public ref CUtlVector< CAnimLocalHierarchy > HierarchyArray {
    get => ref _Handle.AsRef<CUtlVector< CAnimLocalHierarchy >>(Schema.GetOffset(0xF48A6666A806B925));
  }
  public ref float Framestalltime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF48A666641995711));
  }
  public ref Vector RootMin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xF48A66666EC1D517));
  }
  public ref Vector RootMax {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xF48A66667CD572D9));
  }
  public ref CUtlVector< Vector > BoneWorldMin {
    get => ref _Handle.AsRef<CUtlVector< Vector >>(Schema.GetOffset(0xF48A66663E4E9D3F));
  }
  public ref CUtlVector< Vector > BoneWorldMax {
    get => ref _Handle.AsRef<CUtlVector< Vector >>(Schema.GetOffset(0xF48A66664C3B2B91));
  }
  public IAnimSequenceParams SequenceParams {
    get => new CAnimSequenceParams(_Handle + Schema.GetOffset(0xF48A666645F20F3E));
  }


}