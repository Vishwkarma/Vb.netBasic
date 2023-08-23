<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LabelUsername = New Label()
        LabelPassword = New Label()
        TextUser = New TextBox()
        TextPassword = New TextBox()
        ButtonLogin = New Button()
        ButtonSignup = New Button()
        SuspendLayout()
        ' 
        ' LabelUsername
        ' 
        LabelUsername.AutoSize = True
        LabelUsername.Location = New Point(139, 83)
        LabelUsername.Name = "LabelUsername"
        LabelUsername.Size = New Size(75, 20)
        LabelUsername.TabIndex = 0
        LabelUsername.Text = "Username"
        ' 
        ' LabelPassword
        ' 
        LabelPassword.AutoSize = True
        LabelPassword.Location = New Point(139, 164)
        LabelPassword.Name = "LabelPassword"
        LabelPassword.Size = New Size(70, 20)
        LabelPassword.TabIndex = 1
        LabelPassword.Text = "Password"
        ' 
        ' TextUser
        ' 
        TextUser.Location = New Point(403, 68)
        TextUser.Name = "TextUser"
        TextUser.Size = New Size(125, 27)
        TextUser.TabIndex = 2
        ' 
        ' TextPassword
        ' 
        TextPassword.Location = New Point(403, 157)
        TextPassword.Name = "TextPassword"
        TextPassword.Size = New Size(125, 27)
        TextPassword.TabIndex = 3
        ' 
        ' ButtonLogin
        ' 
        ButtonLogin.Location = New Point(116, 305)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(94, 29)
        ButtonLogin.TabIndex = 4
        ButtonLogin.Text = "Login"
        ButtonLogin.UseVisualStyleBackColor = True
        ' 
        ' ButtonSignup
        ' 
        ButtonSignup.Location = New Point(455, 305)
        ButtonSignup.Name = "ButtonSignup"
        ButtonSignup.Size = New Size(94, 29)
        ButtonSignup.TabIndex = 5
        ButtonSignup.Text = "SignUp"
        ButtonSignup.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonSignup)
        Controls.Add(ButtonLogin)
        Controls.Add(TextPassword)
        Controls.Add(TextUser)
        Controls.Add(LabelPassword)
        Controls.Add(LabelUsername)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TextUser As TextBox
    Friend WithEvents TextPassword As TextBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents ButtonSignup As Button
End Class
