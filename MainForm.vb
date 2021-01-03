Partial Public Class MainForm
    ' set english as default when form onload
    ' 表单加载时将英语设置为默认
    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ForEnglish()
    End Sub

    ' when you click the checkbox, change graphical user interface language
    ' 当您单击复选框时，更改图形用户界面语言
    Private Sub ChangeLanguage(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Call ForChinese()
        Else
            Call ForEnglish()
        End If
    End Sub

    ' this subroutine is for menu item click
    ' 此子程序是用于菜单项单击
    Private Sub ClickAndGo(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click, ToolStripMenuItem2.Click, ToolStripMenuItem1.Click
        ' pairing the incoming objects as menu items
        ' 配对传入的物件为菜单项
        Dim CurrentMenuItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

        Select Case CurrentMenuItem.Name
            Case "ToolStripMenuItem2"
                ' run routine below if menu item name is "ToolStripMenuItem2"
                ' 如果菜单项名称为“ToolStripMenuItem2”则运行以下程式
                If CheckBox1.Checked Then
                    Dim MyLanguage = New ChineseMessage
                    MessageBox.Show(MyLanguage.Message, MyLanguage.About, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Dim MyLanguage = New EnglishMessage
                    MessageBox.Show(MyLanguage.Message, MyLanguage.About, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case "ToolStripMenuItem3"
                ' end this program if menu item name is "ToolStripMenuItem3"
                ' 如果菜单项名称为“ToolStripMenuItem3”则结束本程式
                End
            Case Else
                ' do nothing
                ' 什么都不做
        End Select
    End Sub

    ' check only allow numeric button key-in for every textbox
    ' 检查每个文本框仅允许数字按钮键入
    Private Sub NumericOnly(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress, TextBox5.KeyPress, TextBox4.KeyPress, TextBox3.KeyPress, TextBox2.KeyPress, TextBox1.KeyPress
        ' pairing the incoming objects as textbox
        ' 配对传入的物件为文本框
        Dim CurrentTextBox As TextBox = CType(sender, TextBox)
        ' get string length from textbox
        ' 从文本框中获取字符串长度
        Dim CurrentTextLength As Integer = CurrentTextBox.Text.Length
        ' Get number of points from textbox
        ' 从文本框中获取点的数量
        Dim NumberOfPoint As Integer = InStr(CurrentTextBox.Text, ".")

        Select Case True
            Case Char.IsControl(e.KeyChar)
                ' if return from key press event argument is control key, it will not be handled
                ' 如果从按键事件参数传回来的是控制键，则不处理
                e.Handled = False
            Case Char.IsNumber(e.KeyChar)
                ' if return from key press event argument is numeric key, it will not be handled
                ' 如果从按键事件参数传回来的是数字键，则不处理
                e.Handled = False
            Case e.KeyChar = "."
                ' if return from key press event argument is points
                ' 如果从按键事件参数传回来的是点
                If CurrentTextLength > 0 And NumberOfPoint = 0 Then
                    ' if string length is larger than 0 and number of points is 0, it will not be handled
                    ' 如果字符串长度大于0且点数为0，则不处理
                    e.Handled = False
                Else
                    ' otherwise handled
                    ' 否则就处理掉
                    e.Handled = True
                End If
            Case Else
                ' handled otherwise
                ' 处理掉其他的
                e.Handled = True
        End Select
    End Sub

    ' click to copy string from selected textbox
    ' 单击以从选定的文本框中复制字符串
    Private Sub TextCopy(sender As Object, e As EventArgs) Handles Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click
        ' pairing the incoming objects as button
        ' 配对传入的物件为按钮
        Dim CurrentButton As Button = CType(sender, Button)

        ' copy string from corresponding textbox according button name
        ' 根据按钮名称从相应的文本框中复制字符串
        Select Case CurrentButton.Name
            Case "Button1"
                Clipboard.SetText(TextBox1.Text)
            Case "Button2"
                Clipboard.SetText(TextBox2.Text)
            Case "Button3"
                Clipboard.SetText(TextBox3.Text)
            Case "Button4"
                Clipboard.SetText(TextBox4.Text)
            Case "Button5"
                Clipboard.SetText(TextBox5.Text)
            Case "Button6"
                Clipboard.SetText(TextBox6.Text)
            Case Else
        End Select
    End Sub

    ' clear form
    ' 清除表单
    Private Sub ClearForm(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox1.Select()
    End Sub

    ' calculation subroutine
    ' 计算子程序
    Private Sub EnterAndCalculate(sender As Object, e As KeyEventArgs) Handles TextBox6.KeyDown, TextBox5.KeyDown, TextBox4.KeyDown, TextBox3.KeyDown, TextBox2.KeyDown, TextBox1.KeyDown
        ' pairing the incoming objects as textbox
        ' 配对传入的物件为文本框
        Dim CurrentTextBox As TextBox = CType(sender, TextBox)

        ' calculate the formula according which textbox where enter key pressed
        ' 根据按下回车键的文本框计算公式
        If e.KeyCode = Keys.Enter Then
            Dim num As Decimal = CDec(CurrentTextBox.Text)
            Dim answer As Decimal

            Select Case CurrentTextBox.Name
                Case "TextBox1"
                    answer = CDec(num / (10 ^ 3))
                    TextBox2.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num / (1000 ^ 3))
                    TextBox3.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num / (100 ^ 3))
                    TextBox4.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num / ((127 / 5) ^ 3))
                    TextBox5.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num / ((1524 / 5) ^ 3))
                    TextBox6.Text = Math.Round(answer, 15).ToString()
                Case "TextBox2"
                    answer = CDec(num / ((1 / 10) ^ 3))
                    TextBox1.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num / (100 ^ 3))
                    TextBox3.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num / (10 ^ 3))
                    TextBox4.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num / ((127 / 50) ^ 3))
                    TextBox5.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num / ((1524 / 50) ^ 3))
                    TextBox6.Text = Math.Round(answer, 15).ToString()
                Case "TextBox3"
                    answer = CDec(num / ((1 / 1000) ^ 3))
                    TextBox1.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num / ((1 / 100) ^ 3))
                    TextBox2.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num / ((1 / 10) ^ 3))
                    TextBox4.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num / ((127 / 5000) ^ 3))
                    TextBox5.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num / ((1524 / 5000) ^ 3))
                    TextBox6.Text = Math.Round(answer, 15).ToString()
                Case "TextBox4"
                    answer = CDec(num / ((1 / 100) ^ 3))
                    TextBox1.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num / ((1 / 10) ^ 3))
                    TextBox2.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num / (10 ^ 3))
                    TextBox3.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num / ((127 / 500) ^ 3))
                    TextBox5.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num / ((1524 / 500) ^ 3))
                    TextBox6.Text = Math.Round(answer, 15).ToString()
                Case "TextBox5"
                    answer = CDec(num / ((5 / 127) ^ 3))
                    TextBox1.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num / ((50 / 127) ^ 3))
                    TextBox2.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num / ((5000 / 127) ^ 3))
                    TextBox3.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num / ((500 / 127) ^ 3))
                    TextBox4.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num / (12 ^ 3))
                    TextBox6.Text = Math.Round(answer, 15).ToString()
                Case "TextBox6"
                    answer = CDec(num / ((5 / 1524) ^ 3))
                    TextBox1.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num / ((50 / 1524) ^ 3))
                    TextBox2.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num / ((5000 / 1524) ^ 3))
                    TextBox3.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num / ((500 / 1524) ^ 3))
                    TextBox4.Text = Math.Round(answer, 15).ToString()
                    answer = CDec(num * (12 ^ 3))
                    TextBox5.Text = Math.Round(answer, 15).ToString()
                Case Else
                    ' do nothing
                    ' 什么都不做
            End Select
        End If
    End Sub
End Class
