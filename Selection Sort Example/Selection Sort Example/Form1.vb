Public Class Form1
    Dim intNbrsArray() As Integer = {14, 13, 20, 18, 17, 15, 16, 12, 11, 19}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstUnsorted.Items.Add("--------------------------")
        lstUnsorted.Items.Add("Unsorted Array")
        lstUnsorted.Items.Add("--------------------------")

        For i = 0 To intNbrsArray.Length - 1
            lstUnsorted.Items.Add(intNbrsArray(i))
        Next
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Dim intLowerBound As Integer = LBound(intNbrsArray)
        Dim intUpperBound As Integer = UBound(intNbrsArray)

        Dim i As Integer = 0
        Dim j As Integer = 0

        Dim intMinValueIndex As Integer
        Dim intSwapValueIndex As Integer
        Dim intSwapValue As Integer

        For i = intLowerBound To intUpperBound
            intMinValueIndex = i
            intSwapValue = 0
            intSwapValueIndex = 0

            For j = i + 1 To intUpperBound
                If intNbrsArray(j) < intNbrsArray(intMinValueIndex) Then
                    If intSwapValue = 0 Then
                        intSwapValue = intNbrsArray(j)
                        intSwapValueIndex = j
                    Else
                        If intNbrsArray(j) < intSwapValue Then
                            intSwapValue = intNbrsArray(j)
                            intSwapValueIndex = j
                        End If
                    End If
                End If
            Next j

            If intSwapValue <> 0 Then
                intNbrsArray(intSwapValueIndex) = intNbrsArray(intMinValueIndex)
                intNbrsArray(intMinValueIndex) = intSwapValue
            End If

            lstSorted.Items.Clear()
            Dim strCurrentPassInfo As String = "Array Pass i =  " & CStr(i)
            lstSorted.Items.Add("--------------------------")
            lstSorted.Items.Add(strCurrentPassInfo)
            lstSorted.Items.Add("--------------------------")

            For k = 0 To intNbrsArray.Length - 1
                lstSorted.Items.Add(intNbrsArray(k))
            Next k

            MessageBox.Show("Click OK to continue")
        Next i

        lstSorted.Items.Clear()
        lstSorted.Items.Add("--------------------------")
        lstSorted.Items.Add("Final Sorted Array")
        lstSorted.Items.Add("--------------------------")

        For c = 0 To intNbrsArray.Length - 1
            lstSorted.Items.Add(intNbrsArray(c))
        Next c
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
