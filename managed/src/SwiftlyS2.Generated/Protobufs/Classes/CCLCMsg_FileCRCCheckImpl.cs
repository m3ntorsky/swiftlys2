
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CCLCMsg_FileCRCCheckImpl : NetMessage<CCLCMsg_FileCRCCheck>, CCLCMsg_FileCRCCheck
{
  public CCLCMsg_FileCRCCheckImpl(nint handle, bool isManuallyAllocated): base(handle, isManuallyAllocated)
  {
  }


  public int CodePath
  { get => Accessor.GetInt32("code_path"); set => Accessor.SetInt32("code_path", value); }


  public string Path
  { get => Accessor.GetString("path"); set => Accessor.SetString("path", value); }


  public int CodeFilename
  { get => Accessor.GetInt32("code_filename"); set => Accessor.SetInt32("code_filename", value); }


  public string Filename
  { get => Accessor.GetString("filename"); set => Accessor.SetString("filename", value); }


  public uint Crc
  { get => Accessor.GetUInt32("crc"); set => Accessor.SetUInt32("crc", value); }

}
