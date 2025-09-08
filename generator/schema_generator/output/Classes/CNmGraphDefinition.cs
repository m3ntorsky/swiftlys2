using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmGraphDefinition : SchemaClass, INmGraphDefinition {

  public CNmGraphDefinition(nint handle) : base(handle) {
  }

  public ref CGlobalSymbol VariationID {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0xE028E08C8B90A5E3));
  }
  public ref CStrongHandle<InfoForResourceTypeCNmSkeleton> Skeleton {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeCNmSkeleton>>(Schema.GetOffset(0xE028E08CE77F030E));
  }
  public ref CUtlVector<short> PersistentNodeIndices {
    get => ref _Handle.AsRef<CUtlVector<short>>(Schema.GetOffset(0xE028E08C90896209));
  }
  public ref short RootNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xE028E08C25EE94C4));
  }
  public ref CUtlVector<CGlobalSymbol> ControlParameterIDs {
    get => ref _Handle.AsRef<CUtlVector<CGlobalSymbol>>(Schema.GetOffset(0xE028E08C500E5F9D));
  }
  public ref CUtlVector<CGlobalSymbol> VirtualParameterIDs {
    get => ref _Handle.AsRef<CUtlVector<CGlobalSymbol>>(Schema.GetOffset(0xE028E08CB54BB9E7));
  }
  public ref CUtlVector<short> VirtualParameterNodeIndices {
    get => ref _Handle.AsRef<CUtlVector<short>>(Schema.GetOffset(0xE028E08C1A18B610));
  }
  public ref CUtlVector ReferencedGraphSlots {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xE028E08C6244F6FF));
  }
  public ref CUtlVector ExternalGraphSlots {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xE028E08CECBCD94F));
  }
  public ref CUtlVector<CUtlString> NodePaths {
    get => ref _Handle.AsRef<CUtlVector<CUtlString>>(Schema.GetOffset(0xE028E08CFF3E5A07));
  }
  public ref CUtlVector<CStrongHandle<oi>> Resources {
    get => ref _Handle.AsRef<CUtlVector<CStrongHandle<oi>>>(Schema.GetOffset(0xE028E08C227C3612));
  }


}