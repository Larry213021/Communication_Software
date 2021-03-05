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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.ReceiveDataListBox = New System.Windows.Forms.ListBox()
        Me.SendTextBox = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.IP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PortTextBox = New System.Windows.Forms.TextBox()
        Me.Name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Bisque
        Me.btnClose.Font = New System.Drawing.Font("標楷體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnClose.Location = New System.Drawing.Point(393, 50)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 29)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "中斷"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Bisque
        Me.Label2.Font = New System.Drawing.Font("標楷體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(193, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "通訊埠"
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.Bisque
        Me.btnCreate.Font = New System.Drawing.Font("標楷體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(393, 13)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(100, 29)
        Me.btnCreate.TabIndex = 17
        Me.btnCreate.Text = "連接"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'ReceiveDataListBox
        '
        Me.ReceiveDataListBox.BackColor = System.Drawing.Color.Silver
        Me.ReceiveDataListBox.FormattingEnabled = True
        Me.ReceiveDataListBox.ItemHeight = 15
        Me.ReceiveDataListBox.Location = New System.Drawing.Point(51, 86)
        Me.ReceiveDataListBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ReceiveDataListBox.Name = "ReceiveDataListBox"
        Me.ReceiveDataListBox.Size = New System.Drawing.Size(334, 184)
        Me.ReceiveDataListBox.TabIndex = 23
        '
        'SendTextBox
        '
        Me.SendTextBox.BackColor = System.Drawing.Color.Silver
        Me.SendTextBox.Location = New System.Drawing.Point(51, 281)
        Me.SendTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SendTextBox.Name = "SendTextBox"
        Me.SendTextBox.Size = New System.Drawing.Size(334, 25)
        Me.SendTextBox.TabIndex = 25
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Bisque
        Me.btnSend.Font = New System.Drawing.Font("標楷體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnSend.Location = New System.Drawing.Point(393, 281)
        Me.btnSend.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(100, 29)
        Me.btnSend.TabIndex = 26
        Me.btnSend.Text = "傳送"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'IP
        '
        Me.IP.BackColor = System.Drawing.Color.Silver
        Me.IP.Location = New System.Drawing.Point(51, 13)
        Me.IP.Margin = New System.Windows.Forms.Padding(4)
        Me.IP.Name = "IP"
        Me.IP.Size = New System.Drawing.Size(132, 25)
        Me.IP.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Bisque
        Me.Label1.Font = New System.Drawing.Font("標楷體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 15)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "IP"
        '
        'PortTextBox
        '
        Me.PortTextBox.BackColor = System.Drawing.Color.Silver
        Me.PortTextBox.Location = New System.Drawing.Point(253, 13)
        Me.PortTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PortTextBox.Name = "PortTextBox"
        Me.PortTextBox.Size = New System.Drawing.Size(132, 25)
        Me.PortTextBox.TabIndex = 31
        '
        'Name
        '
        Me.Name.BackColor = System.Drawing.Color.Silver
        Me.Name.Location = New System.Drawing.Point(51, 53)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(132, 25)
        Me.Name.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Bisque
        Me.Label3.Font = New System.Drawing.Font("標楷體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "暱稱"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(505, 332)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Name)
        Me.Controls.Add(Me.PortTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IP)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.SendTextBox)
        Me.Controls.Add(Me.ReceiveDataListBox)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCreate)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Text = "伺服端"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents ReceiveDataListBox As System.Windows.Forms.ListBox
    Friend WithEvents SendTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents IP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PortTextBox As TextBox
    Friend WithEvents Name As TextBox
    Friend WithEvents Label3 As Label
End Class
