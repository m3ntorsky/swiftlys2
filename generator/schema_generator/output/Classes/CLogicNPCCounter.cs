using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLogicNPCCounter : CBaseEntity, ILogicNPCCounter {

  public CLogicNPCCounter(nint handle) : base(handle) {
  }

  public CLogicNPCCounter(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEntityIOOutput OnMinCountAll {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x485D88795307A826));
  }
  public IEntityIOOutput OnMaxCountAll {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x485D8879DDCC356C));
  }
  public ISchemaUntypedField OnFactorAll {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x485D8879E34F3A26));
  }
  public ISchemaUntypedField OnMinPlayerDistAll {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x485D887936FA93F4));
  }
  public IEntityIOOutput OnMinCount_1 {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x485D88794C66E6EF));
  }
  public IEntityIOOutput OnMaxCount_1 {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x485D8879A364ADD5));
  }
  public ISchemaUntypedField OnFactor_1 {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x485D8879A2844CEF));
  }
  public ISchemaUntypedField OnMinPlayerDist_1 {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x485D8879C69B333D));
  }
  public IEntityIOOutput OnMinCount_2 {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x485D88794D66E882));
  }
  public IEntityIOOutput OnMaxCount_2 {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x485D8879A064A91C));
  }
  public ISchemaUntypedField OnFactor_2 {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x485D8879A3844E82));
  }
  public ISchemaUntypedField OnMinPlayerDist_2 {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x485D8879C39B2E84));
  }
  public IEntityIOOutput OnMinCount_3 {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x485D88794E66EA15));
  }
  public IEntityIOOutput OnMaxCount_3 {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x485D8879A164AAAF));
  }
  public ISchemaUntypedField OnFactor_3 {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x485D8879A4845015));
  }
  public ISchemaUntypedField OnMinPlayerDist_3 {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x485D8879C49B3017));
  }
  public ref CEntityHandle Source {
    get => ref _Handle.AsRef<CEntityHandle>(Schema.GetOffset(0x485D887933D3CD82));
  }
  public ref CUtlSymbolLarge SourceEntityName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x485D88796C1387C0));
  }
  public ref float DistanceMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x485D8879FDEBADA6));
  }
  public ref bool Disabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x485D88793A7C5965));
  }
  public ref int MinCountAll {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x485D8879CC867BE1));
  }
  public ref int MaxCountAll {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x485D8879307AEE1F));
  }
  public ref int MinFactorAll {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x485D887945AC8C1F));
  }
  public ref int MaxFactorAll {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x485D88793E95FEF5));
  }
  public ref CUtlSymbolLarge NPCClassname_1 {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x485D8879DF49E85F));
  }
  public ref int NPCState_1 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x485D887959CDEB41));
  }
  public ref bool InvertState_1 {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x485D88796F698432));
  }
  public ref int MinCount_1 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x485D88797F3A776A));
  }
  public ref int MaxCount_1 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x485D8879A6C8B370));
  }
  public ref int MinFactor_1 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x485D8879F1CB5D70));
  }
  public ref int MaxFactor_1 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x485D887909B4368E));
  }
  public ref float DefaultDist_1 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x485D88793E54B91C));
  }
  public ref CUtlSymbolLarge NPCClassname_2 {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x485D8879E049E9F2));
  }
  public ref int NPCState_2 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x485D887956CDE688));
  }
  public ref bool InvertState_2 {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x485D88796E69829F));
  }
  public ref int MinCount_2 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x485D88797E3A75D7));
  }
  public ref int MaxCount_2 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x485D8879A9C8B829));
  }
  public ref int MinFactor_2 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x485D8879F4CB6229));
  }
  public ref int MaxFactor_2 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x485D887908B434FB));
  }
  public ref float DefaultDist_2 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x485D88794154BDD5));
  }
  public ref CUtlSymbolLarge NPCClassname_3 {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x485D8879E149EB85));
  }
  public ref int NPCState_3 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x485D887957CDE81B));
  }
  public ref bool InvertState_3 {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x485D88796D69810C));
  }
  public ref int MinCount_3 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x485D88797D3A7444));
  }
  public ref int MaxCount_3 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x485D8879A8C8B696));
  }
  public ref int MinFactor_3 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x485D8879F3CB6096));
  }
  public ref int MaxFactor_3 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x485D887907B43368));
  }
  public ref float DefaultDist_3 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x485D88794054BC42));
  }


}