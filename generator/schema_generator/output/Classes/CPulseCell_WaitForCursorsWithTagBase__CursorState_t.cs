using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_WaitForCursorsWithTagBase__CursorState_t : SchemaClass, IPulseCell_WaitForCursorsWithTagBase__CursorState_t {

  public CPulseCell_WaitForCursorsWithTagBase__CursorState_t(nint handle) : base(handle) {
  }

  public ISchemaUntypedField TagName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x71EA6190647DC278));
  }


}