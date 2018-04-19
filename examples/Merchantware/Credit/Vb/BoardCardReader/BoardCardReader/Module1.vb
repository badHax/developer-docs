﻿Imports BoardCardReader.MWCredit45

Module Module1

    Sub Main()
        'Create Soap Client
        Dim creditSoapClient As New CreditSoapClient
        'Create Credentials Object
        Dim merchantCredentials As New MerchantCredentials With {
            .MerchantName = "TEST MERCHANT",
            .MerchantSiteId = "XXXXXXXX",
            .MerchantKey = "XXXXX-XXXXX-XXXXX-XXXXX-XXXXX"
        }
        'Create PaymentData Object
        Dim paymentData As New PaymentData With {
            .Source = "READER",
            .TrackData = "%B4012000033330026^TEST CARD/GENIUS^191210054321000000000000000 150;4012000033330026=19121011000012345678?"
        }
        'Create Request Object
        Dim boardingRequest As New BoardingRequest
        'Process Request
        Dim vaultBoardingResponse45 As VaultBoardingResponse45
        vaultBoardingResponse45 = creditSoapClient.BoardCard(merchantCredentials, paymentData, boardingRequest)
        'Display Results
        Console.WriteLine(" Vault Token: {0} Error Code: {1} Error Message: {2}", vaultBoardingResponse45.VaultToken + vbNewLine, vaultBoardingResponse45.ErrorCode + vbNewLine, vaultBoardingResponse45.ErrorMessage + vbNewLine)
        Console.WriteLine("Press Any Key to Close")
        Console.ReadKey()
    End Sub

End Module
