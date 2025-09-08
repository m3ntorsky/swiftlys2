using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CStateUpdateData : SchemaClass, IStateUpdateData {

  public CStateUpdateData(nint handle) : base(handle) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xD984C8C64D8F5786));
  }
  public IAnimScriptHandle Script {
    get => new AnimScriptHandle(_Handle + Schema.GetOffset(0xD984C8C629D70FB0));
  }
  public ref CUtlVector<int> TransitionIndices {
    get => ref _Handle.AsRef<CUtlVector<int>>(Schema.GetOffset(0xD984C8C689E40507));
  }
  public ref CUtlVector Actions {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xD984C8C68D622684));
  }
  public IAnimStateID StateID {
    get => new AnimStateID(_Handle + Schema.GetOffset(0xD984C8C65362B56B));
  }
  public ISchemaUntypedField IsStartState {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD984C8C6B4CEE040));
  }
  public ISchemaUntypedField IsEndState {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD984C8C65C2338AF));
  }
  public ISchemaUntypedField IsPassthrough {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD984C8C6F0AD9431));
  }
  public ISchemaUntypedField IsPassthroughRootMotion {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD984C8C64B319C83));
  }
  public ISchemaUntypedField PreEvaluatePassthroughTransitionPath {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD984C8C60DFCB92D));
  }


}