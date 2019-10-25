Public Class Observations
    Public Name As New List(Of String)
    Public Age As New List(Of Integer)
    Public Weight As New List(Of Integer)

    Public DataSet = New List(Of Tuple(Of String, String, Integer, String()))

    Public Function InsertSurveyData()

        'Inserting first servey
        Name.Add("Andrea")
        Age.Add(23)
        Weight.Add(70)

        Name.Add("Roberto")
        Age.Add(23)
        Weight.Add(70)

        Name.Add("Nicola")
        Age.Add(23)
        Weight.Add(85)

        Name.Add("Simone")
        Age.Add(23)
        Weight.Add(78)

        Name.Add("Valerio")
        Age.Add(23)
        Weight.Add(67)

        Name.Add("Francesco")
        Age.Add(26)
        Weight.Add(80)

        Name.Add("Jovana")
        Age.Add(23)
        Weight.Add(60)

    End Function


    Public Sub DisplayResult()
        Console.WriteLine("Name =====" + "\t" + "====Age =====" + "\t" + "=====Weight=====")
        For i As Integer = 0 To Name.Count - 1
            Console.WriteLine(String.Join("     ", Name(i).ToString(), Age(i).ToString(), Weight(i).ToString()))

        Next
        Console.ReadLine()
    End Sub

End Class
