' language pack
Partial Public Class MainForm
    Private Sub ForEnglish()
        Text = "Volume Converter"
        ToolStripMenuItem1.Text = "&Menu"
        ToolStripMenuItem2.Text = "&About"
        ToolStripMenuItem3.Text = "E&xit"
        Dim CopyText As String = "Copy"
        Button1.Text = CopyText
        Button2.Text = CopyText
        Button3.Text = CopyText
        Button4.Text = CopyText
        Button5.Text = CopyText
        Button6.Text = CopyText
        Button7.Text = "Clear"
        Label1.Text = "mm³ Cubic Millimeter"
        Label2.Text = "cm³ Cubic Centimeter"
        Label3.Text = "m³ Cubic Meter"
        Label4.Text = "ℓ Litre"
        Label5.Text = "in³ Cubic Inche"
        Label6.Text = "ft³ Cubic Feet"
        CheckBox1.Text = "中文"
    End Sub

    Private Sub ForChinese()
        Text = "体积转换器"
        ToolStripMenuItem1.Text = "菜单 &M"
        ToolStripMenuItem2.Text = "关于 &A"
        ToolStripMenuItem3.Text = "离开 &X"
        Dim CopyText As String = "复制"
        Button1.Text = CopyText
        Button2.Text = CopyText
        Button3.Text = CopyText
        Button4.Text = CopyText
        Button5.Text = CopyText
        Button6.Text = CopyText
        Button7.Text = "清除"
        Label1.Text = "mm³ 立方毫米"
        Label2.Text = "cm³ 立方厘米"
        Label3.Text = "m³ 立方米"
        Label4.Text = "ℓ 升"
        Label5.Text = "in³ 立方英寸"
        Label6.Text = "ft³ 立方英尺"
        CheckBox1.Text = "Chinese"
    End Sub
End Class

Public Class ChineseMessage
    Private Version As String = My.Application.Info.Version.ToString
    Public Message As String = "被隐藏的实验室（hiddenlabs.net）拥有此程式的版权，版本号" + Version + "，由黄建文设计。"
    Public About As String = "关于"
End Class

Public Class EnglishMessage
    Private Version As String = My.Application.Info.Version.ToString
    Public Message As String = "Hidden Laboratory (hiddenlabs.net) Copyrighted this Software, Version " + Version + ", Design by Wong Kean Boon."
    Public About As String = "About"
End Class

