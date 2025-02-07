namespace Tuna.Client;

public class InitRequest 
{

    public string? PartnerUniqueID
    {
        get ;
        set ;
    }

    public CustomerData? Customer { get; set; }

    public VendorData? Vendor { get; set; }

    public PaymentItems? PaymentItems { get; set; }

    public PaymentData? PaymentData { get; set; }

    public FrontData? FrontData { get; set; }

    public ShippingList? ShippingItems { get; set; }

    public string? OriginalRequestPayload { get; set; }

    public bool? IsTest { get; set; }

    public bool Accumulate { get; set; }

    public bool ChangeAmountOnlyOnInterest { get; set; }

    public bool IsMerchantInitiated { get; set; }

}

public class ShippingList
{
    public List<ShippingDetail>? Items { get; set; }
}

public class ShippingDetail
{
    public decimal Amount { get; set; }

    public AddressData? DeliveryAddress { get; set; }

    public string? Type { get; set; }

    public char? ShippingType { get; set; }


    public string? Code { get; set; }

    public List<string>? Items { get; set; }
}

public class CustomerData : ExtraInfo
{
    public string? ID { get; set; }

    public string? Email { internal get; set; }

    public string? Name { get; set; }

    public string? Document { internal get; set; }

    public string? DocumentType { internal get; set; }

    public DateTime? BirthDate { get; set; }

    public short? Age { get; set; }

    public string? Gender { get; set; }

    public short? DaysSinceRegistration { get; set; }

    public short? DaysSinceLastLogin { get; set; }

    public short? DaysSinceLastPasswordChange { get; set; }

    public short? DaysSinceLastPurchase { get; set; }

    public short? DaysSinceFirstPurchase { get; set; }

    public short? AmountOfPurchases { get; set; }

    public decimal? AveragePurchaseValue { get; set; }

    public short? PurchasingAttempts { get; set; }
}

public class VendorData : ExtraInfo
{
    public string? MCC { get; set; }

    public string? Code { get; set; }

    public string? Industry { get; set; }

    public string? Name { get; set; }

    public string? Document { internal get; set; }

    public string? DocumentType { internal get; set; }

    public short? DaysSinceRegistration { get; set; }

    public short? DaysSinceLastSell { get; set; }

    public short? DaysSinceFirstSell { get; set; }

    public decimal? AverageSale { get; set; }

    public string? BranchOffice { get; set; }

    public AddressData? Address { get; set; }
}

public class FrontData : ExtraInfo
{

    public List<Dictionary<string, string?>>? Sessions { get; set; }

    public string? SessionID { get; set; }

    public string? SessionID2 { get; set; }

    public string? IpAddress { get; set; }

    public string? AcceptHeader { get; set; }

    public string? UserAgent { get; set; }

    public bool? CookiesAccepted { get; set; }

    public string? AcceptLanguage { get; set; }

    public string? ColorDepth { get; set; }

    public string? ScreenHeight { get; set; }

    public string? ScreenWidth { get; set; }

    public string? TimeDifference { get; set; }

    public bool? JavaEnabled { get; set; }

    public bool? JavaScriptEnabled { get; set; }

    public string? DeviceId { get; set; }

    public string? OperatingSystem { get; set; }

    public string? LoginType { get; set; }
}

public class ClientReferenceInformation
{
    public string? Code { get; set; }
    public string? ReferenceId { get; set; }

    public string? TransactionId { get; set; }
}

public class ExternalAuthorizationInformation
{
    public string? Cavv { get; set; }
    public string? Xid { get; set; }

    public string? Eci { get; set; }
    public string? Version { get; set; }
    public string? ReferenceId { get; set; }

    public string? TransactionId { get; set; }
}

public class PaymentData : ExtraInfo
{

    public List<PaymentMethod>? PaymentMethods { get; set; }

    public AntiFraudPaymentData? AntiFraud { get; set; }

    public AddressData? DeliveryAddress { get; set; }

    public string? Countrycode { get; set; }

    public decimal Amount { get; set; }

    public decimal Interest { get; set; }

    public string? Currency { get; set; }

    public string? SalesChannel { get; set; }

    public string? Origin { get; set; }

    public string? Organization { get; set; }

    public string? SoftDescriptor { get; set; }

    public string? CallbackUrl { get; set; }
}

public class PaymentItems
{
    public List<PaymentDataDetail>? Items { get; set; }
}

public class PaymentDataDetail : ExtraInfo
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

    public short ItemQuantity { get; set; }

    public SplitData? Split { get; set; }

    public AntiFraudPaymentData? AntiFraud { get; set; }

    public string? PresentMessage { get; set; }

    public string? PresentRecipient { get; set; }

    public string? SubOrderId { get; set; }
}

public class SplitData
{

    public string? MerchantID { get; set; }

