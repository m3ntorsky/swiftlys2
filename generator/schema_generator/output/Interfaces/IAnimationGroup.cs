using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimationGroup : ISchemaClass {

  public ref uint Flags { get; }
  
  public ref CBufferString Name { get; }
  
  public ref CUtlVector<CStrongHandle<InfoForResourceTypeCAnimData>> LocalHAnimArray_Handle { get; }
  
  public ref CUtlVector<CStrongHandle<InfoForResourceTypeCAnimationGroup>> IncludedGroupArray_Handle { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCSequenceGroupData> DirectHSeqGroup_Handle { get; }
  
  public IAnimKeyData DecodeKey { get; }
  
  public ref CUtlVector<CBufferString> Scripts { get; }
  
  public ref CUtlVector<CStrongHandle<oi>> AdditionalExtRefs { get; }
  
}