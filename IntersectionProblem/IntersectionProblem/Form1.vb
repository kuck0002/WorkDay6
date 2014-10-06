Option Strict On

Public Class Form1

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim Ast, Bst, Cst, Dst As String
        Dim A, B, C, D As Double

        ' Read the input from the user
        Ast = txtA.Text
        Bst = txtB.Text
        Cst = txtC.Text
        Dst = txtD.Text

        ' All input must be numbers
        If Not (IsNumeric(Ast) And IsNumeric(Bst) And IsNumeric(Cst) _
                And IsNumeric(Dst)) Then
            MessageBox.Show("Please enter valid numbers", "Error!")
            Return
        End If

        ' Convert to double
        A = CDbl(Ast)
        B = CDbl(Bst)
        C = CDbl(Cst)
        D = CDbl(Dst)

        If (A > B Or C > D) Then
            MessageBox.Show("Please enter valid numbers", "Error!")
        End If
        ' Please write your code here...

        txtResult.Text = FindIntersection(A, B, C, D)

    End Sub

    Function FindIntersection(ByVal A As Double,
                              ByVal B As Double,
                              ByVal C As Double,
                              ByVal D As Double) As String
        Dim result As String
        If (C > B) Or (A > D) Then
            result = "They don't intersect"
        Else
            Dim begPoint As Double = Math.Max(A, C)
            Dim endPoint As Double = Math.Min(B, D)
            result = "They do intersect from " & begPoint & " to " & endPoint
        End If
        Return result

    End Function

End Class
