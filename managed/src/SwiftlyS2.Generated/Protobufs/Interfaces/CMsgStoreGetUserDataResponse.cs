
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgStoreGetUserDataResponse : ITypedProtobuf<CMsgStoreGetUserDataResponse>
{
  static CMsgStoreGetUserDataResponse ITypedProtobuf<CMsgStoreGetUserDataResponse>.Wrap(nint handle) => new CMsgStoreGetUserDataResponseImpl(handle);


  public int Result { get; set; }


  public int CurrencyDeprecated { get; set; }


  public string CountryDeprecated { get; set; }


  public int PriceSheetVersion { get; set; }


  public byte[] PriceSheet { get; set; }

}
