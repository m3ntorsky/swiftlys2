using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSoundContainerReferenceArray : SchemaClass, ISoundContainerReferenceArray {

  public CSoundContainerReferenceArray(nint handle) : base(handle) {
  }

  public CSoundContainerReferenceArray(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool UseReference {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x80FA0E8A45BCD5C9));
  }
  public ref CUtlVector< CStrongHandle< InfoForResourceTypeCVoiceContainerBase > > Sounds {
    get => ref _Handle.AsRef<CUtlVector< CStrongHandle< InfoForResourceTypeCVoiceContainerBase > >>(Schema.GetOffset(0x80FA0E8ABD919645));
  }
  public ref CUtlVector< CVoiceContainerBase* > Sounds {
    get => ref _Handle.AsRef<CUtlVector< CVoiceContainerBase* >>(Schema.GetOffset(0x80FA0E8AAA82BE1F));
  }


}