using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPathTrack : CPointEntity, IPathTrack {

  public CPathTrack(nint handle) : base(handle) {
  }

  public CPathTrack(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPathTrack Pnext {
    get => new CPathTrack(_Handle + Schema.GetOffset(0xF86750E8B008D5EE));
  }
  public IPathTrack Pprevious {
    get => new CPathTrack(_Handle + Schema.GetOffset(0xF86750E8BD38AFD2));
  }
  public IPathTrack Paltpath {
    get => new CPathTrack(_Handle + Schema.GetOffset(0xF86750E868D10551));
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF86750E85ACFC08D));
  }
  public ref float Length {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF86750E83AFED1B5));
  }
  public ref CUtlSymbolLarge AltName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xF86750E8501CA457));
  }
  public ref int IterVal {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xF86750E808061552));
  }
  public ref TrackOrientationType_t OrientationType {
    get => ref _Handle.AsRef<TrackOrientationType_t>(Schema.GetOffset(0xF86750E8468ECE0A));
  }
  public IEntityIOOutput OnPass {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xF86750E89B527249));
  }


}