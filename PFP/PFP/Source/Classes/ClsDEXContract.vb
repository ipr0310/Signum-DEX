﻿Option Strict On
Option Explicit On

Public Class ClsDEXContract

#Region "SmartContract Structure"
    'SmartContract: 8372890871867317775

    'ActivateDeactivateDispute: -9199918549131231789

    'CreateOrderWithResponder: -5335884675757206276
    'CreateOrder: 716726961670769723
    'AcceptOrder: 4714436802908501638
    'InjectResponder: 9213622959462902524

    'OpenDispute: 7510787419861318753
    'MediateDispute: 1115156232660555199
    'Appeal: 7341272028202959329
    'CheckCloseDispute: -5140474353491861087

    'FinishOrder: 3125596792462301675

    'InjectChainSwapHash: 2770910189976301362
    'FinishOrderWithChainSwapKey: -3992805468895771487

#End Region

    'Public Const _ReferenceTX As ULong = 8372890871867317775UL
    'Public Const _ReferenceTXFullHash As String = "0f1ec3f0e27b327479e559b51a5f32338a60431ec59a64a252269c17932917c8" 
    'Public Const _DeployFeeNQT As ULong = 230000000UL
    'Public Const _GasFeeNQT As ULong = 40000000UL

    Public ReadOnly Property ReferenceDeActivateDeniability As ULong = BitConverter.ToUInt64(BitConverter.GetBytes(-9199918549131231789L), 0) '805352d2a4817dd3

    Public ReadOnly Property ReferenceCreateOrderWithResponder As ULong = BitConverter.ToUInt64(BitConverter.GetBytes(-5335884675757206276L), 0) 'b5f321287b0a94fc
    Public ReadOnly Property ReferenceCreateOrder As ULong = BitConverter.ToUInt64(BitConverter.GetBytes(716726961670769723L), 0) '09f2535fcf54cc3b
    Public ReadOnly Property ReferenceAcceptOrder As ULong = BitConverter.ToUInt64(BitConverter.GetBytes(4714436802908501638L), 0) '416d0b4b4963b686
    Public ReadOnly Property ReferenceInjectResponder As ULong = BitConverter.ToUInt64(BitConverter.GetBytes(9213622959462902524L), 0) '7fdd5d44092b6afc

    Public ReadOnly Property ReferenceOpenDispute As ULong = BitConverter.ToUInt64(BitConverter.GetBytes(7510787419861318753L), 0) '683bad5d504e7c61
    Public ReadOnly Property ReferenceMediateDispute As ULong = BitConverter.ToUInt64(BitConverter.GetBytes(1115156232660555199L), 0) '0f79d4af6ccb95bf '1115156232660555199
    Public ReadOnly Property ReferenceAppeal As ULong = BitConverter.ToUInt64(BitConverter.GetBytes(7341272028202959329L), 0) '65e17003908c81e1
    Public ReadOnly Property ReferenceCheckCloseDispute As ULong = BitConverter.ToUInt64(BitConverter.GetBytes(-5140474353491861087L), 0) 'b8a95dcf971ca1a1

    Public ReadOnly Property ReferenceFinishOrder As ULong = BitConverter.ToUInt64(BitConverter.GetBytes(3125596792462301675L), 0) '2b6059b8fdd0d9eb

    Public ReadOnly Property ReferenceInjectChainSwapHash As ULong = BitConverter.ToUInt64(BitConverter.GetBytes(2770910189976301362L), 0) '267440230a0c2f32
    Public ReadOnly Property ReferenceFinishOrderWithChainSwapKey As ULong = BitConverter.ToUInt64(BitConverter.GetBytes(-3992805468895771487L), 0) 'c896b494b13b04a1

    Private Property C_StartForm As PFPForm

#Region "Properties"

    Private Property C_Node As String = ""
    Public Property Node() As String
        Get
            Return C_Node
        End Get
        Set(value As String)
            C_Node = value
        End Set
    End Property

    Private Property C_DEXContract As Boolean = False
    Public ReadOnly Property IsDEXContract() As Boolean
        Get
            Return C_DEXContract
        End Get
    End Property

    Private Property C_IsReady As Boolean = False
    Public ReadOnly Property IsReady() As Boolean
        Get
            Return C_IsReady
        End Get
    End Property


    Private Property C_ContractTimestamp As ULong = 0UL
    Public ReadOnly Property ContractTimestamp() As ULong
        Get
            Return C_ContractTimestamp
        End Get
    End Property

    Private ReadOnly Property C_ID As ULong = 0UL
    Public ReadOnly Property ID() As ULong
        Get
            Return C_ID
        End Get
    End Property

    Private Property C_Address As String = ""
    Public ReadOnly Property Address() As String
        Get
            Return C_Address
        End Get
    End Property

    Private Property C_Name As String = ""
    Public ReadOnly Property Name() As String
        Get
            Return C_Name
        End Get
    End Property

    Private Property C_Description As String = ""
    Public ReadOnly Property Description() As String
        Get
            Return C_Description
        End Get
    End Property

    Private Property C_CreatorID As ULong = 0UL
    Public ReadOnly Property CreatorID() As ULong
        Get
            Return C_CreatorID
        End Get
    End Property

    Private Property C_CreatorAddress As String = ""
    Public ReadOnly Property CreatorAddress() As String
        Get
            Return C_CreatorAddress
        End Get
    End Property


    Private Property C_CurrentCreationTransaction As ULong
    Public ReadOnly Property CurrentCreationTransaction As ULong
        Get
            Return C_CurrentCreationTransaction
        End Get
    End Property

    Private Property C_CurrentConfirmations As ULong
    Public ReadOnly Property CurrentConfirmations As ULong
        Get
            Return C_CurrentConfirmations
        End Get
    End Property

    Private Property C_CurrentTimestamp As ULong = 0UL
    Public ReadOnly Property CurrentTimestamp() As ULong
        Get
            Return C_CurrentTimestamp
        End Get
    End Property

    Private Property C_CurrentInitiatorID As ULong = 0UL
    Public ReadOnly Property CurrentInitiatorID() As ULong
        Get
            Return C_CurrentInitiatorID
        End Get
    End Property

    Private Property C_CurrentInitiatorAddress As String = ""
    Public ReadOnly Property CurrentInitiatorAddress() As String
        Get
            Return C_CurrentInitiatorAddress
        End Get
    End Property

    Private Property C_CurrentResponderID As ULong = 0UL
    Public ReadOnly Property CurrentResponderID() As ULong
        Get
            Return C_CurrentResponderID
        End Get
    End Property

    Private Property C_CurrentResponderAddress As String = ""
    Public ReadOnly Property CurrentResponserAddress() As String
        Get
            Return C_CurrentResponderAddress
        End Get
    End Property
    Private Property C_IsSellOrder As Boolean = False
    Public ReadOnly Property IsSellOrder() As Boolean
        Get
            Return C_IsSellOrder
        End Get
    End Property

    Private Property C_Deniability As Boolean = False
    Public ReadOnly Property Deniability() As Boolean
        Get
            Return C_Deniability
        End Get
    End Property

    Private Property C_Dispute As Boolean = False
    Public ReadOnly Property Dispute() As Boolean
        Get
            Return C_Dispute
        End Get
    End Property

    Private Property C_Objection As Boolean = False
    Public ReadOnly Property CurrentObjection() As Boolean
        Get
            Return C_Objection
        End Get
    End Property

    Public ReadOnly Property BlocksLeft() As Long
        Get
            Dim diffblock As Long = 0
            diffblock = CLng(CurrentDisputeTimeout) - CLng(GetBlock())
            Return diffblock

        End Get
    End Property

    Private Property C_DisputeTimeout As ULong = 0UL
    ''' <summary>
    ''' Gets the TimeOut in Block
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property CurrentDisputeTimeout() As ULong
        Get
            Return C_DisputeTimeout
        End Get
    End Property


    Private Property C_CurrentSellerID As ULong = 0UL
    Public ReadOnly Property CurrentSellerID() As ULong
        Get
            Return C_CurrentSellerID
        End Get
    End Property
    Private Property C_CurrentSellerAddress As String = ""
    Public ReadOnly Property CurrentSellerAddress() As String
        Get
            Return C_CurrentSellerAddress
        End Get
    End Property
    Private Property C_CurrentBuyerID As ULong = 0UL
    Public ReadOnly Property CurrentBuyerID() As ULong
        Get
            Return C_CurrentBuyerID
        End Get
    End Property
    Private Property C_CurrentBuyerAddress As String = ""
    Public ReadOnly Property CurrentBuyerAddress() As String
        Get
            Return C_CurrentBuyerAddress
        End Get
    End Property
    Private Property C_CurrentBalance As Double = 0.0
    Public ReadOnly Property CurrentBalance() As Double
        Get
            Return C_CurrentBalance
        End Get
    End Property
    Private Property C_CurrentInitiatorsCollateral As Double = 0.0
    Public ReadOnly Property CurrentInitiatorsCollateral() As Double
        Get
            Return C_CurrentInitiatorsCollateral
        End Get
    End Property
    Private Property C_CurrentRespondersCollateral As Double = 0.0
    Public ReadOnly Property CurrentRespondersCollateral() As Double
        Get
            Return C_CurrentRespondersCollateral
        End Get
    End Property
    Private Property C_CurrentBuySellAmount As Double = 0.0
    Public ReadOnly Property CurrentBuySellAmount() As Double
        Get
            Return C_CurrentBuySellAmount
        End Get
    End Property

    Private Property C_MediatorsDeposit As Double = 0.0
    Public ReadOnly Property CurrentMediatorsDeposit() As Double
        Get
            Return C_MediatorsDeposit
        End Get
    End Property

    Private Property C_ConciliationAmount As Double = 0.0
    Public ReadOnly Property CurrentConciliationAmount() As Double
        Get
            Return C_ConciliationAmount
        End Get
    End Property

    Private Property C_CurrentXAmount As Double = 0.0
    Public ReadOnly Property CurrentXAmount() As Double
        Get
            Return C_CurrentXAmount
        End Get
    End Property
    Private Property C_CurrentPrice As Double = 0.0
    Public ReadOnly Property CurrentPrice As Double
        Get
            Return C_CurrentPrice
        End Get
    End Property
    Private Property C_CurrentXItem As String = ""
    Public ReadOnly Property CurrentXItem() As String
        Get
            Return C_CurrentXItem
        End Get
    End Property
    'Private Property C_CurrentChainSwapHash As String = ""
    Public ReadOnly Property CurrentChainSwapHash() As String
        Get

            Dim T_Longs As List(Of ULong) = New List(Of ULong)({C_CurrentChainSwapHashULong4, C_CurrentChainSwapHashULong3, C_CurrentChainSwapHashULong2, C_CurrentChainSwapHashULong1})

            T_Longs = ChangeULongEndians(T_Longs)

            Dim MaxHash As String = ULongListToHEXString(T_Longs)
            Return MaxHash
        End Get
    End Property
    Private Property C_CurrentChainSwapHashULong1 As ULong = 0UL
    Public ReadOnly Property CurrentChainSwapHashULong1() As ULong
        Get
            Return C_CurrentChainSwapHashULong1
        End Get
    End Property
    Private Property C_CurrentChainSwapHashULong2 As ULong = 0UL
    Public ReadOnly Property CurrentChainSwapHashULong2() As ULong
        Get
            Return C_CurrentChainSwapHashULong2
        End Get
    End Property
    Private Property C_CurrentChainSwapHashULong3 As ULong = 0UL
    Public ReadOnly Property CurrentChainSwapHashULong3() As ULong
        Get
            Return C_CurrentChainSwapHashULong3
        End Get
    End Property
    Private Property C_CurrentChainSwapHashULong4 As ULong = 0UL
    Public ReadOnly Property CurrentChainSwapHashULong4() As ULong
        Get
            Return C_CurrentChainSwapHashULong4
        End Get
    End Property

    Private Property C_CurrentChat As List(Of S_Chat) = New List(Of S_Chat)
    Public ReadOnly Property CurrentChat() As List(Of S_Chat)
        Get
            Return C_CurrentChat
        End Get
    End Property
    Private Property C_ContractOrderHistoryList As List(Of S_Order) = New List(Of S_Order)
    Public ReadOnly Property ContractOrderHistoryList() As List(Of S_Order)
        Get
            Return C_ContractOrderHistoryList
        End Get
    End Property



    Private Property C_PendingAmount As Double = 0.0
    Public ReadOnly Property PendingAmount() As Double
        Get
            Return C_PendingAmount
        End Get
    End Property

    Private Property C_PendingCommand As E_ReferenceCommand = E_ReferenceCommand.NONE
    Public ReadOnly Property PendingCommand() As E_ReferenceCommand
        Get
            Return C_PendingCommand
        End Get
    End Property

    Private Property C_PendingCollateral As Double = 0.0
    Public ReadOnly Property PendingCollateral() As Double
        Get
            Return C_PendingCollateral
        End Get
    End Property
    Private Property C_PendingResponderID As ULong = 0UL
    Public ReadOnly Property PendingResponderID() As ULong
        Get
            Return C_PendingResponderID
        End Get
    End Property
    Private Property C_PendingResponderAddress As String = ""
    Public ReadOnly Property PendingResponderAddress() As String
        Get
            Return C_PendingResponderAddress
        End Get
    End Property
    Private Property C_PendingXAmount As Double = 0.0
    Public ReadOnly Property PendingXAmount() As Double
        Get
            Return C_PendingXAmount
        End Get
    End Property
    Private Property C_PendingXItem As String = ""
    Public ReadOnly Property PendingXItem() As String
        Get
            Return C_PendingXItem
        End Get
    End Property



    Private Property C_Status As E_Status = E_Status.NEW_
    Public ReadOnly Property Status() As E_Status
        Get
            Return C_Status
        End Get
    End Property

    Private Property C_StatusMessage As String = ""
    Public ReadOnly Property StatusMessage() As String
        Get
            C_StatusMessage = GetProposalMessage()
            If C_StatusMessage.Trim = "" Then
                C_StatusMessage = GetReserveMessage()
            End If

            Return C_StatusMessage
        End Get
    End Property

    Private ReadOnly Property C_Message As String = ""
    Public ReadOnly Property Message() As String
        Get
            Return C_Message
        End Get
    End Property


    Private Property C_IsFrozen As Boolean = False
    Public ReadOnly Property IsFrozen() As Boolean
        Get
            Return C_IsFrozen
        End Get
    End Property
    Private Property C_IsRunning As Boolean = False
    Public ReadOnly Property IsRunning() As Boolean
        Get
            Return C_IsRunning
        End Get
    End Property
    Private Property C_IsStopped As Boolean = False
    Public ReadOnly Property IsStopped() As Boolean
        Get
            Return C_IsStopped
        End Get
    End Property
    Private Property C_IsFinished As Boolean = False
    Public ReadOnly Property IsFinished() As Boolean
        Get
            Return C_IsFinished
        End Get
    End Property
    Private Property C_IsDead As Boolean = False
    Public ReadOnly Property IsDead() As Boolean
        Get
            Return C_IsDead
        End Get
    End Property

    Private Property XMLList As List(Of List(Of String)) = New List(Of List(Of String))

#End Region

#Region "Structures"
    Public Structure S_Chat
        Dim SenderAddress As String
        Dim RecipientAddress As String

        Dim Attachment As String
        Dim Timestamp As ULong
    End Structure
    Public Structure S_Order

        Dim CreationTransaction As ULong
        Dim LastTransaction As ULong
        Dim Confirmations As ULong

        Dim WasSellOrder As Boolean

        Dim StartTimestamp As ULong
        Dim EndTimestamp As ULong

        'Dim StartDate As Date
        'Dim EndDate As Date

        Dim SellerRS As String
        Dim SellerID As ULong

        Dim BuyerRS As String
        Dim BuyerID As ULong

        Dim Amount As Double
        Dim Collateral As Double

        Dim XAmount As Double
        Dim XItem As String

        Dim Price As Double

        Dim Status As E_Status
        'Dim Message As String
        Dim ChainSwapKey As String
        'Dim ChainSwapHash As String

    End Structure
    Private Structure S_TX
        Dim Transaction As ULong
        Dim Type As Integer
        Dim Timestamp As ULong

        Dim DateTimestamp As Date

        Dim Sender As ULong
        Dim SenderRS As String

        Dim AmountNQT As ULong
        Dim FeeNQT As ULong
        Dim Attachment As String

        Dim Recipient As ULong
        Dim RecipientRS As String

        Dim Confirmations As ULong
    End Structure

