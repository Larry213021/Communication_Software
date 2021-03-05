Imports System.Net.Sockets
Imports System.Net
Imports System.Text

Public Class Form1

    '定義伺服端Socket
    Dim SocketServer As Socket
    '定義客戶端Socket
    Dim SocketClient As Socket
    '定義接收資料的位元組陣列
    Dim data() As Byte
    Dim IsConnected As Boolean
    Dim Accept As AsyncCallback
    Dim ReceiveData As AsyncCallback
    Dim SendData As AsyncCallback

    Private Sub Form1_Load(ByVal sender As System.Object, _
                ByVal e As System.EventArgs) Handles MyBase.Load
        '伺服端預設通訊埠
        PortTextBox.Text = "5001"
        IsConnected = False
        '建立委派
        Accept = New AsyncCallback(AddressOf OnAccept)
        ReceiveData = New AsyncCallback(AddressOf OnReceive)
        SendData = New AsyncCallback(AddressOf OnSend)
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, _
                ByVal e As System.EventArgs) Handles btnCreate.Click
        Try
            '建立Socket物件
            SocketServer = New Socket(AddressFamily.InterNetwork, _
                                      SocketType.Stream, _
                                      ProtocolType.Tcp)
            '繫結IP位址與通訊埠
            Dim ep As New IPEndPoint(IPAddress.Parse("127.0.0.1"), _
                                     CInt(PortTextBox.Text))
            SocketServer.Bind(ep)
            '開啟伺服器Socket物件接聽功能
            SocketServer.Listen(10)
            IsConnected = True
            CheckState()
            SendDataListBox.Items.Add("伺服端Socket建立完成!")
            SendDataListBox.Update()
            '開始準備接收客戶端Socket連接
            SocketServer.BeginAccept(Accept, SocketServer)
        Catch sk As SocketException
            MessageBox.Show("SocketException ErrodCode:" & _
                       sk.ErrorCode.ToString & vbCrLf & _
                       "SocketException Message:" & sk.Message, _
                       "SocketException", _
                       MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, _
                ByVal e As System.EventArgs) Handles btnClose.Click
        '關閉Socket通訊
        IsConnected = False
        CheckState()
        If Not SocketClient Is Nothing Then
            SocketClient.Close()
        End If
        SocketServer.Close()
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, _
                ByVal e As System.EventArgs) Handles btnSend.Click
        If SocketClient Is Nothing Then
            Exit Sub
        End If
        Dim byteSend() As Byte = Encoding.Default.GetBytes(SendTextBox.Text)
        '開始傳送資料
        SocketClient.BeginSend(byteSend, 0, byteSend.Length, _
                               SocketFlags.None, _
                               SendData, SocketClient)
        SendDataListBox.Items.Add(SendTextBox.Text)
    End Sub

    Private Sub CheckState()
        PortTextBox.Enabled = Not IsConnected
        btnCreate.Enabled = Not IsConnected
        btnClose.Enabled = IsConnected
        btnSend.Enabled = IsConnected
        SendTextBox.Enabled = IsConnected
        Me.Update()
    End Sub

    Public Sub OnAccept(ByVal ar As IAsyncResult)
        If Not IsConnected Then
            Exit Sub
        End If
        Dim AcceptClient As Socket = CType(ar.AsyncState, Socket)
        '取得緩衝區的設定值
        Dim dataLength As Integer
        dataLength = CInt(AcceptClient.GetSocketOption( _
                          SocketOptionLevel.Socket, _
                          SocketOptionName.ReceiveBuffer))
        '重新設定接收資料的陣列長度
        ReDim data(dataLength)
        '接受客戶端連入
        SocketClient = AcceptClient.EndAccept(ar)
        Dim ClientIP As IPAddress = CType(SocketClient.RemoteEndPoint,  _
                                       IPEndPoint).Address
        '將接收資料的程序指派給UpdateReceiveMessage
        Me.Invoke(New delReceiveMessage( _
                  AddressOf Me.UpdateReceiveMessage), _
                  "來自IP位址:" & ClientIP.ToString)
        Me.Invoke(New delReceiveMessage( _
                  AddressOf Me.UpdateReceiveMessage), "來自通訊埠:" & CType( _
                   SocketClient.RemoteEndPoint, IPEndPoint).Port.ToString())
        '開始接受客戶端Socket傳送資料
        SocketClient.BeginReceive(data, 0, data.Length, _
                                  SocketFlags.None, _
                                  ReceiveData, SocketClient)
    End Sub

    Public Sub OnReceive(ByVal ar As IAsyncResult)
        '接收資料
        If Not IsConnected Then
            Exit Sub
        End If
        Dim AcceptClient As Socket = CType(ar.AsyncState, Socket)
        Try
            Dim recvLength As Integer
            '完成接收資料
            recvLength = AcceptClient.EndReceive(ar)
            If recvLength = 0 Then
                '客戶端中斷連線,關閉所有Socket通訊
                SocketClient.Close()
                AcceptClient.Close()
                SocketServer.Close()
                IsConnected = False
                Me.Invoke(New delUpdateUI(AddressOf Me.UpdateUI))
            Else
                Dim RecvStr As String = Encoding.Default.GetString( _
                        data, 0, recvLength)
                '將接收資料的程序指派給UpdateReceiveMessage
                Me.Invoke(New delReceiveMessage( _
                          AddressOf Me.UpdateReceiveMessage), RecvStr)
                '繼續開始接收資料
                SocketClient.BeginReceive(data, 0, data.Length, _
                                          SocketFlags.None, _
                                          ReceiveData, AcceptClient)
            End If
        Catch sk As SocketException
            If sk.ErrorCode = 10054 Then
                Me.Invoke(New delReceiveMessage( _
                          AddressOf Me.UpdateReceiveMessage), "客戶端中斷連接")
                '客戶端中斷連線,關閉所有Socket通訊
                SocketClient.Close()
                AcceptClient.Close()
                SocketServer.Close()
                IsConnected = False
                Me.Invoke(New delUpdateUI(AddressOf Me.UpdateUI))
            Else
                MessageBox.Show("SocketException ErrodCode:" & _
                                sk.ErrorCode.ToString & vbCrLf & _
                                "SocketException Message:" & sk.Message, _
                                "SocketException", _
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "錯誤", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub OnSend(ByVal ar As IAsyncResult)
        If Not IsConnected Then
            Exit Sub
        End If
        If SocketClient Is Nothing Then
            Exit Sub
        End If
        '結束傳送資料
        SocketClient.EndSend(ar)
    End Sub

    '指派程序
    Public Delegate Sub delReceiveMessage(ByVal RecvStr As String)
    Public Delegate Sub delUpdateUI()

    Public Sub UpdateReceiveMessage(ByVal RecvStr As String)
        ReceiveDataListBox.Items.Add(RecvStr)
    End Sub

    Public Sub UpdateUI()
        CheckState()
    End Sub
End Class
