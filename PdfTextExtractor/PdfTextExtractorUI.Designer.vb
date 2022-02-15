<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PdfTextExtractorUI
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.StartStopLabel = New System.Windows.Forms.Label()
        Me.FolderLabel = New System.Windows.Forms.Label()
        Me.FolderButton = New System.Windows.Forms.Button()
        Me.StartStopButton = New System.Windows.Forms.Button()
        Me.FolderPathBox = New System.Windows.Forms.TextBox()
        Me.LogTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 10
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.StartStopLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FolderLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FolderButton, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.StartStopButton, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FolderPathBox, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LogTextBox, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'StartStopLabel
        '
        Me.StartStopLabel.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.StartStopLabel, 4)
        Me.StartStopLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.StartStopLabel.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartStopLabel.Location = New System.Drawing.Point(154, 33)
        Me.StartStopLabel.Name = "StartStopLabel"
        Me.StartStopLabel.Size = New System.Drawing.Size(163, 33)
        Me.StartStopLabel.TabIndex = 0
        Me.StartStopLabel.Text = "Start / Stop PDF Text Extractor"
        Me.StartStopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FolderLabel
        '
        Me.FolderLabel.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.FolderLabel, 4)
        Me.FolderLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.FolderLabel.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FolderLabel.Location = New System.Drawing.Point(30, 0)
        Me.FolderLabel.Name = "FolderLabel"
        Me.FolderLabel.Size = New System.Drawing.Size(287, 33)
        Me.FolderLabel.TabIndex = 1
        Me.FolderLabel.Text = "Select a folder to watch PDF files and extract their text"
        Me.FolderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FolderButton
        '
        Me.FolderButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.FolderButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.FolderButton.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FolderButton.Location = New System.Drawing.Point(323, 3)
        Me.FolderButton.Name = "FolderButton"
        Me.FolderButton.Size = New System.Drawing.Size(40, 27)
        Me.FolderButton.TabIndex = 3
        Me.FolderButton.Text = "..."
        Me.FolderButton.UseVisualStyleBackColor = True
        '
        'StartStopButton
        '
        Me.StartStopButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StartStopButton.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartStopButton.ForeColor = System.Drawing.Color.Green
        Me.StartStopButton.Location = New System.Drawing.Point(323, 36)
        Me.StartStopButton.Name = "StartStopButton"
        Me.StartStopButton.Size = New System.Drawing.Size(74, 27)
        Me.StartStopButton.TabIndex = 4
        Me.StartStopButton.Text = "Start"
        Me.StartStopButton.UseVisualStyleBackColor = True
        '
        'FolderPathBox
        '
        Me.FolderPathBox.BackColor = System.Drawing.Color.MistyRose
        Me.TableLayoutPanel1.SetColumnSpan(Me.FolderPathBox, 4)
        Me.FolderPathBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FolderPathBox.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FolderPathBox.Location = New System.Drawing.Point(483, 3)
        Me.FolderPathBox.Multiline = True
        Me.FolderPathBox.Name = "FolderPathBox"
        Me.FolderPathBox.Size = New System.Drawing.Size(314, 27)
        Me.FolderPathBox.TabIndex = 5
        '
        'LogTextBox
        '
        Me.LogTextBox.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.SetColumnSpan(Me.LogTextBox, 10)
        Me.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogTextBox.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogTextBox.Location = New System.Drawing.Point(3, 69)
        Me.LogTextBox.Multiline = True
        Me.LogTextBox.Name = "LogTextBox"
        Me.LogTextBox.Size = New System.Drawing.Size(794, 354)
        Me.LogTextBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MistyRose
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 10)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 426)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(794, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "github.com/sezerad/PdfTextExtractor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PdfTextExtractorUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "PdfTextExtractorUI"
        Me.Text = "PDF Text Extractor"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents StartStopLabel As Label
    Friend WithEvents FolderLabel As Label
    Friend WithEvents StartStopButton As Button
    Friend WithEvents FolderButton As Button
    Friend WithEvents FolderPathBox As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents LogTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
