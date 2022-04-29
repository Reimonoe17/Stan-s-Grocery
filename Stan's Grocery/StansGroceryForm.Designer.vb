<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StansGroceryForm
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
        Me.components = New System.ComponentModel.Container()
        Me.FilterByCategoryRadioButton = New System.Windows.Forms.RadioButton()
        Me.FilterByAisleRadioButton = New System.Windows.Forms.RadioButton()
        Me.SearchGroupBox = New System.Windows.Forms.GroupBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.LookUpTextBox = New System.Windows.Forms.TextBox()
        Me.FilterComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MainToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.SearchGroupBox.SuspendLayout()
        Me.ContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilterByCategoryRadioButton
        '
        Me.FilterByCategoryRadioButton.AutoSize = True
        Me.FilterByCategoryRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterByCategoryRadioButton.Location = New System.Drawing.Point(9, 55)
        Me.FilterByCategoryRadioButton.Name = "FilterByCategoryRadioButton"
        Me.FilterByCategoryRadioButton.Size = New System.Drawing.Size(106, 24)
        Me.FilterByCategoryRadioButton.TabIndex = 3
        Me.FilterByCategoryRadioButton.Text = "Category"
        Me.MainToolTip.SetToolTip(Me.FilterByCategoryRadioButton, "To select Category")
        Me.FilterByCategoryRadioButton.UseVisualStyleBackColor = True
        '
        'FilterByAisleRadioButton
        '
        Me.FilterByAisleRadioButton.AutoSize = True
        Me.FilterByAisleRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterByAisleRadioButton.Location = New System.Drawing.Point(9, 25)
        Me.FilterByAisleRadioButton.Name = "FilterByAisleRadioButton"
        Me.FilterByAisleRadioButton.Size = New System.Drawing.Size(73, 24)
        Me.FilterByAisleRadioButton.TabIndex = 2
        Me.FilterByAisleRadioButton.Text = "Aisle"
        Me.MainToolTip.SetToolTip(Me.FilterByAisleRadioButton, "To select Aisle")
        Me.FilterByAisleRadioButton.UseVisualStyleBackColor = True
        '
        'SearchGroupBox
        '
        Me.SearchGroupBox.Controls.Add(Me.DisplayLabel)
        Me.SearchGroupBox.Controls.Add(Me.FilterByAisleRadioButton)
        Me.SearchGroupBox.Controls.Add(Me.FilterByCategoryRadioButton)
        Me.SearchGroupBox.Location = New System.Drawing.Point(9, 102)
        Me.SearchGroupBox.Name = "SearchGroupBox"
        Me.SearchGroupBox.Size = New System.Drawing.Size(460, 291)
        Me.SearchGroupBox.TabIndex = 0
        Me.SearchGroupBox.TabStop = False
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Location = New System.Drawing.Point(129, 29)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(325, 175)
        Me.DisplayLabel.TabIndex = 10
        Me.DisplayLabel.Text = "Display"
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 20
        Me.DisplayListBox.Location = New System.Drawing.Point(475, 110)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(341, 284)
        Me.DisplayListBox.Sorted = True
        Me.DisplayListBox.TabIndex = 5
        Me.MainToolTip.SetToolTip(Me.DisplayListBox, "Select result for location of item")
        '
        'LookUpTextBox
        '
        Me.LookUpTextBox.Location = New System.Drawing.Point(126, 36)
        Me.LookUpTextBox.Name = "LookUpTextBox"
        Me.LookUpTextBox.Size = New System.Drawing.Size(460, 26)
        Me.LookUpTextBox.TabIndex = 0
        Me.MainToolTip.SetToolTip(Me.LookUpTextBox, "Enter name of the item you would like to seach here")
        '
        'FilterComboBox
        '
        Me.FilterComboBox.FormattingEnabled = True
        Me.FilterComboBox.Location = New System.Drawing.Point(126, 68)
        Me.FilterComboBox.Name = "FilterComboBox"
        Me.FilterComboBox.Size = New System.Drawing.Size(196, 28)
        Me.FilterComboBox.TabIndex = 4
        Me.MainToolTip.SetToolTip(Me.FilterComboBox, "Select what aisle or category to search through")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Look Up Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Category/Aisle"
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(592, 33)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(84, 36)
        Me.SearchButton.TabIndex = 1
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 32)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(166, 34)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(166, 34)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 32)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(164, 34)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.ContextMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.ContextMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(828, 36)
        Me.ContextMenuStrip.TabIndex = 0
        Me.ContextMenuStrip.Text = "MenuStrip1"
        '
        'StansGroceryForm
        '
        Me.AcceptButton = Me.SearchButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 406)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FilterComboBox)
        Me.Controls.Add(Me.LookUpTextBox)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.SearchGroupBox)
        Me.Controls.Add(Me.ContextMenuStrip)
        Me.MainMenuStrip = Me.ContextMenuStrip
        Me.Name = "StansGroceryForm"
        Me.Text = "Welcome to Stan's Grocery"
        Me.SearchGroupBox.ResumeLayout(False)
        Me.SearchGroupBox.PerformLayout()
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.ContextMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FilterByCategoryRadioButton As RadioButton
    Friend WithEvents FilterByAisleRadioButton As RadioButton
    Friend WithEvents SearchGroupBox As GroupBox
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents LookUpTextBox As TextBox
    Friend WithEvents FilterComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SearchButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents MainToolTip As ToolTip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip As MenuStrip
End Class
