using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSoundOpvarSetEntity : CBaseEntity, ISoundOpvarSetEntity {

  public CSoundOpvarSetEntity(nint handle) : base(handle) {
  }

  public ref CUtlSymbolLarge StackName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xAF468F963B3E9CD4));
  }
  public ref CUtlSymbolLarge OperatorName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xAF468F96F6140996));
  }
  public ref CUtlSymbolLarge OpvarName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xAF468F962CAEFF3C));
  }
  public ref int OpvarType {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xAF468F96752C1313));
  }
  public ref int OpvarIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xAF468F962482CE01));
  }
  public ref float OpvarValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xAF468F96D0681AAE));
  }
  public ref CUtlSymbolLarge OpvarValueString {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xAF468F96D2422B1D));
  }
  public ref bool SetOnSpawn {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAF468F96749B637D));
  }


}