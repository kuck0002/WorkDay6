Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

        Dim aStr As String = txtSideOne.Text
        Dim bStr As String = txtSideTwo.Text

        Dim aDbl As Double = CDbl(aStr)
        Dim bDbl As Double = CDbl(bStr)

        Dim result As Double
        result = Hypotenuse(aDbl, bDbl)

        txtHyp.Text = CStr(result)

    End Sub

    Function Hypotenuse(ByVal x As Double, ByVal y As Double) As Double

        Dim result As Double = 0
        result = Math.Sqrt(x ^ 2 + y ^ 2)
        Return result

    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
