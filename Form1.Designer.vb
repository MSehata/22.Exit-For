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
        btnAddItems = New Button()
        btnClose = New Button()
        lBoxItems = New ListBox()
        SuspendLayout()
        ' 
        ' btnAddItems
        ' 
        btnAddItems.Location = New Point(332, 328)
        btnAddItems.Name = "btnAddItems"
        btnAddItems.Size = New Size(94, 29)
        btnAddItems.TabIndex = 0
        btnAddItems.Text = "Add Items"
        btnAddItems.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(332, 389)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 0
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' lBoxItems
        ' 
        lBoxItems.FormattingEnabled = True
        lBoxItems.ItemHeight = 20
        lBoxItems.Location = New Point(257, 71)
        lBoxItems.Name = "lBoxItems"
        lBoxItems.Size = New Size(254, 204)
        lBoxItems.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lBoxItems)
        Controls.Add(btnClose)
        Controls.Add(btnAddItems)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnAddItems As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lBoxItems As ListBox
End Class
