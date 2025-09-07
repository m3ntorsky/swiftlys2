using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_PositionPlaceOnGround : CParticleFunctionInitializer, IC_INIT_PositionPlaceOnGround {

  public C_INIT_PositionPlaceOnGround(nint handle) : base(handle) {
  }

  public C_INIT_PositionPlaceOnGround(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPerParticleFloatInput Offset {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xA022821E7F14BA34));
  }
  public IPerParticleFloatInput MaxTraceLength {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xA022821E543C3798));
  }
  public ISchemaFixedString CollisionGroupName {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0xA022821ED58A3195));
  }
  public ref ParticleTraceSet_t TraceSet {
    get => ref _Handle.AsRef<ParticleTraceSet_t>(Schema.GetOffset(0xA022821EBD26C5B2));
  }
  public ref ParticleTraceMissBehavior_t TraceMissBehavior {
    get => ref _Handle.AsRef<ParticleTraceMissBehavior_t>(Schema.GetOffset(0xA022821E1F2C7BCC));
  }
  public ref bool IncludeWater {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA022821EEB8D4646));
  }
  public ref bool SetNormal {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA022821E542722AC));
  }
  public IParticleAttributeIndex_t Attribute {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xA022821E7FE8DE0B));
  }
  public ref bool SetPXYZOnly {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA022821E93ED3336));
  }
  public ref bool TraceAlongNormal {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA022821EF6E20144));
  }
  public IParticleAttributeIndex_t TraceDirectionAttribute {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xA022821E00E7482D));
  }
  public ref bool OffsetonColOnly {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA022821E0720D19D));
  }
  public ref float OffsetByRadiusFactor {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA022821E61169F50));
  }
  public ref int PreserveOffsetCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA022821E58AC51C1));
  }
  public ref int IgnoreCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA022821EF0DDC7AC));
  }


}