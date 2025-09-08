using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSoundContainerReferenceArray : SchemaClass, ISoundContainerReferenceArray {

  public CSoundContainerReferenceArray(nint handle) : base(handle) {
  }

  public ref bool UseReference {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x80FA0E8A45BCD5C9));
  }
  public ref CUtlVector Sounds {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x80FA0E8ABD919645));
  }
  public ref CUtlVector<PointerTo<CVoiceContainerBase>> Sounds {
    get => ref _Handle.AsRef<CUtlVector<PointerTo<CVoiceContainerBase>>>(Schema.GetOffset(0x80FA0E8AAA82BE1F));
  }


}