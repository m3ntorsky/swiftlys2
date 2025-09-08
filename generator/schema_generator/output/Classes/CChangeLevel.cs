using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CChangeLevel : CBaseTrigger, IChangeLevel {

  public CChangeLevel(nint handle) : base(handle) {
  }

  public ref CUtlString MapName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x52008134CE11EF47));
  }
  public ref CUtlString LandmarkName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x520081342DEE941D));
  }
  public IEntityIOOutput OnChangeLevel {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x52008134EED57EDE));
  }
  public ref bool Touched {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x520081342BF07839));
  }
  public ref bool NoTouch {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x520081343004899D));
  }
  public ref bool NewChapter {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x520081342D184126));
  }
  public ref bool OnChangeLevelFired {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x520081341173C672));
  }


}