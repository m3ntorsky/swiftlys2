using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTriggerSndSosOpvar : CBaseTrigger, ITriggerSndSosOpvar {

  public CTriggerSndSosOpvar(nint handle) : base(handle) {
  }

  public CTriggerSndSosOpvar(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CHandle< CBaseEntity > > TouchingPlayers {
    get => ref _Handle.AsRef<CUtlVector< CHandle< CBaseEntity > >>(Schema.GetOffset(0xD4B7BEBCD365BA28));
  }
  public ref Vector Position {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD4B7BEBC4142D14C));
  }
  public ref float CenterSize {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD4B7BEBC253C84EB));
  }
  public ref float MinVal {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD4B7BEBC9A76F478));
  }
  public ref float MaxVal {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD4B7BEBC8CE3891E));
  }
  public ref CUtlSymbolLarge OpvarName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xD4B7BEBC4ECBF7E4));
  }
  public ref CUtlSymbolLarge StackName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xD4B7BEBCC6D6063C));
  }
  public ref CUtlSymbolLarge OperatorName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xD4B7BEBCC4AA99BE));
  }
  public ref bool VolIs2D {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD4B7BEBC384D3350));
  }
  public ISchemaFixedString OpvarNameChar {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0xD4B7BEBC55F3CFF0));
  }
  public ISchemaFixedString StackNameChar {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0xD4B7BEBC87998C38));
  }
  public ISchemaFixedString OperatorNameChar {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0xD4B7BEBC9824CD12));
  }
  public ref Vector VecNormPos {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD4B7BEBC66F7FECF));
  }
  public ref float NormCenterSize {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD4B7BEBC3245C335));
  }


}