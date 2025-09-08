using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CShatterGlassShard : SchemaClass, IShatterGlassShard {

  public CShatterGlassShard(nint handle) : base(handle) {
  }

  public ref uint ShardHandle {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x1350BEC3018E384F));
  }
  public ref CUtlVector<Vector2D> PanelVertices {
    get => ref _Handle.AsRef<CUtlVector<Vector2D>>(Schema.GetOffset(0x1350BEC349BB3ECE));
  }
  public ref Vector2D LocalPanelSpaceOrigin {
    get => ref _Handle.AsRef<Vector2D>(Schema.GetOffset(0x1350BEC3D2F782FE));
  }
  public CStrongHandle<IInfoForResourceTypeCModel> Model {
    get => new CStrongHandle<InfoForResourceTypeCModel>(_Handle + Schema.GetOffset(0x1350BEC3E100C814));
  }
  public CHandle<IShatterGlassShardPhysics> PhysicsEntity {
    get => new CHandle<CShatterGlassShardPhysics>(_Handle + Schema.GetOffset(0x1350BEC396EA280F));
  }
  public CHandle<IFuncShatterglass> ParentPanel {
    get => new CHandle<CFuncShatterglass>(_Handle + Schema.GetOffset(0x1350BEC3385216AF));
  }
  public ref uint ParentShard {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x1350BEC3E3717B41));
  }
  public ref ShatterGlassStressType ShatterStressType {
    get => ref _Handle.AsRef<ShatterGlassStressType>(Schema.GetOffset(0x1350BEC300D3667A));
  }
  public ref Vector StressVelocity {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1350BEC3A4B62C52));
  }
  public ref bool CreatedModel {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1350BEC3CC206618));
  }
  public ref float LongestEdge {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1350BEC3B6906D8E));
  }
  public ref float ShortestEdge {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1350BEC30012FB38));
  }
  public ref float LongestAcross {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1350BEC398AEE1F6));
  }
  public ref float ShortestAcross {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1350BEC3A14E5348));
  }
  public ref float SumOfAllEdges {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1350BEC31E8C597C));
  }
  public ref float Area {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1350BEC3623D1622));
  }
  public ref OnFrame OnFrameEdge {
    get => ref _Handle.AsRef<OnFrame>(Schema.GetOffset(0x1350BEC34F0A3650));
  }
  public ref int SubShardGeneration {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1350BEC34106ACCD));
  }
  public ref Vector2D AverageVertPosition {
    get => ref _Handle.AsRef<Vector2D>(Schema.GetOffset(0x1350BEC302B48078));
  }
  public ref bool AverageVertPositionIsValid {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1350BEC33261C872));
  }
  public ref Vector2D PanelSpaceStressPositionA {
    get => ref _Handle.AsRef<Vector2D>(Schema.GetOffset(0x1350BEC34DFDAE31));
  }
  public ref Vector2D PanelSpaceStressPositionB {
    get => ref _Handle.AsRef<Vector2D>(Schema.GetOffset(0x1350BEC34AFDA978));
  }
  public ref bool StressPositionAIsValid {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1350BEC39B0D4BAD));
  }
  public ref bool StressPositionBIsValid {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1350BEC32AC62BB2));
  }
  public ref bool FlaggedForRemoval {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1350BEC35D1816FC));
  }
  public IGameTime_t PhysicsEntitySpawnedAtTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x1350BEC3AA81B16F));
  }
  public CHandle<IBaseEntity> EntityHittingMe {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0x1350BEC3820AF257));
  }
  public ref CUtlVector<uint> Neighbors {
    get => ref _Handle.AsRef<CUtlVector<uint>>(Schema.GetOffset(0x1350BEC3622F1068));
  }


}