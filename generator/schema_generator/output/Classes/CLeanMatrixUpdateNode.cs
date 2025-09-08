using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLeanMatrixUpdateNode : CLeafUpdateNode, ILeanMatrixUpdateNode {

  public CLeanMatrixUpdateNode(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<int[3]> FrameCorners {
    get => new SchemaFixedArray<int[3]>(_Handle, 0xDB33C9A617463774, 3, 12, 4);
  }
  public IPoseHandle Poses {
    get => new CPoseHandle(_Handle, 0xDB33C9A6B851C9F5, 9, 4, 2);
  }
  public IAnimInputDamping Damping {
    get => new CAnimInputDamping(_Handle + Schema.GetOffset(0xDB33C9A615440FB5));
  }
  public ref AnimVectorSource BlendSource {
    get => ref _Handle.AsRef<AnimVectorSource>(Schema.GetOffset(0xDB33C9A6EB9142CD));
  }
  public IAnimParamHandle ParamIndex {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xDB33C9A661990A86));
  }
  public ref Vector VerticalAxis {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xDB33C9A6F82ED1C6));
  }
  public ref Vector HorizontalAxis {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xDB33C9A6FE8AD688));
  }
  public IHSequence Sequence {
    get => new HSequence(_Handle + Schema.GetOffset(0xDB33C9A6E0A0598E));
  }
  public ref float MaxValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDB33C9A6D0A5C87C));
  }
  public ref int SequenceMaxFrame {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDB33C9A65FD0AE0B));
  }


}