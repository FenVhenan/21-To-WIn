Module Module1

    Sub Main()

        Do Until (Console.ReadKey.Key = ConsoleKey.Escape)
            Console.WriteLine(" Make Full Screen then Press Enter to Continue...")
            Console.ReadLine()
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Cyan 'I like how cyan looks
            'may play with other colors to see how it looks on the screen

            Console.WriteLine(" ****System Warning****")
            Console.WriteLine(" ****To prevent the game from exiting before you want to exit****")
            Console.WriteLine(" ****Only press enter when prompted****")
            Console.WriteLine(" ****And press enter after typing in your answer****")
            Console.WriteLine(" ****End System Warning****")
            Console.WriteLine(" ")
            Console.WriteLine(" ")
            Console.WriteLine(" ")
            Console.WriteLine(" ")
            'figured out that I had to put a tab before each statement
            'it got weird to look at if I didn't
            Console.WriteLine(" 21 To Win")
            Threading.Thread.Sleep(2000)
            Console.WriteLine(" A game where all you need to do is answer 21 questions to win.")
            Threading.Thread.Sleep(2000)
            Console.WriteLine(" It’s simple really.")
            Threading.Thread.Sleep(2000)
            Console.WriteLine(" If you answer exactly 21 questions you win!")
            Threading.Thread.Sleep(2000)
            Console.WriteLine(" Remember this isn’t a game of logic so don’t worry too much.")
            Threading.Thread.Sleep(2000)
            Console.WriteLine(" Just relax… it's just a game right?")
            Threading.Thread.Sleep(2000)

            Console.WriteLine(" Press the Enter key to continue...")
            Console.ReadLine()
            Console.Clear()

            Dim question, question1, question3, question5, question7, question9, question11, question13, question15, question17, question19, question21 As String
            Dim count = 0


first:  'label for the first question
            Console.WriteLine(" I have a pill, as soon as you ingest it a poison will kill you.  I have a pill in each hand.  Which hand will you choose?")
            Console.WriteLine(" [1] Left   [2] Right")
            Console.Write(" ...")
            question1 = Console.ReadLine()
            count = count + 1
            If question1 = 1 Then 'If they select right
                Console.WriteLine(" Are you sure?")
                Console.WriteLine(" [1] Yes   [2] No")
                Console.Write(" ...")
                question = Console.ReadLine()
                count = count + 1
                If question = 2 Then  'It's always for if they select no
                    GoTo first
                Else
                    Console.WriteLine(" You snatch and swallow the pill...")
                    Threading.Thread.Sleep(2000)
                    Console.WriteLine(" ...")
                    Threading.Thread.Sleep(2000)
                    Console.WriteLine(" NOTHING HAPPENED!")
                    Threading.Thread.Sleep(2000)
                End If
            Else    'else is left
                Console.WriteLine(" Are you sure?")
                Console.WriteLine(" [1] Yes   [2] No")
                Console.Write(" ...")
                question = Console.ReadLine()
                count = count + 1
                If question = 2 Then
                    GoTo first
                Else
                    Console.WriteLine(" You snatch and swallow the pill...")
                    Threading.Thread.Sleep(2000)
                    Console.WriteLine(" ...")
                    Threading.Thread.Sleep(2000)
                    Console.WriteLine(" NOTHING HAPPENED!")
                    Threading.Thread.Sleep(2000)
                End If
            End If
third:  'label for the third question
            Console.WriteLine(" Which came first the chicken or the egg?")
            Console.WriteLine(" [1] Chicken   [2] Egg")
            Console.Write(" ...")
            question3 = Console.ReadLine()
            count = count + 1
            If question3 = 1 Then 'If they select chicken
                Console.WriteLine(" Are you sure?")
                Console.WriteLine(" [1] Yes   [2] No")
                Console.Write(" ...")
                question = Console.ReadLine()
                count = count + 1
                If question = 2 Then
                    GoTo third
                Else
                    Console.WriteLine(" ***Creationism***")
                    Threading.Thread.Sleep(2000)
                End If
            Else    'else is egg
                Console.WriteLine(" Are you sure?")
                Console.WriteLine(" [1] Yes  [2] No")
                Console.Write(" ...")
                question = Console.ReadLine()
                count = count + 1
                If question = 2 Then
                    GoTo third
                Else
                    Console.WriteLine(" ***Evolution***")
                    Threading.Thread.Sleep(2000)
                End If
            End If
fifth:  'fifth question label
            Console.WriteLine(" Can you cry underwater?")
            Console.WriteLine(" [1] Yes   [2] No")
            Console.Write(" ...")
            question5 = Console.ReadLine()
            count = count + 1
            If question5 = 1 Then     'If they select yes
                Console.WriteLine(" Are you sure?")
                Console.WriteLine(" [1] Yes   [2] No")
                Console.Write(" ...")
                question = Console.ReadLine()
                count = count + 1
                If question = 2 Then
                    GoTo fifth
                Else
                    Console.WriteLine(" They could in Spongebob, right?")
                    Threading.Thread.Sleep(2000)
                End If
            Else    'If they select no
                Console.WriteLine(" Are you sure?")
                Console.WriteLine(" [1] Yes   [2] No")
                Console.Write(" ...")
                question = Console.ReadLine()
                count = count + 1
                If question = 2 Then
                    GoTo fifth
                Else
                    Console.WriteLine(" I guess not...")
                    Threading.Thread.Sleep(2000)
                End If
            End If
