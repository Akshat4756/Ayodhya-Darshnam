<%@ Page Title="" Language="C#" MasterPageFile="~/darshan.master" AutoEventWireup="true" CodeBehind="UserSignUp.aspx.cs" Inherits="Project_Ayodhya_Darshan.UserSignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <section>
     <div class="container pt-5">
         <div class="form-group">
         <div class="card mx-auto mt-5 mb-5 col-md-6 col-lg-6 col-sm-6" style="background:linear-gradient(to right, #fc2525, #f53232, #f89c0a, #f75e0f);">
             <div class="card-header">
                 <img src="Assets/Images/Ayodhya Darshnam (1).png" class="img-fluid float-start" />
                 <span class="text-center text-warning"><I>Your Guide to</I><b>Ayodhya</b></span></div>
             <div class="card-body">
                 <div class="form-control">
                     <div class="form-group">
                         <div class="form-row">
                             <div class="col-md-12">
                                 <div class="row">
                                 <div class="col-md-6">
                                      <label for="Example for First Name" runat="server" class="form-label">First Name</label>
                                      <asp:TextBox ID="txt_FirstName" runat="server" CssClass="form-control" Placeholder="First Name" BorderColor="#ff6600"></asp:TextBox>
                                      <asp:RequiredFieldValidator ID="r_FirstName" runat="server" ControlToValidate="txt_FirstName" ErrorMessage="Please Enter the First Name" ForeColor="Red" ValidationGroup="SignUp"></asp:RequiredFieldValidator>
                                 </div>
                                 <div class="col-md-6">
                                     <label for="Example for Last Name" runat="server" class="form-label">Last Name</label>
                                     <asp:TextBox ID="txt_LastName" runat="server" CssClass="form-control" Placeholder="Last Name" BorderColor="#ff6600"></asp:TextBox>
                                     <asp:RequiredFieldValidator ID="r_LastName" runat="server" ControlToValidate="txt_LastName" ErrorMessage="Please Enter the Last Name" ForeColor="Red" ValidationGroup="SignUp"></asp:RequiredFieldValidator>
                                 </div>
                                 </div>
                            </div>
                             <div class="col-md-12">
                                 <label for="Example for E Mail" runat="server" class="form-label">E Mail</label>
                                 <asp:TextBox ID="txt_EMail" TextMode="Email" runat="server" BorderColor="#ff6600" CssClass="form-control" Placeholder="abcd@gmail.com"></asp:TextBox>
                                 <asp:RegularExpressionValidator ID="rg_EMail" runat="server" ControlToValidate="txt_EMail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Please Enter Valid E Mail ID" ForeColor="Red" ValidationGroup="SignUp"></asp:RegularExpressionValidator>
                             </div>
                             <div class="col-md-12">
                                 <label for="Example for DropDown gender" runat="server" class="form-label">Gender</label>
                                 <asp:DropDownList ID="ddl_Gender" runat="server" CssClass="form-control" Placeholder="Please Select your gender" BorderColor="#ff6600">
                                     <asp:ListItem Value="">Please select Your Gender</asp:ListItem>
                                     <asp:ListItem Text="Male" Value="1"></asp:ListItem>
                                     <asp:ListItem Text="Female" Value="2"></asp:ListItem>
                                     <asp:ListItem Text="Transgender" Value="3"></asp:ListItem>
                                 </asp:DropDownList>
                                 <asp:RequiredFieldValidator ID="rqr_ddl_Gender" runat="server" ControlToValidate="ddl_Gender" ErrorMessage="Please Select your Gender" ForeColor="Red" ValidationGroup="SignUp" InitialValue="0"></asp:RequiredFieldValidator>
                             </div>
                             <div class="col-md-12">
                                 <div class="row">
                                     <div class="col-md-6">
                                         <label for="Exmaple for state" runat="server" class="form-label">State</label>
                                         <asp:DropDownList ID="ddl_State" runat="server" CssClass="form-control" placeholder="Select your state" AutoPostBack="true" AppendDataBoundItems="true" BorderColor="#ff6600" >
                                             <asp:ListItem Value="">Please Select your state</asp:ListItem>
                                         </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="rqr_ddl_State" runat="server" ControlToValidate="ddl_State" ErrorMessage="Please Select Your State" ForeColor="Red" InitialValue="0" ValidationGroup="SignUp"></asp:RequiredFieldValidator>
                                     </div>
                                     <div class="col-md-6">
                                         <label for="Example for City" runat="server" class="form-label">City</label>
                                         <asp:DropDownList ID="ddl_City" runat="server" CssClass="form-control" Placeholder="Select your city" AutoPostBack="true" AppendDataBoundItems="true" BorderColor="#ff6600">
                                             <asp:ListItem Value="">Please select your city</asp:ListItem>
                                         </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="rqr_ddl_City" runat="server" ControlToValidate="ddl_City" ErrorMessage="Please select your city" ForeColor="Red" InitialValue="0" ValidationGroup="SignUp"></asp:RequiredFieldValidator>
                                     </div>
                                 </div>
                             </div>
                             <div class="col-md-12">
                                 <div class="row">
                                     <div class="col-md-6">
                                         <label for="Example for Password" class="form-label" runat="server">Password</label>
                                         <asp:TextBox ID="txt_Password" runat="server" CssClass="form-control" Placeholder="i.g. ab@232323" AutoPostBack="true" BorderColor="#ff6600"></asp:TextBox>
                                         <asp:RegularExpressionValidator ID="rg_Password" runat="server" ValidationExpression="(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$" ControlToValidate="txt_Password" ErrorMessage="Password atleast contain one character" ForeColor="Red" ValidationGroup="SignUp"></asp:RegularExpressionValidator>
                                     </div>
                                     <div class="col-md-6">
                                         <label for ="Example for Username" runat="server" class="form-label">Username</label>
                                         <asp:TextBox ID="txt_Username" runat="server" CssClass="form-control" placeholder="i.g. John@34" AutoPostBack="true" BorderColor="#ff6600"></asp:TextBox>
                                         <asp:RequiredFieldValidator ID="r_Username" runat="server" ControlToValidate="txt_Username" ErrorMessage="Please Enter the Valid Username" ForeColor="Red" ValidationGroup="SignUp"></asp:RequiredFieldValidator>
                                     </div>
                                 </div>
                             </div>
                             
                         </div>
                     </div>
                 </div>
                 <div class="col-md-12">
                     <div class="row">
                         <div class="col-md-6">
                             <asp:Button ID="Btn_SignUp" runat="server" Text="Register" CssClass="btn btn-sm btn-grad float-md-start float-sm-none" ValidationGroup="SignUp" />
                         </div>
                         <div class="col-md-6">
                             <asp:Button ID="Btn_Login" runat="server" Text="Already have an account? Login" CssClass="btn btn-sm btn-grad float-md-end float-sm-none " OnClick="Btn_Login_Click"/>           
                         </div>           
                     </div>
                </div>
             </div>
         </div>
     </div>
   </div>
 </section>
</asp:Content>
