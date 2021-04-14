Imports System

Module Program
    Sub Main()
        Console.WriteLine("V�po�et odmocniny.")
        Console.Write("Zadej ��slo k odmocn�n�: ")
        Try

            Dim Cislo = CInt(Console.ReadLine())

            If Cislo < 0 Then
                Console.Write("Zadali jste z�porn� ��slo, prov�st odmocninu nem� smysl." & vbCrLf)
            ElseIf Cislo = 0 Then
                Console.Write("��slo 0 odmocnit nelze." & vbCrLf)
            Else
                Dim Odmocnina = Math.Sqrt(Cislo)
                Console.Write("V�sledek odmocn�n� je {0}." & vbCrLf, Odmocnina)
            End If

        Catch e As Exception
            Console.WriteLine("Nastala chyba: {0}", e)

        End Try

        Main()

    End Sub
End Module
