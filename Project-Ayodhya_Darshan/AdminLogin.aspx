<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="Project_Ayodhya_Darshan.UserLogin"%>


<asp:Content ID="Content2" ContentPlaceHolderID="MedPart" runat="server">
    <section>
      <div class="container pt-5">
          <div class="form-group">
          <div class="card card_1 card-login mx-auto mt-5 mb-5 col-sm-6 col-md-6 col-lg-4 d-flex" style="background: linear-gradient(to right, #fc2525, #f53232, #f89c0a, #f75e0f);">
              <div class="card-header"><img src="logo/Ayodhya Darshnam (1).png" class="d-flex img-fluid" /><span class="text-center text-warning"><I>Your Guide to</I><b>Ayodhya</b></span></div>
              <div class="card-body align-content-center">
                 <div class="form-control">
                     <div class="form-group">
                         <div class="form-row">
                             <div class="col-md-12">
                                 <label for="Example for AdminName" class="form-label" runat="server">AdminName</label>
                                 <asp:TextBox ID="txtAdminName" runat="server" CssClass="form-control" placeholder="AdminName" BorderColor="#ff6600"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="cmp_AdminName" runat="server" ControlToValidate="txtAdminName" ErrorMessage="Please Enter the AdminName" Forecolor="Red" ValidationGroup="SignIn"></asp:RequiredFieldValidator>
                             </div>
                             <div class="col-md-12">
                                 <label for="Example for Password" class="form-label" runat="server">Password</label>
                                 <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" CssClass="form-control" placeholder="Password" BorderColor="#ff6600"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="cmp_Password" runat="server" ControlToValidate="txtPassword" ErrorMessage="Please Enter your password" ForeColor="Red" ValidationGroup="SignIn"></asp:RequiredFieldValidator>
                                 
                             </div>
                             <div class="form-group">
                                 <div class="form-check">
                                     <label clas="form-check-label">
                                         <asp:CheckBox ID="chk_remember" runat="server" CssClass="form-check-input" BorderColor="#ff6600"/>Remember Password
                                     </label>
                                 </div>
                             </div>
                            
                         </div>
                     </div>
                  </div>
                   <div class="col-md-12 mt-3">
                                 <asp:Button ID="btnLogin" runat="server" Class="btn btn-group  btn-grad"  Text="Login" ValidationGroup="SignIn"  OnClick="btnLogin_Click"/>
                                 <asp:Button ID="btnSignUp" runat="server" Class="btn btn-group btn-grad float-end" Text="SignUp" OnClick="BtnSignUp_Click1" />
                             </div>
              </div>
          </div>
          <div>
              <center><asp:Label ID="Labelmsg" runat="server" Font-Bold="true"></asp:Label></center>
         </div>
    
     
     </div> 
     </div>
  </section>

  </asp:Content>
