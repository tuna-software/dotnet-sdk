namespace Tuna.Client;

public class InitResponse
{

    public char? Status { get; set; }

    public List<InitMethodResponse>? Methods { get; set; }

    public string? PaymentKey { get; set; }

    public string? PartnerUniqueId { get; set; }

    public int Code { get; set; }

    public ResponseMessage? Message { get; set; }

    public string? OperationId { get; set; }

    public string? ExternalId { get; set; }
}


public class ResponseMessage
{
    public int Source { get; set; }

    public string? Code { get; set; }

    public string? Message { get; set; }

    public string? Info { get; set; }
}

public class InitMethodResponse
{
    public char? MethodType { get; set; }

    public char? Status { get; set; }

    public short MethodId { get; set; }

    public string? OperationId { get; set; }

    public string? MethodKey { get;  set; }

    public string? StatusAF { get;  set; }

    public ResponseMessage? Message { get; set; }

    public object? AdditionalInfo { get; set; }

    public RedirectInfo? RedirectInfo { get; set; }

    public PixResponseInfo? PixInfo { get; set; }

    public BoletoInfo? BoletoInfo { get; set; }

    public CardInfo? CardInfo { get; set; }

    public CryptoResponseInfo? CryptoInfo { get; set; }

    public ThreeDSInfo? ThreeDSInfo { get; set; }

    public ExternalInfo? ExternalInfo { get; set; }

    public SetupPayerInfo? SetupPayerInfo { get; set; }

    public Dictionary<string, string?>? AntiFraudResults { get; set; }

    public List<ServiceStatus>? AntiFraud { get; set; }

    public List<ServiceStatus>? Acquirer { get; set; }
}

public class RedirectInfo
{
    public string? Url { get; set; }

    public Dictionary<string, object?>? FormInfo { get; set; }
}

public class PixResponseInfo
{
    public string? QRContent { get; set; }

    public string? QRImage { get; set; }

    public string? QRCopyPaste { get; set; }

    public string? Txid { get; set; }

    public int? Expiration { get; set; }
}

public class BoletoInfo
{
    public string? DownloadUrl { get; set; }

    public string? BoletoCode { get; set; }
}

public class CardInfo
{
    public string? Bin { get; set; }

    public string? AuthorizeNsu { get; set; }

    public string? TransactionId { get; set; }

    public string? AuthorizeCode { get; set; }

    public string? BrandName { get; set; }

}

public class CryptoResponseInfo
{
    public string? CoinValue { get; set; }

    public string? CoinRateCurrency { get; set; }

    public string? CoinAddr { get; set; }

    public string? CoinQRCodeUrl { get; set; }

    public string? Coin { get; set; }
}

public class ThreeDSInfo
{
    public string? Url { get; set; }

    public string? Provider { get; set; }

    public string? Token { get; set; }

    public string? PaRequest { get; set; }
}

public class SetupPayerInfo
{
    public string? AccessToken { get; set; }
    public string? deviceDataCollectionUrl { get; set; }

    public string? referenceId { get; set; }
    public string? token { get; set; }

    public string? transactionId { get; set; }

    public string? paymentMethodIdentifier { get; set; }
}

public class ExternalInfo
{
    public string? SessionId { get; set; }
}
public class ServiceStatus
{
    public string? Name { get; set; }

    public string? Status { get; set; }

    public string? Message { get; set; }

    public string? ResultId { get; set; }

    public Dictionary<string, string>? Info { get; internal set; }
}