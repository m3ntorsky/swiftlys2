
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CUIFontFilePackagePB_CUIEncryptedFontFilePB : ITypedProtobuf<CUIFontFilePackagePB_CUIEncryptedFontFilePB>
{
  static CUIFontFilePackagePB_CUIEncryptedFontFilePB ITypedProtobuf<CUIFontFilePackagePB_CUIEncryptedFontFilePB>.Wrap(nint handle) => new CUIFontFilePackagePB_CUIEncryptedFontFilePBImpl(handle);


  public byte[] EncryptedContents { get; set; }

}
