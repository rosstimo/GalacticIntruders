'Miranda Breves
'RCET0265
'Spring 2022
'Galactic Invaders - Animation Code
'github url

Imports System.Timers

Public Class AnimationSetup

    Public Sub BeginAnimationConsole(Optional ByVal fps As Integer = 4)
        ' Run all the necessary code to begin animation work on the console. FPS is set and running, and animations are able
        ' to start being displayed.


        SetScreenSize()
        SetFPS(fps)

        Console.Read()  'This needs to be left at the end, or else the console will not show up

    End Sub

    Sub SetScreenSize()

        ' ============================= Setting Screen Size ==================================  '

        'Console.WindowHeight = 10
        'Console.WindowWidth = 10
        'Console.SetBufferSize(35, 35)  'To change the buffer, the window height and width must be set small

        '.SetWindowPosition(0, 0)

        'Setting the size of the window for use in terms of rows (height) and columns (width)
        Console.SetWindowSize(135, 35)
        Console.Title = "Galactic Intruders"

        'Trying this
        Console.SetWindowPosition(0, 0)
        'My.Computer.Screen

        ' ============================= Trying to Center Console ================================ '
        '           Playing with code down here

        'Declaring variables
        'Getting the windows handle (properties and control of the console window)
        Dim windowHandle As IntPtr

        'Positioning the console in the center of the screen
        windowHandle = Diagnostics.Process.GetCurrentProcess().MainWindowHandle

    End Sub

    Sub SetFPS(ByVal fps As Integer)

        'Declaring variables
        Dim timer As Timer = New Timer()

        ' Our fps is like a frequency - cycles per second. The timer will need a time to alert an event - a period.
        ' Our interval for our timer is then the reciprocal of the frequency, then set in milliseconds.
        timer.Interval = (Math.Round((1 / fps), 3) * 1000)
        AddHandler timer.Elapsed, AddressOf DrawScreenElements  'this sets a timer event to happen when the timer hits the interval

        timer.AutoReset = True  'We want to run this timer continuously and not once, so we want it to reset itself
        timer.Enabled = True    'Enabling timer so that it can call the DrawScreenElements sub after resetting

    End Sub

    Sub DrawScreenElements(ByVal source As Object, ByVal e As ElapsedEventArgs)

        'I did some research on this to see if I could make drawing to the screen smoother and less intensive. There is a 
        'concept called double buffering where the whole layout of the screen is written to a variable and then the variable
        'is written to the screen in one shot. This is better because Console.Writes are slow and intensive, so you want to
        'use it a minimum amount of times. Here is the websites I found this at:
        'https://gamedev.stackexchange.com/questions/25013/c-console-snake-game-sort-of-fps-problem
        'http://cecilsunkure.blogspot.com/2011/11/windows-console-game-writing-to-console.html

        'Variable where the screen elements are to be written to - a character array
        'Dim renderArray()() As Char
        Dim consoleString As String

        consoleString = "Console statistics" & vbNewLine &
                        $"   Buffer: {Console.BufferHeight} x {Console.BufferWidth}" & vbNewLine &
                        $"   Window: {Console.WindowHeight} x {Console.WindowWidth}" & vbNewLine &
                        $"   Window starts at {Console.WindowLeft}."

        Console.Clear()
        Console.WriteLine(consoleString)

    End Sub

End Class
