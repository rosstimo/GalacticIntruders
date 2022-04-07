Module GalacticIntrudersGame

    Sub Main()
        ReadKeyTest()
        'Console.Read()
    End Sub

    ''' <summary>
    ''' see https://docs.microsoft.com/en-us/dotnet/api/system.console.readkey?view=netframework-4.7.2
    ''' </summary>
    Sub ReadKeyTest()
        Dim key As String

        Do
            key = Console.ReadKey(True).KeyChar
            MsgBox(key)
        Loop While key <> "q"
    End Sub

End Module
