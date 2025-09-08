using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFeJiggleBone : SchemaClass, IFeJiggleBone {

  public CFeJiggleBone(nint handle) : base(handle) {
  }

  public ref uint Flags {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xC064D4BDCE6E9C28));
  }
  public ref float Length {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BDFF9776DF));
  }
  public ref float TipMass {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BDEB1310B8));
  }
  public ref float YawStiffness {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BDDBF83D43));
  }
  public ref float YawDamping {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BD2F1091CC));
  }
  public ref float PitchStiffness {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BD3553FEE0));
  }
  public ref float PitchDamping {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BDDE2FCEFF));
  }
  public ref float AlongStiffness {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BD677C6B51));
  }
  public ref float AlongDamping {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BDE7D22252));
  }
  public ref float AngleLimit {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BD2A410905));
  }
  public ref float MinYaw {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BD4496E01C));
  }
  public ref float MaxYaw {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BD19C4AE42));
  }
  public ref float YawFriction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BD07FAF648));
  }
  public ref float YawBounce {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BD156E2E2A));
  }
  public ref float MinPitch {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BDE0093115));
  }
  public ref float MaxPitch {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BD1F14D2C3));
  }
  public ref float PitchFriction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BDB31D7A5D));
  }
  public ref float PitchBounce {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BDAC140AE3));
  }
  public ref float BaseMass {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BDC56419D2));
  }
  public ref float BaseStiffness {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BD32834B1B));
  }
  public ref float BaseDamping {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BDB3E982B4));
  }
  public ref float BaseMinLeft {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BD796C25E3));
  }
  public ref float BaseMaxLeft {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BDB9338D95));
  }
  public ref float BaseLeftFriction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BD591435B1));
  }
  public ref float BaseMinUp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BD993DE07B));
  }
  public ref float BaseMaxUp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BD81FA3CF9));
  }
  public ref float BaseUpFriction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BD657E3D81));
  }
  public ref float BaseMinForward {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BDF05F062B));
  }
  public ref float BaseMaxForward {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BDB071FCD9));
  }
  public ref float BaseForwardFriction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BD1DC9EF21));
  }
  public ref float Radius0 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BDB20C6987));
  }
  public ref float Radius1 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC064D4BDB10C67F4));
  }
  public ref Vector Point0 {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xC064D4BDF88AE06F));
  }
  public ref Vector Point1 {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xC064D4BDF78ADEDC));
  }
  public ref ushort CollisionMask {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xC064D4BD0CCF1BEF));
  }


}