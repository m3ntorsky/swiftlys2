using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSlopeComponentUpdater : CAnimComponentUpdater, ISlopeComponentUpdater {

  public CSlopeComponentUpdater(nint handle) : base(handle) {
  }

  public CSlopeComponentUpdater(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float TraceDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC0FC4829B2F3B0F7));
  }
  public IAnimParamHandle SlopeAngle {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xC0FC4829ED49556D));
  }
  public IAnimParamHandle SlopeAngleFront {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xC0FC48291ED54070));
  }
  public IAnimParamHandle SlopeAngleSide {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xC0FC4829E6ADA076));
  }
  public IAnimParamHandle SlopeHeading {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xC0FC482945A85028));
  }
  public IAnimParamHandle SlopeNormal {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xC0FC48292A185DE5));
  }
  public IAnimParamHandle SlopeNormal_WorldSpace {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xC0FC48290CCD648C));
  }


}