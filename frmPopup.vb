REM MessagePop
' By Nitemice
' Date:8-5-2013
' Updated: 19-9-2013
' Version: 1.2.5
' Pops up a window containing whatever message you pass to it via command line

'This software is licensed under The MIT License (MIT)
'	Copyright (c) 2013 Nitemice

'	Permission is hereby granted, free of charge, to any person obtaining a copy of this software
'	 and associated documentation files (the "Software"), to deal in the Software without restriction,
'	 including without limitation the rights to use, copy, modify, merge, publish, distribute, 
'	 sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is 
'	 furnished to do so, subject to the following conditions:

'	The above copyright notice and this permission notice shall be included in all copies
'	or substantial portions of the Software.

'	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
'	INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE
'	AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, 
'	DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
'	OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

Public Class frmPopup
    Dim argsToBreak(), pieceOfArgs As String
    Dim messageTxt As String = ""
    Dim titleTxt As String = ""
    Dim buttonTxt As String = ""
    Dim argType As Integer = 1 'used to tell what the purpose of the string we're collecting from the arguments is
    ' 1 =message, 2=title, 3=button
    Private Sub frmPopup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'get the arguments that were passed
        argsToBreak = System.Environment.GetCommandLineArgs

        ''just for testing - to see how this works
        'For i As Integer = 0 To ArgsToBreak.Length - 1
        '    MessageBox.Show(ArgsToBreak(i))
        'Next

        'Ignore the first argument - it's always rubbish
        For i As Integer = 1 To argsToBreak.Length - 1

            'move the next piece into place
            pieceOfArgs = argsToBreak(i)

            'if it's a hash, move to the next type
            While pieceOfArgs = "#"
                argType += 1
                i += 1
                pieceOfArgs = argsToBreak(i)
            End While

            'go through the arguments and put them where they belong
            Select Case argType
                Case 1 'adding to messageTxt
                    messageTxt = messageTxt & pieceOfArgs & " "
                Case 2 'adding to titleTxt
                    titleTxt = titleTxt & pieceOfArgs & " "
                Case 3 'adding to buttonTxt
                    buttonTxt = buttonTxt & pieceOfArgs & " "
            End Select

        Next


        'use the collected strings, if something was collected
        If messageTxt.Length > 0 Then
            lblMessage.Text = messageTxt
        End If
        If titleTxt.Length > 0 Then
            Me.Text = titleTxt
        End If
        If buttonTxt.Length > 0 Then
            btnQuit.Text = buttonTxt
        End If
    End Sub

    Private Sub btnQuit_Click(sender As System.Object, e As System.EventArgs) Handles btnQuit.Click
        'quit the program
        End
    End Sub
End Class
