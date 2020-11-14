
Partial Class Signup
    Inherits System.Web.UI.Page
    Dim db As New DataClassesDataContext
    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub lbtnLogin_Click(sender As Object, e As EventArgs) Handles lbtnLogin.Click
        Response.Redirect("Default.aspx")
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Dim checkUser = (From cu In db.Users Where cu.isDel = False And txtEmail.Text = cu.Email).SingleOrDefault

        If checkUser IsNot Nothing Then
            divAlert.Visible = True
            txtEmail.Text = ""
        Else
            Dim _User As New User
            _User.FName = txtFName.Text
            _User.LName = txtLName.Text
            _User.Mobile = txtMobile.Text
            _User.Email = txtEmail.Text
            _User.Password = txtPassword.Text
            _User.isAdmin = 0
            _User.CDate = Date.Now

            _User.UID = Guid.NewGuid().ToString.ToUpper
            _User.isDel = 0

            db.Users.InsertOnSubmit(_User)
            db.SubmitChanges()

            Response.Redirect("Default.aspx")
        End If
    End Sub
End Class
