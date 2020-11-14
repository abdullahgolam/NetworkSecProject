
Partial Class _Default
    Inherits System.Web.UI.Page
    Dim db As New DataClassesDataContext
    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub lbtnSignup_Click(sender As Object, e As EventArgs) Handles lbtnSignup.Click
        Response.Redirect("Signup.aspx")
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim checkUser = (From cu In db.Users Where cu.isDel = False And txtEmail.Text = cu.Email And txtPass.Text = cu.Password).SingleOrDefault
        If checkUser IsNot Nothing Then
            Response.Redirect("Home.aspx")
        Else
            divAlert.Visible = True
            txtEmail.Text = ""
            txtPass.Text = ""
        End If
    End Sub
End Class
