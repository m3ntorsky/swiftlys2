using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Outflow_PlayVCD : CPulseCell_Outflow_PlaySceneBase, IPulseCell_Outflow_PlayVCD {

  public CPulseCell_Outflow_PlayVCD(nint handle) : base(handle) {
  }

  public CPulseCell_Outflow_PlayVCD(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString VcdFilename {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xB095B414240AE32B));
  }


}