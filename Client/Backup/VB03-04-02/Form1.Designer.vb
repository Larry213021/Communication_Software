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
        Me.btnSend = New System.Windows.Forms.Button
        Me.SendTextBox = New System.Windows.Forms.TextBox
        Me.SendListBox = New System.Windows.Forms.ListBox
        Me.PortTextBox = New System.Windows.Forms.TextBox
        Me.IPAddTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCreate = New System.Windows.Forms.Button
        Me.ReceiveListBox = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(276, 32)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 27
        Me.btnClose.Text = "停止"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(276, 61)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 26
        Me.btnSend.Text = "傳送"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'SendTextBox
        '
        Me.SendTextBox.Location = New System.Drawing.Point(14, 62)
        Me.SendTextBox.Name = "SendTextBox"
        Me.SendTextBox.Size = New System.Drawing.Size(258, 22)
        Me.SendTextBox.TabIndex = 25
        '
        'SendListBox
        '
        Me.SendListBox.FormattingEnabled = True
        Me.SendListBox.ItemHeight = 12
        Me.SendListBox.Location = New System.Drawing.Point(14, 91)
        Me.SendListBox.Name = "SendListBox"
        Me.SendListBox.Size = New System.Drawing.Size(337, 88)
        Me.SendListBox.TabIndex = 24
        '
        'PortTextBox
        '
        Me.PortTextBox.Location = New System.Drawing.Point(88, 32)
        Me.PortTextBox.Name = "PortTextBox"
        Me.PortTextBox.Size = New System.Drawing.Size(61, 22)
        Me.PortTextBox.TabIndex = 23
        '
        'IPAddTextBox
        '
        Me.IPAddTextBox.Location = New System.Drawing.Point(88, 4)
        Me.IPAddTextBox.Name = "IPAddTextBox"
        Me.IPAddTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IPAddTextBox.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "伺服端通訊埠"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 12)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "伺服端IP位址"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(276, 4)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 19
        Me.btnCreate.Text = "建立"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'ReceiveListBox
        '
        Me.ReceiveListBox.FormattingEnabled = True
        Me.ReceiveListBox.ItemHeight = 12
        Me.ReceiveListBox.Location = New System.Drawing.Point(14, 185)
        Me.ReceiveListBox.Name = "ReceiveListBox"
        Me.ReceiveListBox.Size = New System.Drawing.Size(337, 100)
        Me.ReceiveListBox.TabIndex = 28
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 295)
        Me.Controls.Add(Me.ReceiveListBox)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.SendTextBox)
        Me.Controls.Add(Me.SendListBox)
        Me.Controls.Add(Me.PortTextBox)
        Me.Controls.Add(Me.IPAddTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCreate)
        Me.Name = "Form1"
        Me.Text = "VB03-04-02非同步客戶端Socket"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents SendTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SendListBox As System.Windows.Forms.ListBox
    Friend WithEvents PortTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IPAddTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents ReceiveListBox As System.Windows.Forms.ListBox

End Class
