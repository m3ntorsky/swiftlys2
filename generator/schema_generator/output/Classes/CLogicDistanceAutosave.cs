using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLogicDistanceAutosave : CLogicalEntity, ILogicDistanceAutosave {

  public CLogicDistanceAutosave(nint handle) : base(handle) {
  }

  public ISchemaUntypedField TargetEntity {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8E908EDD8951B0FB));
  }
  public ref float DistanceToPlayer {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8E908EDDF04AFE0C));
  }
  public ref bool ForceNewLevelUnit {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8E908EDD1473BFDE));
  }
  public ref bool CheckCough {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8E908EDD25C565C3));
  }
  public ref bool ThinkDangerous {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8E908EDDE079F1C9));
  }
  public ref float DangerousTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8E908EDD19BC5644));
  }


}