<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPopup))
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(0, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Padding = New System.Windows.Forms.Padding(5)
        Me.lblMessage.Size = New System.Drawing.Size(323, 159)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "MessagePop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "==============" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "By Nitemice Software" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "_______________________" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "V1.2  " & _
    "- 2013" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnQuit
        '
        Me.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnQuit.Location = New System.Drawing.Point(0, 146)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(323, 34)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Okay!"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmPopup
        '
        Me.AcceptButton = Me.btnQuit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnQuit
        Me.ClientSize = New System.Drawing.Size(323, 180)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblMessage)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPopup"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MessagePop"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnQuit As System.Windows.Forms.Button

End Class
