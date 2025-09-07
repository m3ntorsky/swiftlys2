using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CDirectionalBlendUpdateNode : CLeafUpdateNode, IDirectionalBlendUpdateNode {

  public CDirectionalBlendUpdateNode(nint handle) : base(handle) {
  }

  public CDirectionalBlendUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IHSequence Sequences {
    get => new HSequence(_Handle + Schema.GetOffset(0xD7E03CEC996DA947));
  }
  public IAnimInputDamping Damping {
    get => new CAnimInputDamping(_Handle + Schema.GetOffset(0xD7E03CEC15440FB5));
  }
  public ref AnimValueSource BlendValueSource {
    get => ref _Handle.AsRef<AnimValueSource>(Schema.GetOffset(0xD7E03CEC7AB7C374));
  }
  public IAnimParamHandle ParamIndex {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xD7E03CEC61990A86));
  }
  public ref float PlaybackSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD7E03CEC1AFA7387));
  }
  public ref float Duration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD7E03CEC3D9FF5AD));
  }
  public ref bool Loop {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD7E03CECC668A4CB));
  }
  public ref bool LockBlendOnReset {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD7E03CEC76334223));
  }


}