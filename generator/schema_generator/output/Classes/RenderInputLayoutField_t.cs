using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RenderInputLayoutField_t : SchemaClass, IRenderInputLayoutField_t {

  public RenderInputLayoutField_t(nint handle) : base(handle) {
  }

  public ISchemaFixedString SemanticName {
    get => new SchemaFixedString(_Handle, 0x752C88F08F25E44C, 32, 1, 1);
  }
  public ref byte SemanticIndex {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x752C88F0AAC99783));
  }
  public ref short Offset {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x752C88F027734C8E));
  }
  public ref byte Slot {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x752C88F08A37D215));
  }
  public ref RenderSlotType_t SlotType {
    get => ref _Handle.AsRef<RenderSlotType_t>(Schema.GetOffset(0x752C88F05072B95D));
  }
  public ISchemaFixedString ShaderSemantic {
    get => new SchemaFixedString(_Handle, 0x752C88F0897CAA95, 32, 1, 1);
  }


}