seventh:    'seventh question label
            Console.WriteLine(" If a doctor died while doing surgery, would the other doctors work on the doctor or the patient?")
            Console.WriteLine(" [1] Doctor   [2] Patient")
            Console.Write(" ...")
            question7 = Console.ReadLine()
            count = count + 1
            If question7 = 1 Then     'If they select doctor
                Console.WriteLine(" Are you sure?")
                Console.WriteLine(" [1] Yes   [2] No")
                Console.Write(" ...")
                question = Console.ReadLine()
                count = count + 1
                If question = 2 Then
                    GoTo seventh
                Else
                    Console.WriteLine(" Patient pays doctor doesn't...")
                    Threading.Thread.Sleep(2000)
                End If
            Else    'If they select patient
                Console.WriteLine(" Are you sure?")
                Console.WriteLine(" [1] Yes   [2] No")
                Console.Write(" ...")
                question = Console.ReadLine()
                count = count + 1
                If question = 2 Then
                    GoTo seventh
                Else
                    Console.WriteLine(" I guess that was the sensible choice...")
                    Threading.Thread.Sleep(2000)
                End If
            End If
ninth:      'ninth question label
            Console.WriteLine(" If there's a wheelchair-bound comedian, is it still called 'stand-up'?")
            Console.WriteLine(" [1] Yes   [2] No")
            Console.Write(" ...")
            question9 = Console.ReadLine()
            count = count + 1
            If question9 = 1 Then     'if questioned yes
                Console.WriteLine(" Are you sure?")
                Console.WriteLine(" [1] Yes   [2] No")
                Console.Write(" ...")
                question = Console.ReadLine()
                count = count + 1
                If question = 2 Then
                    GoTo ninth
                Else
                    Console.WriteLine(" I mean I guess...")
                    Threading.Thread.Sleep(2000)
                End If
            Else        'if questioned no
                Console.WriteLine(" Are you sure?")
                Console.WriteLine(" [1] Yes   [2] No")
                Console.Write(" ...")
                question = Console.ReadLine()
                count = count + 1
                If question = 2 Then
                    GoTo ninth
                Else
                    Console.WriteLine(" I wonder what it's called then...")
                    Threading.Thread.Sleep(2000)
                End If
            End If
eleventh:      'eleventh question label
            Console.WriteLine(" Can you slam a revolving door?")
            Console.WriteLine(" [1] Yes   [2] No")
            Console.Write(" ...")
            question11 = Console.ReadLine()
            count = count + 1
            If question11 = 1 Then    'if question is yes
                Console.WriteLine(" Are you sure?")
                Console.WriteLine(" [1] Yes   [2] No")
                Console.Write(" ...")
                question = Console.ReadLine()
                count = count + 1
                If question = 2 Then
                    GoTo eleventh
                Else
                    Console.WriteLine(" The Infinity Slam!")
                    Threading.Thread.Sleep(2000)
                End If
            Else        'if question is no
                Console.WriteLine(" Are you sure?")
                Console.WriteLine(" [1] Yes   [2] No")
                Console.Write(" ...")
                question = Console.ReadLine()
                count = count + 1
                If question = 2 Then
                    GoTo eleventh
                Else
                    Console.WriteLine(" Obviously you've never used a revolving door...")
                    Threading.Thread.Sleep(2000)
                End If
            End If
thirteenth:     'thirteenth question label
            Console.WriteLine(" Can you read a picture book?")
            Console.WriteLine(" [1] Yes   [2] No")
            Console.Write(" ...")
            question13 = Console.ReadLine()
            count = count + 1
            If question13 = 1 Then        'if the question is yes
                Console.WriteLine(" Are you sure?")
                Console.WriteLine(" [1] Yes   [2] No")
                Console.Write(" ...")
                question = Console.ReadLine()
                count = count + 1
                If question = 2 Then
                    GoTo thirteenth
                Else
                    Console.WriteLine(" A picture is worth a thousand words...")
                    Threading.Thread.Sleep(2000)
                End If
            Else        'if the question is no
                Console.WriteLine(" Are you sure?")
                Console.WriteLine(" [1] Yes   [2] No")
                Console.Write(" ...")
                question = Console.ReadLine()
                count = count + 1
                If question = 2 Then
                    GoTo thirteenth
                Else
                    Console.WriteLine(" A picture is worth a thousand words!")
                    Threading.Thread.Sleep(2000)
                End If
            End If