#End Region

#Region "Enumerables"

    Public Enum E_Status
        NEW_ = 0
        FREE = 1

        OPEN = 2
        RESERVED = 3
        CLOSED = 4
        CANCELED = 5
        UTX_PENDING = 6
        TX_PENDING = 7
        ERROR_ = 8

        DISPUTE = 9
    End Enum

    Public Enum E_Choice
        INITIATOR = 1
        RESPONDER = 2
    End Enum

    Private Enum E_ContractVariables

        'r0 = 0
        'r1 = 1
        'r2 = 2

        'n1 = 3
        'n2 = 4

        CREATE_ORDER = 5
        ACCEPT_ORDER = 6

        INITIATOR = 7
        RESPONDER = 8

        INITIATORS_COLLATERAL = 9
        RESPONDERS_COLLATERAL = 10
        MEDIATORS_DEPOSIT = 11
        BUY_SELL_AMOUNT = 12
        CONCILIATION_AMOUNT = 13

        CHAINSWAPHASHLONG1 = 14
        CHAINSWAPHASHLONG2 = 15
        CHAINSWAPHASHLONG3 = 16
        CHAINSWAPHASHLONG4 = 17

        TIMEOUT = 18

        SELL_ORDER = 19
        FREE_FOR_ALL = 20

        IS_FIAT_ORDER = 21
        DECIMALS = 25

        DENIABILITY = 22
        DISPUTE = 23
        OBJECTION = 24

    End Enum

    Enum E_ReferenceCommand
        REFERENCE_DE_ACTIVATE_DENIABILITY = 0
        REFERENCE_CREATE_ORDER_WITH_RESPONDER = 1
        REFERENCE_CREATE_ORDER = 2
        REFERENCE_ACCEPT_ORDER = 3
        REFERENCE_INJECT_RESPONDER = 4
        REFERENCE_OPEN_DISPUTE = 5
        REFERENCE_MEDIATE_DISPUTE = 6
        REFERENCE_APPEAL = 7
        REFERENCE_CHECK_CLOSE_DISPUTE = 8
        REFERENCE_FINISH_ORDER = 9
        REFERENCE_INJECT_CHAINSWAPHASH = 10
        REFERENCE_FINISH_ORDER_WITH_CHAINSWAPKEY = 11
        NONE = 12
    End Enum

#End Region

