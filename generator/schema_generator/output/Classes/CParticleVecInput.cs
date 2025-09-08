using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CParticleVecInput : CParticleInput, IParticleVecInput {

  public CParticleVecInput(nint handle) : base(handle) {
  }

  public ref ParticleVecType_t Type {
    get => ref _Handle.AsRef<ParticleVecType_t>(Schema.GetOffset(0xD598DA0A18853D59));
  }
  public ref Vector LiteralValue {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD598DA0A80638A21));
  }
  public ref Color LiteralColor {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0xD598DA0A75AE86AB));
  }
  public ISchemaUntypedField NamedValue {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD598DA0AE0618727));
  }
  public ref bool FollowNamedValue {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD598DA0A0F6CBBBA));
  }
  public IParticleAttributeIndex_t VectorAttribute {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xD598DA0A2B36D79A));
  }
  public ref Vector VectorAttributeScale {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD598DA0A69912478));
  }
  public ref int ControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD598DA0A0D0DDF8C));
  }
  public ref int DeltaControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD598DA0AC74F7C50));
  }
  public ref Vector CPValueScale {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD598DA0A9A43168B));
  }
  public ref Vector CPRelativePosition {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD598DA0A1964C465));
  }
  public ref Vector CPRelativeDir {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD598DA0A23334FC1));
  }
  public IParticleFloatInput FloatComponentX {
    get => new CParticleFloatInput(_Handle + Schema.GetOffset(0xD598DA0A8D4D4148));
  }
  public IParticleFloatInput FloatComponentY {
    get => new CParticleFloatInput(_Handle + Schema.GetOffset(0xD598DA0A8E4D42DB));
  }
  public IParticleFloatInput FloatComponentZ {
    get => new CParticleFloatInput(_Handle + Schema.GetOffset(0xD598DA0A8F4D446E));
  }
  public IParticleFloatInput FloatInterp {
    get => new CParticleFloatInput(_Handle + Schema.GetOffset(0xD598DA0AF81AB0BB));
  }
  public ref float InterpInput0 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD598DA0A55806CD1));
  }
  public ref float InterpInput1 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD598DA0A54806B3E));
  }
  public ref Vector InterpOutput0 {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD598DA0AD54AF42E));
  }
  public ref Vector InterpOutput1 {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD598DA0AD64AF5C1));
  }
  public ISchemaUntypedField Gradient {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD598DA0A05C95F25));
  }
  public ref Vector RandomMin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD598DA0AC6B45DA2));
  }
  public ref Vector RandomMax {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD598DA0AB0A0B348));
  }


}