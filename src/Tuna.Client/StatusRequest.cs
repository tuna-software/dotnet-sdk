namespace Tuna.Client;

public class StatusRequest 
{
    public string? PaymentKey { get; set; }

    public string? PartnerUniqueID { get; set; }

    public DateTime? PaymentDate { get; set; }

    public short? PaymentMethodId { get; set; }

    public List<char>? PaymentStatusList { get; set; }
}

public class BaseResponse
{
    public int Code { get; set; }

    public ResponseMessage? Message { get; set; }

    public string? OperationId { get; set; }

    public string? ExternalId { get; set; }
}
