using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSosGroupActionSoundeventPrioritySchema : CSosGroupActionSchema, ISosGroupActionSoundeventPrioritySchema {

  public CSosGroupActionSoundeventPrioritySchema(nint handle) : base(handle) {
  }

  public ref CUtlString PriorityValue {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x1E84D860257F7BF6));
  }
  public ref CUtlString PriorityVolumeScalar {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x1E84D860F21824AF));
  }
  public ref CUtlString PriorityContributeButDontRead {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x1E84D8608078C7B6));
  }
  public ref CUtlString PriorityReadButDontContribute {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x1E84D860112DDB84));
  }


}