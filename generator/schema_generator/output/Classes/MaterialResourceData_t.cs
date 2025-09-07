using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class MaterialResourceData_t : SchemaClass, IMaterialResourceData_t {

  public MaterialResourceData_t(nint handle) : base(handle) {
  }

  public MaterialResourceData_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString MaterialName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xA8F70097AF8795A3));
  }
  public ref CUtlString ShaderName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xA8F70097F8B3D7CB));
  }
  public ref CUtlVector< MaterialParamInt_t > IntParams {
    get => ref _Handle.AsRef<CUtlVector< MaterialParamInt_t >>(Schema.GetOffset(0xA8F7009783517144));
  }
  public ref CUtlVector< MaterialParamFloat_t > FloatParams {
    get => ref _Handle.AsRef<CUtlVector< MaterialParamFloat_t >>(Schema.GetOffset(0xA8F70097E6B01113));
  }
  public ref CUtlVector< MaterialParamVector_t > VectorParams {
    get => ref _Handle.AsRef<CUtlVector< MaterialParamVector_t >>(Schema.GetOffset(0xA8F70097FA0211E0));
  }
  public ref CUtlVector< MaterialParamTexture_t > TextureParams {
    get => ref _Handle.AsRef<CUtlVector< MaterialParamTexture_t >>(Schema.GetOffset(0xA8F70097E53114F2));
  }
  public ref CUtlVector< MaterialParamBuffer_t > DynamicParams {
    get => ref _Handle.AsRef<CUtlVector< MaterialParamBuffer_t >>(Schema.GetOffset(0xA8F70097CC06B734));
  }
  public ref CUtlVector< MaterialParamBuffer_t > DynamicTextureParams {
    get => ref _Handle.AsRef<CUtlVector< MaterialParamBuffer_t >>(Schema.GetOffset(0xA8F70097A1DB64A7));
  }
  public ref CUtlVector< MaterialParamInt_t > IntAttributes {
    get => ref _Handle.AsRef<CUtlVector< MaterialParamInt_t >>(Schema.GetOffset(0xA8F700974510A3FB));
  }
  public ref CUtlVector< MaterialParamFloat_t > FloatAttributes {
    get => ref _Handle.AsRef<CUtlVector< MaterialParamFloat_t >>(Schema.GetOffset(0xA8F70097D7D0F554));
  }
  public ref CUtlVector< MaterialParamVector_t > VectorAttributes {
    get => ref _Handle.AsRef<CUtlVector< MaterialParamVector_t >>(Schema.GetOffset(0xA8F70097FDB43687));
  }
  public ref CUtlVector< MaterialParamTexture_t > TextureAttributes {
    get => ref _Handle.AsRef<CUtlVector< MaterialParamTexture_t >>(Schema.GetOffset(0xA8F70097417A5705));
  }
  public ref CUtlVector< MaterialParamString_t > StringAttributes {
    get => ref _Handle.AsRef<CUtlVector< MaterialParamString_t >>(Schema.GetOffset(0xA8F700973452D511));
  }
  public ref CUtlVector< CUtlString > RenderAttributesUsed {
    get => ref _Handle.AsRef<CUtlVector< CUtlString >>(Schema.GetOffset(0xA8F700979CB01DD9));
  }


}