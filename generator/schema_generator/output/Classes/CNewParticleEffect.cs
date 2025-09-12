using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNewParticleEffect : IParticleEffect, INewParticleEffect {

  public CNewParticleEffect(nint handle) : base(handle) {
  }

  public INewParticleEffect Next {
    get => new CNewParticleEffect(_Handle + Schema.GetOffset(0x80246F2332B11E0E));
  }
  public INewParticleEffect Prev {
    get => new CNewParticleEffect(_Handle + Schema.GetOffset(0x80246F23D49AD9AA));
  }
  public IIParticleCollection Particles {
    get => new IParticleCollection(_Handle + Schema.GetOffset(0x80246F230264D666));
  }
  public ref CString DebugName {
    get => ref _Handle.AsRef<CString>(Schema.GetOffset(0x80246F23831E1E2D));
  }
  public ISchemaUntypedField DontRemove {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x80246F2318B469AA));
  }
  public ISchemaUntypedField Remove {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x80246F23DE0A6D5D));
  }
  public ISchemaUntypedField NeedsBBoxUpdate {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x80246F235AEEC4C0));
  }
  public ISchemaUntypedField IsFirstFrame {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x80246F238B55CEC2));
  }
  public ISchemaUntypedField AutoUpdateBBox {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x80246F2326B4EA98));
  }
  public ISchemaUntypedField Allocated {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x80246F23BD9EA512));
  }
  public ISchemaUntypedField Simulate {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x80246F234268FC4F));
  }
  public ISchemaUntypedField ShouldPerformCullCheck {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x80246F235AE4A4A1));
  }
  public ISchemaUntypedField ForceNoDraw {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x80246F23B481F091));
  }
  public ISchemaUntypedField SuppressScreenSpaceEffect {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x80246F237FA21D5D));
  }
  public ISchemaUntypedField ShouldSave {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x80246F23574A1977));
  }
  public ISchemaUntypedField ShouldSimulateDuringGamePaused {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x80246F233E7DF411));
  }
  public ISchemaUntypedField ShouldCheckFoW {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x80246F237B2493C2));
  }
  public ref Vector SortOrigin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x80246F23E2F1590F));
  }
  public ref float Scale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x80246F23B731A42F));
  }
  public IPARTICLE_EHANDLE__ Owner {
    get => new PARTICLE_EHANDLE__(_Handle + Schema.GetOffset(0x80246F23F6D89572));
  }
  public IParticleProperty OwningParticleProperty {
    get => new CParticleProperty(_Handle + Schema.GetOffset(0x80246F2374DD533C));
  }
  public ref float FreezeTransitionStart {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x80246F233AB5D201));
  }
  public ref float FreezeTransitionDuration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x80246F239CE29C67));
  }
  public ref float FreezeTransitionOverride {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x80246F23A55719DB));
  }
  public ref bool FreezeTransitionActive {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x80246F23DE61FB43));
  }
  public ref bool FreezeTargetState {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x80246F235ACCAFF4));
  }
  public ref bool CanFreeze {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x80246F2314DD4F42));
  }
  public ref Vector LastMin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x80246F23102539F3));
  }
  public ref Vector LastMax {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x80246F232638E44D));
  }
  public ref uint SplitScreenUser {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x80246F23480103D8));
  }
  public ref Vector AggregationCenter {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x80246F23094BDF24));
  }
  public ref int RefCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x80246F237998CBC9));
  }


}