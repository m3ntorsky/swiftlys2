using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAudioMorphData : SchemaClass, IAudioMorphData {

  public CAudioMorphData(nint handle) : base(handle) {
  }

  public CAudioMorphData(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< float32 > Times {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0xA13726EA86A55CD5));
  }
  public ref CUtlVector< uint32 > NameHashCodes {
    get => ref _Handle.AsRef<CUtlVector< uint32 >>(Schema.GetOffset(0xA13726EAC13918BC));
  }
  public ref CUtlVector< CUtlString > NameStrings {
    get => ref _Handle.AsRef<CUtlVector< CUtlString >>(Schema.GetOffset(0xA13726EA23776A0C));
  }
  public ref CUtlVector< CUtlVector< float32 > > Samples {
    get => ref _Handle.AsRef<CUtlVector< CUtlVector< float32 > >>(Schema.GetOffset(0xA13726EA364CA9DC));
  }
  public ref float EaseIn {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA13726EA4514C026));
  }
  public ref float EaseOut {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA13726EA46B49C07));
  }


}