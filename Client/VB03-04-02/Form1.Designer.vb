<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.SendTextBox = New System.Windows.Forms.TextBox()
        Me.PortTextBox = New System.Windows.Forms.TextBox()
        Me.IPAddTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.ReceiveListBox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Name = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Bisque
        Me.btnClose.Font = New System.Drawing.Font("標楷體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnClose.Location = New System.Drawing.Point(431, 44)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 29)
        Me.btnClose.TabIndex = 27
        Me.btnClose.Text = "中斷"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Bisque
        Me.btnSend.Font = New System.Drawing.Font("標楷體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnSend.Location = New System.Drawing.Point(431, 264)
        Me.btnSend.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(100, 29)
        Me.btnSend.TabIndex = 26
        Me.btnSend.Text = "傳送"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'SendTextBox
        '
        Me.SendTextBox.BackColor = System.Drawing.Color.Silver
        Me.SendTextBox.Location = New System.Drawing.Point(71, 268)
        Me.SendTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SendTextBox.Name = "SendTextBox"
        Me.SendTextBox.Size = New System.Drawing.Size(343, 25)
        Me.SendTextBox.TabIndex = 25
        '
        'PortTextBox
        '
        Me.PortTextBox.BackColor = System.Drawing.Color.Silver
        Me.PortTextBox.Location = New System.Drawing.Point(296, 9)
        Me.PortTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PortTextBox.Name = "PortTextBox"
        Me.PortTextBox.Size = New System.Drawing.Size(132, 25)
        Me.PortTextBox.TabIndex = 23
        '
        'IPAddTextBox
        '
        Me.IPAddTextBox.BackColor = System.Drawing.Color.Silver
        Me.IPAddTextBox.Location = New System.Drawing.Point(71, 9)
        Me.IPAddTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IPAddTextBox.Name = "IPAddTextBox"
        Me.IPAddTextBox.Size = New System.Drawing.Size(132, 25)
        Me.IPAddTextBox.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Bisque
        Me.Label2.Font = New System.Drawing.Font("標楷體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(211, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "伺服port"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Bisque
        Me.Label1.Font = New System.Drawing.Font("標楷體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "伺服IP"
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.Bisque
        Me.btnCreate.Font = New System.Drawing.Font("標楷體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(431, 9)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(100, 29)
        Me.btnCreate.TabIndex = 19
        Me.btnCreate.Text = "連接"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'ReceiveListBox
        '
        Me.ReceiveListBox.BackColor = System.Drawing.Color.Silver
        Me.ReceiveListBox.FormattingEnabled = True
        Me.ReceiveListBox.ItemHeight = 15
        Me.ReceiveListBox.Location = New System.Drawing.Point(71, 81)
        Me.ReceiveListBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ReceiveListBox.Name = "ReceiveListBox"
        Me.ReceiveListBox.Size = New System.Drawing.Size(344, 169)
        Me.ReceiveListBox.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Bisque
        Me.Label3.Font = New System.Drawing.Font("標楷體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "暱稱"
        '
        'Name
        '
        Me.Name.BackColor = System.Drawing.Color.Silver
        Me.Name.Location = New System.Drawing.Point(71, 44)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(132, 25)
        Me.Name.TabIndex = 30
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(544, 323)
        Me.Controls.Add(Me.Name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ReceiveListBox)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.SendTextBox)
        Me.Controls.Add(Me.PortTextBox)
        Me.Controls.Add(Me.IPAddTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCreate)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Text = "客戶端"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents SendTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PortTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IPAddTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents ReceiveListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Name As TextBox
End Class