fifteenth:      'fifteenth question label
            Console.WriteLine(" Have you ever imagined a world with no hypothetical situations?")
            Console.WriteLine(" [1] Yes   [2] No")
            Console.Write(" ...")
            question15 = Console.ReadLine()
            count = count + 1
            If question15 = 1 Then        'if the question is yes
                Console.WriteLine(" Are you sure?")
                Console.WriteLine(" [1] Yes   [2] No")
                Console.Write(" ...")
                question = Console.ReadLine()
                count = count + 1
                If question = 2 Then
                    GoTo fifteenth
                Else
                    Console.WriteLine(" You need to look up the word hypothetical...")
                    Threading.Thread.Sleep(2000)
                End If
            Else        'if the question is no
                Console.WriteLine(" Are you sure?")
                Console.WriteLine(" [1] Yes   [2] No")
                Console.Write(" ...")
                question = Console.ReadLine()
                count = count + 1
                If question = 2 Then
                    GoTo fifteenth
                Else
                    Console.WriteLine(" You should try it sometime!")
                    Threading.Thread.Sleep(2000)
                End If
            End If
seventeenth:        'seventeenth question label
            Console.WriteLine(" If a turtle doesn't have a shell, is he homeless or naked?")
            Console.WriteLine(" [1] Homeless   [2] Naked")
            Console.Write(" ...")
            question17 = Console.ReadLine()
            count = count + 1
            If question17 = 1 Then        'if question is homeless
                Console.WriteLine(" Are you sure?")
                Console.WriteLine(" [1] Yes   [2] No")
                Console.Write(" ...")
                question = Console.ReadLine()
                count = count + 1
                If question = 2 Then
                    GoTo seventeenth
                Else
                    Console.WriteLine(" Poor homeless turtle...")
                    Threading.Thread.Sleep(2000)
                End If
            Else        'if the question is naked
                Console.WriteLine(" Are you sure?")
                Console.WriteLine(" [1] Yes   [2] No")
                Console.Write(" ...")
                question = Console.ReadLine()
                count = count + 1
                If question = 2 Then
                    GoTo seventeenth
                Else
                    Console.WriteLine(" Poor naked turtle...")
                    Threading.Thread.Sleep(2000)
                End If
            End If
nineteenth:     'nineteenth question label
            Console.WriteLine(" Can you dig half a hole?")
            Console.WriteLine(" [1] Yes   [2] No")
            Console.Write(" ...")
            question19 = Console.ReadLine()
            count = count + 1
            If question19 = 1 Then        'if question is yes
                Console.WriteLine(" Are you sure?")
                Console.WriteLine(" [1] Yes   [2] No")
                Console.Write(" ...")
                question = Console.ReadLine()
                count = count + 1
                If question = 2 Then
                    GoTo nineteenth
                Else
                    Console.WriteLine(" Duh")
                    Threading.Thread.Sleep(2000)
                End If
            Else        'if question is no
                Console.WriteLine(" Are you sure?")
                Console.WriteLine(" [1] Yes   [2] No")
                Console.Write(" ...")
                question = Console.ReadLine()
                count = count + 1
                If question = 2 Then
                    GoTo nineteenth
                Else
                    Console.WriteLine(" ...")
                    Threading.Thread.Sleep(2000)
                End If
            End If
twentyone:      'question number twenty one!
            Console.WriteLine(" This is my 21st question...do you think you've won the game?")
            Console.WriteLine(" [1] Yes   [2] No")
            Console.Write(" ...")
            question21 = Console.ReadLine()
            count = count + 1
            If question21 = 1 Then        'if question is yes
                Console.WriteLine(" Are you sure?")
                Console.WriteLine(" [1] Yes   [2] No")
                Console.Write(" ...")
                question = Console.ReadLine()
                count = count + 1
                If question = 2 Then
                    GoTo twentyone
                Else
                    Console.WriteLine(" Let's see if you've won the game!")
                    Threading.Thread.Sleep(2000)
                End If
            Else        'if question is no
                Console.WriteLine(" Are you sure?")
                Console.WriteLine(" [1] Yes   [2] No")
                Console.Write(" ...")
                question = Console.ReadLine()
                count = count + 1
                If question = 2 Then
                    GoTo twentyone
                Else
                    Console.WriteLine(" You never know...let's see if you've won or not!")
                    Threading.Thread.Sleep(2000)
                End If
            End If
            'End game stuff
            Console.WriteLine(" ...")
            Threading.Thread.Sleep(5000)
            Console.WriteLine(" The total number of questions you answered were " & count & ".")
            Threading.Thread.Sleep(2000)
            Console.WriteLine(" ...")
            Threading.Thread.Sleep(2000)
            Console.WriteLine(" I'm sorry that is more than 21 and thus you did not win the game.")
            Threading.Thread.Sleep(2000)
            Console.WriteLine(" But hey maybe you would like to try again or get a friend to try?")
            Threading.Thread.Sleep(2000)

            Console.WriteLine(" Press enter to continue...")
            Console.ReadLine()
            Console.Clear()
        Loop

    End Sub

End Module
