using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLogicCase : CLogicalEntity, ILogicCase {

  public CLogicCase(nint handle) : base(handle) {
  }

  public CLogicCase(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<CUtlSymbolLarge> Case {
    get => new SchemaFixedArray<CUtlSymbolLarge>(_Handle + Schema.GetOffset(0x4B6BB20CBD726255));
  }
  public ref int ShuffleCases {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4B6BB20C3441354F));
  }
  public ref int LastShuffleCase {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4B6BB20C053CE392));
  }
  public ISchemaFixedArray<uint8> UchShuffleCaseMap {
    get => new SchemaFixedArray<uint8>(_Handle + Schema.GetOffset(0x4B6BB20CF9FC41AE));
  }
  public IEntityIOOutput OnCase {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x4B6BB20CF8743C7C));
  }
  public ISchemaUntypedField OnDefault {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x4B6BB20C4B03C3CD));
  }


}