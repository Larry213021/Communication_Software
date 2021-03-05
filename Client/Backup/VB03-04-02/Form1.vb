Imports System.Net.Sockets
Imports System.Net
Imports System.Text

Public Class Form1

    '定義客戶端Socket
    Dim SocketClient As Socket
    '定義接收資料的位元組陣列
    Dim data() As Byte
    Dim IsConnected As Boolean
    Dim Connect As AsyncCallback
    Dim ReceiveData As AsyncCallback
    Dim SendData As AsyncCallback

    Private Sub Form1_Load(ByVal sender As System.Object, _
                ByVal e As System.EventArgs) Handles MyBase.Load
        '伺服端預設的IP位址
        IPAddTextBox.Text = "127.0.0.1"
        '伺服端預設通訊埠
        PortTextBox.Text = "5001"
        IsConnected = False
        CheckState()
        '建立委派
        Connect = New AsyncCallback(AddressOf OnConnect)
        ReceiveData = New AsyncCallback(AddressOf OnReceive)
        SendData = New AsyncCallback(AddressOf OnSend)
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, _
                ByVal e As System.EventArgs) Handles btnCreate.Click
        Try
            '建立Socket物件
            SocketClient = New Socket(AddressFamily.InterNetwork, _
                                      SocketType.Stream, _
                                      ProtocolType.Tcp)
            '取得緩衝區的設定值
            Dim dataLength As Integer
            dataLength = CInt(SocketClient.GetSocketOption( _
                              SocketOptionLevel.Socket, _
                              SocketOptionName.ReceiveBuffer))
            '重新設定接收資料的陣列長度
            ReDim data(dataLength)
            '繫結IP位址與通訊埠
            Dim ep As New IPEndPoint(IPAddress.Parse(IPAddTextBox.Text), _
                                     CInt(PortTextBox.Text))

            '開始連接至Socket伺服端
            SocketClient.BeginConnect(ep, Connect, SocketClient)
            SendListBox.Items.Add("客戶端Socket建立完成!")
            IsConnected = True
            CheckState()
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
        SocketClient.Close()
        IsConnected = False
        CheckState()
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, _
                ByVal e As System.EventArgs) Handles btnSend.Click
        Dim byteSend() As Byte = Encoding.Default.GetBytes(SendTextBox.Text)
        '開始傳送資料
        SocketClient.BeginSend(byteSend, 0, byteSend.Length, _
                               SocketFlags.None, SendData, SocketClient)
        SendListBox.Items.Add(SendTextBox.Text)
    End Sub

    Private Sub CheckState()
        PortTextBox.Enabled = Not IsConnected
        btnCreate.Enabled = Not IsConnected
        btnClose.Enabled = IsConnected
        btnSend.Enabled = IsConnected
        SendTextBox.Enabled = IsConnected
        Me.Update()
    End Sub

    Public Sub OnConnect(ByVal ar As IAsyncResult)
        Try
            '結束連接至Socket伺服端
            SocketClient.EndConnect(ar)
            '將接收資料的程序指派給UpdateReceiveMessage
            Me.Invoke(New delSendMessage( _
                      AddressOf Me.UpdateSendMessage), "已連入伺服器")
            '開始接收資料
            SocketClient.BeginReceive(data, 0, data.Length, _
                         SocketFlags.None, ReceiveData, SocketClient)
        Catch sk As SocketException
            MessageBox.Show("SocketException ErrodCode:" & _
                       sk.ErrorCode.ToString & vbCrLf & _
                       "SocketException Message:" & sk.Message, _
                       "SocketException", _
                       MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub OnReceive(ByVal ar As IAsyncResult)
        If Not IsConnected Then
            Exit Sub
        End If
        Dim SocketServer As Socket = CType(ar.AsyncState, Socket)
        Try
            Dim recvLength As Integer
            '完成接收資料
            recvLength = SocketServer.EndReceive(ar)
            If recvLength = 0 Then
                '伺服端中斷連線,關閉所有Socket通訊
                SocketClient.Close()
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
                        SocketFlags.None, ReceiveData, SocketClient)
            End If
        Catch sk As SocketException
            If sk.ErrorCode = 10054 Then
                '伺服端中斷連線,關閉所有Socket通訊
                Me.Invoke(New delReceiveMessage( _
                          AddressOf Me.UpdateReceiveMessage), "伺服端中斷連接")
                IsConnected = False
                Me.Invoke(New delUpdateUI(AddressOf Me.UpdateUI))
            Else
                MessageBox.Show("SocketException ErrodCode:" & _
                                sk.ErrorCode.ToString & vbCrLf & _
                                "SocketException Message:" & sk.Message, _
                                "SocketException", _
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch dx As ObjectDisposedException
            '中斷連線會觸發本事件, 略過不處理
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
    Public Delegate Sub delSendMessage(ByVal SendStr As String)
    Public Delegate Sub delUpdateUI()

    Public Sub UpdateReceiveMessage(ByVal RecvStr As String)
        ReceiveListBox.Items.Add(RecvStr)
    End Sub

    Public Sub UpdateSendMessage(ByVal SendStr As String)
        SendListBox.Items.Add(SendStr)
    End Sub

    Public Sub UpdateUI()
        CheckState()
    End Sub
End Class
