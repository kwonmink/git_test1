Imports System.Data.SqlClient

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim dbcon As SqlConnection
        Dim dbcmd As SqlCommand
        Dim dataread As SqlDataReader
        Dim sqlStr As String
        Dim strdEmployname As String
        Dim InputStr1 As String
        Dim tableRow As TableRow
        Dim tableCell As TableCell

        InputStr1 = TextBox1().Text
        Label1.Text = InputStr1 + " が入力されました。"

        dbcon = New SqlConnection("Data Source=DESKTOP-NN6RU3T;Integrated Security=SSPI;Initial Catalog=test")

        'DBオープン
        dbcon.Open()

        'SQL文
        sqlStr = "SELECT employeeid, employname FROM employee WHERE employname=" + "'" + InputStr1 + "'"

        'ＳＱＬコマンド作成
        dbcmd = New SqlCommand(sqlStr, dbcon)

        'ＳＱＬ文実行
        dataread = dbcmd.ExecuteReader()

        'TABLE生成
        tableRow = New TableRow()

        tableCell = New TableCell()
        tableCell.text = "employeeid"
        tableRow.Cells.Add(tableCell)

        tableCell = New TableCell()
        tableCell.text = "employname"
        tableRow.Cells.Add(tableCell)
        Table1.Rows.Add(tableRow)

        While dataread.Read()

            strdEmployname = dataread(1).ToString

            'TABLE生成
            tableRow = New TableRow()

            tableCell = New TableCell()
            tableCell.text = dataread(0).ToString
            tableRow.Cells.Add(tableCell)

            tableCell = New TableCell()
            tableCell.text = dataread(1).ToString
            tableRow.Cells.Add(tableCell)

            Table1.Rows.Add(tableRow)

        End While

        'クローズ処理
        dataread.Close()
        dbcmd.Dispose()
        dbcon.Close()
        dbcon.Dispose()

    End Sub


    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim conn As SqlConnection
        Dim cmd As SqlCommand


        Dim sqlQuery As String

        Dim InputStr2 As String
        Dim InputStr3 As String
        Dim InputStr4 As String
        Dim InputStr5 As String
        Dim InputStr6 As String

        InputStr2 = TextBox2().Text
        InputStr3 = TextBox3().Text
        InputStr4 = TextBox4().Text
        InputStr5 = TextBox5().Text
        InputStr6 = TextBox6().Text


        conn = New SqlConnection("Data Source=DESKTOP-NN6RU3T;Integrated Security=SSPI;Initial Catalog=test")

        conn.Open()

        sqlQuery = "Insert into employee (employeeid, departcode, employname, loginid, loginpass) VALUES (@employeeid, @departcode, @employname, @loginid, @loginpass)"


        cmd = New SqlCommand(sqlQuery, conn)


        cmd.Parameters.Add("@employeeid", InputStr2)
        cmd.Parameters.Add("@departcode", InputStr3)
        cmd.Parameters.Add("@employname", InputStr4)
        cmd.Parameters.Add("@loginid", InputStr5)
        cmd.Parameters.Add("@loginpass", InputStr6)

        cmd.ExecuteNonQuery()


        Label7.Text = "追加完了！"

        conn.Close()


        



       







    End Sub




   
End Class
