using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetControlPointsToModelParticles : CParticleFunctionOperator, IC_OP_SetControlPointsToModelParticles {

  public C_OP_SetControlPointsToModelParticles(nint handle) : base(handle) {
  }

  public C_OP_SetControlPointsToModelParticles(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedString HitboxSetName {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0x8850EF6A6A21BB0E));
  }
  public ISchemaFixedString AttachmentName {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0x8850EF6A9CFCA76B));
  }
  public ref int FirstControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8850EF6A72117650));
  }
  public ref int NumControlPoints {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8850EF6A551EBC4F));
  }
  public ref int FirstSourcePoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8850EF6A9D7DC18E));
  }
  public ref bool Skin {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8850EF6A1BE32F18));
  }
  public ref bool Attachment {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8850EF6A4D2F6EC8));
  }


}