Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Declaración de arreglos
        Dim empleados(,) As String
        Dim departamentos() As String

        'Se define el tamaño del arreglo de departamentos
        ReDim departamentos(3)

        'Asignación de valores al arreglo de departamentos
        departamentos(0) = "Ventas"
        departamentos(1) = "Marketing"
        departamentos(2) = "Recursos Humanos"
        departamentos(3) = "Finanzas"

        'Se define el tamaño del arreglo de empleados
        ReDim empleados(10, 2)

        'Asignación de valores al arreglo de empleados
        empleados(0, 0) = "Juan Perez"
        empleados(0, 1) = "2500"
        empleados(0, 2) = "Ventas"

        empleados(1, 0) = "Maria Lopez"
        empleados(1, 1) = "3000"
        empleados(1, 2) = "Marketing"

        '... y así sucesivamente para cada empleado

        'Impresión de la información de cada empleado
        For i As Integer = 0 To UBound(empleados, 1)
            If empleados(i, 0) IsNot Nothing Then 'Verifica que la celda no esté vacía
                MsgBox("Empleado: " & empleados(i, 0))
                MsgBox("Salario: " & empleados(i, 1))
                MsgBox("Departamento: " & departamentos(Array.IndexOf(departamentos, empleados(i, 2))))

            End If
        Next
    End Sub
End Class
