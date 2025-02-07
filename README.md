# dotnet-sdk

Basic usage: 

     TunaClient tunaClient = new TunaClient("your account","account key"); 
     
     InitRequest req = new InitRequest(){
     .......
     };

     InitResponse rsp = await tunaClient.Payments.InitPci(req).ConfigureAwait(false);


    