    public string? MerchantDocument { get; set; }

    public string? MerchantDocumentType { get; set; }

    public decimal? Percent { get; set; }

    public decimal? Amount { get; set; }

    public decimal? ShippingAmount { get; set; }
}

public class AntiFraudPaymentData : ExtraInfo
{
    public int? CustomerSince { get; set; }

    public string? CuponCode { get; set; }

    public string? Ean { get; set; }

    public string? DeliveryAddressee { get; set; }

    public string? DeliveryAddresseeDocument { get; set; }

    public bool? IsEmailConfirmed { get; set; }

    public bool? WasCardChanged { get; set; }

    public bool? IsPhoneNumberConfirmed { get; set; }

    public string? LoginCredential { get; set; }

    public bool? IsVIPClient { get; set; }

    public bool? IsEmployeeClient { get; set; }

    public string? DiscountCouponNumber { get; set; }

    public bool? WasAccountModified { get; set; }

    public short? DaysSinceLastAccountChange { get; set; }

    public string? FidelityNumber { get; set; }

    public short? DaysSinceFidelityRegistration { get; set; }

    public short? DaysSinceLastPointsExchange { get; set; }

    public int? FidelityBalance { get; set; }

    public int? AmountPointsLastExchange { get; set; }

    public short? PhoneChargesInLast30Days { get; set; }

    public short? MinutesChargedInLast30Days { get; set; }
}


public class CardData : ExtraInfo
{
    public string? Token { get; set; }

    public string? TokenProvider { get; set; }

    public string? CardNumber { internal get; set; }

    public string? CardHolderName { get; set; }

    public string? CVV { internal get; set; }

    public string? Alias { get; set; }

    public short? ExpirationMonth { get; set; }

    public short? ExpirationYear { get; set; }

    public BillingInfo? BillingInfo { get; set; }

    public string? ExternalProvider { get; set; }

    public string? ExternalProviderInfo { get; set; }

    public string? BrandName { get; set; }

    public int? TokenSingleUse { get; set; }

    public bool? SaveCard { get; set; }

    public bool? IsFirstUse { get; set; }

    public string? FireFields { get; set; }

    public string? CardOnFile { get; set; }
}

public class BankTransferData
{
}

public class Boleto
{
    public DateTime? Expiration { get; set; }

    public BillingInfo? BillingInfo { get; set; }
    public short? MaxOverdueDays { get; set; }
    public string? Instructions { get; set; }
    public decimal? ExtraTax { get; set; }
    public DateTime? ExtraTaxDate { get; set; }
    public decimal? Fees { get; set; }
}

public class PaymentMethod : ExtraInfo
{
    public string? PartnerUniqueID { get; set; }

    public char PaymentMethodType { get; set; }

    public decimal Amount { get; set; }

    public short Installments { get; set; }

    public CardData? CardInfo { get; set; }

    public Boleto? BoletoInfo { get; set; }

    public BankTransferData? TransferInfo { get; set; }

    public CustomerData? Customer { get; set; }

    public PixInfo? Pix { get; set; }

    public HybridOrder? Hybrid { get; set; }

    public ClientReferenceInformation? AuthenticationInformation { get; set; }

    public ExternalAuthorizationInformation? ExternalAuthorizationInformation { get; set; }

    public string? SoftDescriptor { get; set; }
}

public class PixInfo
{
    public string? Name { get; set; }

    public string? Document { internal get; set; }

    public string? DocumentType { internal get; set; }

    public int? ExpirationSeconds { get; set; }

    public string? PhoneNumber { get; set; }

    public string? CountryCode { get; set; }

    public string? Email { get; set; }
    public string? CallbackSuccess { get; set; }
    public string? CallbackFailure { get; set; }
}

public class ExtraInfo
{
    public Dictionary<string, object?>? Data { get; set; }

    public Dictionary<string, object?>? DataInternal { get; set; }

    public void InternalizeData()
    {
        if (Data != null)
            DataInternal = Data;

        Data = null;
    }
}

public class BillingInfo
{
    public string? Number { get; set; }

    public string? Document { internal get; set; }

    public string? DocumentType { internal get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public decimal? TaxedAmount { get; set; }

    public decimal? BilledAmount { get; set; }

    public AddressData? Address { get; set; }

    public DateTime? BirthDate { get; set; }
}

public class AddressData
{
    public string? Street { get; set; }

    public string? Number { get; set; }

    public string? Complement { get; set; }

    public string? Neighborhood { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? PostalCode { get; set; }

    public string? Phone { get; set; }
}

public class HybridOrder
{
    public string? LocationId { get; set; }

    public bool? PhysicalPayment { get; set; }

    public string? Nsu { get; set; }

    public string? Provider { get; set; }

    public string? AuthorizationCode { get; set; }

    public string? AcquirerPaymentId { get; set; }
}