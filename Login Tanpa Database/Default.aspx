<script runat="server">
    Dim username, pasword, nama

    Protected Sub Button1_Click(sender As Object, e As EventArgs)
        username = TextBox1.Text
        pasword = TextBox2.Text
        If (username = "vika" And pasword = "katasandi") Then
            Response.Redirect("biodata.aspx")

        Else
            Label2.Text = "Your username and password is incorrect"
            Label2.ForeColor = System.Drawing.Color.Red
        End If


    End Sub
</script>
<head>
    <style type="text/css">
        #form1 {
            height: 201px;
            width: 301px;
        }
       
    </style>
    <link rel="stylesheet" href="css login.css"/>
</head>
<div class="login">
    <form id="form1" runat="server">
            <br />
&nbsp; <b>&nbsp;FORM&nbsp; LOGIN<br /></b>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            &nbsp;&nbsp; &nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="label" runat="server" Text="Password"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <p style="height: 29px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" Height="22px" Width="51px" />
            </p>
            <p style="height: 29px">
            &nbsp;&nbsp;<asp:Label ID="Label2" runat="server"></asp:Label>
            </p>
            <p>
                &nbsp;</p>
        </center>
    </form>
</div>




