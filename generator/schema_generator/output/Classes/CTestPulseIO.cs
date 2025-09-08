using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTestPulseIO : CLogicalEntity, ITestPulseIO {

  public CTestPulseIO(nint handle) : base(handle) {
  }

  public IEntityIOOutput OnVariantVoid {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x3CAD66134B0C5D73));
  }
  public IEntityIOOutput OnVariantBool {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x3CAD66138350E481));
  }
  public IEntityIOOutput OnVariantInt {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x3CAD66131C6BA682));
  }
  public IEntityIOOutput OnVariantFloat {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x3CAD661378E46379));
  }
  public IEntityIOOutput OnVariantString {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x3CAD6613DE2E3E5C));
  }
  public IEntityIOOutput OnVariantColor {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x3CAD66139A1362C4));
  }
  public IEntityIOOutput OnVariantVector {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x3CAD6613A6D8BE1E));
  }
  public ref bool AllowEmptyInputs {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3CAD661342A93BD2));
  }


}