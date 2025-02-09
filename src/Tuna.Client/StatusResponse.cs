namespace Tuna.Client;

public class StatusResponse : BaseResponse
{
    public char? Status { get; set; }

    public string? StatusDescription { get; set; }

    public string? PartnerUniqueId { get; set; }

    public List<StatusMethodResponse>? Methods { get; set; }

    public List<StatusItemResponse>? Items { get; set; }

}

public class StatusMethodResponse : BaseMethodResponse
{

    public string? StatusDescription { get; set; }

    public new string? PartnerUniqueId { get; set; }

    public decimal? CapturedAmount { get; set; }

    public decimal? BalanceAmount { get; set; }

    public decimal? Interest { get; set; }

    public string? ReviewerComments { get; set; }

    public List<ServiceStatus>? AntiFraud { get; set; }

    public List<ServiceStatus>? Acquirer { get; set; }
    
    public string? AuthorizerNsu { get; internal set; }
    
    public string? CaptureNsu { get; internal set; }
    
    public int Installments { get; internal set; }
    
    public string? TransactionId { get; internal set; }
    
    public string? Bin { get; internal set; }
    
    public string? BrandName { get; internal set; }

    public string? Seller { get; internal set; }
    
    public string? SubOrderId { get; set; }

    public List<MethodRefunds>? Refunds { get; set; }
}

public class ServiceStatus
{
    public string? Name { get; set; }

    public string? ServiceName { get; set; }

    public string? Status { get; set; }

    public string? Message { get; set; }

    public DateTime? Time { get; set; }

    public int? Order { get; set; }

    public string? RegistrationKey { get; set; }
}


public class StatusPollResponse : BaseResponse
{
    public bool PaymentMethodConfimed { get; set; }
    
    public bool AllowRetry { get; set; }

    public char? PaymentStatusFound { get; set; }
}

public class StatusItemResponse
{
    public string? DetailUniqueID { get; set; }

    public string? Sku { get; set; }

    public string? Ean { get; set; }

    public decimal Amount { get; set; }

    public decimal? ShippingAmount { get; set; }

    public decimal? DiscountAmount { get; set; }

    public int? ProductID { get; set; }

    public string? ProductUniqueID { get; set; }

    public string? ProductDescription { get; set; }

    public int? CategoryID { get; set; }

    public string? CategoryTree { get; set; }

    public string? CategoryName { get; set; }

    public short Quantity { get; set; }

    public string? SubOrderId { get; set; }
}

public class MethodRefunds
{
    public string? RefundId { get; set; }
    
    public short? Quantity { get; set; }
    
    public decimal? Amount { get; set; }

    public decimal SellerAmount { get; set; }
    
    public decimal TunaAmount { get; set; }

    public decimal PercentFee { get; set; }

    public decimal FixedFee { get; set; }

    public decimal AnticipationFee { get; set; }

    public string? MerchantId { get; set; }

    public string? MerchantName { get; set; }

    public DateTime? EventDate { get; set; }
}
