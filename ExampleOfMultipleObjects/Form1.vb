Public Class Form1

    Public b As Bitmap

    Public g As Graphics

    Public WithEvents TimerAnimation As Timer

    Public BallCollection As List(Of Ball)

    Dim rand = New Random

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click

        Me.BallCollection = New List(Of Ball)
        For counter As Integer = 1 To (Me.NumericUpDown1.Value)
            Me.BallCollection.Add(New Ball)
        Next counter
        Dim i As Integer = 0
        For Each MyBall As Ball In BallCollection
            With MyBall
                .XPos = rand.Next(0, 150)
                .YPos = rand.Next(0, 150)
                .StepX = 40
                .StepY = 20
                .XGoForward = False
                .YGoForward = False
                .Colore = Color.FromArgb(255, rand.Next(255), rand.Next(255), rand.Next(255))
                .BallDiameter = rand.Next(20, 50)
            End With
            i += 1
        Next

        Me.DrawScene()

        Me.TimerAnimation = New Timer
        Me.TimerAnimation.Interval = 100  'millisec
        Me.TimerAnimation.Start()


    End Sub


    Sub DrawScene()

        '1
        b = New Bitmap(Me.PictureBoxScene.Width, Me.PictureBoxScene.Height)

        '2
        g = Graphics.FromImage(b)


        For Each MyBall As Ball In Me.BallCollection

            With MyBall

                '3
                g.FillEllipse(New SolidBrush(.Colore), .XPos, .YPos, .BallDiameter, .BallDiameter)

                .MoveAndCheckBounds(Me.PictureBoxScene.Width, Me.PictureBoxScene.Height)

            End With

        Next


        '4 
        Me.PictureBoxScene.Image = b


    End Sub


    Private Sub TimerAnimation_Tick(sender As Object, e As EventArgs) Handles TimerAnimation.Tick

        Me.DrawScene()

    End Sub



End Class
