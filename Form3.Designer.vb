<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        LabelName = New Label()
        LabelAge = New Label()
        LabelPassword = New Label()
        LabelConfirmpassword = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        LabelSignup = New Label()
        SuspendLayout()
        ' 
        ' LabelName
        ' 
        LabelName.AutoSize = True
        LabelName.Location = New Point(131, 102)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(49, 20)
        LabelName.TabIndex = 0
        LabelName.Text = "Name"
        ' 
        ' LabelAge
        ' 
        LabelAge.AutoSize = True
        LabelAge.Location = New Point(131, 159)
        LabelAge.Name = "LabelAge"
        LabelAge.Size = New Size(36, 20)
        LabelAge.TabIndex = 1
        LabelAge.Text = "Age"
        ' 
        ' LabelPassword
        ' 
        LabelPassword.AutoSize = True
        LabelPassword.Location = New Point(131, 210)
        LabelPassword.Name = "LabelPassword"
        LabelPassword.Size = New Size(70, 20)
        LabelPassword.TabIndex = 2
        LabelPassword.Text = "Password"
        ' 
        ' LabelConfirmpassword
        ' 
        LabelConfirmpassword.AutoSize = True
        LabelConfirmpassword.Location = New Point(131, 260)
        LabelConfirmpassword.Name = "LabelConfirmpassword"
        LabelConfirmpassword.Size = New Size(127, 20)
        LabelConfirmpassword.TabIndex = 3
        LabelConfirmpassword.Text = "Confirm Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(355, 102)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(188, 27)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(355, 159)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(188, 27)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(355, 207)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(188, 27)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(355, 270)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(188, 27)
        TextBox4.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(243, 353)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 8
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' LabelSignup
        ' 
        LabelSignup.AutoSize = True
        LabelSignup.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        LabelSignup.Location = New Point(255, 26)
        LabelSignup.Name = "LabelSignup"
        LabelSignup.Size = New Size(186, 38)
        LabelSignup.TabIndex = 9
        LabelSignup.Text = "SIGNUP PAGE"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LabelSignup)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(LabelConfirmpassword)
        Controls.Add(LabelPassword)
        Controls.Add(LabelAge)
        Controls.Add(LabelName)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelName As Label
    Friend WithEvents LabelAge As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents LabelConfirmpassword As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelSignup As Label
End Class
