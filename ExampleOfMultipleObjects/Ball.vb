Public Class Ball
    Public random As New Random
    Public Colore As Color

    Public BallDiameter As Integer

    Public XPos As Integer
    Public StepX As Integer
    Public XGoForward As Boolean

    Public YPos As Integer
    Public StepY As Integer
    Public YGoForward As Boolean


    Public Sub MoveAndCheckBounds(AreaWidth As Integer, AreaHeight As Integer)


        'X direction

        If Me.XGoForward Then
            Me.XPos += Me.StepX
        Else
            Me.XPos -= Me.StepX
        End If

        If Me.XPos + Me.BallDiameter > AreaWidth Then
            Me.XGoForward = False
        ElseIf Me.XPos < 0 Then
            Me.XGoForward = True
        End If


        'Y direction

        If Me.YGoForward Then
            Me.YPos += Me.StepY
        Else
            Me.YPos -= Me.StepY
        End If

        If Me.YPos + Me.BallDiameter > AreaHeight Then
            Me.YGoForward = False
        ElseIf Me.YPos < 0 Then
            Me.YGoForward = True
        End If

    End Sub



End Class
