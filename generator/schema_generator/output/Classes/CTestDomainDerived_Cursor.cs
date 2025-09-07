using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTestDomainDerived_Cursor : CPulseExecCursor, ITestDomainDerived_Cursor {

  public CTestDomainDerived_Cursor(nint handle) : base(handle) {
  }

  public CTestDomainDerived_Cursor(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int CursorValueA {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x7D1D938EF43E6EDB));
  }
  public ref int CursorValueB {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x7D1D938EF53E706E));
  }


}