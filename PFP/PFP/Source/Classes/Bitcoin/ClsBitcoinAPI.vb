﻿
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Runtime.Serialization
Imports System.Text
'Imports BitcoinNET.ClsBitcoinNET

''' <summary>
''' this class is used for raw communication with the bitcoin-node
''' </summary>
Public Class ClsBitcoinAPI

    Property C_API_URL As String = ""
    Property API_URL() As String
        Get
            Return C_API_URL
        End Get
        Set(value As String)
            C_API_URL = value
        End Set
    End Property

    Private C_API_Wallet As String = ""
    Property API_Wallet() As String
        Get
            Return C_API_Wallet
        End Get
        Set(value As String)
            C_API_Wallet = value
        End Set
    End Property

    Private ReadOnly Property Full_API_URL As String
        Get
            Return C_API_URL + "/wallet/" + C_API_Wallet
        End Get
    End Property

    ReadOnly Property C_API_User() As String
    ReadOnly Property C_API_Password() As String

    Enum BTC_API_CALLS

        'Blockchain RPCs
        getbestblockhash = 0
        getblock = 1
        getblockchaininfo = 2
        getblockcount = 3
        getblockfilter = 4
        getblockhash = 5
        getblockheader = 6
        getblockstats = 7
        getchaintips = 8
        getchaintxstats = 9
        getdifficulty = 10
        getmempoolancestors = 11
        getmempooldescendants = 12
        getmempoolentry = 13
        getmempoolinfo = 14
        getrawmempool = 15
        gettxout = 16
        gettxoutproof = 17
        gettxoutsetinfo = 18
        preciousblock = 19
        pruneblockchain = 20
        savemempool = 21
        scantxoutset = 22
        verifychain = 23
        verifytxoutproof = 24

        'Control RPCs
        getmemoryinfo = 25
        getrpcinfo = 26
        help = 27
        logging = 28
        Stop_ = 29
        uptime = 30

        'Generating RPCs
        generateblock = 31
        generatetoaddress = 32
        generatetodescriptor = 33

        'Mining RPCs
        getblocktemplate = 34
        getmininginfo = 35
        getnetworkhashps = 36
        prioritisetransaction = 37
        submitblock = 38
        submitheader = 39

        'Network RPCs
        addnode = 40
        clearbanned = 41
        disconnectnode = 42
        getaddednodeinfo = 43
        getconnectioncount = 44
        getnettotals = 45
        getnetworkinfo = 46
        getnodeaddresses = 47
        getpeerinfo = 48
        listbanned = 49
        ping = 50
        setban = 51
        setnetworkactive = 52

        'Rawtransactions RPCs
        analyzepsbt = 53
        combinepsbt = 54
        combinerawtransaction = 55
        converttopsbt = 56
        createpsbt = 57
        createrawtransaction = 58
        decodepsbt = 59
        decoderawtransaction = 60
        decodescript = 61
        finalizepsbt = 62
        fundrawtransaction = 63
        getrawtransaction = 64
        joinpsbts = 65
        sendrawtransaction = 66
        signrawtransactionwithkey = 67
        testmempoolaccept = 68
        utxoupdatepsbt = 69

        'Util RPCs
        createmultisig = 70
        deriveaddresses = 71
        estimatesmartfee = 72
        getdescriptorinfo = 73
        getindexinfo = 74
        signmessagewithprivkey = 75
        validateaddress = 76
        verifymessage = 77

        'Wallet RPCs
        'Note:   the wallet RPCs are only available If Bitcoin Core was built With wallet support, which Is the Default.
        abandontransaction = 78
        abortrescan = 79
        addmultisigaddress = 80
        backupwallet = 81
        bumpfee = 82
        createwallet = 83
        dumpprivkey = 84
        dumpwallet = 85
        encryptwallet = 86
        getaddressesbylabel = 87
        getaddressinfo = 88
        getbalance = 89
        getbalances = 90
        getnewaddress = 91
        getrawchangeaddress = 92
        getreceivedbyaddress = 93
        getreceivedbylabel = 94
        gettransaction = 95
        getunconfirmedbalance = 96
        getwalletinfo = 97
        importaddress = 98
        importdescriptors = 99
        importmulti = 100
        importprivkey = 101
        importprunedfunds = 102
        importpubkey = 103
        importwallet = 104
        keypoolrefill = 105
        listaddressgroupings = 106
        listlabels = 107
        listlockunspent = 108
        listreceivedbyaddress = 109
        listreceivedbylabel = 110
        listsinceblock = 111
        listtransactions = 112
        listunspent = 113
        listwalletdir = 114
        listwallets = 115
        loadwallet = 116
        lockunspent = 117
        psbtbumpfee = 118
        removeprunedfunds = 119
        rescanblockchain = 120
        send = 121
        sendmany = 122
        sendtoaddress = 123
        sethdseed = 124
        setlabel = 125
        settxfee = 126
        setwalletflag = 127
        signmessage = 128
        signrawtransactionwithwallet = 129
        unloadwallet = 130
        upgradewallet = 131
        walletcreatefundedpsbt = 132
        walletlock = 133
        walletpassphrase = 134
        walletpassphrasechange = 135
        walletprocesspsbt = 136

        'getaddressesbyaccount = 11
        'listaccounts = 13

    End Enum

    Sub New(ByVal API_URL As String, ByVal API_Wallet As String, ByVal API_User As String, ByVal API_Password As String)

        C_API_URL = API_URL
        C_API_Wallet = API_Wallet

        C_API_User = API_User
        C_API_Password = API_Password

    End Sub

    Function BuildRequestString(ByVal APICall As BTC_API_CALLS, ByVal Params As String) As String

        Dim RequestString As String = "error"

        Select Case APICall

            'Blockchain RPCs
            Case BTC_API_CALLS.getbestblockhash
            Case BTC_API_CALLS.getblock
            Case BTC_API_CALLS.getblockchaininfo
            Case BTC_API_CALLS.getblockcount
            Case BTC_API_CALLS.getblockfilter
            Case BTC_API_CALLS.getblockhash
            Case BTC_API_CALLS.getblockheader
            Case BTC_API_CALLS.getblockstats
            Case BTC_API_CALLS.getchaintips
            Case BTC_API_CALLS.getchaintxstats
            Case BTC_API_CALLS.getdifficulty
            Case BTC_API_CALLS.getmempoolancestors
            Case BTC_API_CALLS.getmempooldescendants
            Case BTC_API_CALLS.getmempoolentry
            Case BTC_API_CALLS.getmempoolinfo
            Case BTC_API_CALLS.getrawmempool
                RequestString = "{""jsonrpc"":""1.0"", ""id"":1, ""method"":""getrawmempool"", ""params"":[]}"
            Case BTC_API_CALLS.gettxout
                RequestString = "{""jsonrpc"":""1.0"", ""id"":1,""method"":""gettxout"",""params"":[" + Params + "]}"
            Case BTC_API_CALLS.gettxoutproof
            Case BTC_API_CALLS.gettxoutsetinfo
                RequestString = "{""jsonrpc"":""1.0"", ""id"":1,""method"":""gettxoutsetinfo"",""params"":[]}"
            Case BTC_API_CALLS.preciousblock
            Case BTC_API_CALLS.pruneblockchain
            Case BTC_API_CALLS.savemempool
            Case BTC_API_CALLS.scantxoutset
            Case BTC_API_CALLS.verifychain
            Case BTC_API_CALLS.verifytxoutproof

                'Control RPCs
            Case BTC_API_CALLS.getmemoryinfo
            Case BTC_API_CALLS.getrpcinfo
            Case BTC_API_CALLS.help
            Case BTC_API_CALLS.logging
            Case BTC_API_CALLS.Stop_
            Case BTC_API_CALLS.uptime

                'Generating RPCs
            Case BTC_API_CALLS.generateblock
            Case BTC_API_CALLS.generatetoaddress
            Case BTC_API_CALLS.generatetodescriptor

                'Mining RPCs
            Case BTC_API_CALLS.getblocktemplate
            Case BTC_API_CALLS.getmininginfo
                RequestString = "{""jsonrpc"":""1.0"", ""id"":1, ""method"":""getmininginfo"", ""params"":[]}"
            Case BTC_API_CALLS.getnetworkhashps
            Case BTC_API_CALLS.prioritisetransaction
            Case BTC_API_CALLS.submitblock
            Case BTC_API_CALLS.submitheader

                'Network RPCs
            Case BTC_API_CALLS.addnode
            Case BTC_API_CALLS.clearbanned
            Case BTC_API_CALLS.disconnectnode
            Case BTC_API_CALLS.getaddednodeinfo
            Case BTC_API_CALLS.getconnectioncount
            Case BTC_API_CALLS.getnettotals
            Case BTC_API_CALLS.getnetworkinfo
            Case BTC_API_CALLS.getnodeaddresses
            Case BTC_API_CALLS.getpeerinfo
            Case BTC_API_CALLS.listbanned
            Case BTC_API_CALLS.ping
            Case BTC_API_CALLS.setban
            Case BTC_API_CALLS.setnetworkactive

                'Rawtransactions RPCs
            Case BTC_API_CALLS.analyzepsbt
            Case BTC_API_CALLS.combinepsbt
            Case BTC_API_CALLS.combinerawtransaction
            Case BTC_API_CALLS.converttopsbt
            Case BTC_API_CALLS.createpsbt
            Case BTC_API_CALLS.createrawtransaction
            Case BTC_API_CALLS.decodepsbt
            Case BTC_API_CALLS.decoderawtransaction
                RequestString = "{""jsonrpc"":""1.0"", ""id"":1,""method"":""decoderawtransaction"",""params"":[" + Params + "]}"
            Case BTC_API_CALLS.decodescript
                RequestString = "{""jsonrpc"":""1.0"", ""id"":1,""method"":""decodescript"",""params"":[" + Params + "]}"
            Case BTC_API_CALLS.finalizepsbt
            Case BTC_API_CALLS.fundrawtransaction
            Case BTC_API_CALLS.getrawtransaction
                RequestString = "{""jsonrpc"":""1.0"", ""id"":1,""method"":""getrawtransaction"",""params"":[" + Params + "]}"
            Case BTC_API_CALLS.joinpsbts
            Case BTC_API_CALLS.sendrawtransaction
                RequestString = "{""jsonrpc"":""1.0"", ""id"":1,""method"":""sendrawtransaction"",""params"":[" + Params + "]}"
            Case BTC_API_CALLS.signrawtransactionwithkey
            Case BTC_API_CALLS.testmempoolaccept
            Case BTC_API_CALLS.utxoupdatepsbt

                'Util RPCs
            Case BTC_API_CALLS.createmultisig
            Case BTC_API_CALLS.deriveaddresses
            Case BTC_API_CALLS.estimatesmartfee
            Case BTC_API_CALLS.getdescriptorinfo
            Case BTC_API_CALLS.getindexinfo
            Case BTC_API_CALLS.signmessagewithprivkey
            Case BTC_API_CALLS.validateaddress
            Case BTC_API_CALLS.verifymessage
                RequestString = "{""jsonrpc"":""1.0"", ""id"":1,""method"":""verifymessage"",""params"":[" + Params + "]}"
                'Wallet RPCs
                'Note:   the wallet RPCs are only available If Bitcoin Core was built With wallet support, which Is the Default.
            Case BTC_API_CALLS.abandontransaction
            Case BTC_API_CALLS.abortrescan
            Case BTC_API_CALLS.addmultisigaddress
            Case BTC_API_CALLS.backupwallet
            Case BTC_API_CALLS.bumpfee
            Case BTC_API_CALLS.createwallet
                'TODO: create wallet
                RequestString = "{""jsonrpc"":""1.0"", ""id"":1,""method"":""createwallet"",""params"":[" + Params + "]}"
            Case BTC_API_CALLS.dumpprivkey
                RequestString = "{""jsonrpc"":""1.0"", ""id"":1,""method"":""dumpprivkey"",""params"":[" + Params + "]}"
            Case BTC_API_CALLS.dumpwallet
            Case BTC_API_CALLS.encryptwallet
            Case BTC_API_CALLS.getaddressesbylabel
            Case BTC_API_CALLS.getaddressinfo
            Case BTC_API_CALLS.getbalance
            Case BTC_API_CALLS.getbalances
            Case BTC_API_CALLS.getnewaddress
            Case BTC_API_CALLS.getrawchangeaddress
            Case BTC_API_CALLS.getreceivedbyaddress
            Case BTC_API_CALLS.getreceivedbylabel
            Case BTC_API_CALLS.gettransaction
                RequestString = "{""jsonrpc"":""1.0"", ""id"":1,""method"":""gettransaction"",""params"":[" + Params + "]}"
            Case BTC_API_CALLS.getunconfirmedbalance
            Case BTC_API_CALLS.getwalletinfo
            Case BTC_API_CALLS.importaddress
                'TODO: import address after create wallet
                '["myaddress", "testing", false]
                RequestString = "{""jsonrpc"":""1.0"", ""id"":1,""method"":""importaddress"",""params"":[" + Params + "]}"
            Case BTC_API_CALLS.importdescriptors
            Case BTC_API_CALLS.importmulti
            Case BTC_API_CALLS.importprivkey
            Case BTC_API_CALLS.importprunedfunds
            Case BTC_API_CALLS.importpubkey
            Case BTC_API_CALLS.importwallet
            Case BTC_API_CALLS.keypoolrefill
            Case BTC_API_CALLS.listaddressgroupings
                RequestString = "{""jsonrpc"":""1.0"", ""id"":1,""method"":""listaddressgroupings"",""params"":[]}"
            Case BTC_API_CALLS.listlabels
            Case BTC_API_CALLS.listlockunspent
            Case BTC_API_CALLS.listreceivedbyaddress
                RequestString = "{""jsonrpc"":""1.0"", ""id"":1,""method"":""listreceivedbyaddress"",""params"":[" + Params + "]}"
            Case BTC_API_CALLS.listreceivedbylabel
            Case BTC_API_CALLS.listsinceblock
            Case BTC_API_CALLS.listtransactions
                RequestString = "{""jsonrpc"":""1.0"", ""id"":1,""method"":""listtransactions"",""params"":[" + Params + "]}"
            Case BTC_API_CALLS.listunspent

                If Params.Trim = "" Then
                    RequestString = "{""jsonrpc"":""1.0"", ""id"":1,""method"":""listunspent"",""params"":[" + Params + "]}"
                Else
                    RequestString = "{""jsonrpc"":""1.0"", ""id"":1,""method"":""listunspent"",""params"": [1, 9999999, [" + Params + "]]}"
                End If

            Case BTC_API_CALLS.listwalletdir
            Case BTC_API_CALLS.listwallets
            Case BTC_API_CALLS.loadwallet
                RequestString = "{""jsonrpc"":""1.0"", ""id"":1,""method"":""loadwallet"",""params"":[" + Params + "]}"
            Case BTC_API_CALLS.lockunspent
            Case BTC_API_CALLS.psbtbumpfee
            Case BTC_API_CALLS.removeprunedfunds
            Case BTC_API_CALLS.rescanblockchain
            Case BTC_API_CALLS.send
            Case BTC_API_CALLS.sendmany
            Case BTC_API_CALLS.sendtoaddress
                RequestString = "{""jsonrpc"":""1.0"", ""id"":1, ""method"":""sendtoaddress"", ""params"":[" + Params + "]}"
            Case BTC_API_CALLS.sethdseed
            Case BTC_API_CALLS.setlabel
            Case BTC_API_CALLS.settxfee
                RequestString = "{""jsonrpc"":""1.0"", ""id"":1, ""method"":""settxfee"", ""params"":[" + Params + "]}"
            Case BTC_API_CALLS.setwalletflag
            Case BTC_API_CALLS.signmessage
            Case BTC_API_CALLS.signrawtransactionwithwallet
            Case BTC_API_CALLS.unloadwallet
                RequestString = "{""jsonrpc"":""1.0"", ""id"":1,""method"":""unloadwallet"",""params"":[" + Params + "]}"
            Case BTC_API_CALLS.upgradewallet
            Case BTC_API_CALLS.walletcreatefundedpsbt
            Case BTC_API_CALLS.walletlock
            Case BTC_API_CALLS.walletpassphrase
                RequestString = "{""jsonrpc"":""1.0"", ""id"":1, ""method"":""walletpassphrase"", ""params"":[" + Params + "]}"
            Case BTC_API_CALLS.walletpassphrasechange
            Case BTC_API_CALLS.walletprocesspsbt
            Case Else
                RequestString = "error"
        End Select

        Return RequestString
    End Function

    Function ReqStrToByte(ByVal RequestString As String) As Byte()
        Dim ByteArray As Byte() = Encoding.UTF8.GetBytes(RequestString)
        Return ByteArray
    End Function


    'Public Function SendToAddress(ByVal Address As String, ByVal Amount As Double, Optional ByVal Fee As Double = 0.00000001) As String

    '    Dim k = RequestFromBitcoinWallet(API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.getmininginfo, "")))

    '    'Fee set
    '    Dim ResponseString As String = RequestFromBitcoinWallet(API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.settxfee, Math.Round(Fee, 8).ToString.Replace(",", "."))))

    '    If Not ResponseString.Trim = "" Then
    '        'set passphrase for 10 seconds
    '        ResponseString = RequestFromBitcoinWallet(API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.walletpassphrase, """" + Wallet_PassPhrase + """, 10")))

    '        If Not ResponseString.Trim = "" Then
    '            'send amount to recipient
    '            ResponseString = RequestFromBitcoinWallet(API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.sendtoaddress, """" + Address + """, " + Math.Round(Amount, 8).ToString.Replace(",", ".") + ","""",""""")))

    '        End If
    '    End If

    '    Return ResponseString
    'End Function


    Public Function GetTXOutSetInfo() As String
        Dim TXOUT As String = RequestFromBitcoinNode(Full_API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.gettxoutsetinfo, "")))
        Return TXOUT
    End Function

    Public Function ListTransactions(ByVal Account As String, Optional ByVal Count As Integer = 10, Optional ByVal From As Integer = 0) As String
        Dim TXs As String = RequestFromBitcoinNode(Full_API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.listtransactions, """" + Account + """, " + Count.ToString + ", " + From.ToString + "")))
        Return TXs
    End Function

    Public Function GetRawMempool() As String
        Dim Mempool As String = RequestFromBitcoinNode(Full_API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.getrawmempool, "")))
        Return Mempool
    End Function

    ''' <summary>
    ''' Gets the unconfirmed transaction output
    ''' </summary>
    ''' <param name="TX">The Transaction to check</param>
    ''' <param name="VOut">The output index of the given Transaction</param>
    ''' <param name="UnconformedToo">The Boolean to check in Unconfirmed ones</param>
    ''' <returns>vout,confirmations,value and hex of the lockingscript</returns>
    Public Function GetTXOut(ByVal TX As String, ByVal VOut As Integer, Optional ByVal UnconformedToo As Boolean = True) As String
        Dim TXOUT As String = RequestFromBitcoinNode(Full_API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.gettxout, """" + TX + """, " + VOut.ToString + ", " + UnconformedToo.ToString.ToLower + "")))

        Dim JSON As ClsJSON = New ClsJSON
        Dim XML As String = JSON.JSONToXML(TXOUT)

        Dim Confirmations As String = JSON.RecursiveXMLSearch(XML, "confirmations").ToString
        Dim Value As String = JSON.RecursiveXMLSearch(XML, "value").ToString
        Dim HEX As String = JSON.RecursiveXMLSearch(XML, "hex").ToString

        If Not Confirmations.Trim = "" Or Not Value.Trim = "" Or Not HEX.Trim = "" Then
            Return "<vout>" + VOut.ToString + "</vout><confirmations>" + Confirmations + "</confirmations><value>" + Value + "</value><hex>" + HEX + "</hex>"
        Else
            Return ""
        End If


        '{
        '	"result":
        '	{
        '		"bestblock":"000000000000000f45c8efa2e3eb383125ce3154ab9030582c96d686de204442",
        '		"confirmations":0,
        '		"value":0.00008100,
        '		"scriptPubKey":
        '		{
        '			"asm":"OP_DUP OP_HASH160 5176b296b00f400de0ea44dae8691d7715a29620 OP_EQUALVERIFY OP_CHECKSIG", 
        '			"hex":"76a9145176b296b00f400de0ea44dae8691d7715a2962088ac", 
        '			"address":"mnwhDr5MPnqPSnaux2Gro6t6NZoXjcSLUp", 
        '			"type":"pubkeyhash"
        '		},
        '		"coinbase":false
        '	},
        '	"error":null, "id": 1
        '}


    End Function

    Public Function GetRawTransaction(ByVal TX As String) As String
        Dim RawTxInfo As String = RequestFromBitcoinNode(Full_API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.getrawtransaction, """" + TX + """")))
        Return RawTxInfo

        '{
        '	"result":"0200000000010124d3ed953e57bd7785b54accd4f5c9729004b4c9c546a48b398239a6e4b1cb560000000000feffffff0210270000000000001976a914aa08a90b8b1d81da80deaf11564ab5b71bb7bf6288ac594e050000000000160014444c726b593faad2cbea9adc438b8834aaf483800247304402200c34d9c68ab9e9feae28e23efe37648e1ac0055ef55facede0ade92b507e1d29022021edc740861524d1c09190dcc4cdfe677b6e7e4503acf462e48d37cb41c4f9e301210376493706530b47ed1951460716cd49f9112188ddd72dc3fed016a1b3f6aa963258d52300",
        '	"error":null,
        '    "id": 1
        '}

    End Function

    Public Function GetRawTransaction(ByVal TX As String, Optional ByVal Path As String = "result/vout", Optional ByVal SenderRIPE160 As String = "") As List(Of String)
        Dim RawTxInfo As String = GetRawTransaction(TX)

        If RawTxInfo.Contains("result") Then
            Dim JSON As ClsJSON = New ClsJSON
            Dim JSONList As List(Of Object) = JSON.JSONRecursive(RawTxInfo)
            Dim Result As String = JSON.RecursiveListSearch(JSONList, "result").ToString

            RawTxInfo = DecodeRawTransaction(Result)

            Dim XML_Vouts As List(Of String) = JSON.GetFromJSON(RawTxInfo, Path, SenderRIPE160)

            Return XML_Vouts
        Else
            Return New List(Of String)
        End If

    End Function

    Public Function VerifyMessage(ByVal Address As String, ByVal Signature As String, ByVal Message As String) As String
        Dim VerifyResponse As String = RequestFromBitcoinNode(Full_API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.verifymessage, """" + Address + """, """ + Signature + """, """ + Message + """")))
        Return VerifyResponse
    End Function

    Public Function CreateWallet(ByVal Name As String, Optional ByVal Description As String = "", Optional ByVal Rescan As Boolean = True) As String
        Dim CreateWalletResponse As String = "{""result"":{""name"":""" + Name.Trim + """,""warning"":""""},""Error"":null,""id"":1}"
        If Not Description.Trim = "" Or Not Rescan Then
            CreateWalletResponse = RequestFromBitcoinNode(Full_API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.createwallet, """" + Name + """, """ + Description + """, """ + Rescan.ToString.ToLower + """")))
        Else
            CreateWalletResponse = RequestFromBitcoinNode(Full_API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.createwallet, """" + Name + """")))
        End If

        API_Wallet = Name

        Return CreateWalletResponse

        'Dim JSON As ClsJSON = New ClsJSON
        'Dim XMLList As List(Of String) = JSON.GetFromJSON(CreateWalletResponse, "result/")

        'For Each XML As String In XMLList

        '    If XML.Contains("warning") Then

        '        Dim Warn As String = GetStringBetween(XML, "<warning>", "</warning>").Trim

        '        If Warn <> "" Then
        '            Return Warn
        '        End If

        '    End If

        'Next

        'Return "ok"
    End Function

    Public Function LoadWallet(ByVal WalletName As String) As String

        Dim Response As String = "{""result"":{""name"":""" + WalletName.Trim + """,""warning"":""""},""Error"":null,""id"":1}"
        Response = RequestFromBitcoinNode(Full_API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.loadwallet, """" + WalletName + """")))
        API_Wallet = WalletName
        Return Response

    End Function

    Public Function UnloadWallet(ByVal WalletName As String) As String

        Dim Response As String = "{""result"":{""name"":""" + WalletName.Trim + """,""warning"":""""},""Error"":null,""id"":1}"
        Response = RequestFromBitcoinNode(Full_API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.unloadwallet, """" + WalletName + """")))
        API_Wallet = WalletName
        Return Response

    End Function

    Public Function ImportAddress(ByVal Address As String, Optional ByVal Label As String = "", Optional ByVal Rescan As Boolean = False) As String
        '["myaddress", "testing", false]
        Dim ImportAddressResponse As String = RequestFromBitcoinNode(Full_API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.importaddress, """" + Address + """, """ + Label + """, " + Rescan.ToString.ToLower)), 600000)
        Return ImportAddressResponse
    End Function

    Public Function SendRawTransaction(ByVal RawTX As String) As String
        Dim SendRawTXResponse As String = RequestFromBitcoinNode(Full_API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.sendrawtransaction, """" + RawTX + """")))
        Return SendRawTXResponse
    End Function

    Public Function DecodeRawTransaction(ByVal RawTX As String) As String
        Dim DecRawTx As String = RequestFromBitcoinNode(Full_API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.decoderawtransaction, """" + RawTX + """")))
        Return DecRawTx
    End Function

    Public Function DecodeScript(ByVal Script As String) As String
        Dim DecScript As String = RequestFromBitcoinNode(Full_API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.decodescript, """" + Script + """")))
        Return DecScript
    End Function

    Public Function GetTransaction(ByVal TX As String) As String
        LoadWallet()
        Dim GetTX As String = RequestFromBitcoinNode(Full_API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.gettransaction, """" + TX + """")))
        Return GetTX
    End Function


    Private Function LoadWallet()
        Dim T_LoadWallet As String = RequestFromBitcoinNode(Full_API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.loadwallet, """" + API_Wallet + """")))
        Return T_LoadWallet
    End Function


    'Public Function GetTransactionInfo(ByVal TX As String) As String
    '    Dim TxInfo As String = RequestFromBitcoinWallet(Full_API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.gettransaction, """" + TX + """")))

    '    Dim JSON As ClsJSON = New ClsJSON
    '    Dim JSONList As List(Of Object) = JSON.JSONRecursive(TxInfo)
    '    Dim Obj As Object = JSON.RecursiveListSearch(JSONList, "result")
    '    TxInfo = JSON.JSONListToXMLRecursive(Obj)

    '    Return TxInfo
    'End Function


    Public Function GetMiningInfo() As String
        Dim MiningInfo As String = RequestFromBitcoinNode(Full_API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.getmininginfo, "")), 1000)
        Return MiningInfo
    End Function

    Public Function ListReceivedByAddress() As List(Of String)
        Dim AddressTX As String = RequestFromBitcoinNode(Full_API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.listreceivedbyaddress, "0, true")))
        Dim JSON As ClsJSON = New ClsJSON
        Dim XML_Addresses As List(Of String) = JSON.GetFromJSON(AddressTX, "result/")
        Return XML_Addresses
    End Function

    Public Function ListUnspent(Optional ByVal Address As String = "") As List(Of String)
        LoadWallet()
        If Address.Trim <> "" Then
            Address = """" + Address + """"
        End If

        Dim Unspends As String = RequestFromBitcoinNode(Full_API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.listunspent, Address)))
        Dim JSON As ClsJSON = New ClsJSON
        Dim XML_Vouts As List(Of String) = JSON.GetFromJSON(Unspends, "result/")
        Return XML_Vouts
    End Function


    Public Function ListAddressGroupings()
        Dim AddresseGrps As String = RequestFromBitcoinNode(Full_API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.listaddressgroupings, "")))
        Return AddresseGrps
    End Function


    Public Function DumpPrivKey(ByVal Address As String) As String
        Dim PrivKey As String = RequestFromBitcoinNode(Full_API_URL, ReqStrToByte(BuildRequestString(BTC_API_CALLS.dumpprivkey, """" + Address + """")))
        Return PrivKey
    End Function


    Function RequestFromBitcoinNode(ByVal URL As String, ByVal ByteArray As Byte(), Optional ByVal TimeOut As Integer = 100000) As String

        Try

            Dim Request As HttpWebRequest
            Request = WebRequest.Create(URL)

            If C_API_User.Trim = "" Or C_API_Password.Trim = "" Then
                Return ""
            End If

            Request.Credentials = New NetworkCredential(C_API_User, C_API_Password)
            Request.Method = "POST"
            Request.ContentType = "application/json-rpc;"
            Request.Timeout = TimeOut

            Request.ContentLength = ByteArray.Length
            Dim RequestStream As Stream = Request.GetRequestStream()

            RequestStream.Write(ByteArray, 0, ByteArray.Length)
            RequestStream.Close()

            Dim WebResponse As WebResponse = Request.GetResponse()

            Dim ResponseStream As Stream = WebResponse.GetResponseStream
            Dim ResponseReader As New StreamReader(ResponseStream)
            Dim Responsemsg As String = ResponseReader.ReadToEnd()

            Return Responsemsg

        Catch ex As WebException

            Try
                Dim x = New StreamReader(ex.Response.GetResponseStream())
                Dim xstr As String = x.ReadToEnd()
                Return xstr

                Dim out As ClsOut = New ClsOut(Application.StartupPath)
                out.ErrorLog2File(ex.Message)

            Catch exep As Exception
                Return Application.ProductName + "-error in RequestFromBitcoinNode(" + URL + ", " + ByteArrayToHEXString(ByteArray) + ", " + TimeOut.ToString() + ") -> ConvertThread(): " + exep.Message
            End Try

        End Try

    End Function

End Class