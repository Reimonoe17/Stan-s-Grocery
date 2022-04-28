

Option Compare Text
Option Strict On
Option Explicit On

Public Class StansGroceryForm
    Dim food(256, 2) As String
    'Dim filter As Integer

    Sub LoadDataFile()
        Dim filename = "C:\Users\jamis\source\repos\Stan's Grocery\Grocery.txt"
        Dim record As String
        Dim row As Integer
        Dim temp() As String

        Try
            FileOpen(1, filename, OpenMode.Input)
        Catch ex As Exception
            OpenFileDialog1.ShowDialog()
            filename = OpenFileDialog1.FileName
        End Try

        Do Until EOF(1)
            'grab item name
            Input(1, record)
            temp = Split(record, "$$ITM")
            food(row, 0) = temp(1)

            'grab location
            Input(1, record)
            temp = Split(record, "##LOC")
            food(row, 1) = temp(1)

            'grab category
            Input(1, record)
            temp = Split(record, "%%CAT")
            food(row, 2) = temp(1)

            row += 1
        Loop

        FileClose(1)
    End Sub
    Sub ListBoxDisplay()

        For i = Me.food.GetLowerBound(0) To Me.food.GetUpperBound(0)
            DisplayListBox.Items.Add($"{Me.food(i, 0)} : {Me.food(i, 1)} : {Me.food(i, 2)}")
        Next

    End Sub
    Sub SelectCombo()
        Dim category As String = "Unlisted"
        Dim aisle As Integer

        FilterComboBox.Items.Clear()

        If FilterByAisleRadioButton.Checked = Enabled Then
            For i = Me.food.GetLowerBound(0) To Me.food.GetUpperBound(0)
                Try
                    aisle = CInt(food(i, 1))

                Catch ex As Exception

                End Try

                If FilterComboBox.Items.Contains(aisle.ToString.PadLeft(2)) = False Then

                    FilterComboBox.Items.Add(aisle.ToString.PadLeft(2))
                End If

                'If aisle = "" Then
                '    aisle = 1
                'End If

            Next
            'FilterComboBox.Items.Add(food())
        ElseIf FilterByCategoryRadioButton.Checked = Enabled Then
            For i = Me.food.GetLowerBound(0) To Me.food.GetUpperBound(0)
                Try
                    category = food(i, 2)
                    If FilterComboBox.Items.Contains(category) = False Then
                        FilterComboBox.Items.Add(category)
                    End If
                Catch ex As Exception
                    category = "Unlisted"
                End Try


            Next
        End If
        FilterComboBox.Sorted = True
    End Sub

    Sub LookUp()
        Dim searchText As String

        DisplayListBox.Items.Clear()

        searchText = LookUpTextBox.Text

        If searchText = "zzz" Then
            Me.Close()
        End If

        For i = 0 To 255
            If InStr(food(i, 0), searchText) <> 0 Then
                DisplayListBox.Items.Add($"{Me.food(i, 0)}")
            End If
        Next

    End Sub

    Sub Filter()
        Dim filterContent As String = FilterComboBox.Text

        DisplayListBox.Items.Clear()

        If FilterByAisleRadioButton.Checked = True Then
            For i = 0 To 255
                If filterContent.Trim = food(i, 1) Then
                    DisplayListBox.Items.Add($"{Me.food(i, 0)}")
                End If
            Next
        ElseIf FilterByCategoryRadioButton.checked = True Then
            For i = 0 To 255
                If filterContent = food(i, 2) Then
                    DisplayListBox.Items.Add($"{Me.food(i, 0)}")
                End If
            Next
        End If
    End Sub
    Sub Location()
        Dim item As String
        Dim aisle As String
        Dim category As String
        For i = 0 To 255
            If DisplayListBox.SelectedItem.ToString = food(i, 0) Then
                item = food(i, 0)
                aisle = food(i, 1)
                category = food(i, 2)
            End If
        Next

        DisplayLabel.Text = ($"{item} can be found on Aisle {aisle} in the {category} section")

    End Sub
    Private Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisplayLabel.Text = ""
        LoadDataFile()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click, SearchToolStripMenuItem.Click
        LookUp()
    End Sub

    Private Sub FilterByAisleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByAisleRadioButton.CheckedChanged, FilterByCategoryRadioButton.CheckedChanged
        SelectCombo()
    End Sub

    Private Sub FilterComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles FilterComboBox.SelectedValueChanged
        Filter()
    End Sub

    Private Sub DisplayListBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedValueChanged
        Location()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
