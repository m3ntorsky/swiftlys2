using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class SequenceHistory_t : SchemaClass, ISequenceHistory_t {

  public SequenceHistory_t(nint handle) : base(handle) {
  }

  public IHSequence Sequence {
    get => new HSequence(_Handle + Schema.GetOffset(0x8B1B0C2BE0A0598E));
  }
  public IGameTime_t SeqStartTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x8B1B0C2B9120356F));
  }
  public ref float SeqFixedCycle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8B1B0C2B77103EAE));
  }
  public ref AnimLoopMode_t SeqLoopMode {
    get => ref _Handle.AsRef<AnimLoopMode_t>(Schema.GetOffset(0x8B1B0C2BB011340D));
  }
  public ref float PlaybackRate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8B1B0C2BC396F9D8));
  }
  public ref float CyclesPerSecond {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8B1B0C2B44417193));
  }


}