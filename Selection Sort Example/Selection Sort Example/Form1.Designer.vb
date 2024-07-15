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
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        btnExit = New Button()
        btnSort = New Button()
        lstSorted = New ListBox()
        lstUnsorted = New ListBox()
        Label3 = New Label()
        Label2 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F)
        Label1.Location = New Point(347, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(286, 59)
        Label1.TabIndex = 0
        Label1.Text = "Selection Sort"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnExit)
        GroupBox1.Controls.Add(btnSort)
        GroupBox1.Controls.Add(lstSorted)
        GroupBox1.Controls.Add(lstUnsorted)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(66, 105)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(849, 769)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Data"
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(577, 703)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(150, 46)
        btnExit.TabIndex = 5
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnSort
        ' 
        btnSort.Location = New Point(126, 703)
        btnSort.Name = "btnSort"
        btnSort.Size = New Size(150, 46)
        btnSort.TabIndex = 4
        btnSort.Text = "Sort Data"
        btnSort.UseVisualStyleBackColor = True
        ' 
        ' lstSorted
        ' 
        lstSorted.FormattingEnabled = True
        lstSorted.Location = New Point(452, 120)
        lstSorted.Name = "lstSorted"
        lstSorted.Size = New Size(350, 548)
        lstSorted.TabIndex = 3
        ' 
        ' lstUnsorted
        ' 
        lstUnsorted.FormattingEnabled = True
        lstUnsorted.Location = New Point(51, 120)
        lstUnsorted.Name = "lstUnsorted"
        lstUnsorted.Size = New Size(350, 548)
        lstUnsorted.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(539, 52)
        Label3.Name = "Label3"
        Label3.Size = New Size(188, 45)
        Label3.TabIndex = 1
        Label3.Text = "Sorted Data"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(99, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(225, 45)
        Label2.TabIndex = 0
        Label2.Text = "Unsorted Data"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(974, 929)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstSorted As ListBox
    Friend WithEvents lstUnsorted As ListBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSort As Button

End Class
