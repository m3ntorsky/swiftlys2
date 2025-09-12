using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmStateNode__CDefinition : CNmPoseNode::CDefinition, INmStateNode__CDefinition {

  public CNmStateNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short ChildNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x1C1728105C29A73C));
  }
  public ISchemaUntypedField EntryEvents {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x1C172810211A7856));
  }
  public ISchemaUntypedField ExecuteEvents {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x1C1728103BF4FF69));
  }
  public ISchemaUntypedField ExitEvents {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x1C17281096F711C4));
  }
  public ISchemaUntypedField TimedRemainingEvents {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x1C172810DFC9D945));
  }
  public ISchemaUntypedField TimedElapsedEvents {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x1C172810E054F8B9));
  }
  public ref short LayerWeightNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x1C17281069611331));
  }
  public ref short LayerRootMotionWeightNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x1C17281040566E47));
  }
  public ref short LayerBoneMaskNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x1C1728101BA67627));
  }
  public ref bool IsOffState {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1C172810291F238F));
  }


}