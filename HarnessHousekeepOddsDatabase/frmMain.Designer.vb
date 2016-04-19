<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnHousekeepDatabase = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHousekeepDatabase
        '
        Me.btnHousekeepDatabase.Location = New System.Drawing.Point(84, 83)
        Me.btnHousekeepDatabase.Name = "btnHousekeepDatabase"
        Me.btnHousekeepDatabase.Size = New System.Drawing.Size(129, 64)
        Me.btnHousekeepDatabase.TabIndex = 0
        Me.btnHousekeepDatabase.Text = "Housekeep Database"
        Me.btnHousekeepDatabase.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnHousekeepDatabase)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Housekeep Odds Database"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHousekeepDatabase As Button
End Class
