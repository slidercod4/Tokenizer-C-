(keyword, using)
(identifier, System)
(separator, ;)
(keyword, using)
(identifier, System)
(operator, .)
(identifier, IO)
(separator, ;)
(keyword, namespace)
(identifier, Mukodik)
(separator, {)
(keyword, class)
(identifier, Program)
(separator, {)
(keyword, static)
(keyword, void)
(identifier, Main)
(operator, ()
(keyword, string)
(operator, [])
(identifier, args)
(operator, ))
(separator, {)
(keyword, string)
(identifier, FileName)
(separator, ;)
(keyword, do)
(separator, {)
(identifier, FileName)
(operator, =)
(identifier, setFileName)
(operator, ())
(separator, ;)
(keyword, string)
(identifier, readedText)
(operator, =)
[literal constant, ""] 
(separator, ;)
(identifier, OutputFileCreater)
(identifier, creater)
(operator, =)
(keyword, null)
(separator, ;)
(identifier, StreamReader)
(identifier, sr)
(operator, =)
(keyword, null)
(separator, ;)
(keyword, try)
(separator, {)
(identifier, FileName)
(operator, =)
(identifier, FileName)
(operator, ==)
[literal constant, ""] 
(identifier, ?)
[literal constant, "Program"] 
(identifier, :)
(identifier, FileName)
(separator, ;)
(identifier, sr)
(operator, =)
(keyword, new)
(identifier, StreamReader)
(operator, ()
(identifier, FileName)
(operator, +)
[literal constant, ".cs"] 
(operator, ))
(separator, ;)
(identifier, creater)
(operator, =)
(keyword, new)
(identifier, OutputFileCreater)
(operator, ()
(identifier, FileName)
(operator, ))
(separator, ;)
(identifier, Console)
(operator, .)
(identifier, ForegroundColor)
(operator, =)
(identifier, ConsoleColor)
(operator, .)
(identifier, Red)
(separator, ;)
(identifier, Console)
(operator, .)
(identifier, WriteLine)
(operator, ()
[literal constant, "\nMegnyitás sikeres!\n------{0}_output.cs létrehozva!--------"] 
(operator, ,)
(identifier, FileName)
(operator, ))
(separator, ;)
(identifier, Console)
(operator, .)
(identifier, ResetColor)
(operator, ())
(separator, ;)
(keyword, while)
(operator, ()
(operator, !)
(identifier, sr)
(operator, .)
(identifier, EndOfStream)
(operator, ))
(separator, {)
(identifier, readedText)
(operator, +=)
(identifier, sr)
(operator, .)
(identifier, ReadLine)
(operator, ())
(separator, ;)
(separator, })
(identifier, Lex)
(identifier, lexer)
(operator, =)
(keyword, new)
(identifier, Lex)
(operator, ()
[literal constant, "tokens.csv"] 
(operator, ))
(separator, ;)
(keyword, while)
(operator, ()
(identifier, readedText)
(operator, !=)
[literal constant, ""] 
(operator, ))
(separator, {)
(identifier, readedText)
(operator, =)
(identifier, readedText)
(operator, .)
(identifier, Trim)
(operator, ()
[literal constant, ' ']
(operator, ,)
[literal constant, '\t']
(operator, ))
(separator, ;)
(keyword, string)
(identifier, token)
(operator, =)
(identifier, lexer)
(operator, .)
(identifier, getNextElement)
(operator, ()
(keyword, ref)
(identifier, readedText)
(operator, ))
(separator, ;)
(identifier, Console)
(operator, .)
(identifier, WriteLine)
(operator, ()
(identifier, token)
(operator, ))
(separator, ;)
(identifier, creater)
(operator, .)
(identifier, addItemToString)
(operator, ()
(identifier, token)
(operator, ))
(separator, ;)
(separator, })
(separator, })
(keyword, catch)
(operator, ()
(identifier, Exception)
(operator, ))
(separator, {)
(keyword, if)
(operator, ()
(identifier, sr)
(operator, ==)
(keyword, null)
(operator, ))
(separator, {)
(identifier, Console)
(operator, .)
(identifier, ForegroundColor)
(operator, =)
(identifier, ConsoleColor)
(operator, .)
(identifier, Red)
(separator, ;)
(identifier, Console)
(operator, .)
(identifier, WriteLine)
(operator, ()
[literal constant, "\nFájl megnyitása sikertelen!"] 
(operator, ))
(separator, ;)
(identifier, Console)
(operator, .)
(identifier, ResetColor)
(operator, ())
(separator, ;)
(separator, })
(separator, })
(keyword, if)
(operator, ()
(identifier, creater)
(operator, !=)
(keyword, null)
(operator, ))
(separator, {)
(identifier, creater)
(operator, .)
(identifier, fileCloser)
(operator, ())
(separator, ;)
(separator, })
(identifier, Console)
(operator, .)
(identifier, WriteLine)
(operator, ()
[literal constant, "\n"] 
(operator, ))
(separator, ;)
(separator, })
(keyword, while)
(operator, ()
(operator, !)
(identifier, FileName)
(operator, .)
(identifier, ToLower)
(operator, ())
(operator, .)
(identifier, Equals)
(operator, ()
[literal constant, "exit"] 
(operator, ))
(operator, ))
(separator, ;)
(separator, })
(keyword, public)
(keyword, static)
(keyword, string)
(identifier, setFileName)
(operator, ())
(separator, {)
(identifier, Console)
(operator, .)
(identifier, Write)
(operator, ()
[literal constant, "Kilépéshez írja be, hogy EXIT!\nAdja meg a fájl nevét/elérési útját vagy üssön ENTER-t, hogy ezt a programot vizsgálja: "] 
(operator, ))
(separator, ;)
(keyword, string)
(identifier, fileName)
(operator, =)
(identifier, Console)
(operator, .)
(identifier, ReadLine)
(operator, ())
(separator, ;)
(keyword, return)
(identifier, fileName)
(separator, ;)
(separator, })
(separator, })
