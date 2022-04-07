Imports System.Timers

Module GalacticIntrudersGame


    Sub Main()



    End Sub

    Sub CreateTimer(ByVal fps As Integer)

        'Declaring variables
        Dim timer As Timer = New Timer()

        ' Our fps is like a frequency - cycles per second. The timer will need a period to alert an event - a period.
        ' Our interval for our timer is then our period of time.
        timer.Interval = (1 / fps)
        AddHandler timer.Elapsed, AddressOf TimerEvent  'this sets a timer event to happen when the timer hits the interval

        timer.AutoReset = True  'We want to run this timer continuously and not once, so we want it to reset itself
        timer.Enabled = True

    End Sub

    Sub TimerEvent(ByVal source As Object, ByVal e As ElapsedEventArgs)

    End Sub

End Module
