using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLogicCase : CLogicalEntity, ILogicCase {

  public CLogicCase(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<CUtlSymbolLarge> Case {
    get => new SchemaFixedArray<CUtlSymbolLarge>(_Handle, 0x4B6BB20CBD726255, 32, 8, 8);
  }
  public ref int ShuffleCases {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4B6BB20C3441354F));
  }
  public ref int LastShuffleCase {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4B6BB20C053CE392));
  }
  public ISchemaFixedArray<byte> UchShuffleCaseMap {
    get => new SchemaFixedArray<byte>(_Handle, 0x4B6BB20CF9FC41AE, 32, 1, 1);
  }
  public IEntityIOOutput OnCase {
    get => new CEntityIOOutput(_Handle, 0x4B6BB20CF8743C7C, 32, 40, 8);
  }
  public ISchemaUntypedField OnDefault {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x4B6BB20C4B03C3CD));
  }


}