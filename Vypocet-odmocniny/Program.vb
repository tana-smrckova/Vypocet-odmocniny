Imports System

Module Program
    Sub Main()
        Console.WriteLine("Výpoèet odmocniny.")
        Console.Write("Zadej èíslo k odmocnìní: ")
        Try

            Dim Cislo = CInt(Console.ReadLine())

            If Cislo < 0 Then
                Console.Write("Zadali jste záporné èíslo, provést odmocninu nemá smysl." & vbCrLf)
            ElseIf Cislo = 0 Then
                Console.Write("Èíslo 0 odmocnit nelze." & vbCrLf)
            Else
                Dim Odmocnina = Math.Sqrt(Cislo)
                Console.Write("Výsledek odmocnìní je {0}." & vbCrLf, Odmocnina)
            End If

        Catch e As Exception
            Console.WriteLine("Nastala chyba: {0}", e)

        End Try

        Main()

    End Sub
End Module
