using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CDirectPlaybackTagData : SchemaClass, IDirectPlaybackTagData {

  public CDirectPlaybackTagData(nint handle) : base(handle) {
  }

  public ref CUtlString SequenceName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xAADCE162B4A24CB));
  }
  public ref CUtlVector Tags {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xAADCE16B46C8540));
  }


}