#Region "Constructors"
    ''' <summary>
    ''' Loads the entire DEXContract with its HistoryOrders
    ''' </summary>
    ''' <param name="Node">The API node to get the info</param>
    ''' <param name="ContractID">The Contract ID</param>
    ''' <param name="StartDateTime">The start date from which the history is loaded</param>
    Sub New(ByVal StartForm As PFPForm, ByVal Node As String, ByVal ContractID As ULong, Optional ByVal StartDateTime As Date = #01/01/0001#, Optional ByVal RefreshHistoryOrders As Boolean = True)

        C_StartForm = StartForm

        If Node.Trim = "" Then
            C_Node = GetINISetting(E_Setting.DefaultNode, ClsSignumAPI._DefaultNode)
        Else
            C_Node = Node
        End If

        C_ID = ContractID

        LoadBasics(StartDateTime)
        Refresh(RefreshHistoryOrders)

    End Sub
    Sub New(ByVal StartForm As PFPForm, ByVal Node As String, ByVal ContractID As ULong, ByVal HistoryOrders As List(Of S_Order), Optional ByVal RefreshHistoryOrders As Boolean = True)

        C_StartForm = StartForm

        If Node.Trim = "" Then
            C_Node = GetINISetting(E_Setting.DefaultNode, ClsSignumAPI._DefaultNode)
        Else
            C_Node = Node
        End If

        C_ID = ContractID

        LoadBasics(HistoryOrders)
        Refresh(RefreshHistoryOrders)

    End Sub

#End Region

#Region "Public Supportfunctions/Subroutines"
    ''' <summary>
    ''' Refreshing DEXContract
    ''' </summary>
    Public Sub Refresh(Optional ByVal RefreshHistoryOrders As Boolean = True)

        Dim SignumAPI As ClsSignumAPI = New ClsSignumAPI(C_Node)
        Dim ContractList As List(Of String) = SignumAPI.GetSmartContractDetails(C_ID)

        If ContractList.Count > 0 Then
            If C_DEXContract Then

                C_CurrentBalance = ClsSignumAPI.Planck2Dbl(GetULongBetweenFromList(ContractList, "<balanceNQT>", "</balanceNQT>"))

                Dim MachineData As String = GetStringBetweenFromList(ContractList, "<machineData>", "</machineData>")
                Dim MachineDataULongList As List(Of ULong) = ClsSignumAPI.DataStr2ULngList(MachineData)

                Dim T_CreateOrderTX As ULong = MachineDataULongList(E_ContractVariables.CREATE_ORDER)
                'Dim T_AcceptOrderTX As ULong = MachineDataULongList(E_ContractVariables.ACCEPT_ORDER)

                Dim T_InitiatorID As ULong = MachineDataULongList(E_ContractVariables.INITIATOR)
                Dim T_ResponderID As ULong = MachineDataULongList(E_ContractVariables.RESPONDER)


                Dim T_InitiatorsCollateral As ULong = MachineDataULongList(E_ContractVariables.INITIATORS_COLLATERAL)
                Dim T_RespondersCollateral As ULong = MachineDataULongList(E_ContractVariables.RESPONDERS_COLLATERAL)
                Dim T_BuySellAmount As ULong = MachineDataULongList(E_ContractVariables.BUY_SELL_AMOUNT)

                Dim T_SellOrder As ULong = MachineDataULongList(E_ContractVariables.SELL_ORDER)
                Dim T_FreeForAll As ULong = MachineDataULongList(E_ContractVariables.FREE_FOR_ALL)

                Dim T_ChainSwapHashULong1 As ULong = MachineDataULongList(E_ContractVariables.CHAINSWAPHASHLONG1)
                Dim T_ChainSwapHashULong2 As ULong = MachineDataULongList(E_ContractVariables.CHAINSWAPHASHLONG2)
                Dim T_ChainSwapHashULong3 As ULong = MachineDataULongList(E_ContractVariables.CHAINSWAPHASHLONG3)
                Dim T_ChainSwapHashULong4 As ULong = MachineDataULongList(E_ContractVariables.CHAINSWAPHASHLONG4)


                Dim T_Dispute As ULong = MachineDataULongList(E_ContractVariables.DISPUTE)
                Dim T_ConciliationAmount As ULong = MachineDataULongList(E_ContractVariables.CONCILIATION_AMOUNT)

                Dim T_TimeOut As ULong = MachineDataULongList(E_ContractVariables.TIMEOUT)

                Dim T_MediatorsDeposit As ULong = MachineDataULongList(E_ContractVariables.MEDIATORS_DEPOSIT)
                Dim T_Deniability As ULong = MachineDataULongList(E_ContractVariables.DENIABILITY)
                Dim T_Objection As ULong = MachineDataULongList(E_ContractVariables.OBJECTION)

#Region "getCandidates"

                C_CurrentInitiatorID = T_InitiatorID
                If Not C_CurrentInitiatorID = 0UL Then
                    C_CurrentInitiatorAddress = ClsSignumAPI._AddressPreFix + ClsReedSolomon.Encode(CurrentInitiatorID)
                Else
                    C_CurrentInitiatorAddress = ""
                End If

                C_CurrentResponderID = T_ResponderID
                If Not C_CurrentResponderID = 0UL Then
                    C_CurrentResponderAddress = ClsSignumAPI._AddressPreFix + ClsReedSolomon.Encode(CurrentResponderID)
                Else
                    C_CurrentResponderAddress = ""
                End If

                C_CurrentInitiatorsCollateral = ClsSignumAPI.Planck2Dbl(T_InitiatorsCollateral)
                C_CurrentRespondersCollateral = ClsSignumAPI.Planck2Dbl(T_RespondersCollateral)

#End Region
#Region "convertCandidates"
                If T_SellOrder = 0UL Then
                    C_IsSellOrder = False
                    C_CurrentSellerID = CurrentResponderID
                    C_CurrentBuyerID = CurrentInitiatorID
                Else
                    C_IsSellOrder = True
                    C_CurrentSellerID = CurrentInitiatorID
                    C_CurrentBuyerID = CurrentResponderID
                End If


                If Not C_CurrentSellerID = 0UL Then
                    C_CurrentSellerAddress = ClsSignumAPI._AddressPreFix + ClsReedSolomon.Encode(CurrentSellerID)
                Else
                    C_CurrentSellerAddress = ""
                End If

                If Not C_CurrentBuyerID = 0UL Then
                    C_CurrentBuyerAddress = ClsSignumAPI._AddressPreFix + ClsReedSolomon.Encode(CurrentBuyerID)
                Else
                    C_CurrentBuyerAddress = ""
                End If
#End Region

                If T_Deniability = 0UL Or T_Deniability = 3UL Then
                    C_Deniability = False
                Else
                    C_Deniability = True
                End If

                If T_Objection = 0UL Then
                    C_Objection = False
                Else
                    C_Objection = True
                End If

                Dim T_DisputeTimeOut As Byte() = BitConverter.GetBytes(T_TimeOut)
                C_DisputeTimeout = CULng(BitConverter.ToInt32(T_DisputeTimeOut, 4))

                C_CurrentBuySellAmount = ClsSignumAPI.Planck2Dbl(T_BuySellAmount)
                C_MediatorsDeposit = ClsSignumAPI.Planck2Dbl(T_MediatorsDeposit)
                C_ConciliationAmount = ClsSignumAPI.Planck2Dbl(T_ConciliationAmount)


                C_CurrentChainSwapHashULong1 = T_ChainSwapHashULong1
                C_CurrentChainSwapHashULong2 = T_ChainSwapHashULong2
                C_CurrentChainSwapHashULong3 = T_ChainSwapHashULong3
                C_CurrentChainSwapHashULong4 = T_ChainSwapHashULong4

                If CurrentInitiatorID = 0UL And CurrentResponderID = 0UL Then
                    C_Status = E_Status.FREE ' "FREE"
                ElseIf Not CurrentInitiatorID = 0UL And CurrentResponderID = 0UL Then
                    C_Status = E_Status.OPEN ' "OPEN"
                ElseIf CurrentInitiatorID = 0UL And Not CurrentResponderID = 0UL Then
                    C_Status = E_Status.ERROR_ ' "ERROR"
                ElseIf Not CurrentInitiatorID = 0UL And Not CurrentResponderID = 0UL Then

                    C_Status = E_Status.RESERVED ' "RESERVED"
                    C_Dispute = False

                    If Not T_Dispute = 0L Then
                        C_Status = E_Status.DISPUTE
                        C_Dispute = True
                    End If
                Else
                    C_Status = E_Status.ERROR_ ' "ERROR"
                End If


                Dim TXList As List(Of String) = New List(Of String)

                If Not T_CreateOrderTX = 0UL Then
                    TXList = SignumAPI.GetTransaction(T_CreateOrderTX)
                End If

                If TXList.Count > 0 Then

                    Dim Message As String = GetStringBetweenFromList(TXList, "<message>", "</message>")
                    Dim MessageList As List(Of ULong) = ClsSignumAPI.DataStr2ULngList(Message)

                    C_CurrentCreationTransaction = GetULongBetweenFromList(TXList, "<transaction>", "</transaction>")
                    C_CurrentConfirmations = GetULongBetweenFromList(TXList, "<confirmations>", "</confirmations>")

                    C_CurrentTimestamp = GetULongBetweenFromList(TXList, "<timestamp>", "</timestamp>")

                    '(0) ULong   creation method
                    '(1) ULong   collateral
                    '(2) ULong   xamountnqt
                    '(3) ULong   xitem USD

                    If MessageList.Count > 2 Then
                        C_CurrentXAmount = ClsSignumAPI.Planck2Dbl(MessageList(2))
                        C_CurrentXItem = ClsSignumAPI.ULng2String(MessageList(3))
                    End If

                    C_CurrentPrice = C_CurrentXAmount / C_CurrentBuySellAmount

                Else

                    If T_FreeForAll = 0L Then
                        C_Status = E_Status.NEW_ ' "NEW"
                    Else

                        C_Status = E_Status.FREE ' "FREE"

                        C_CurrentXAmount = 0.0
                        C_CurrentXItem = ""

                        C_CurrentInitiatorID = 0UL
                        C_CurrentInitiatorAddress = ""

                        C_CurrentResponderID = 0UL
                        C_CurrentResponderAddress = ""

                        C_CurrentInitiatorsCollateral = 0.0
                        C_CurrentRespondersCollateral = 0.0
                        C_CurrentBuySellAmount = 0.0
                        C_CurrentChainSwapHashULong1 = 0UL
                        C_CurrentChainSwapHashULong2 = 0UL
                        C_CurrentChainSwapHashULong3 = 0UL
                        C_CurrentChainSwapHashULong4 = 0UL

                        C_IsSellOrder = False
                        C_CurrentSellerID = 0UL
                        C_CurrentBuyerID = 0UL

                        C_CurrentSellerAddress = ""
                        C_CurrentBuyerAddress = ""

                    End If

                End If

                CheckForTX()
                CheckForUTX()

                C_IsFrozen = GetBooleanBetweenFromList(ContractList, "<frozen>", "</frozen>")
                C_IsRunning = GetBooleanBetweenFromList(ContractList, "<running>", "</running>")
                C_IsStopped = GetBooleanBetweenFromList(ContractList, "<stopped>", "</stopped>")
                C_IsFinished = GetBooleanBetweenFromList(ContractList, "<finished>", "</finished>")
                C_IsDead = GetBooleanBetweenFromList(ContractList, "<dead>", "</dead>")

                If RefreshHistoryOrders Then
                    If C_ContractOrderHistoryList.Count = 0 Then
                        GetHistoryTransactions(ContractTimestamp)
                    Else
                        GetHistoryTransactions(C_ContractOrderHistoryList(C_ContractOrderHistoryList.Count - 1).EndTimestamp)
                    End If
                End If

                If C_ContractOrderHistoryList.Count > 0 Then
                    If C_Status = E_Status.NEW_ Then
                        C_Status = E_Status.FREE
                    End If
                End If

                GetCurrentChat()
                C_IsReady = True

            Else
                'No DEX Contract
                LoadBasics(#01/01/0001#)
                C_IsReady = True
            End If

        Else
            'not ready
            C_IsReady = False
        End If

    End Sub

    ''' <summary>
    ''' Checks incoming unconfirmedTransaction for DEXContract 
    ''' </summary>
    ''' <returns></returns>
    Public Function CheckForUTX() As Boolean

        Dim SignumAPI As ClsSignumAPI = New ClsSignumAPI(C_Node)
        Dim T_UTXList As List(Of List(Of String)) = SignumAPI.GetUnconfirmedTransactions()

        For Each UTX In T_UTXList

            Dim UTX_Sender As ULong = GetULongBetweenFromList(UTX, "<sender>", "</sender>")
            Dim UTX_Recipient As ULong = GetULongBetweenFromList(UTX, "<recipient>", "</recipient>")
            Dim UTX_Amount As Double = ClsSignumAPI.Planck2Dbl(GetULongBetweenFromList(UTX, "<amountNQT>", "</amountNQT>"))

            If Not UTX_Sender = 0UL And Not UTX_Recipient = 0UL Then
                If UTX_Recipient = C_ID Then

                    Dim T_Message As String = GetStringBetweenFromList(UTX, "<message>", "</message>")
                    Dim ReferenceMessageList As List(Of ULong) = ClsSignumAPI.DataStr2ULngList(T_Message)

                    If ReferenceMessageList.Count > 0 Then
                        If IsReferenceCommand(ReferenceMessageList(0)) Then

                            SetPendings(UTX_Amount, ReferenceMessageList)
                            If CurrentInitiatorID <> 0UL And CurrentResponderID <> 0UL Then
                                If UTX_Sender = CurrentInitiatorID Or UTX_Sender = CurrentResponderID Or (UTX_Sender = CreatorID And C_Status = E_Status.DISPUTE) Then
                                    C_Status = E_Status.UTX_PENDING
                                    Return True
                                End If
                            Else
                                C_Status = E_Status.UTX_PENDING
                                Return True
                            End If
                        End If
                    End If

                End If
            End If

        Next

        Return False

    End Function
    ''' <summary>
    ''' Checks incoming Transaction for DEXContract
    ''' </summary>
    ''' <returns></returns>
    Public Function CheckForTX() As Boolean

        Dim T_LastTimestamp As ULong = C_ContractTimestamp

        If ContractOrderHistoryList.Count > 0 Then
            T_LastTimestamp = ContractOrderHistoryList(ContractOrderHistoryList.Count - 1).EndTimestamp
        End If

        Dim SignumAPI = New ClsSignumAPI(C_Node)
        Dim T_ContractTransactionsList As List(Of List(Of String)) = SignumAPI.GetAccountTransactions(C_ID, T_LastTimestamp)

        Dim T_TXList As List(Of S_TX) = New List(Of S_TX)

        For Each TX As List(Of String) In T_ContractTransactionsList
            Dim T_TX As S_TX = New S_TX

            T_TX.Transaction = GetULongBetweenFromList(TX, "<transaction>", "</transaction>")
            T_TX.Type = GetIntegerBetweenFromList(TX, "<type>", "</type>")
            T_TX.Timestamp = GetULongBetweenFromList(TX, "<timestamp>", "</timestamp>")

            T_TX.Sender = GetULongBetweenFromList(TX, "<sender>", "</sender>")
            T_TX.SenderRS = GetStringBetweenFromList(TX, "<senderRS>", "</senderRS>")

            T_TX.AmountNQT = GetULongBetweenFromList(TX, "<amountNQT>", "</amountNQT>")
            T_TX.FeeNQT = GetULongBetweenFromList(TX, "<feeNQT>", "</feeNQT>")
            T_TX.Attachment = GetStringBetweenFromList(TX, "<attachment>", "</attachment>")

            T_TX.Recipient = GetULongBetweenFromList(TX, "<recipient>", "</recipient>")
            T_TX.RecipientRS = GetStringBetweenFromList(TX, "<recipientRS>", "</recipientRS>")

            T_TX.Confirmations = GetULongBetweenFromList(TX, "<confirmations>", "</confirmations>")

            T_TXList.Add(T_TX)

        Next

        If T_TXList.Count > 0 Then
            T_TXList = T_TXList.OrderBy(Function(T_TX As S_TX) T_TX.Timestamp).ToList

            Dim T_LastTX As S_TX = T_TXList(T_TXList.Count - 1)

            If T_LastTX.Recipient = C_ID Then
                If T_LastTX.Confirmations = 0 Then

                    Dim T_Amount As Double = ClsSignumAPI.Planck2Dbl(T_LastTX.AmountNQT)
                    Dim T_Message As String = GetStringBetween(T_LastTX.Attachment, "<message>", "</message>")
                    Dim ReferenceMessageList As List(Of ULong) = ClsSignumAPI.DataStr2ULngList(T_Message)

                    If ReferenceMessageList.Count > 0 Then

                        If IsReferenceCommand(ReferenceMessageList(0)) Then

                            SetPendings(T_Amount, ReferenceMessageList)
                            If CurrentInitiatorID <> 0UL And CurrentResponderID <> 0UL Then
                                If T_LastTX.Sender = CurrentInitiatorID Or T_LastTX.Sender = CurrentResponderID Or (T_LastTX.Sender = CreatorID And C_Status = E_Status.DISPUTE) Then
                                    C_Status = E_Status.TX_PENDING
                                    Return True
                                End If
                            Else
                                C_Status = E_Status.TX_PENDING
                                Return True
                            End If

                        End If

                    End If


                End If

            End If

        End If

        Return False

    End Function

    Public Function CurrencyIsCrypto() As Boolean
        Return CurrencyIsCrypto(C_CurrentXItem)
    End Function
    Public Shared Function CurrencyIsCrypto(ByVal Currency As String) As Boolean
        Select Case Currency
            Case "AUD", "BRL", "CAD", "CNY", "CZK", "DKK", "EUR", "HKD", "HUF", "ILS", "INR", "JPY", "MXN", "MYR", "NOK", "NZD", "PHP", "PLN", "GBP", "RUB", "SEK", "SGD", "CHF", "THB", "TWD", "USD"
                'Non CryptoCurrencys Supported by PayPal
                Return False
        End Select
        Return True
    End Function

    Public Function GetCurrencyDecimals() As Integer
        Return GetCurrencyDecimals(C_CurrentXItem)
    End Function
    Public Shared Function GetCurrencyDecimals(ByVal Currency As String) As Integer

        Select Case Currency

            Case "AUD", "BRL", "CAD", "CHF", "CNY", "CZK", "DKK", "EUR", "HKD", "ILS", "INR", "MXN", "MYR", "NOK", "NZD", "PHP", "PLN", "GBP", "RUB", "SEK", "SGD", "THB", "USD"
                'Non CryptoCurrencys Supported by PayPal
                Return 2

            Case "HUF", "JPY", "TWD"
                'These Currencys do not support decimals
                Return 0

            Case Else
                Return 8

        End Select

        Return 8

    End Function

    Private Function GetProposalMessage() As String

        Dim Proposal As String = ""
        If CurrentDisputeTimeout <> 0UL And Dispute And Not CurrencyIsCrypto(CurrentXItem) Then

            Dim percentage As Double = 100 / CurrentBuySellAmount * CurrentConciliationAmount
            Proposal = " (Proposal:" + Math.Round(CurrentConciliationAmount, 2).ToString + " Signa =" + Math.Round(percentage, 2).ToString + "%)"
            Dim diffblock As Long = 0
            diffblock = CLng(CurrentDisputeTimeout) - CLng(GetBlock())

            If diffblock < 0 Then
                Proposal += " accepted"
            ElseIf diffblock <= 1 Then
                Proposal += " not appealable"
            Else
                Proposal += " autoaccept in: ~" + CStr(diffblock * 4) + " Min"
            End If
            'ElseIf CurrentDisputeTimeout <> 0UL And CurrencyIsCrypto(CurrentXItem) Then
            '    Dim diffblock As Long = 0
            '    diffblock = CLng(CurrentDisputeTimeout) - CLng(GetBlock())
            '    Proposal += "reserved for ~" + CStr(diffblock * 4) + " Min"
        End If

        Return Proposal

    End Function

    Private Function GetReserveMessage() As String

        Dim ReserveMessage As String = ""
        If CurrentDisputeTimeout <> 0UL And CurrencyIsCrypto(CurrentXItem) Then
            Dim diffblock As Long = 0
            diffblock = CLng(CurrentDisputeTimeout) - CLng(GetBlock())
            ReserveMessage += "reserved for ~" + CStr(diffblock * 4) + " Min"
        End If

        Return ReserveMessage

    End Function

    Private Function GetBlock() As Integer
        Dim SignumAPI As ClsSignumAPI = New ClsSignumAPI(Node)
        Return SignumAPI.GetCurrentBlock()
    End Function

#End Region

#Region "Private Supportfunctions/Subroutines"

    Private Sub LoadBasics(ByVal StartDateTime As Date)

        If Not StartDateTime = #01/01/0001# Then
            C_ContractTimestamp = ClsSignumAPI.TimeToUnix(StartDateTime)
        End If

        Dim SignumAPI As ClsSignumAPI = New ClsSignumAPI(C_Node)
        Dim ContractList As List(Of String) = SignumAPI.GetSmartContractDetails(C_ID)

        If ContractList.Count > 0 Then
            C_Address = GetStringBetweenFromList(ContractList, "<atRS>", "</atRS>")
            C_DEXContract = GetBooleanBetweenFromList(ContractList, "<referenceMachineCode>", "</referenceMachineCode>")

            If C_DEXContract Then

                C_CreatorID = GetULongBetweenFromList(ContractList, "<creator>", "</creator>")
                C_CreatorAddress = GetStringBetweenFromList(ContractList, "<creatorRS>", "</creatorRS>")
                C_Name = GetStringBetweenFromList(ContractList, "<name>", "</name>")
                C_Description = GetStringBetweenFromList(ContractList, "<description>", "</description>")

                Dim CreationTXList As List(Of String) = SignumAPI.GetTransaction(C_ID)

                If StartDateTime = #01/01/0001# Then
                    C_ContractTimestamp = GetULongBetweenFromList(CreationTXList, "<timestamp>", "</timestamp>")
                End If

            End If
        Else
            C_DEXContract = False
        End If

    End Sub
    Private Sub LoadBasics(ByVal HistoryOrders As List(Of S_Order))

        C_ContractOrderHistoryList = New List(Of S_Order)(HistoryOrders.ToArray)

        Dim SignumAPI As ClsSignumAPI = New ClsSignumAPI(C_Node)
        Dim ContractList As List(Of String) = SignumAPI.GetSmartContractDetails(C_ID)

        If ContractList.Count > 0 Then
            C_Address = GetStringBetweenFromList(ContractList, "<atRS>", "</atRS>")
            C_DEXContract = GetBooleanBetweenFromList(ContractList, "<referenceMachineCode>", "</referenceMachineCode>")

            If C_DEXContract Then

                C_CreatorID = GetULongBetweenFromList(ContractList, "<creator>", "</creator>")
                C_CreatorAddress = GetStringBetweenFromList(ContractList, "<creatorRS>", "</creatorRS>")
                C_Name = GetStringBetweenFromList(ContractList, "<name>", "</name>")
                C_Description = GetStringBetweenFromList(ContractList, "<description>", "</description>")

                Dim CreationTXList As List(Of String) = SignumAPI.GetTransaction(C_ID)
                C_ContractTimestamp = GetULongBetweenFromList(CreationTXList, "<timestamp>", "</timestamp>")

            End If
        Else
            C_DEXContract = False
        End If

    End Sub
    Private Sub LoadUpTransactions(ByVal SetStartTimeStamp As ULong)

        Dim SignumAPI = New ClsSignumAPI(C_Node)

        Dim T_ContractTransactionsRAWPieceList As List(Of String) = SignumAPI.GetAccountTransactionsRAWList(C_ID, SetStartTimeStamp)
        Dim T_ContractTransactionsRAWList As List(Of String) = New List(Of String)(T_ContractTransactionsRAWPieceList.ToArray)

        Dim W500 As Integer = T_ContractTransactionsRAWPieceList.Count
        While W500 >= 500

            C_StartForm.MultiInvoker(C_StartForm.SubStatusLabel, "Text", "LoadHistoryTransactions(" + C_ID.ToString + "): " + W500.ToString)

            T_ContractTransactionsRAWPieceList = SignumAPI.GetAccountTransactionsRAWList(C_ID, SetStartTimeStamp, Convert.ToUInt64(W500))

            Dim T_W500 As Integer = T_ContractTransactionsRAWPieceList.Count

            If T_W500 >= 500 Then
                W500 += 500
            Else
                W500 = 0
            End If

            T_ContractTransactionsRAWList.AddRange(T_ContractTransactionsRAWPieceList.ToArray)

        End While

        Dim C_ThreadList As List(Of Threading.Thread) = New List(Of Threading.Thread)

        C_StartForm.MultiInvoker(C_StartForm.SubStatusLabel, "Text", "ProcessingHistoryTransactions(" + C_ID.ToString + ")")


        For i As Integer = 0 To T_ContractTransactionsRAWList.Count - 1

            Dim T_JSONStr As String = T_ContractTransactionsRAWList(i)

            Dim C_Thread As Threading.Thread = New Threading.Thread(AddressOf ConvertThread)
            C_Thread.Start(T_JSONStr)
            C_ThreadList.Add(C_Thread)

        Next

        Dim SubThreadsFinished As Boolean = False

        While Not SubThreadsFinished
            SubThreadsFinished = True

            For Each T_Thread As Threading.Thread In C_ThreadList

                If T_Thread.IsAlive Then
                    SubThreadsFinished = False
                    Application.DoEvents()
                    Exit For
                End If

            Next

        End While


        Dim T_TXList As List(Of S_TX) = New List(Of S_TX)

        For Each TX As List(Of String) In XMLList
            Dim T_TX As S_TX = New S_TX

            T_TX.Transaction = GetULongBetweenFromList(TX, "<transaction>", "</transaction>")
            T_TX.Type = GetIntegerBetweenFromList(TX, "<type>", "</type>")
            T_TX.Timestamp = GetULongBetweenFromList(TX, "<timestamp>", "</timestamp>")

            T_TX.DateTimestamp = ClsSignumAPI.UnixToTime(T_TX.Timestamp.ToString)

            T_TX.Sender = GetULongBetweenFromList(TX, "<sender>", "</sender>")
            T_TX.SenderRS = GetStringBetweenFromList(TX, "<senderRS>", "</senderRS>")

            T_TX.AmountNQT = GetULongBetweenFromList(TX, "<amountNQT>", "</amountNQT>")
            T_TX.FeeNQT = GetULongBetweenFromList(TX, "<feeNQT>", "</feeNQT>")
            T_TX.Attachment = GetStringBetweenFromList(TX, "<attachment>", "</attachment>")

            T_TX.Recipient = GetULongBetweenFromList(TX, "<recipient>", "</recipient>")
            T_TX.RecipientRS = GetStringBetweenFromList(TX, "<recipientRS>", "</recipientRS>")

            T_TX.Confirmations = GetULongBetweenFromList(TX, "<confirmations>", "</confirmations>")

            T_TXList.Add(T_TX)

        Next

        XMLList.Clear()

        If T_TXList.Count > 0 Then

            T_TXList = T_TXList.OrderBy(Function(T_TX As S_TX) T_TX.Timestamp).ToList

            Dim T_LastTX As S_TX = T_TXList(T_TXList.Count - 1)

            If T_LastTX.Recipient = C_ID Then
                If T_LastTX.Confirmations < 2 Then

                    If CurrentInitiatorID <> 0UL And CurrentResponderID <> 0UL Then
                        If T_LastTX.Sender = CurrentInitiatorID Or T_LastTX.Sender = CurrentResponderID Then
                            C_Status = E_Status.TX_PENDING
                        End If
                    Else
                        C_Status = E_Status.TX_PENDING
                    End If

                End If
            End If

            Dim T_ContractOrderHistoryList As List(Of S_Order) = New List(Of S_Order)

            For i As Integer = 0 To T_TXList.Count - 1

                Dim T_TX As S_TX = T_TXList(i)

                C_StartForm.MultiInvoker(C_StartForm.SubStatusLabel, "Text", "ProcessingHistoryTransactions(" + C_ID.ToString + ") (" + i.ToString + "/" + T_TXList.Count.ToString + ")")

                If T_TX.Sender = C_ID Then

                    'LastTX = False

                    Dim ReferenceTXIDs As String = GetStringBetween(T_TX.Attachment, "<message>", "</message>")
                    If Not ReferenceTXIDs.Trim = "" Then

                        Dim ReferenceTXIDList As List(Of ULong) = ClsSignumAPI.DataStr2ULngList(ReferenceTXIDs)

                        If Not ReferenceTXIDList(0) = 0UL And Not ReferenceTXIDList(1) = 0UL And Not ReferenceTXIDList(2) = 0UL Then
                            'referenceTXID

                            Dim T_CreationTX As S_TX = Nothing
                            Dim T_AcceptTX As S_TX = Nothing
                            Dim T_FinishTX As S_TX = Nothing

                            For Each R_TX As S_TX In T_TXList
                                Select Case R_TX.Transaction
                                    Case ReferenceTXIDList(0)
                                        T_CreationTX = R_TX
                                    Case ReferenceTXIDList(1)
                                        T_AcceptTX = R_TX
                                    Case ReferenceTXIDList(2)
                                        T_FinishTX = R_TX
                                End Select

                                If R_TX.Transaction = ReferenceTXIDList(1) And ReferenceTXIDList(1) = ReferenceTXIDList(2) Then
                                    T_AcceptTX = R_TX
                                    T_FinishTX = R_TX
                                End If

                                If Not T_CreationTX.Transaction = 0UL And Not T_AcceptTX.Transaction = 0UL And Not T_FinishTX.Transaction = 0UL Then
                                    Exit For
                                End If

                            Next

                            If Not T_CreationTX.Transaction = 0UL And Not T_AcceptTX.Transaction = 0UL And Not T_FinishTX.Transaction = 0UL Then

                                Dim ReferenceCreationMessage As String = GetStringBetween(T_CreationTX.Attachment, "<message>", "</message>")
                                Dim ReferenceCreationMessageList As List(Of ULong) = ClsSignumAPI.DataStr2ULngList(ReferenceCreationMessage)

                                Dim ReferenceAcceptMessage As String = GetStringBetween(T_AcceptTX.Attachment, "<message>", "</message>")
                                Dim ReferenceAcceptMessageList As List(Of ULong) = ClsSignumAPI.DataStr2ULngList(ReferenceAcceptMessage)

                                Dim ReferenceFinishMessage As String = GetStringBetween(T_FinishTX.Attachment, "<message>", "</message>")
                                Dim ReferenceFinishMessageList As List(Of ULong) = ClsSignumAPI.DataStr2ULngList(ReferenceFinishMessage)

                                If ReferenceCreateOrder = ReferenceCreationMessageList(0) And (ReferenceAcceptOrder = ReferenceAcceptMessageList(0) Or ReferenceInjectResponder = ReferenceAcceptMessageList(0)) And ((ReferenceFinishOrder = ReferenceFinishMessageList(0) Or ReferenceFinishOrderWithChainSwapKey = ReferenceFinishMessageList(0)) Or (ReferenceAcceptMessageList(0) = ReferenceFinishMessageList(0) And T_AcceptTX.Transaction = T_FinishTX.Transaction)) Then

                                    Dim T_Order As S_Order = New S_Order

                                    T_Order.CreationTransaction = T_CreationTX.Transaction
                                    T_Order.LastTransaction = T_FinishTX.Transaction

                                    T_Order.Confirmations = T_CreationTX.Confirmations

                                    T_Order.StartTimestamp = T_CreationTX.Timestamp
                                    T_Order.EndTimestamp = T_TX.Timestamp + 1UL

                                    T_Order.ChainSwapKey = ""
                                    'T_Order.ChainSwapHash = ""

                                    'T_Order.StartDate = ClsSignumAPI.UnixToTime(T_Order.StartTimestamp.ToString) 'Debug
                                    'T_Order.EndDate = ClsSignumAPI.UnixToTime(T_Order.EndTimestamp.ToString) 'Debug

                                    Dim T_Collateral As ULong = ReferenceCreationMessageList(1)
                                    Dim T_Amount As ULong = T_CreationTX.AmountNQT '- T_Collateral - ClsSignumAPI._GasFeeNQT

                                    If T_Amount > T_Collateral Then

                                        '(0) ULong   Creation Method SellOrder
                                        '(1) ULong   Collateral
                                        '(2) ULong   XAmountNQT
                                        '(3) ULong   XItem USD

                                        T_Order.WasSellOrder = True

                                        T_Order.SellerID = T_CreationTX.Sender
                                        T_Order.SellerRS = T_CreationTX.SenderRS
                                        T_Order.BuyerID = T_AcceptTX.Sender
                                        T_Order.BuyerRS = T_AcceptTX.SenderRS

                                        T_Order.Amount = ClsSignumAPI.Planck2Dbl(T_Amount - T_Collateral - ClsSignumAPI._GasFeeNQT)
                                        T_Order.Collateral = ClsSignumAPI.Planck2Dbl(ReferenceCreationMessageList(1))

                                        T_Order.XAmount = ClsSignumAPI.Planck2Dbl(ReferenceCreationMessageList(2))
                                        T_Order.XItem = ClsSignumAPI.ULng2String(ReferenceCreationMessageList(3))

                                        T_Order.Price = T_Order.XAmount / T_Order.Amount

                                        Dim Finisher As ULong = T_FinishTX.Sender

                                        If ReferenceFinishOrder = ReferenceFinishMessageList(0) Then
                                            If Finisher = T_Order.SellerID Then
                                                T_Order.Status = E_Status.CLOSED
                                            Else 'If Finisher = o.BuyerID Then
                                                T_Order.Status = E_Status.CANCELED
                                            End If
                                        ElseIf ReferenceAcceptOrder = ReferenceFinishMessageList(0) Then
                                            'initiator canceled Order
                                            T_Order.Status = E_Status.CANCELED
                                        ElseIf ReferenceFinishOrderWithChainSwapKey = ReferenceFinishMessageList(0) Then
                                            T_Order.Status = E_Status.CLOSED
                                        End If


                                    Else

                                        '(0) ULong   Creation Method BuyOrder
                                        '(1) ULong   WantToBuyAmount
                                        '(2) ULong   XAmountNQT
                                        '(3) ULong   XItem USD

                                        T_Order.WasSellOrder = False

                                        T_Order.BuyerID = T_CreationTX.Sender
                                        T_Order.BuyerRS = T_CreationTX.SenderRS
                                        T_Order.SellerID = T_AcceptTX.Sender
                                        T_Order.SellerRS = T_AcceptTX.SenderRS

                                        T_Order.Amount = ClsSignumAPI.Planck2Dbl(ReferenceCreationMessageList(1))
                                        T_Order.Collateral = ClsSignumAPI.Planck2Dbl(T_Amount - ClsSignumAPI._GasFeeNQT)

                                        T_Order.XAmount = ClsSignumAPI.Planck2Dbl(ReferenceCreationMessageList(2))
                                        T_Order.XItem = ClsSignumAPI.ULng2String(ReferenceCreationMessageList(3))

                                        T_Order.Price = T_Order.XAmount / T_Order.Amount

                                        Dim Finisher As ULong = T_FinishTX.Sender

                                        If ReferenceFinishOrder = ReferenceFinishMessageList(0) Then
                                            If Finisher = T_Order.SellerID Then
                                                T_Order.Status = E_Status.CLOSED
                                            Else 'If Finisher = o.BuyerID Then
                                                T_Order.Status = E_Status.CANCELED
                                            End If
                                        ElseIf ReferenceAcceptOrder = ReferenceFinishMessageList(0) Then
                                            'initiator canceled Order
                                            T_Order.Status = E_Status.CANCELED
                                        ElseIf ReferenceFinishOrderWithChainSwapKey = ReferenceFinishMessageList(0) Then
                                            T_Order.Status = E_Status.CLOSED
                                        End If

                                    End If

                                    T_ContractOrderHistoryList.Add(T_Order)

                                End If

                            End If

                        End If

                    End If

                End If

            Next

            'If SetStartTimeStamp = 0UL Then
            C_ContractOrderHistoryList = T_ContractOrderHistoryList.OrderBy(Function(T_TX As S_Order) T_TX.StartTimestamp).ToList
            'Else
            '    T_ContractOrderHistoryList = T_ContractOrderHistoryList.OrderBy(Function(T_TX As S_Order) T_TX.StartTimestamp).ToList
            '    C_ContractOrderHistoryList.AddRange(T_ContractOrderHistoryList.ToArray)
            'End If

        Else

        End If

        C_StartForm.MultiInvoker(C_StartForm.SubStatusLabel, "Text", "")

    End Sub

    Private Sub ConvertThread(ByVal Input As Object)

        Dim JSONStr As String = Convert.ToString(Input)

        Dim JSON As ClsJSON = New ClsJSON
        Dim RespList As Object = JSON.JSONRecursive(JSONStr)

        Dim Error0 As Object = JSON.RecursiveListSearch(DirectCast(RespList, List(Of Object)), "errorCode")
        If Error0.GetType.Name = GetType(Boolean).Name Then
            'TX OK

            Dim TempList As List(Of String) = New List(Of String)

            For Each T_SubEntry In DirectCast(RespList, List(Of Object))

                Dim SubEntry As List(Of Object) = New List(Of Object)

                If T_SubEntry.GetType.Name = GetType(List(Of Object)).Name Then
                    SubEntry = DirectCast(T_SubEntry, List(Of Object))
                End If

                If SubEntry.Count > 0 Then

                    Select Case True
                        Case SubEntry(0).ToString = "type"
                            TempList.Add("<type>" + SubEntry(1).ToString + "</type>")
                        Case SubEntry(0).ToString = "timestamp"
                            TempList.Add("<timestamp>" + SubEntry(1).ToString + "</timestamp>")
                        Case SubEntry(0).ToString = "recipient"
                            TempList.Add("<recipient>" + SubEntry(1).ToString + "</recipient>")
                        Case SubEntry(0).ToString = "recipientRS"
                            TempList.Add("<recipientRS>" + SubEntry(1).ToString + "</recipientRS>")
                        Case SubEntry(0).ToString = "amountNQT"
                            TempList.Add("<amountNQT>" + SubEntry(1).ToString + "</amountNQT>")
                        Case SubEntry(0).ToString = "feeNQT"
                            TempList.Add("<feeNQT>" + SubEntry(1).ToString + "</feeNQT>")
                        Case SubEntry(0).ToString = "transaction"
                            TempList.Add("<transaction>" + SubEntry(1).ToString + "</transaction>")
                        Case SubEntry(0).ToString = "attachment"

                            Dim TMsg As String = "<attachment>"
                            Dim Message As String = JSON.RecursiveListSearch(DirectCast(SubEntry(1), List(Of Object)), "message").ToString

                            If Message.Trim <> "False" Then
                                Dim IsText As String = JSON.RecursiveListSearch(DirectCast(SubEntry(1), List(Of Object)), "messageIsText").ToString
                                TMsg += "<message>" + Message + "</message><isText>" + IsText + "</isText>"
                            End If

                            Dim EncMessage As Object = JSON.RecursiveListSearch(DirectCast(SubEntry(1), List(Of Object)), "encryptedMessage")

                            If EncMessage.GetType.Name = GetType(Boolean).Name Then

                            ElseIf EncMessage.GetType.Name = GetType(List(Of Object)).Name Then

                                Dim Data As String = Convert.ToString(JSON.RecursiveListSearch(DirectCast(EncMessage, List(Of Object)), "data"))
                                Dim Nonce As String = Convert.ToString(JSON.RecursiveListSearch(DirectCast(EncMessage, List(Of Object)), "nonce"))
                                Dim IsText As String = Convert.ToString(JSON.RecursiveListSearch(DirectCast(SubEntry(1), List(Of Object)), "isText"))

                                If Not Data.Trim = "False" And Not Nonce.Trim = "False" Then
                                    TMsg += "<data>" + Data + "</data><nonce>" + Nonce + "</nonce><isText>" + IsText + "</isText>"
                                End If

                            End If

                            TMsg += "</attachment>"
                            TempList.Add(TMsg)

                        Case SubEntry(0).ToString = "sender"
                            TempList.Add("<sender>" + SubEntry(1).ToString + "</sender>")
                        Case SubEntry(0).ToString = "senderRS"
                            TempList.Add("<senderRS>" + SubEntry(1).ToString + "</senderRS>")
                        Case SubEntry(0).ToString = "confirmations"
                            TempList.Add("<confirmations>" + SubEntry(1).ToString + "</confirmations>")
                    End Select

                End If

            Next

            XMLList.Add(TempList)

        ElseIf Error0.GetType.Name = GetType(String).Name Then
            'TX not OK
            'If GetINISetting(E_Setting.InfoOut, False) Then
            '    Dim Out As ClsOut = New ClsOut(Application.StartupPath)
            '    Out.ErrorLog2File(Application.ProductName + "-error in LoadUpTransactions() -> ConvertThread(): " + JSONStr)
            'End If

        End If

    End Sub

    ''' <summary>
    ''' Loads HistoryTransactions
    ''' </summary>
    ''' <param name="SetStartTimeStamp"></param>
    Private Function GetHistoryTransactions(Optional ByVal SetStartTimeStamp As ULong = 0UL) As Integer

        Dim SignumAPI = New ClsSignumAPI(C_Node)

        If SetStartTimeStamp = 0UL Then
            C_ContractOrderHistoryList.Clear()
        End If

        Dim T_ContractTransactionsPieceList As List(Of List(Of String)) = SignumAPI.GetAccountTransactions(C_ID, SetStartTimeStamp)
        Dim T_ContractTransactionsList As List(Of List(Of String)) = New List(Of List(Of String))
        T_ContractTransactionsList.AddRange(T_ContractTransactionsPieceList.ToArray)

        Dim W500 As Integer = T_ContractTransactionsPieceList.Count
        While W500 >= 500

            C_StartForm.MultiInvoker(C_StartForm.SubStatusLabel, "Text", "LoadHistoryTransactions(" + C_ID.ToString + "): " + W500.ToString)

            T_ContractTransactionsPieceList = SignumAPI.GetAccountTransactions(C_ID, SetStartTimeStamp, Convert.ToUInt64(W500))

            Dim T_W500 As Integer = T_ContractTransactionsPieceList.Count

            If T_W500 >= 500 Then
                W500 += 500
            Else
                W500 = 0
            End If

            T_ContractTransactionsList.AddRange(T_ContractTransactionsPieceList.ToArray)

        End While



        Dim T_TXList As List(Of S_TX) = New List(Of S_TX)

        For Each TX As List(Of String) In T_ContractTransactionsList
            Dim T_TX As S_TX = New S_TX

            T_TX.Transaction = GetULongBetweenFromList(TX, "<transaction>", "</transaction>")
            T_TX.Type = GetIntegerBetweenFromList(TX, "<type>", "</type>")
            T_TX.Timestamp = GetULongBetweenFromList(TX, "<timestamp>", "</timestamp>")

            T_TX.DateTimestamp = ClsSignumAPI.UnixToTime(T_TX.Timestamp.ToString)

            T_TX.Sender = GetULongBetweenFromList(TX, "<sender>", "</sender>")
            T_TX.SenderRS = GetStringBetweenFromList(TX, "<senderRS>", "</senderRS>")

            T_TX.AmountNQT = GetULongBetweenFromList(TX, "<amountNQT>", "</amountNQT>")
            T_TX.FeeNQT = GetULongBetweenFromList(TX, "<feeNQT>", "</feeNQT>")
            T_TX.Attachment = GetStringBetweenFromList(TX, "<attachment>", "</attachment>")

            T_TX.Recipient = GetULongBetweenFromList(TX, "<recipient>", "</recipient>")
            T_TX.RecipientRS = GetStringBetweenFromList(TX, "<recipientRS>", "</recipientRS>")

            T_TX.Confirmations = GetULongBetweenFromList(TX, "<confirmations>", "</confirmations>")

            T_TXList.Add(T_TX)

        Next

        If T_TXList.Count > 0 Then

            T_TXList = T_TXList.OrderBy(Function(T_TX As S_TX) T_TX.DateTimestamp).ToList

            Dim T_LastTX As S_TX = T_TXList(T_TXList.Count - 1)

            'If T_LastTX.Recipient = C_ID Then
            '    If T_LastTX.Confirmations = 0 Then

            '        If CurrentInitiatorID <> 0UL And CurrentResponderID <> 0UL Then
            '            If T_LastTX.Sender = CurrentInitiatorID Or T_LastTX.Sender = CurrentResponderID Then
            '                C_Status = E_Status.TX_PENDING
            '            End If
            '        Else
            '            C_Status = E_Status.TX_PENDING
            '        End If

            '    End If
            'End If

            Dim T_ContractOrderHistoryList As List(Of S_Order) = New List(Of S_Order)

            For i As Integer = 0 To T_TXList.Count - 1

                Dim T_TX As S_TX = T_TXList(i)

                C_StartForm.MultiInvoker(C_StartForm.SubStatusLabel, "Text", "ProcessingHistoryTransactions(" + C_ID.ToString + ") (" + i.ToString + "/" + T_TXList.Count.ToString + ")")

                If T_TX.Sender = C_ID Then

                    'LastTX = False

                    Dim ReferenceTXIDs As String = GetStringBetween(T_TX.Attachment, "<message>", "</message>")
                    If Not ReferenceTXIDs.Trim = "" Then

                        Dim ReferenceTXIDList As List(Of ULong) = ClsSignumAPI.DataStr2ULngList(ReferenceTXIDs)

                        If Not ReferenceTXIDList(0) = 0UL And Not ReferenceTXIDList(1) = 0UL And Not ReferenceTXIDList(2) = 0UL Then
                            'referenceTXID

                            Dim T_CreationTX As S_TX = Nothing
                            Dim T_AcceptTX As S_TX = Nothing
                            Dim T_FinishTX As S_TX = Nothing

                            Dim T_Responder As ULong = ReferenceTXIDList(3)

                            For Each R_TX As S_TX In T_TXList
                                Select Case R_TX.Transaction
                                    Case ReferenceTXIDList(0)
                                        T_CreationTX = R_TX
                                    Case ReferenceTXIDList(1)
                                        T_AcceptTX = R_TX
                                    Case ReferenceTXIDList(2)
                                        T_FinishTX = R_TX
                                End Select

                                If R_TX.Transaction = ReferenceTXIDList(1) And ReferenceTXIDList(1) = ReferenceTXIDList(2) Then
                                    T_AcceptTX = R_TX
                                    T_FinishTX = R_TX
                                End If

                                If Not T_CreationTX.Transaction = 0UL And Not T_AcceptTX.Transaction = 0UL And Not T_FinishTX.Transaction = 0UL Then
                                    Exit For
                                End If

                            Next

                            If Not T_CreationTX.Transaction = 0UL And Not T_AcceptTX.Transaction = 0UL And Not T_FinishTX.Transaction = 0UL Then

                                Dim ReferenceCreationMessage As String = GetStringBetween(T_CreationTX.Attachment, "<message>", "</message>")
                                Dim ReferenceCreationMessageList As List(Of ULong) = ClsSignumAPI.DataStr2ULngList(ReferenceCreationMessage)

                                Dim ReferenceAcceptMessage As String = GetStringBetween(T_AcceptTX.Attachment, "<message>", "</message>")
                                Dim ReferenceAcceptMessageList As List(Of ULong) = ClsSignumAPI.DataStr2ULngList(ReferenceAcceptMessage)

                                Dim ReferenceFinishMessage As String = GetStringBetween(T_FinishTX.Attachment, "<message>", "</message>")
                                Dim ReferenceFinishMessageList As List(Of ULong) = ClsSignumAPI.DataStr2ULngList(ReferenceFinishMessage)


                                Dim RefCreateOrderBool As Boolean = ReferenceCreateOrder = ReferenceCreationMessageList(0)
                                Dim RefCreateOrderWithResponderBool As Boolean = ReferenceCreateOrderWithResponder = ReferenceCreationMessageList(0)

                                Dim RefAcceptOrderBol As Boolean = ReferenceAcceptOrder = ReferenceAcceptMessageList(0) Or ReferenceInjectResponder = ReferenceAcceptMessageList(0)

                                Dim RefCancelOrderBol As Boolean = ReferenceAcceptMessageList(0) = ReferenceFinishMessageList(0) And T_AcceptTX.Transaction = T_FinishTX.Transaction
                                Dim RefFinishOrderBol As Boolean = ReferenceFinishOrder = ReferenceFinishMessageList(0)
                                Dim RefFinishOrderWithChainSwapKeyBol As Boolean = ReferenceFinishOrderWithChainSwapKey = ReferenceFinishMessageList(0)

                                Dim RefFinishOrderByCheckCloseDisputeBol As Boolean = ReferenceCheckCloseDispute = ReferenceFinishMessageList(0)

                                If (RefCreateOrderBool Or RefCreateOrderWithResponderBool) And RefAcceptOrderBol And (RefCancelOrderBol Or RefFinishOrderBol Or RefFinishOrderWithChainSwapKeyBol Or RefFinishOrderByCheckCloseDisputeBol) Then

                                    'RefCreateOrderBool = RefCreateOrderBool
                                    'End If
                                    'If ReferenceCreateOrder = ReferenceCreationMessageList(0) And (ReferenceAcceptOrder = ReferenceAcceptMessageList(0) Or ReferenceInjectResponder = ReferenceAcceptMessageList(0)) And ((ReferenceFinishOrder = ReferenceFinishMessageList(0) Or ReferenceFinishOrderWithChainSwapKey = ReferenceFinishMessageList(0)) Or (ReferenceAcceptMessageList(0) = ReferenceFinishMessageList(0) And T_AcceptTX.Transaction = T_FinishTX.Transaction)) Then

                                    Dim T_Order As S_Order = New S_Order

                                    T_Order.CreationTransaction = T_CreationTX.Transaction
                                    T_Order.LastTransaction = T_FinishTX.Transaction

                                    T_Order.Confirmations = T_CreationTX.Confirmations

                                    T_Order.StartTimestamp = T_CreationTX.Timestamp
                                    T_Order.EndTimestamp = T_TX.Timestamp + 1UL

                                    'T_Order.StartDate = ClsSignumAPI.UnixToTime(T_Order.StartTimestamp.ToString) 'Debug
                                    'T_Order.EndDate = ClsSignumAPI.UnixToTime(T_Order.EndTimestamp.ToString) 'Debug
                                    T_Order.ChainSwapKey = ""
                                    'T_Order.ChainSwapHash = ""

                                    Dim T_Collateral As ULong = ReferenceCreationMessageList(1)
                                    Dim T_Amount As ULong = T_CreationTX.AmountNQT '- T_Collateral - ClsSignumAPI._GasFeeNQT

                                    If T_Amount > T_Collateral Then

                                        '(0) ULong   Creation Method SellOrder
                                        '(1) ULong   Collateral
                                        '(2) ULong   XAmountNQT
                                        '(3) ULong   XItem USD

                                        T_Order.WasSellOrder = True

                                        T_Order.SellerID = T_CreationTX.Sender
                                        T_Order.SellerRS = T_CreationTX.SenderRS

                                        If T_Responder = 0UL Then
                                            T_Order.BuyerID = T_AcceptTX.Sender
                                            T_Order.BuyerRS = T_AcceptTX.SenderRS
                                        Else
                                            T_Order.BuyerID = T_Responder
                                            T_Order.BuyerRS = ClsSignumAPI._AddressPreFix + ClsReedSolomon.Encode(T_Responder)
                                        End If


                                        T_Order.Amount = ClsSignumAPI.Planck2Dbl(T_Amount - T_Collateral - ClsSignumAPI._GasFeeNQT)
                                        T_Order.Collateral = ClsSignumAPI.Planck2Dbl(ReferenceCreationMessageList(1))

                                        T_Order.XAmount = ClsSignumAPI.Planck2Dbl(ReferenceCreationMessageList(2))
                                        T_Order.XItem = ClsSignumAPI.ULng2String(ReferenceCreationMessageList(3))

                                        T_Order.Price = T_Order.XAmount / T_Order.Amount

                                        Dim Finisher As ULong = T_FinishTX.Sender

                                        If RefFinishOrderBol Then
                                            If Finisher = T_Order.SellerID Then
                                                T_Order.Status = E_Status.CLOSED
                                            Else 'If Finisher = o.BuyerID Then
                                                T_Order.Status = E_Status.CANCELED
                                            End If
                                        ElseIf ReferenceAcceptOrder = ReferenceFinishMessageList(0) Then
                                            'initiator canceled Order
                                            T_Order.Status = E_Status.CANCELED
                                        ElseIf RefFinishOrderWithChainSwapKeyBol Then

                                            '(0) ULong   Finish Method FinishOrderWithChainSwapKey()
                                            '(1) ULong   First ChainSwapKeyLong
                                            '(2) ULong   Second ChainSwapKeyLong
                                            '(3) ULong   Third ChainSwapKeyLong
                                            '(4) ULong   Fourth ChainSwapKeyLong

                                            Dim FirstChainSwapKeyLong As Byte() = BitConverter.GetBytes(ReferenceFinishMessageList(1))
                                            Dim SecondChainSwapKeyLong As Byte() = BitConverter.GetBytes(ReferenceFinishMessageList(2))
                                            Dim ThirdChainSwapKeyLong As Byte() = BitConverter.GetBytes(ReferenceFinishMessageList(3))
                                            Dim FourthChainSwapKeyLong As Byte() = BitConverter.GetBytes(ReferenceFinishMessageList(4))

                                            Dim ChainSwapKeyByteList As List(Of Byte) = New List(Of Byte)(FirstChainSwapKeyLong)
                                            ChainSwapKeyByteList.AddRange(SecondChainSwapKeyLong)
                                            ChainSwapKeyByteList.AddRange(ThirdChainSwapKeyLong)
                                            ChainSwapKeyByteList.AddRange(FourthChainSwapKeyLong)

                                            Dim ChainSwapKeyHEX As String = ByteArrayToHEXString(ChainSwapKeyByteList.ToArray)

                                            'TODO: ##AtomicSwap get chainswapkey 

                                            T_Order.ChainSwapKey = ChainSwapKeyHEX

                                            T_Order.Status = E_Status.CLOSED
                                        ElseIf RefFinishOrderByCheckCloseDisputeBol Then
                                            T_Order.Status = E_Status.CANCELED
                                        End If


                                    Else

                                        '(0) ULong   Creation Method BuyOrder
                                        '(1) ULong   WantToBuyAmount
                                        '(2) ULong   XAmountNQT
                                        '(3) ULong   XItem USD

                                        T_Order.WasSellOrder = False

                                        T_Order.BuyerID = T_CreationTX.Sender
                                        T_Order.BuyerRS = T_CreationTX.SenderRS
                                        T_Order.SellerID = T_AcceptTX.Sender
                                        T_Order.SellerRS = T_AcceptTX.SenderRS


                                        T_Order.Amount = ClsSignumAPI.Planck2Dbl(ReferenceCreationMessageList(1))
                                        T_Order.Collateral = ClsSignumAPI.Planck2Dbl(T_Amount - ClsSignumAPI._GasFeeNQT)

                                        T_Order.XAmount = ClsSignumAPI.Planck2Dbl(ReferenceCreationMessageList(2))
                                        T_Order.XItem = ClsSignumAPI.ULng2String(ReferenceCreationMessageList(3))

                                        T_Order.Price = T_Order.XAmount / T_Order.Amount

                                        Dim Finisher As ULong = T_FinishTX.Sender

                                        If RefFinishOrderBol Then
                                            If Finisher = T_Order.SellerID Then
                                                T_Order.Status = E_Status.CLOSED
                                            Else 'If Finisher = o.BuyerID Then
                                                T_Order.Status = E_Status.CANCELED
                                            End If
                                        ElseIf ReferenceAcceptOrder = ReferenceFinishMessageList(0) Then
                                            'initiator canceled Order
                                            T_Order.Status = E_Status.CANCELED
                                        ElseIf RefFinishOrderWithChainSwapKeyBol Then

                                            '(0) ULong   Finish Method FinishOrderWithChainSwapKey()
                                            '(1) ULong   First ChainSwapKeyLong
                                            '(2) ULong   Second ChainSwapKeyLong
                                            '(3) ULong   Third ChainSwapKeyLong
                                            '(4) ULong   Fourth ChainSwapKeyLong

                                            Dim FirstChainSwapKeyLong As Byte() = BitConverter.GetBytes(ReferenceFinishMessageList(1))
                                            Dim SecondChainSwapKeyLong As Byte() = BitConverter.GetBytes(ReferenceFinishMessageList(2))
                                            Dim ThirdChainSwapKeyLong As Byte() = BitConverter.GetBytes(ReferenceFinishMessageList(3))
                                            Dim FourthChainSwapKeyLong As Byte() = BitConverter.GetBytes(ReferenceFinishMessageList(4))

                                            Dim ChainSwapKeyByteList As List(Of Byte) = New List(Of Byte)(FirstChainSwapKeyLong)
                                            ChainSwapKeyByteList.AddRange(SecondChainSwapKeyLong)
                                            ChainSwapKeyByteList.AddRange(ThirdChainSwapKeyLong)
                                            ChainSwapKeyByteList.AddRange(FourthChainSwapKeyLong)

                                            Dim ChainSwapKeyHEX As String = ByteArrayToHEXString(ChainSwapKeyByteList.ToArray)

                                            'TODO: ##AtomicSwap get chainswapkey 

                                            T_Order.ChainSwapKey = ChainSwapKeyHEX

                                            T_Order.Status = E_Status.CLOSED
                                        ElseIf RefFinishOrderByCheckCloseDisputeBol Then
                                            T_Order.Status = E_Status.CANCELED
                                        End If

                                    End If

                                    T_ContractOrderHistoryList.Add(T_Order)

                                End If

                            End If

                        End If

                    End If

                End If

            Next

            If SetStartTimeStamp = 0UL Then
                C_ContractOrderHistoryList = T_ContractOrderHistoryList.OrderBy(Function(T_TX As S_Order) T_TX.StartTimestamp).ToList
            Else
                T_ContractOrderHistoryList = T_ContractOrderHistoryList.OrderBy(Function(T_TX As S_Order) T_TX.StartTimestamp).ToList
                C_ContractOrderHistoryList.AddRange(T_ContractOrderHistoryList.ToArray)
            End If
        Else

        End If

        C_StartForm.MultiInvoker(C_StartForm.SubStatusLabel, "Text", "")

        Return C_ContractOrderHistoryList.Count

    End Function

    Private Sub GetCurrentChat()

        If Not C_CurrentInitiatorID = 0UL And Not C_CurrentResponderID = 0UL Then

            Dim SignumAPI = New ClsSignumAPI(C_Node)

            Dim T_TXIDList As List(Of ULong) = SignumAPI.GetTransactionIds(C_CurrentInitiatorID, C_CurrentResponderID, C_CurrentTimestamp)
            T_TXIDList.AddRange(SignumAPI.GetTransactionIds(C_CurrentResponderID, C_CurrentInitiatorID, C_CurrentTimestamp))

            T_TXIDList.AddRange(SignumAPI.GetTransactionIds(C_CreatorID, C_CurrentInitiatorID, C_CurrentTimestamp))
            T_TXIDList.AddRange(SignumAPI.GetTransactionIds(C_CurrentInitiatorID, C_CreatorID, C_CurrentTimestamp))

            T_TXIDList.AddRange(SignumAPI.GetTransactionIds(C_CreatorID, C_CurrentResponderID, C_CurrentTimestamp))
            T_TXIDList.AddRange(SignumAPI.GetTransactionIds(C_CurrentResponderID, C_CreatorID, C_CurrentTimestamp))

            Dim T_TXRList As List(Of List(Of String)) = New List(Of List(Of String))

            For Each T_TXID As ULong In T_TXIDList
                Dim T_TX As List(Of String) = SignumAPI.GetTransaction(T_TXID)
                T_TXRList.Add(T_TX)
            Next


            Dim T_TXList As List(Of S_TX) = New List(Of S_TX)

            For Each TX As List(Of String) In T_TXRList
                Dim T_TX As S_TX = New S_TX

                T_TX.Transaction = GetULongBetweenFromList(TX, "<transaction>", "</transaction>")
                'T_TX.Type = BetweenFromList(TX, "<type>", "</type>",, GetType(Integer))
                T_TX.Timestamp = GetULongBetweenFromList(TX, "<timestamp>", "</timestamp>")

                T_TX.Sender = GetULongBetweenFromList(TX, "<sender>", "</sender>")
                T_TX.SenderRS = GetStringBetweenFromList(TX, "<senderRS>", "</senderRS>")

                T_TX.AmountNQT = GetULongBetweenFromList(TX, "<amountNQT>", "</amountNQT>")
                T_TX.FeeNQT = GetULongBetweenFromList(TX, "<feeNQT>", "</feeNQT>")
                T_TX.Attachment = GetStringBetweenFromList(TX, "<attachment>", "</attachment>")

                T_TX.Recipient = GetULongBetweenFromList(TX, "<recipient>", "</recipient>")
                T_TX.RecipientRS = GetStringBetweenFromList(TX, "<recipientRS>", "</recipientRS>")

                T_TX.Confirmations = GetULongBetweenFromList(TX, "<confirmations>", "</confirmations>")

                T_TXList.Add(T_TX)

            Next

            T_TXList = T_TXList.OrderBy(Function(T_TX As S_TX) T_TX.Timestamp).ToList

            C_CurrentChat.Clear()

            For Each T_TX As S_TX In T_TXList

                Dim T_Chat As S_Chat = New S_Chat
                T_Chat.Timestamp = T_TX.Timestamp
                T_Chat.SenderAddress = T_TX.SenderRS
                T_Chat.RecipientAddress = T_TX.RecipientRS
                T_Chat.Attachment = T_TX.Attachment

                C_CurrentChat.Add(T_Chat)

            Next

        End If

    End Sub

    Private Sub GetChatHistory()

        For Each T_Order As S_Order In C_ContractOrderHistoryList
            Dim SignumAPI As ClsSignumAPI = New ClsSignumAPI(C_Node)
        Next

    End Sub

    Private Sub SetPendings(ByVal PendingAmount As Double, ByVal ReferenceMessageULongList As List(Of ULong))

        C_PendingCommand = GetReferenceCommand(ReferenceMessageULongList(0))

        If C_PendingCommand <> E_ReferenceCommand.NONE Then
            C_PendingAmount = PendingAmount
        End If

        Select Case C_PendingCommand
            Case E_ReferenceCommand.REFERENCE_DE_ACTIVATE_DENIABILITY

            Case E_ReferenceCommand.REFERENCE_CREATE_ORDER

                C_PendingCollateral = ClsSignumAPI.Planck2Dbl(ReferenceMessageULongList(1))
                C_PendingResponderID = 0UL
                C_PendingResponderAddress = ""
                C_PendingXAmount = ClsSignumAPI.Planck2Dbl(ReferenceMessageULongList(2))
                C_PendingXItem = ClsSignumAPI.ULng2String(ReferenceMessageULongList(3))

                If CurrentInitiatorID = 0 And ((PendingAmount > 0.4 And C_PendingCollateral >= 0.0) Or (PendingAmount > 100.4 And C_PendingCollateral = 0.0)) Then

                Else
                    ResetPendings()
                End If

            Case E_ReferenceCommand.REFERENCE_CREATE_ORDER_WITH_RESPONDER

                C_PendingCollateral = 0.0
                C_PendingResponderID = ReferenceMessageULongList(1)
                C_PendingResponderAddress = ClsReedSolomon.Encode(C_PendingResponderID)
                C_PendingXAmount = ClsSignumAPI.Planck2Dbl(ReferenceMessageULongList(2))
                C_PendingXItem = ClsSignumAPI.ULng2String(ReferenceMessageULongList(3))

                If CurrentInitiatorID = 0 And C_PendingResponderID <> 0UL And PendingAmount > 0.4 Then

                Else
                    ResetPendings()
                End If

                'TODO: set pendings
                'Case E_ReferenceCommand.REFERENCE_ACCEPT_ORDER

                'Case E_ReferenceCommand.REFERENCE_INJECT_RESPONDER

                'Case E_ReferenceCommand.REFERENCE_INJECT_CHAINSWAPHASH

                'Case E_ReferenceCommand.REFERENCE_OPEN_DISPUTE

                'Case E_ReferenceCommand.REFERENCE_MEDIATE_DISPUTE

                'Case E_ReferenceCommand.REFERENCE_APPEAL

                'Case E_ReferenceCommand.REFERENCE_CHECK_CLOSE_DISPUTE

                'Case E_ReferenceCommand.REFERENCE_FINISH_ORDER

                'Case E_ReferenceCommand.REFERENCE_FINISH_ORDER_WITH_CHAINSWAPKEY

            Case Else
                ResetPendings()

        End Select


    End Sub

    Private Sub ResetPendings()
        C_PendingAmount = 0.0
        C_PendingCommand = E_ReferenceCommand.NONE
        C_PendingCollateral = 0.0
        C_PendingResponderID = 0UL
        C_PendingResponderAddress = ""
        C_PendingXAmount = 0.0
        C_PendingXItem = ""
    End Sub

    Private Function GetReferenceCommand(ByVal ReferenceCommand As ULong) As E_ReferenceCommand

        Select Case ReferenceCommand
            Case ReferenceDeActivateDeniability
                Return E_ReferenceCommand.REFERENCE_DE_ACTIVATE_DENIABILITY
            Case ReferenceCreateOrderWithResponder
                Return E_ReferenceCommand.REFERENCE_CREATE_ORDER_WITH_RESPONDER
            Case ReferenceCreateOrder
                Return E_ReferenceCommand.REFERENCE_CREATE_ORDER
            Case ReferenceAcceptOrder
                Return E_ReferenceCommand.REFERENCE_ACCEPT_ORDER
            Case ReferenceInjectResponder
                Return E_ReferenceCommand.REFERENCE_INJECT_RESPONDER
            Case ReferenceOpenDispute
                Return E_ReferenceCommand.REFERENCE_OPEN_DISPUTE
            Case ReferenceMediateDispute
                Return E_ReferenceCommand.REFERENCE_MEDIATE_DISPUTE
            Case ReferenceAppeal
                Return E_ReferenceCommand.REFERENCE_APPEAL
            Case ReferenceCheckCloseDispute
                Return E_ReferenceCommand.REFERENCE_CHECK_CLOSE_DISPUTE
            Case ReferenceFinishOrder
                Return E_ReferenceCommand.REFERENCE_FINISH_ORDER
            Case ReferenceInjectChainSwapHash
                Return E_ReferenceCommand.REFERENCE_INJECT_CHAINSWAPHASH
            Case ReferenceFinishOrderWithChainSwapKey
                Return E_ReferenceCommand.REFERENCE_FINISH_ORDER_WITH_CHAINSWAPKEY
            Case Else
                Return E_ReferenceCommand.NONE
        End Select

    End Function
    Private Function IsReferenceCommand(ByVal ReferenceCommand As ULong) As Boolean

        If GetReferenceCommand(ReferenceCommand) = E_ReferenceCommand.NONE Then
            Return False
        Else
            Return True
        End If

    End Function

#End Region

#Region "DEXContract interactions"

    Public Function DeActivateDeniability(ByVal SenderPublicKey As String, Optional Fee As Double = 0.0, Optional ByVal SignKeyHEX As String = "") As String

        Dim Response As String = ""
        CheckForUTX()
        CheckForTX()

        If Not C_Status = E_Status.NEW_ And Not C_Status = E_Status.FREE Then
            Return Application.ProductName + "-error in DeActivateDeniability(1): ->" + vbCrLf + "Contract Status:" + C_Status.ToString
        End If

        Dim SignumAPI As ClsSignumAPI = New ClsSignumAPI(,, C_ID)
        Dim ULngList As List(Of ULong) = New List(Of ULong)({ReferenceDeActivateDeniability})
        Dim MsgStr As String = ClsSignumAPI.ULngList2DataStr(ULngList)
        Response = SignumAPI.SendMoney(SenderPublicKey, C_ID, ClsSignumAPI.Planck2Dbl(ClsSignumAPI._GasFeeNQT), Fee, MsgStr.Trim, False)

        Dim JSON As ClsJSON = New ClsJSON

        Dim Error0 As Object = JSON.RecursiveListSearch(JSON.JSONRecursive(Response), "errorCode")
        If Error0.GetType.Name = GetType(Boolean).Name Then
            'TX OK
        ElseIf Error0.GetType.Name = GetType(String).Name Then
            'TX not OK
            Return Application.ProductName + "-error in DeActivateDeniability(2): ->" + vbCrLf + Response
        End If

        If Response.Contains(Application.ProductName + "-error") Then
            Return Response
        Else
            Dim UTXList As List(Of String) = ClsSignumAPI.ConvertUnsignedTXToList(Response)
            Response = GetStringBetweenFromList(UTXList, "<unsignedTransactionBytes>", "</unsignedTransactionBytes>")
        End If

        If Not SignKeyHEX.Trim = "" Then

            Dim SignumNET As ClsSignumNET = New ClsSignumNET
            Dim STX As ClsSignumNET.S_Signature = SignumNET.SignHelper(Response, SignKeyHEX)
            Response = SignumAPI.BroadcastTransaction(STX.SignedTransaction)

            If Response.Contains(Application.ProductName + "-error") Then
                Return Response
            End If

        End If

        Return Response

    End Function

    Public Function CreateOrderWithResponder(ByVal SenderPublicKey As String, ByVal SellAmount As Double, ByVal ResponderID As ULong, ByVal Xitem As String, ByVal XAmount As Double, Optional Fee As Double = 0.0, Optional ByVal SignKeyHEX As String = "") As String

        Dim Response As String = ""

        CheckForUTX()
        CheckForTX()

        If Not C_Status = E_Status.NEW_ And Not C_Status = E_Status.FREE Then
            Return Application.ProductName + "-error in CreateOrderWithResponder(1): ->" + vbCrLf + "Contract Status:" + C_Status.ToString
        End If

        Dim SignumAPI As ClsSignumAPI = New ClsSignumAPI(C_Node,, C_ID)
        Dim XAmountNQT As ULong = ClsSignumAPI.Dbl2Planck(XAmount)
        Dim ULngList As List(Of ULong) = New List(Of ULong)({ReferenceCreateOrderWithResponder, ResponderID, XAmountNQT, ClsSignumAPI.String2ULng(Xitem.Trim)})
        Dim MsgStr As String = ClsSignumAPI.ULngList2DataStr(ULngList)

        Response = SignumAPI.SendMoney(SenderPublicKey, C_ID, SellAmount + ClsSignumAPI.Planck2Dbl(ClsSignumAPI._GasFeeNQT), Fee, MsgStr.Trim, False)

        Dim JSON As ClsJSON = New ClsJSON

        Dim Error0 As Object = JSON.RecursiveListSearch(JSON.JSONRecursive(Response), "errorCode")
        If Error0.GetType.Name = GetType(Boolean).Name Then
            'TX OK
        ElseIf Error0.GetType.Name = GetType(String).Name Then
            'TX not OK
            Return Application.ProductName + "-error in CreateOrderWithResponder(2): ->" + vbCrLf + Response
        End If


        If Response.Contains(Application.ProductName + "-error") Then
            Return Response
        Else
            Dim UTXList As List(Of String) = ClsSignumAPI.ConvertUnsignedTXToList(Response)
            Response = GetStringBetweenFromList(UTXList, "<unsignedTransactionBytes>", "</unsignedTransactionBytes>")
        End If


        If Not SignKeyHEX.Trim = "" Then

            Dim SignumNET As ClsSignumNET = New ClsSignumNET
            Dim STX As ClsSignumNET.S_Signature = SignumNET.SignHelper(Response, SignKeyHEX)
            Response = SignumAPI.BroadcastTransaction(STX.SignedTransaction)

            If Response.Contains(Application.ProductName + "-error") Then
                Return Response
            End If

        End If

        Return Response

    End Function

    Public Function CreateSellOrder(ByVal SenderPublicKey As String, ByVal WantToSellAmount As Double, ByVal Collateral As Double, ByVal Xitem As String, ByVal XAmount As Double, Optional Fee As Double = 0.0, Optional ByVal SignKeyHEX As String = "") As String

        Dim Response As String = ""

        CheckForUTX()
        CheckForTX()

        If Not C_Status = E_Status.NEW_ And Not C_Status = E_Status.FREE Then
            Return Application.ProductName + "-error in CreateSellOrder(1): ->" + vbCrLf + "Contract Status:" + C_Status.ToString
        End If

        Dim SignumAPI As ClsSignumAPI = New ClsSignumAPI(,, C_ID)
        Dim XAmountNQT As ULong = ClsSignumAPI.Dbl2Planck(XAmount)
        Dim CollateralNQT As ULong = ClsSignumAPI.Dbl2Planck(Collateral)
        Dim ULngList As List(Of ULong) = New List(Of ULong)({ReferenceCreateOrder, CollateralNQT, XAmountNQT, ClsSignumAPI.String2ULng(Xitem.Trim)})
        Dim MsgStr As String = ClsSignumAPI.ULngList2DataStr(ULngList)

        Response = SignumAPI.SendMoney(SenderPublicKey, C_ID, WantToSellAmount + Collateral + ClsSignumAPI.Planck2Dbl(ClsSignumAPI._GasFeeNQT), Fee, MsgStr.Trim, False)

        Dim JSON As ClsJSON = New ClsJSON

        Dim Error0 As Object = JSON.RecursiveListSearch(JSON.JSONRecursive(Response), "errorCode")
        If Error0.GetType.Name = GetType(Boolean).Name Then
            'TX OK
        ElseIf Error0.GetType.Name = GetType(String).Name Then
            'TX not OK
            Return Application.ProductName + "-error in CreateSellOrder(2): ->" + vbCrLf + Response
        End If


        If Response.Contains(Application.ProductName + "-error") Then
            Return Response
        Else
            Dim UTXList As List(Of String) = ClsSignumAPI.ConvertUnsignedTXToList(Response)
            Response = GetStringBetweenFromList(UTXList, "<unsignedTransactionBytes>", "</unsignedTransactionBytes>")
        End If


        If Not SignKeyHEX.Trim = "" Then

            Dim SignumNET As ClsSignumNET = New ClsSignumNET
            Dim STX As ClsSignumNET.S_Signature = SignumNET.SignHelper(Response, SignKeyHEX)
            Response = SignumAPI.BroadcastTransaction(STX.SignedTransaction)

            If Response.Contains(Application.ProductName + "-error") Then
                Return Response
            End If

        End If

        Return Response

    End Function
    Public Function CreateBuyOrder(ByVal SenderPublicKey As String, ByVal WantToBuyAmount As Double, ByVal Collateral As Double, ByVal Xitem As String, ByVal XAmount As Double, Optional Fee As Double = 0.0, Optional ByVal SignKeyHEX As String = "") As String

        Dim Response As String = ""

        CheckForUTX()
        CheckForTX()

        If Not C_Status = E_Status.NEW_ And Not C_Status = E_Status.FREE Then
            Return Application.ProductName + "-error in CreateBuyOrder(1): ->" + vbCrLf + "Contract Status:" + C_Status.ToString
        End If

        Dim SignumAPI As ClsSignumAPI = New ClsSignumAPI(,, C_ID)

        'Dim AmountNQT As ULong = ClsSignumAPI.Dbl2Planck(Collateral)
        Dim XAmountNQT As ULong = ClsSignumAPI.Dbl2Planck(XAmount)
        Dim ReserveNQT As ULong = ClsSignumAPI.Dbl2Planck(WantToBuyAmount)
        Dim ULngList As List(Of ULong) = New List(Of ULong)({ReferenceCreateOrder, ReserveNQT, XAmountNQT, ClsSignumAPI.String2ULng(Xitem.Trim)})
        Dim MsgStr As String = ClsSignumAPI.ULngList2DataStr(ULngList)

        Response = SignumAPI.SendMoney(SenderPublicKey, C_ID, Collateral + ClsSignumAPI.Planck2Dbl(ClsSignumAPI._GasFeeNQT), Fee, MsgStr.Trim, False)

        Dim JSON As ClsJSON = New ClsJSON

        Dim Error0 As Object = JSON.RecursiveListSearch(JSON.JSONRecursive(Response), "errorCode")
        If Error0.GetType.Name = GetType(Boolean).Name Then
            'TX OK
        ElseIf Error0.GetType.Name = GetType(String).Name Then
            'TX not OK
            Return Application.ProductName + "-error in CreateBuyOrder(2): ->" + vbCrLf + Response
        End If

        If Response.Contains(Application.ProductName + "-error") Then
            Return Response
        Else
            Dim UTXList As List(Of String) = ClsSignumAPI.ConvertUnsignedTXToList(Response)
            Response = GetStringBetweenFromList(UTXList, "<unsignedTransactionBytes>", "</unsignedTransactionBytes>")
        End If


        If Not SignKeyHEX.Trim = "" Then

            Dim SignumNET As ClsSignumNET = New ClsSignumNET
            Dim STX As ClsSignumNET.S_Signature = SignumNET.SignHelper(Response, SignKeyHEX)
            Response = SignumAPI.BroadcastTransaction(STX.SignedTransaction)

            If Response.Contains(Application.ProductName + "-error") Then
                Return Response
            End If

        End If

        Return Response

    End Function

    Public Function AcceptSellOrder(ByVal SenderPublicKey As String, Optional ByVal Collateral As Double = -1.0, Optional ByVal Fee As Double = 0.0, Optional ByVal SignKeyHEX As String = "") As String

        Dim Response As String = ""

        CheckForUTX()
        CheckForTX()

        If Not C_Status = E_Status.OPEN Then
            Return Application.ProductName + "-error in AcceptOrder(1): ->" + vbCrLf + "Contract Status:" + C_Status.ToString
        End If


        If Collateral < 0.0 Then
            Collateral = C_CurrentInitiatorsCollateral
        End If

        Dim SignumAPI As ClsSignumAPI = New ClsSignumAPI(,, C_ID)
        Dim ULngList As List(Of ULong) = New List(Of ULong)({ReferenceAcceptOrder})
        Dim MsgStr As String = ClsSignumAPI.ULngList2DataStr(ULngList)
        Response = SignumAPI.SendMoney(SenderPublicKey, C_ID, Collateral + (ClsSignumAPI.Planck2Dbl(ClsSignumAPI._GasFeeNQT)), Fee, MsgStr.Trim, False)

        Dim JSON As ClsJSON = New ClsJSON

        Dim Error0 As Object = JSON.RecursiveListSearch(JSON.JSONRecursive(Response), "errorCode")
        If Error0.GetType.Name = GetType(Boolean).Name Then
            'TX OK
        ElseIf Error0.GetType.Name = GetType(String).Name Then
            'TX not OK
            Return Application.ProductName + "-error in AcceptOrder(2): ->" + vbCrLf + Response
        End If

        If Response.Contains(Application.ProductName + "-error") Then
            Return Response
        Else
            Dim UTXList As List(Of String) = ClsSignumAPI.ConvertUnsignedTXToList(Response)
            Response = GetStringBetweenFromList(UTXList, "<unsignedTransactionBytes>", "</unsignedTransactionBytes>")
        End If

        If Not SignKeyHEX.Trim = "" Then

            Dim SignumNET As ClsSignumNET = New ClsSignumNET
            Dim STX As ClsSignumNET.S_Signature = SignumNET.SignHelper(Response, SignKeyHEX)
            Response = SignumAPI.BroadcastTransaction(STX.SignedTransaction)

            If Response.Contains(Application.ProductName + "-error") Then
                Return Response
            End If

        End If

        Return Response

    End Function

    Public Function RejectResponder(ByVal SenderPublicKey As String, Optional ByVal Fee As Double = 0.0, Optional ByVal SignKeyHEX As String = "") As String
        Dim SignumAPI As ClsSignumAPI = New ClsSignumAPI(,, C_ID)
        Dim ULngList As List(Of ULong) = New List(Of ULong)({ReferenceAcceptOrder})
        Dim MsgStr As String = ClsSignumAPI.ULngList2DataStr(ULngList)
        Dim Response As String = SignumAPI.SendMoney(SenderPublicKey, C_ID, ClsSignumAPI.Planck2Dbl(ClsSignumAPI._GasFeeNQT), , MsgStr.Trim, False)

        Dim JSON As ClsJSON = New ClsJSON
        Dim Error0 As Object = JSON.RecursiveListSearch(JSON.JSONRecursive(Response), "errorCode")
        If Error0.GetType.Name = GetType(Boolean).Name Then
            'TX OK
        ElseIf Error0.GetType.Name = GetType(String).Name Then
            'TX not OK
            Return Application.ProductName + "-error in RejectResponder(): ->" + vbCrLf + Response
        End If

        If Response.Contains(Application.ProductName + "-error") Then
            Return Response
        Else
            Dim UTXList As List(Of String) = ClsSignumAPI.ConvertUnsignedTXToList(Response)
            Response = GetStringBetweenFromList(UTXList, "<unsignedTransactionBytes>", "</unsignedTransactionBytes>")
        End If

        If Not SignKeyHEX.Trim = "" Then

            Dim SignumNET As ClsSignumNET = New ClsSignumNET
            Dim STX As ClsSignumNET.S_Signature = SignumNET.SignHelper(Response, SignKeyHEX)
            Response = SignumAPI.BroadcastTransaction(STX.SignedTransaction)

            If Response.Contains(Application.ProductName + "-error") Then
                Return Response
            End If

        End If

        Return Response
    End Function

    Public Function AcceptBuyOrder(ByVal SenderPublicKey As String, Optional ByVal SellAmount As Double = -1.0, Optional ByVal Collateral As Double = -1.0, Optional ByVal Fee As Double = 0.0, Optional ByVal SignKeyHEX As String = "") As String

        Dim Response As String = ""

        CheckForUTX()
        CheckForTX()

        If Not C_Status = E_Status.OPEN Then
            Return Application.ProductName + "-error in AcceptOrder(1): ->" + vbCrLf + "Contract Status:" + C_Status.ToString
        End If

        If SellAmount < 0.0 Then
            SellAmount = C_CurrentBuySellAmount
        End If

        If Collateral < 0.0 Then
            Collateral = C_CurrentInitiatorsCollateral
        End If

        Dim SignumAPI As ClsSignumAPI = New ClsSignumAPI(,, C_ID)
        Dim ULngList As List(Of ULong) = New List(Of ULong)({ReferenceAcceptOrder, 0UL, 0UL, 0UL})
        Dim MsgStr As String = ClsSignumAPI.ULngList2DataStr(ULngList)
        Response = SignumAPI.SendMoney(SenderPublicKey, C_ID, SellAmount + Collateral + (ClsSignumAPI.Planck2Dbl(ClsSignumAPI._GasFeeNQT)), Fee, MsgStr.Trim, False)

        Dim JSON As ClsJSON = New ClsJSON

        Dim Error0 As Object = JSON.RecursiveListSearch(JSON.JSONRecursive(Response), "errorCode")
        If Error0.GetType.Name = GetType(Boolean).Name Then
            'TX OK
        ElseIf Error0.GetType.Name = GetType(String).Name Then
            'TX not OK
            Return Application.ProductName + "-error in AcceptOrder(2): ->" + vbCrLf + Response
        End If

        If Response.Contains(Application.ProductName + "-error") Then
            Return Response
        Else
            Dim UTXList As List(Of String) = ClsSignumAPI.ConvertUnsignedTXToList(Response)
            Response = GetStringBetweenFromList(UTXList, "<unsignedTransactionBytes>", "</unsignedTransactionBytes>")
        End If

        If Not SignKeyHEX.Trim = "" Then

            Dim SignumNET As ClsSignumNET = New ClsSignumNET
            Dim STX As ClsSignumNET.S_Signature = SignumNET.SignHelper(Response, SignKeyHEX)
            Response = SignumAPI.BroadcastTransaction(STX.SignedTransaction)

            If Response.Contains(Application.ProductName + "-error") Then
                Return Response
            End If

        End If

        Return Response

    End Function

    Public Function InjectResponder(ByVal SenderPublicKey As String, ByVal ResponderAddress As String, Optional ByVal Fee As Double = 0.0, Optional ByVal SignKeyHEX As String = "") As String
        Dim T_ResponderID As ULong = ClsReedSolomon.Decode(ResponderAddress)

        If T_ResponderID = 0L Then
            Return Application.ProductName + "-error in InjectResponder(ol1): ->" + vbCrLf + T_ResponderID.ToString
        End If

        Return InjectResponder(SenderPublicKey, T_ResponderID, Fee, SignKeyHEX)
    End Function
    Public Function InjectResponder(ByVal SenderPublicKey As String, ByVal ResponderID As ULong, Optional ByVal Fee As Double = 0.0, Optional ByVal SignKeyHEX As String = "") As String

        Dim Response As String = ""

        CheckForUTX()
        CheckForTX()

        If Not C_Status = E_Status.OPEN Then
            Return Application.ProductName + "-error in InjectResponder(1): ->" + vbCrLf + "Contract Status:" + C_Status.ToString
        End If

        Dim SignumAPI As ClsSignumAPI = New ClsSignumAPI(,, C_ID)
        Dim ULngList As List(Of ULong) = New List(Of ULong)({ReferenceInjectResponder, ResponderID})
        Dim MsgStr As String = ClsSignumAPI.ULngList2DataStr(ULngList)
        Response = SignumAPI.SendMoney(SenderPublicKey, C_ID, ClsSignumAPI.Planck2Dbl(ClsSignumAPI._GasFeeNQT), Fee, MsgStr.Trim, False)

        Dim JSON As ClsJSON = New ClsJSON

        Dim Error0 As Object = JSON.RecursiveListSearch(JSON.JSONRecursive(Response), "errorCode")
        If Error0.GetType.Name = GetType(Boolean).Name Then
            'TX OK
        ElseIf Error0.GetType.Name = GetType(String).Name Then
            'TX not OK
            Return Application.ProductName + "-error in InjectResponder(2): ->" + vbCrLf + Response
        End If

        If Response.Contains(Application.ProductName + "-error") Then
            Return Response
        Else
            Dim UTXList As List(Of String) = ClsSignumAPI.ConvertUnsignedTXToList(Response)
            Response = GetStringBetweenFromList(UTXList, "<unsignedTransactionBytes>", "</unsignedTransactionBytes>")
        End If

        If Not SignKeyHEX.Trim = "" Then

            Dim SignumNET As ClsSignumNET = New ClsSignumNET
            Dim STX As ClsSignumNET.S_Signature = SignumNET.SignHelper(Response, SignKeyHEX)
            Response = SignumAPI.BroadcastTransaction(STX.SignedTransaction)

            If Response.Contains(Application.ProductName + "-error") Then
                Return Response
            End If

        End If

        Return Response

    End Function

    Public Function OpenDispute(ByVal SenderPublicKey As String, Optional ByVal Fee As Double = 0.0, Optional ByVal SignKeyHEX As String = "") As String

        Dim Response As String = ""

        CheckForUTX()
        CheckForTX()

        If Not C_Status = E_Status.RESERVED Then
            Return Application.ProductName + "-error in OpenDispute(1): ->" + vbCrLf + "Contract Status:" + C_Status.ToString
        End If

        Dim SignumAPI As ClsSignumAPI = New ClsSignumAPI(,, C_ID)
        Dim ULngList As List(Of ULong) = New List(Of ULong)({ReferenceOpenDispute})
        Dim MsgStr As String = ClsSignumAPI.ULngList2DataStr(ULngList)
        Response = SignumAPI.SendMoney(SenderPublicKey, C_ID, ClsSignumAPI.Planck2Dbl(ClsSignumAPI._GasFeeNQT), Fee, MsgStr.Trim, False)

        Dim JSON As ClsJSON = New ClsJSON

        Dim Error0 As Object = JSON.RecursiveListSearch(JSON.JSONRecursive(Response), "errorCode")
        If Error0.GetType.Name = GetType(Boolean).Name Then
            'TX OK
        ElseIf Error0.GetType.Name = GetType(String).Name Then
            'TX not OK
            Return Application.ProductName + "-error in OpenDispute(2): ->" + vbCrLf + Response
        End If

        If Response.Contains(Application.ProductName + "-error") Then
            Return Response
        Else
            Dim UTXList As List(Of String) = ClsSignumAPI.ConvertUnsignedTXToList(Response)
            Response = GetStringBetweenFromList(UTXList, "<unsignedTransactionBytes>", "</unsignedTransactionBytes>")
        End If

        If Not SignKeyHEX.Trim = "" Then

            Dim SignumNET As ClsSignumNET = New ClsSignumNET
            Dim STX As ClsSignumNET.S_Signature = SignumNET.SignHelper(Response, SignKeyHEX)
            Response = SignumAPI.BroadcastTransaction(STX.SignedTransaction)

            If Response.Contains(Application.ProductName + "-error") Then
                Return Response
            End If

        End If

        Return Response

    End Function
    Public Function MediateDispute(ByVal SenderPublicKey As String, ByVal Amount As Double, Optional ByVal Fee As Double = 0.0, Optional ByVal SignKeyHEX As String = "") As String

        Dim Percentage As ULong = 0L

        If Amount > C_CurrentBuySellAmount Then
            Percentage = 10000L
        Else
            Percentage = Convert.ToUInt64(Math.Floor(Amount / C_CurrentBuySellAmount * 10000))
        End If

        Return MediateDispute(SenderPublicKey, Percentage, Fee, SignKeyHEX)

    End Function

    Public Function MediateDispute(ByVal SenderPublicKey As String, ByVal Percentage As Decimal, Optional ByVal Fee As Double = 0.0, Optional ByVal SignKeyHEX As String = "") As String
        Dim T_Percent As ULong = Convert.ToUInt64(Percentage * 100)
        Return MediateDispute(SenderPublicKey, T_Percent, Fee, SignKeyHEX)
    End Function

    Public Function MediateDispute(ByVal SenderPublicKey As String, ByVal Percentage As ULong, Optional ByVal Fee As Double = 0.0, Optional ByVal SignKeyHEX As String = "") As String

        Dim Response As String = ""

        CheckForUTX()
        CheckForTX()

        If Not C_Status = E_Status.DISPUTE Then
            Return Application.ProductName + "-error in MediateDispute(1): ->" + vbCrLf + "Contract Status:" + C_Status.ToString
        End If

        Dim SignumAPI As ClsSignumAPI = New ClsSignumAPI(,, C_ID)


        Dim ULngList As List(Of ULong) = New List(Of ULong)({ReferenceMediateDispute, Percentage, 0L, 0L})
        Dim MsgStr As String = ClsSignumAPI.ULngList2DataStr(ULngList)

        Dim SumCollateral As Double = CurrentInitiatorsCollateral + CurrentRespondersCollateral
        SumCollateral /= 2

        Response = SignumAPI.SendMoney(SenderPublicKey, C_ID, ClsSignumAPI.Planck2Dbl(ClsSignumAPI._GasFeeNQT) + SumCollateral + C_MediatorsDeposit, Fee, MsgStr.Trim, False)

        Dim JSON As ClsJSON = New ClsJSON

        Dim Error0 As Object = JSON.RecursiveListSearch(JSON.JSONRecursive(Response), "errorCode")
        If Error0.GetType.Name = GetType(Boolean).Name Then
            'TX OK
        ElseIf Error0.GetType.Name = GetType(String).Name Then
            'TX not OK
            Return Application.ProductName + "-error in MediateDispute(2): ->" + vbCrLf + Response
        End If

        If Response.Contains(Application.ProductName + "-error") Then
            Return Response
        Else
            Dim UTXList As List(Of String) = ClsSignumAPI.ConvertUnsignedTXToList(Response)
            Response = GetStringBetweenFromList(UTXList, "<unsignedTransactionBytes>", "</unsignedTransactionBytes>")
        End If

        If Not SignKeyHEX.Trim = "" Then

            Dim SignumNET As ClsSignumNET = New ClsSignumNET
            Dim STX As ClsSignumNET.S_Signature = SignumNET.SignHelper(Response, SignKeyHEX)
            Response = SignumAPI.BroadcastTransaction(STX.SignedTransaction)

            If Response.Contains(Application.ProductName + "-error") Then
                Return Response
            End If

        End If

        Return Response

    End Function
    Public Function Appeal(ByVal SenderPublicKey As String, Optional ByVal Fee As Double = 0.0, Optional ByVal SignKeyHEX As String = "") As String

        Dim Response As String = ""

        'CheckForUTX()
        'CheckForTX()

        'If Not C_Status = E_Status.DISPUTE Then
        '    Return Application.ProductName + "-error in Appeal(1): ->" + vbCrLf + "Contract Status:" + C_Status.ToString
        'End If

        Dim SignumAPI As ClsSignumAPI = New ClsSignumAPI(,, C_ID)
        Dim ULngList As List(Of ULong) = New List(Of ULong)({ReferenceAppeal})
        Dim MsgStr As String = ClsSignumAPI.ULngList2DataStr(ULngList)
        Response = SignumAPI.SendMoney(SenderPublicKey, C_ID, ClsSignumAPI.Planck2Dbl(ClsSignumAPI._GasFeeNQT), Fee, MsgStr.Trim, False)

        Dim JSON As ClsJSON = New ClsJSON

        Dim Error0 As Object = JSON.RecursiveListSearch(JSON.JSONRecursive(Response), "errorCode")
        If Error0.GetType.Name = GetType(Boolean).Name Then
            'TX OK
        ElseIf Error0.GetType.Name = GetType(String).Name Then
            'TX not OK
            Return Application.ProductName + "-error in Appeal(2): ->" + vbCrLf + Response
        End If

        If Response.Contains(Application.ProductName + "-error") Then
            Return Response
        Else
            Dim UTXList As List(Of String) = ClsSignumAPI.ConvertUnsignedTXToList(Response)
            Response = GetStringBetweenFromList(UTXList, "<unsignedTransactionBytes>", "</unsignedTransactionBytes>")
        End If

        If Not SignKeyHEX.Trim = "" Then

            Dim SignumNET As ClsSignumNET = New ClsSignumNET
            Dim STX As ClsSignumNET.S_Signature = SignumNET.SignHelper(Response, SignKeyHEX)
            Response = SignumAPI.BroadcastTransaction(STX.SignedTransaction)

            If Response.Contains(Application.ProductName + "-error") Then
                Return Response
            End If

        End If

        Return Response

    End Function
    Public Function CheckCloseDispute(ByVal SenderPublicKey As String, Optional ByVal Fee As Double = 0.0, Optional ByVal SignKeyHEX As String = "") As String

        Dim Response As String = ""

        CheckForUTX()
        CheckForTX()

        If Not C_Status = E_Status.DISPUTE Then
            Return Application.ProductName + "-error in CheckCloseDispute(1): ->" + vbCrLf + "Contract Status:" + C_Status.ToString
        End If

        Dim SignumAPI As ClsSignumAPI = New ClsSignumAPI(,, C_ID)
        Dim ULngList As List(Of ULong) = New List(Of ULong)({ReferenceCheckCloseDispute})
        Dim MsgStr As String = ClsSignumAPI.ULngList2DataStr(ULngList)
        Response = SignumAPI.SendMoney(SenderPublicKey, C_ID, ClsSignumAPI.Planck2Dbl(ClsSignumAPI._GasFeeNQT), Fee, MsgStr.Trim, False)

        Dim JSON As ClsJSON = New ClsJSON

        Dim Error0 As Object = JSON.RecursiveListSearch(JSON.JSONRecursive(Response), "errorCode")
        If Error0.GetType.Name = GetType(Boolean).Name Then
            'TX OK
        ElseIf Error0.GetType.Name = GetType(String).Name Then
            'TX not OK
            Return Application.ProductName + "-error in CheckCloseDispute(2): ->" + vbCrLf + Response
        End If

        If Response.Contains(Application.ProductName + "-error") Then
            Return Response
        Else
            Dim UTXList As List(Of String) = ClsSignumAPI.ConvertUnsignedTXToList(Response)
            Response = GetStringBetweenFromList(UTXList, "<unsignedTransactionBytes>", "</unsignedTransactionBytes>")
        End If

        If Not SignKeyHEX.Trim = "" Then

            Dim SignumNET As ClsSignumNET = New ClsSignumNET
            Dim STX As ClsSignumNET.S_Signature = SignumNET.SignHelper(Response, SignKeyHEX)
            Response = SignumAPI.BroadcastTransaction(STX.SignedTransaction)

            If Response.Contains(Application.ProductName + "-error") Then
                Return Response
            End If

        End If

        Return Response

    End Function

    Public Function FinishOrder(ByVal SenderPublicKey As String, Optional ByVal Fee As Double = 0.0, Optional ByVal SignKeyHEX As String = "") As String

        Dim Response As String = ""

        CheckForUTX()
        CheckForTX()

        If Not C_Status = E_Status.RESERVED And Not C_Status = E_Status.DISPUTE Then
            Return Application.ProductName + "-error in FinishOrder(1): ->" + vbCrLf + "Contract Status:" + C_Status.ToString
        End If


        Dim SignumAPI As ClsSignumAPI = New ClsSignumAPI(,, C_ID)
        Dim ULngList As List(Of ULong) = New List(Of ULong)({ReferenceFinishOrder})
        Dim MsgStr As String = ClsSignumAPI.ULngList2DataStr(ULngList)
        Response = SignumAPI.SendMoney(SenderPublicKey, C_ID, ClsSignumAPI.Planck2Dbl(ClsSignumAPI._GasFeeNQT) * 3, Fee, MsgStr.Trim, False)

        Dim JSON As ClsJSON = New ClsJSON

        Dim Error0 As Object = JSON.RecursiveListSearch(JSON.JSONRecursive(Response), "errorCode")
        If Error0.GetType.Name = GetType(Boolean).Name Then
            'TX OK
        ElseIf Error0.GetType.Name = GetType(String).Name Then
            'TX not OK
            Return Application.ProductName + "-error in FinishOrder(2): ->" + vbCrLf + Response
        End If

        If Response.Contains(Application.ProductName + "-error") Then
            Return Response
        Else
            Dim UTXList As List(Of String) = ClsSignumAPI.ConvertUnsignedTXToList(Response)
            Response = GetStringBetweenFromList(UTXList, "<unsignedTransactionBytes>", "</unsignedTransactionBytes>")
        End If

        If Not SignKeyHEX.Trim = "" Then

            Dim SignumNET As ClsSignumNET = New ClsSignumNET
            Dim STX As ClsSignumNET.S_Signature = SignumNET.SignHelper(Response, SignKeyHEX)
            Response = SignumAPI.BroadcastTransaction(STX.SignedTransaction)

            If Response.Contains(Application.ProductName + "-error") Then
                Return Response
            End If

        End If

        Return Response

    End Function




    Function ChangeULongEndians(ByVal ULongList As List(Of ULong)) As List(Of ULong)

        Dim T_ULongList As List(Of ULong) = New List(Of ULong)

        For Each TUL As ULong In ULongList
            T_ULongList.Add(ChangeULongEndian(TUL))
        Next

        Return T_ULongList

    End Function

    Function ChangeULongEndian(ByVal uLog As ULong) As ULong

        Dim T_ByteList As List(Of Byte) = BitConverter.GetBytes(uLog).ToList
        T_ByteList.Reverse()

        Dim T_UL As ULong = BitConverter.ToUInt64(T_ByteList.ToArray, 0)

        Return T_UL

    End Function



    Public Function InjectChainSwapKeyToHash(ByVal SenderPublicKey As String, ByVal ChainSwapKey As String, Optional ByVal Fee As Double = 0.0, Optional ByVal SignKeyHEX As String = "") As String
        Dim SecretKeyList As String = GetSHA256HashString(ChainSwapKey)
        Return InjectChainSwapHash(SenderPublicKey, SecretKeyList, Fee, SignKeyHEX)
    End Function

    Public Function InjectChainSwapHash(ByVal SenderPublicKey As String, ByVal ChainSwapHash As String, Optional ByVal Fee As Double = 0.0, Optional ByVal SignKeyHEX As String = "") As String

        If MessageIsHEXString(ChainSwapHash, 32) Then
            Dim HashULongList As List(Of ULong) = HEXStringToULongList(ChainSwapHash)
            HashULongList = ChangeULongEndians(HashULongList)
            Return InjectChainSwapHash(SenderPublicKey, HashULongList(3), HashULongList(2), HashULongList(1), HashULongList(0), Fee, SignKeyHEX)
        End If

        Return Application.ProductName + "-error in InjectChainSwapHash(" + SenderPublicKey + ", " + ChainSwapHash + ", " + Fee.ToString + ", " + SignKeyHEX + "): -> ChainSwapHash is no 32 len HEX"

    End Function
    Public Function InjectChainSwapHash(ByVal SenderPublicKey As String, ByVal ChainSwapHashLong1 As ULong, ByVal ChainSwapHashLong2 As ULong, ByVal ChainSwapHashLong3 As ULong, ByVal ChainSwapHashLong4 As ULong, Optional ByVal Fee As Double = 0.0, Optional ByVal SignKeyHEX As String = "") As String

        Dim Response As String = Application.ProductName + "-error in InjectChainSwapHash(#init# " + SenderPublicKey.ToString + ", " + ChainSwapHashLong1.ToString + ", " + ChainSwapHashLong2.ToString + ", " + ChainSwapHashLong3.ToString + ", " + ChainSwapHashLong4.ToString + ", " + Fee.ToString + ", " + SignKeyHEX + ")"

        CheckForUTX()
        CheckForTX()

        If Not C_Status = E_Status.RESERVED And Not C_Status = E_Status.DISPUTE Then
            Return Application.ProductName + "-error in InjectChainSwapHash(1): ->" + vbCrLf + "Contract Status:" + C_Status.ToString
        End If

        Dim SignumAPI As ClsSignumAPI = New ClsSignumAPI(,, C_ID)
        Dim ULngList As List(Of ULong) = New List(Of ULong)({ReferenceInjectChainSwapHash, ChainSwapHashLong1, ChainSwapHashLong2, ChainSwapHashLong3, ChainSwapHashLong4})
        Dim MsgStr As String = ClsSignumAPI.ULngList2DataStr(ULngList)
        Response = SignumAPI.SendMoney(SenderPublicKey, C_ID, ClsSignumAPI.Planck2Dbl(ClsSignumAPI._GasFeeNQT), Fee, MsgStr.Trim, False)

        Dim JSON As ClsJSON = New ClsJSON

        Dim Error0 As Object = JSON.RecursiveListSearch(JSON.JSONRecursive(Response), "errorCode")
        If Error0.GetType.Name = GetType(Boolean).Name Then
            'TX OK
        ElseIf Error0.GetType.Name = GetType(String).Name Then
            'TX not OK
            Return Application.ProductName + "-error in InjectChainSwapHash(2): ->" + vbCrLf + Response
        End If

        If Response.Contains(Application.ProductName + "-error") Then
            Return Response
        Else
            Dim UTXList As List(Of String) = ClsSignumAPI.ConvertUnsignedTXToList(Response)
            Response = GetStringBetweenFromList(UTXList, "<unsignedTransactionBytes>", "</unsignedTransactionBytes>")
        End If

        If Not SignKeyHEX.Trim = "" Then

            Dim SignumNET As ClsSignumNET = New ClsSignumNET
            Dim STX As ClsSignumNET.S_Signature = SignumNET.SignHelper(Response, SignKeyHEX)
            Response = SignumAPI.BroadcastTransaction(STX.SignedTransaction)

            If Response.Contains(Application.ProductName + "-error") Then
                Return Response
            End If

        End If

        Return Response

    End Function
    Public Function FinishOrderWithChainSwapKey(ByVal SenderPublicKey As String, ByVal ChainSwapKey As String, Optional ByVal Fee As Double = 0.0, Optional ByVal SignKeyHEX As String = "") As String

        Try
            Dim KeyULongList As List(Of ULong) = HEXStringToULongList(ChainSwapKey)

            While KeyULongList.Count < 4
                KeyULongList.Add(0UL)
            End While

            KeyULongList = ChangeULongEndians(KeyULongList)

            Return FinishOrderWithChainSwapKey(SenderPublicKey, KeyULongList(3), KeyULongList(2), KeyULongList(1), KeyULongList(0), Fee, SignKeyHEX)
        Catch ex As Exception

        End Try

        Return Application.ProductName + "-error in FinishOrderWithChainSwapKey(" + SenderPublicKey + ", " + ChainSwapKey + ", " + Fee.ToString + ", " + SignKeyHEX + "): -> ChainSwapKey is no 32 len HEX"

    End Function
    Public Function FinishOrderWithChainSwapKey(ByVal SenderPublicKey As String, ByVal ChainSwapKeyLong1 As ULong, ByVal ChainSwapKeyLong2 As ULong, ByVal ChainSwapKeyLong3 As ULong, ByVal ChainSwapKeyLong4 As ULong, Optional ByVal Fee As Double = 0.0, Optional ByVal SignKeyHEX As String = "") As String

        Dim Response As String = Application.ProductName + "-error in FinishOrderWithChainSwapKey(#init# " + SenderPublicKey.ToString + ", " + ChainSwapKeyLong1.ToString + ", " + ChainSwapKeyLong2.ToString + ", " + ChainSwapKeyLong3.ToString + ", " + ChainSwapKeyLong4.ToString + ", " + Fee.ToString + ", " + SignKeyHEX + ")"

        CheckForUTX()
        CheckForTX()

        If Not C_Status = E_Status.RESERVED And Not C_Status = E_Status.DISPUTE Then
            Return Application.ProductName + "-error in FinishOrderWithChainSwapKey(1): ->" + vbCrLf + "Contract Status:" + C_Status.ToString
        End If

        Dim SignumAPI As ClsSignumAPI = New ClsSignumAPI(,, C_ID)
        Dim ULngList As List(Of ULong) = New List(Of ULong)({ReferenceFinishOrderWithChainSwapKey, ChainSwapKeyLong1, ChainSwapKeyLong2, ChainSwapKeyLong3, ChainSwapKeyLong4})
        Dim MsgStr As String = ClsSignumAPI.ULngList2DataStr(ULngList)
        Response = SignumAPI.SendMoney(SenderPublicKey, C_ID, ClsSignumAPI.Planck2Dbl(ClsSignumAPI._GasFeeNQT) * 3, Fee, MsgStr.Trim, False)
        Dim JSON As ClsJSON = New ClsJSON

        Dim Error0 As Object = JSON.RecursiveListSearch(JSON.JSONRecursive(Response), "errorCode")
        If Error0.GetType.Name = GetType(Boolean).Name Then
            'TX OK
        ElseIf Error0.GetType.Name = GetType(String).Name Then
            'TX not OK
            Return Application.ProductName + "-error in FinishOrderWithChainSwapKey(2): ->" + vbCrLf + Response
        End If

        If Response.Contains(Application.ProductName + "-error") Then
            Return Response
        Else
            Dim UTXList As List(Of String) = ClsSignumAPI.ConvertUnsignedTXToList(Response)
            Response = GetStringBetweenFromList(UTXList, "<unsignedTransactionBytes>", "</unsignedTransactionBytes>")
        End If

        If Not SignKeyHEX.Trim = "" Then

            Dim SignumNET As ClsSignumNET = New ClsSignumNET
            Dim STX As ClsSignumNET.S_Signature = SignumNET.SignHelper(Response, SignKeyHEX)
            Response = SignumAPI.BroadcastTransaction(STX.SignedTransaction)

            If Response.Contains(Application.ProductName + "-error") Then
                Return Response
            End If

        End If

        Return Response

    End Function

    Public Function SendMessageToDEXContract(ByVal SenderPublicKeyHEX As String, ByVal Collateral As Double, ByVal ULongMsgList As List(Of ULong), Optional ByVal Fee As Double = 0.0, Optional ByVal SignKeyHEX As String = "") As String

        Dim Response As String = Application.ProductName + "-error in SendMessageToDEXContract(#init# " + SenderPublicKeyHEX + ", " + Collateral.ToString + ", " + ULongMsgList.ToString + ", " + Fee.ToString + ", " + SignKeyHEX + ")"

        If CheckForUTX() Or CheckForTX() Or Not C_Status = E_Status.OPEN Then
            Return Application.ProductName + "-error in SendMessageToDEXContract(1): ->" + vbCrLf + "Contract not OPEN"
        End If


        Dim SignumAPI As ClsSignumAPI = New ClsSignumAPI(,, C_ID)
        Dim MsgStr As String = ClsSignumAPI.ULngList2DataStr(ULongMsgList)
        Response = SignumAPI.SendMoney(SenderPublicKeyHEX, C_ID, Collateral + ClsSignumAPI.Planck2Dbl(ClsSignumAPI._GasFeeNQT), Fee, MsgStr.Trim, False)
        Dim JSON As ClsJSON = New ClsJSON

        Dim Error0 As Object = JSON.RecursiveListSearch(JSON.JSONRecursive(Response), "errorCode")
        If Error0.GetType.Name = GetType(Boolean).Name Then
            'TX OK
        ElseIf Error0.GetType.Name = GetType(String).Name Then
            'TX not OK
            Return Application.ProductName + "-error in SendMessageToDEXContract(2): ->" + vbCrLf + Response
        End If

        If Response.Contains(Application.ProductName + "-error") Then
            Return Response
        Else
            Dim UTXList As List(Of String) = ClsSignumAPI.ConvertUnsignedTXToList(Response)
            Response = GetStringBetweenFromList(UTXList, "<unsignedTransactionBytes>", "</unsignedTransactionBytes>")
        End If


        If Not SignKeyHEX.Trim = "" Then

            Dim SignumNET As ClsSignumNET = New ClsSignumNET
            Dim STX As ClsSignumNET.S_Signature = SignumNET.SignHelper(Response, SignKeyHEX)
            Response = SignumAPI.BroadcastTransaction(STX.SignedTransaction)

            If Response.Contains(Application.ProductName + "-error") Then
                Return Response
            End If

        End If

        Return Response

    End Function

#End Region

End Class