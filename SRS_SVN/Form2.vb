Public Class Form1
    Public flag As Integer
    Public tb5 As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        flag = 0
        If TextBox1.Text = "" Then
            flag = 1
            Label1.ForeColor = Color.Red
            TextBox1.BackColor = Color.LightYellow
        End If
        If TextBox2.Text <> "" Then
            If IsNumeric(TextBox2.Text) = 0 Then
                flag = 1
                TextBox2.BackColor = Color.LightYellow
                Label10.Text = "некорректный ввод"
            Else
                If CInt(TextBox2.Text) < 0 Then
                    flag = 1
                    TextBox2.BackColor = Color.LightYellow
                End If
            End If
        Else
            TextBox2.Text = "0"
        End If

        If TextBox3.Text <> "" Then
            If IsNumeric(TextBox3.Text) = 0 Then
                flag = 1
                TextBox3.BackColor = Color.LightYellow
                Label10.Text = "некорректный ввод"
            Else
                If CInt(TextBox3.Text) < 0 Then
                    flag = 1
                    TextBox3.BackColor = Color.LightYellow
                    Label10.Text = "некорректный ввод"
                End If
            End If
        Else
            flag = 1
            TextBox3.Text = "заполните поле"
            TextBox3.ForeColor = Color.Red
        End If

        If TextBox4.Text <> "" Then
            If IsNumeric(TextBox4.Text) = 0 Then
                flag = 1
                TextBox4.BackColor = Color.LightYellow
                Label10.Text = "некорректный ввод"
            Else
                If CInt(TextBox4.Text) < 0 Then
                    flag = 1
                    TextBox4.BackColor = Color.LightYellow
                    Label10.Text = "некорректный ввод"
                End If
            End If
        Else
            flag = 1
            TextBox4.Text = "заполните поле"
            TextBox4.ForeColor = Color.Red
        End If

        If TextBox5.Text <> "" Then
            If IsNumeric(TextBox5.Text) = 0 Then
                flag = 1
                TextBox5.BackColor = Color.LightYellow
                Label10.Text = "некорректный ввод"
            Else
                If CInt(TextBox5.Text) < 0 Then
                    flag = 1
                    TextBox5.BackColor = Color.LightYellow
                End If
            End If
        Else
            flag = 1
            TextBox5.Text = "заполните поле"
            TextBox5.ForeColor = Color.Red
        End If

        If TextBox6.Text <> "" Then
            If IsNumeric(TextBox6.Text) = 0 Then
                flag = 1
                TextBox6.BackColor = Color.LightYellow
                Label10.Text = "некорректный ввод"
            Else
                If CInt(TextBox6.Text) < 0 Then
                    flag = 1
                    TextBox6.BackColor = Color.LightYellow
                End If
            End If
        Else
            TextBox6.Text = "0"
        End If

        If TextBox7.Text <> "" Then
            If IsNumeric(TextBox7.Text) = 0 Then
                flag = 1
                TextBox7.BackColor = Color.LightYellow
                Label10.Text = "некорректный ввод"
            Else
                If CInt(TextBox7.Text) < 0 Then
                    flag = 1
                    TextBox7.BackColor = Color.LightYellow
                    Label10.Text = "некорректный ввод"
                End If
            End If
        Else
            TextBox7.Text = "0"
        End If

        If TextBox8.Text <> "" Then
            If IsNumeric(TextBox8.Text) = 0 Then
                flag = 1
                TextBox8.BackColor = Color.LightYellow
                Label10.Text = "некорректный ввод"
            Else
                If CInt(TextBox8.Text) < 0 Then
                    flag = 1
                    TextBox8.BackColor = Color.LightYellow
                End If
            End If
        Else
            TextBox8.Text = "0"
        End If
        If CheckBox1.Checked = False And CheckBox2.Checked = False Then
            flag = 1
            Label24.Text = "Выберите метод платежа"
        End If


        If DateTimePicker2.Value < DateTimePicker1.Value Then
            flag = 1
            MsgBox("Дата фактической уплаты" & vbCrLf& & "не может быть раньше начала выплат", vbExclamation)
        End If

        If flag = 0 Then
            TextBox1.BackColor = Color.White
            TextBox1.ForeColor = Color.Black
            TextBox2.BackColor = Color.White
            TextBox2.ForeColor = Color.Black
            TextBox3.BackColor = Color.White
            TextBox3.ForeColor = Color.Black
            TextBox4.BackColor = Color.White
            TextBox4.ForeColor = Color.Black
            TextBox5.BackColor = Color.White
            TextBox5.ForeColor = Color.Black
            TextBox6.BackColor = Color.White
            TextBox6.ForeColor = Color.Black
            TextBox7.BackColor = Color.White
            TextBox7.ForeColor = Color.Black
            TextBox8.BackColor = Color.White
            TextBox8.ForeColor = Color.Black
            Label10.Text = ""
            Label24.Text = ""

            'расчет
            Dim Sek As Double 'общая сумма ежемесячных комиссий за весь период
            Dim Ek As Double 'ежемесячная комиссия
            Dim K As Double 'сумма ипотеки
            Dim N As Integer 'период погашения по договору в месяцах
            Dim P As Double 'процентная ставка
            Dim Sp As Double 'сумма процентов (переплата)
            Dim Spk As Double 'итоговая переплата с учетом комиссий
            Dim SS As Double 'полная итоговая сумма выплат
            Dim S As Double 'общая сумма выплат при использовнном методе
            Dim Sa As Double 'сумма ежемесячного платежа
            Dim Pen As Double 'пеня
            Dim KPD As Integer 'кол-во просроченных дней 
            Dim date1 As Date
            Dim date2 As Date
            Dim tb1 As Double 'TextBox1
            Dim tb2 As Double
            Dim tb3 As Integer
            Dim tb4 As Double

            Dim tb6 As Double
            Dim tb7 As Double
            Dim tb8 As Double
            If CheckBox3.Checked = True Then


            End If
            tb1 = CLng(TextBox1.Text)
            tb2 = CDbl(TextBox2.Text)
            tb3 = CInt(TextBox3.Text)
            tb4 = CDbl(TextBox4.Text)
            tb6 = CDbl(TextBox6.Text)
            tb7 = CDbl(TextBox7.Text)
            tb8 = CDbl(TextBox8.Text)
            K = tb1
            If ComboBox2.SelectedIndex = 0 Then
                N = tb3 * 12
            Else N = tb3
            End If
            If CheckBox4.Checked = True Then
                TextBox5.Enabled = True
                tb5 = CDbl(TextBox5.Text)
            End If
            Ek = tb5 / 100 * K
            Sek = Ek * N
            If ComboBox3.SelectedIndex = 0 Then
                P = tb4 / 100 / 12
            Else P = tb4 / 100
            End If
            'рассчет пени
            If DateTimePicker2.Checked = False Then
                Pen = 0
            Else
                date1 = DateAdd("m", N, DateTimePicker1.Value)
                date2 = DateTimePicker2.Value
                KPD = DateDiff("d", date1, date2) 'расчет разницы
                Pen = tb8 / 100 * K * KPD
            End If

            If CheckBox1.Checked Then
                'рассчет аннуитетным методом
                Dim A As Double 'коэффициент аннуитета
                A = P * (1 + P) ^ N / ((1 + P) ^ N - 1)
                Sa = A * K + Ek
                S = N * Sa
                Spk = S - K
                Sp = Spk - Sek
                SS = S + tb6 + tb7 + Pen - tb2
                TextBox11.Text = Format(Sa, "0.00")
                Label21.Visible = True
                TextBox11.Visible = True
                Label18.Visible = True

            ElseIf CheckBox2.Checked Then
                ' расчет дифференцированным методом
                Dim Op As Double 'сумма основного платежа при деффиренцированном методе               
                'Dim Sek As Double 'общая сумма ежемесячных комиссий за весь период
                'Dim K As Double 'сумма ипотеки
                'Dim N As Integer 'период погашения по договору в месяцах
                'Dim P As Double 'процентная ставка
                'Dim Sp As Double 'сумма процентов (переплата)
                'Dim Spk As Double 'итоговая переплата с учетом комиссий
                'Dim SS As Double 'полная итоговая сумма выплат
                'Dim S As Double 'общая сумма выплат при использовнном методе
                'Dim Sa As Double 'сумма ежемесячного платежа
                Op = K / N
                S = 0
                For i = 1 To N
                    Sa = Op + P * (K - Op * (i - 1))
                    S = S + Sa
                Next
                Sp = S - K
                Spk = Sp + Sek
                SS = S + Sek + tb6 + tb7 + Pen - tb2
                Label21.Visible = False
                TextBox11.Visible = False
                Label18.Visible = False
            End If
            TextBox13.Text = Format(Pen, "0.00")
            TextBox10.Text = Format(Sp, "0.00")
            TextBox9.Text = Format(Spk, "0.00")
            TextBox12.Text = Format(SS, "0.00")
            Label17.Visible = True
            Label20.Visible = True
            Label23.Visible = True
            Label28.Visible = True
            TextBox9.Visible = True
            TextBox10.Visible = True
            TextBox12.Visible = True
            TextBox13.Visible = True
            Label16.Visible = True
            Label19.Visible = True
            Label22.Visible = True
            Label27.Visible = True

        ElseIf flag = 1 Then
            TextBox9.Visible = False
            TextBox10.Visible = False
            TextBox11.Visible = False
            TextBox12.Visible = False
            TextBox13.Visible = False
            Label17.Visible = False
            Label20.Visible = False
            Label21.Visible = False
            Label23.Visible = False
            Label16.Visible = False
            Label18.Visible = False
            Label19.Visible = False
            Label22.Visible = False
            Label27.Visible = False
            Label28.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'сброс данных
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox9.Visible = False
        TextBox10.Visible = False
        TextBox11.Visible = False
        TextBox12.Visible = False
        TextBox13.Visible = False
        Label17.Visible = False
        Label20.Visible = False
        Label21.Visible = False
        Label23.Visible = False
        Label16.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        Label22.Visible = False
        Label27.Visible = False
        Label28.Visible = False
        Label10.Text = ""
        Label24.Text = ""
        ComboBox1.Text = "валюта"
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox4.Checked = True
        Label1.ForeColor = Color.Black
        Label9.Text = ""
        Label11.Text = ""
        Label15.Text = ""
        Label16.Text = ""
        Label18.Text = ""
        Label19.Text = ""
        Label22.Text = ""
        Label27.Visible = False
        Label28.Visible = False
        TextBox1.BackColor = Color.White
        TextBox1.ForeColor = Color.Black
        TextBox2.BackColor = Color.White
        TextBox2.ForeColor = Color.Black
        TextBox3.BackColor = Color.White
        TextBox3.ForeColor = Color.Black
        TextBox4.BackColor = Color.White
        TextBox4.ForeColor = Color.Black
        TextBox5.BackColor = Color.White
        TextBox5.ForeColor = Color.Black
        TextBox6.BackColor = Color.White
        TextBox6.ForeColor = Color.Black
        TextBox7.BackColor = Color.White
        TextBox7.ForeColor = Color.Black
        TextBox8.BackColor = Color.White
        TextBox8.ForeColor = Color.Black
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now
        DateTimePicker2.Checked = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ssrToday.Text = System.DateTime.Today.ToLongDateString
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now
        DateTimePicker2.Checked = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Label24.Text = ""
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Label24.Text = ""
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Label9.Text = "сом"
            Label11.Text = "сом"
            Label15.Text = "сом"
            Label16.Text = "сом"
            Label18.Text = "сом"
            Label19.Text = "сом"
            Label22.Text = "сом"
            Label27.Text = "сом"
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Label9.Text = "$"
            Label11.Text = "$"
            Label15.Text = "$"
            Label16.Text = "$"
            Label18.Text = "$"
            Label19.Text = "$"
            Label22.Text = "$"
            Label27.Text = "$"
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Label9.Text = "€"
            Label11.Text = "€"
            Label15.Text = "€"
            Label16.Text = "€"
            Label18.Text = "€"
            Label19.Text = "€"
            Label22.Text = "€"
            Label27.Text = "€"
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Label9.Text = "₽"
            Label11.Text = "₽"
            Label15.Text = "₽"
            Label16.Text = "₽"
            Label18.Text = "₽"
            Label19.Text = "₽"
            Label22.Text = "₽"
            Label27.Text = "₽"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        flag = 0
        If TextBox1.Text <> "" Then
            If IsNumeric(TextBox1.Text) = 0 Then
                flag = 1
                TextBox1.BackColor = Color.LightYellow
                Label10.Text = "некорректный ввод"
            Else
                If CLng(TextBox1.Text) < 0 Then
                    flag = 1
                    TextBox1.BackColor = Color.LightYellow
                    Label10.Text = "некорректный ввод"
                ElseIf CLng(TextBox1.Text) < 50000 Then
                    flag = 1
                    Label10.Text = "минимальная сумма" & vbCrLf & "50 000"
                ElseIf CLng(TextBox1.Text) > 5000000 Then
                    flag = 1
                    Label10.Text = "максимальная сумма" & vbCrLf & "5 000 000"
                ElseIf CLng(TextBox1.Text) >= 50000 And CLng(TextBox1.Text) <= 5000000 Then
                    Label1.ForeColor = Color.Black
                    Label10.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            CheckBox3.Checked = False
            TextBox4.Enabled = True
            TextBox4.Text = ""
            TextBox4.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CheckBox4.Checked = False
            tb5 = 0.2
            TextBox4.Text = "20"
            TextBox4.Enabled = False
        End If
    End Sub


End Class