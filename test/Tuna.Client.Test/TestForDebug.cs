namespace Tuna.Client.Test;
using Tuna.Client;

public class TestForDebug
{
    [Fact]
    public async Task Test()
    {
        TunaClient tunaClient = new TunaClient("",""); 


        var json = """
{
  "PartnerUniqueID": "test-client-c#",
  "Customer": {
    "Email": "test2@tuna.uy",
    "Name": "M R",
    "ID": "tuna_123s4",
    "Document": "80150446981",
    "DocumentType": "CPF"
  },
  "PaymentItems": {
    "Items": [
      {
        "DetailUniqueID": "40c80d93-b752-4d83-b797-3dfb0b0ce2a5",
        "Amount": 3,
        "ProductID": 2,
        "ProductDescription": "Product Description",
        "CategoryID": 819,
        "CategoryName": "Category Name",
        "ItemQuantity": 5
        },
        { "DetailUniqueID": "40c80d93-b752-4d83-b797-3dfb0b0ce2a4",
        "Amount": 7.5,
        "ProductID": 1,
        "ProductDescription": "Product Description",
        "CategoryID": 166,
        "CategoryName": "Category Name",
        "ItemQuantity": 1
      }
    ]
  },
  "PaymentData": {
    "PaymentMethods": [
      {
        "PaymentMethodType": "D",
        "Amount":22.5,
        "Pix": {
          "Name": "M R",
          "Document": "80150446981",
          "DocumentType": "CPF"
        }
      }
    ],
    "Countrycode": "BR"
  },
  "FrontData": {
    "SessionID": "SessionID1",
    "IpAddress": "10.9.199.27"
  }
}
""";

        InitRequest req = System.Text.Json.JsonSerializer.Deserialize<InitRequest>(json)!;

        await tunaClient.Payments.InitPci(req).ConfigureAwait(false);
    }
}