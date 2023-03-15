Imports System


Friend Class LaGeneral
    ' arreglos unidimensionales y bidimensionales
    Private Shared partidasJugadas As Integer(,) = New Integer(2, 0) {}
    Private Shared dados As Integer() = New Integer(4) {}
    Private Shared jugadores As Integer() = New Integer(2) {}
    Private Shared modoJuego As Integer = 0
    Public Sub Dado()
        ' hago uso de la clase random para poder escoger numeros de manera "aleatoria"
        Dim rnd As Random = New Random()

        ' aqui se inicializan y obtienen un valor dado por la clase random y el metodo next
        dados(0) = rnd.[Next](1, 6)
        dados(1) = rnd.[Next](1, 6)
        dados(2) = rnd.[Next](1, 6)
        dados(3) = rnd.[Next](1, 6)
        dados(4) = rnd.[Next](1, 6)
    End Sub

    Public Sub Modo1()
        Console.WriteLine($"// Jugador 1, teclea para tirar los dados")
        Console.ReadKey()
        Dado()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine($"// Jugador 1 tira primeron y saca <{CSharpImpl.__Assign(jugadores(0), dados(0) + dados(1) + dados(2) + dados(3) + dados(4))}>")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine($"[1]: Dado uno: {dados(0)}")
        Console.WriteLine($"[2]: Dado dos: {dados(1)}")
        Console.WriteLine($"[3]: Dado tres: {dados(2)}")
        Console.WriteLine($"[4]: Dado cuatro: {dados(3)}")
        Console.WriteLine($"[5]: Dado cinco: {dados(4)}
")

        Console.WriteLine($"// Consola esta tirando")
        Dado()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine($"// Consola tira despues y saca <{CSharpImpl.__Assign(jugadores(2), dados(0) + dados(1) + dados(2) + dados(3) + dados(4))}>")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine($"[1]: Dado uno: {dados(0)}")
        Console.WriteLine($"[2]: Dado dos: {dados(1)}")
        Console.WriteLine($"[3]: Dado tres: {dados(2)}")
        Console.WriteLine($"[4]: Dado cuatro: {dados(3)}")
        Console.WriteLine($"[5]: Dado cinco: {dados(4)}
")

        If jugadores(0) > jugadores(2) Then
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("// Jugador 1 es el ganador!")
            Console.ForegroundColor = ConsoleColor.White
            partidasJugadas(0, 0) += 1
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("// Consola es el ganador!")
            Console.ForegroundColor = ConsoleColor.White
            partidasJugadas(2, 0) += 1
        End If
        jugadores(0) = 0
        jugadores(2) = 0
    End Sub
    Public Sub Modo2()
        Console.WriteLine($"// Jugador 1, teclea para tirar los dados")
        Console.ReadKey()
        Dado()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine($"// Jugador 1 tira primeron y saca <{CSharpImpl.__Assign(jugadores(0), dados(0) + dados(1) + dados(2) + dados(3) + dados(4))}>")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine($"[1]: Dado uno: {dados(0)}")
        Console.WriteLine($"[2]: Dado dos: {dados(1)}")
        Console.WriteLine($"[3]: Dado tres: {dados(2)}")
        Console.WriteLine($"[4]: Dado cuatro: {dados(3)}")
        Console.WriteLine($"[5]: Dado cinco: {dados(4)}
")

        Console.WriteLine($"// Jugador 2, teclea para tirar los dados")
        Console.ReadKey()
        Dado()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine($"// Jugador 2 tira despues y saca <{CSharpImpl.__Assign(jugadores(1), dados(0) + dados(1) + dados(2) + dados(3) + dados(4))}>")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine($"[1]: Dado uno: {dados(0)}")
        Console.WriteLine($"[2]: Dado dos: {dados(1)}")
        Console.WriteLine($"[3]: Dado tres: {dados(2)}")
        Console.WriteLine($"[4]: Dado cuatro: {dados(3)}")
        Console.WriteLine($"[5]: Dado cinco: {dados(4)}
")

        If jugadores(0) > jugadores(1) Then
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("// Jugador 1 es el ganador!")
            Console.ForegroundColor = ConsoleColor.White
            partidasJugadas(0, 0) += 1
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("// Jugador 2 es el ganador!")
            Console.ForegroundColor = ConsoleColor.White
            partidasJugadas(1, 0) += 1
        End If
        jugadores(0) = 0
        jugadores(1) = 0
    End Sub
    Public Sub JuegoDados()
        Dim result = 0

        While modoJuego = 0
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("Juego de dados <La General>!")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("El juego de dados consiste en sacar la mayor cantidad de puntos posibles para ganar" & vbLf)
            Console.WriteLine("// Escoge tu modo de juego")
            Console.WriteLine("[1]: Consola")
            Console.WriteLine("[2]: Dos jugadores")
            Console.WriteLine("[3]: ranking de veces ganadas")
            Console.WriteLine("[4]: Salir")
            Try
                modoJuego = Convert.ToInt16(Console.ReadLine())
            Catch e As Exception
                Console.WriteLine("// Eso no es una respuesta valida!")
                Console.ReadKey()
                Console.Clear()
            End Try
        End While
        Console.Clear()
        Select Case modoJuego
            Case 1
                Modo1()
            Case 2
                Modo2()
            Case 3
                Console.WriteLine("// Partidas ganadas del jugador 1: " & partidasJugadas(0, 0))
                Console.WriteLine("// Partidas ganadas del jugador 2: " & partidasJugadas(1, 0))
                Console.WriteLine("// Partidas ganadas del jugador 3: " & partidasJugadas(2, 0))
                Console.ReadKey()
                Console.Clear()
            Case 4
                Console.Clear()
                Console.WriteLine("// Saliendo del juego")
        End Select

    End Sub

    Shared Sub Main(args As String())

        While modoJuego < 4
            Dim lgn As LaGeneral = New LaGeneral()
            If modoJuego < 4 Then
                modoJuego = 0
            End If
            lgn.JuegoDados()
            Console.ReadKey()
            Console.Clear()
        End While
    End Sub

    Private Class CSharpImpl
        <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Class
