namespace Tuna.Client;

public class BaseMethodResponse
{
    public char? MethodType { get; set; }

    public char? Status { get; set; }

    public short MethodId { get; set; }

    public string? PartnerUniqueId { get; set; }

    public string? OperationId { get; set; }

    public string? MethodKey { get; internal set; }

    public char? StatusAF { get; set; }
}