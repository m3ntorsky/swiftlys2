using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMoverPathNode : CPointEntity, IMoverPathNode {

  public CMoverPathNode(nint handle) : base(handle) {
  }

  public ref Vector InTangentLocal {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x5847AABC46C1388A));
  }
  public ref Vector OutTangentLocal {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x5847AABC788EFFFB));
  }
  public ISchemaUntypedField ParentPathUniqueID {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x5847AABCC2958DE1));
  }
  public ISchemaUntypedField PathNodeParameter {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x5847AABC5B2492DE));
  }
  public IEntityIOOutput OnStartFromOrInSegment {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x5847AABC6622BECB));
  }
  public IEntityIOOutput OnStoppedAtOrInSegment {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x5847AABCBF4204DB));
  }
  public IEntityIOOutput OnPassThrough {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x5847AABC3A5F20B6));
  }
  public IEntityIOOutput OnPassThroughForward {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x5847AABCA62F443B));
  }
  public IEntityIOOutput OnPassThroughReverse {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x5847AABC37667FA8));
  }
  public ref CHandle<CPathMover> Mover {
    get => ref _Handle.AsRef<CHandle<CPathMover>>(Schema.GetOffset(0x5847AABC3629FA74));
  }
  public ref CTransform XWSPrevParent {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0x5847AABC2AEC980C));
  }


}