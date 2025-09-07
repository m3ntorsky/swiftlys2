using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSosSoundEventGroupSchema : SchemaClass, ISosSoundEventGroupSchema {

  public CSosSoundEventGroupSchema(nint handle) : base(handle) {
  }

  public CSosSoundEventGroupSchema(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x25BA87004D8F5786));
  }
  public ref SosGroupType_t Type {
    get => ref _Handle.AsRef<SosGroupType_t>(Schema.GetOffset(0x25BA870018853D59));
  }
  public ref bool IsBlocking {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x25BA87001C9AB88E));
  }
  public ref int BlockMaxCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x25BA8700282E91F7));
  }
  public ref bool InvertMatch {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x25BA87003C3CF99A));
  }
  public ISosGroupMatchPattern MatchPattern {
    get => new CSosGroupMatchPattern(_Handle + Schema.GetOffset(0x25BA8700E065AB84));
  }
  public ISosGroupBranchPattern BranchPattern {
    get => new CSosGroupBranchPattern(_Handle + Schema.GetOffset(0x25BA870017E92C29));
  }
  public ref float LifeSpanTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x25BA870068189B78));
  }
  public ISosGroupActionSchema Actions {
    get => new CSosGroupActionSchema(_Handle + Schema.GetOffset(0x25BA8700D36B7908));
  }


}