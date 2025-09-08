using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSkeletonInstance : CGameSceneNode, ISkeletonInstance {

  public CSkeletonInstance(nint handle) : base(handle) {
  }

  public ref bool DisableSolidCollisionsForHierarchy {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD6C6252E50FCF465));
  }
  public ISchemaUntypedField DirtyMotionType {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD6C6252E6EB99391));
  }
  public ISchemaUntypedField IsGeneratingLatchedParentSpaceState {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD6C6252ED0EFEAB7));
  }

  public void ModelStateUpdated() {
    Schema.Update(_Handle, 0xD6C6252E52AC8C4F);
  }
  public void IsAnimationEnabledUpdated() {
    Schema.Update(_Handle, 0xD6C6252E44F0C816);
  }
  public void UseParentRenderBoundsUpdated() {
    Schema.Update(_Handle, 0xD6C6252E15B8267D);
  }
  public void MaterialGroupUpdated() {
    Schema.Update(_Handle, 0xD6C6252E2B778F03);
  }
  public void HitboxSetUpdated() {
    Schema.Update(_Handle, 0xD6C6252E80C42271);
  }
}