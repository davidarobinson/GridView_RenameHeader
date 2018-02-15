Public Class ChangeHeader
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init


    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            loadstuff()
        End If

    End Sub

    Private Sub loadstuff()
        Dim table As New DataTable
        table.Columns.Add("OneID", Type.GetType("System.Int32"))
        table.Rows.Add(1)
        table.Rows.Add(2)
        table.Rows.Add(3)
        Me.lstTest.DataSource = table
        Me.lstTest.DataBind()
    End Sub

    Protected Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        'For Each col As DataControlField In Me.lstTest.Columns
        '    If col.HeaderText = "One" Then
        '        col.HeaderText = "Two"
        '    End If
        'Next

        Dim Header As GridViewRow = Me.lstTest.HeaderRow
        Dim lbl As Label = Header.FindControl("ColHeader")

        If Not lbl Is Nothing Then
            ' Retrieve value 
            lbl.Text = "Two"
        End If


    End Sub
End Class