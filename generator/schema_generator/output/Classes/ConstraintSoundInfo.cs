using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ConstraintSoundInfo : SchemaClass, IConstraintSoundInfo {

  public ConstraintSoundInfo(nint handle) : base(handle) {
  }

  public IVelocitySampler Sampler {
    get => new VelocitySampler(_Handle + Schema.GetOffset(0x79068C49FCCD6193));
  }
  public ISimpleConstraintSoundProfile SoundProfile {
    get => new SimpleConstraintSoundProfile(_Handle + Schema.GetOffset(0x79068C49D9300921));
  }
  public ref Vector ForwardAxis {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x79068C49DC95B25F));
  }
  public ref CUtlSymbolLarge TravelSoundFwd {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x79068C497A65F069));
  }
  public ref CUtlSymbolLarge TravelSoundBack {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x79068C49506B73E3));
  }
  public ISchemaFixedArray<CUtlSymbolLarge> ReversalSounds {
    get => new SchemaFixedArray<CUtlSymbolLarge>(_Handle, 0x79068C49F5164187, 3, 8, 8);
  }
  public ref bool PlayTravelSound {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x79068C49FF3432DE));
  }
  public ref bool PlayReversalSound {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x79068C4941EF4324));
  }


}