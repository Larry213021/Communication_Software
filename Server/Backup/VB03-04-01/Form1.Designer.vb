<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SendDataListBox = New System.Windows.Forms.ListBox
        Me.PortTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnCreate = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.ReceiveDataListBox = New System.Windows.Forms.ListBox
        Me.SendTextBox = New System.Windows.Forms.TextBox
        Me.btnSend = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(338, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "停止"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "接收資料"
        '
        'SendDataListBox
        '
        Me.SendDataListBox.FormattingEnabled = True
        Me.SendDataListBox.ItemHeight = 12
        Me.SendDataListBox.Location = New System.Drawing.Point(71, 69)
        Me.SendDataListBox.Name = "SendDataListBox"
        Me.SendDataListBox.Size = New System.Drawing.Size(261, 64)
        Me.SendDataListBox.TabIndex = 20
        '
        'PortTextBox
        '
        Me.PortTextBox.Location = New System.Drawing.Point(71, 9)
        Me.PortTextBox.Name = "PortTextBox"
        Me.PortTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PortTextBox.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "通訊埠"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(257, 7)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 17
        Me.btnCreate.Text = "建立"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "傳送資料"
        '
        'ReceiveDataListBox
        '
        Me.ReceiveDataListBox.FormattingEnabled = True
        Me.ReceiveDataListBox.ItemHeight = 12
        Me.ReceiveDataListBox.Location = New System.Drawing.Point(71, 148)
        Me.ReceiveDataListBox.Name = "ReceiveDataListBox"
        Me.ReceiveDataListBox.Size = New System.Drawing.Size(261, 112)
        Me.ReceiveDataListBox.TabIndex = 23
        '
        'SendTextBox
        '
        Me.SendTextBox.Location = New System.Drawing.Point(71, 38)
        Me.SendTextBox.Name = "SendTextBox"
        Me.SendTextBox.Size = New System.Drawing.Size(261, 22)
        Me.SendTextBox.TabIndex = 25
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(338, 38)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 26
        Me.btnSend.Text = "傳送"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "訊息"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 266)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.SendTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ReceiveDataListBox)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SendDataListBox)
        Me.Controls.Add(Me.PortTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCreate)
        Me.Name = "Form1"
        Me.Text = "VB03-04-01非同步伺服端Socket"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SendDataListBox As System.Windows.Forms.ListBox
    Friend WithEvents PortTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ReceiveDataListBox As System.Windows.Forms.ListBox
    Friend WithEvents SendTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
