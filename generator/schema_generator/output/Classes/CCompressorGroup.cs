using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCompressorGroup : SchemaClass, ICompressorGroup {

  public CCompressorGroup(nint handle) : base(handle) {
  }

  public CCompressorGroup(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int TotalElementCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8D9A46F69E4F56A2));
  }
  public ref CUtlVector< char* > ChannelClass {
    get => ref _Handle.AsRef<CUtlVector< char* >>(Schema.GetOffset(0x8D9A46F68F5E9AD5));
  }
  public ref CUtlVector< char* > VariableName {
    get => ref _Handle.AsRef<CUtlVector< char* >>(Schema.GetOffset(0x8D9A46F6369599AB));
  }
  public ref CUtlVector< fieldtype_t > Type {
    get => ref _Handle.AsRef<CUtlVector< fieldtype_t >>(Schema.GetOffset(0x8D9A46F618853D59));
  }
  public ref CUtlVector< int32 > Flags {
    get => ref _Handle.AsRef<CUtlVector< int32 >>(Schema.GetOffset(0x8D9A46F6CE6E9C28));
  }
  public ref CUtlVector< CUtlString > Grouping {
    get => ref _Handle.AsRef<CUtlVector< CUtlString >>(Schema.GetOffset(0x8D9A46F64308F10D));
  }
  public ref CUtlVector< int32 > CompressorIndex {
    get => ref _Handle.AsRef<CUtlVector< int32 >>(Schema.GetOffset(0x8D9A46F67B4BF604));
  }
  public ref CUtlVector< CUtlVector< char* > > ElementNames {
    get => ref _Handle.AsRef<CUtlVector< CUtlVector< char* > >>(Schema.GetOffset(0x8D9A46F6D5BFAA00));
  }
  public ref CUtlVector< CUtlVector< int32 > > ElementUniqueID {
    get => ref _Handle.AsRef<CUtlVector< CUtlVector< int32 > >>(Schema.GetOffset(0x8D9A46F64C95C12D));
  }
  public ref CUtlVector< uint32 > ElementMask {
    get => ref _Handle.AsRef<CUtlVector< uint32 >>(Schema.GetOffset(0x8D9A46F67BBE1B07));
  }
  public ref CUtlVector< CCompressor< Vector >* > VectorCompressor {
    get => ref _Handle.AsRef<CUtlVector< CCompressor< Vector >* >>(Schema.GetOffset(0x8D9A46F61A8B6EBF));
  }
  public ref CUtlVector< CCompressor< QuaternionStorage >* > QuaternionCompressor {
    get => ref _Handle.AsRef<CUtlVector< CCompressor< QuaternionStorage >* >>(Schema.GetOffset(0x8D9A46F6D4D751D4));
  }
  public ref CUtlVector< CCompressor< int32 >* > IntCompressor {
    get => ref _Handle.AsRef<CUtlVector< CCompressor< int32 >* >>(Schema.GetOffset(0x8D9A46F654D409FB));
  }
  public ref CUtlVector< CCompressor< bool >* > BoolCompressor {
    get => ref _Handle.AsRef<CUtlVector< CCompressor< bool >* >>(Schema.GetOffset(0x8D9A46F6359E7C24));
  }
  public ref CUtlVector< CCompressor< Color >* > ColorCompressor {
    get => ref _Handle.AsRef<CUtlVector< CCompressor< Color >* >>(Schema.GetOffset(0x8D9A46F6088C2B29));
  }
  public ref CUtlVector< CCompressor< Vector2D >* > Vector2DCompressor {
    get => ref _Handle.AsRef<CUtlVector< CCompressor< Vector2D >* >>(Schema.GetOffset(0x8D9A46F633C3F00D));
  }
  public ref CUtlVector< CCompressor< Vector4D >* > Vector4DCompressor {
    get => ref _Handle.AsRef<CUtlVector< CCompressor< Vector4D >* >>(Schema.GetOffset(0x8D9A46F6E178618F));
  }


}