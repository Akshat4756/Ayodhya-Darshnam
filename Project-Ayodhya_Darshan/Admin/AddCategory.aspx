<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddCategory.aspx.cs" Inherits="Project_Ayodhya_Darshan.Admin.AddCategory" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MedPart" runat="server">
    <div id="page-wrapper">


        <div class="container-fluid">
            <!-- Page Heading -->
            <div class="box_general padding_bottom">
                <div class="header_box version_2">
                    <h2><i class="fa fa-file"></i>Add Category</h2>
                </div>

                <div class="row">
                    <div class="col-md-4">
                        <div class="form-group">
                            <label>Serial Number: </label>
                            <asp:TextBox class="form-control" ID="txtSerialNumber" runat="server" placeholder="Name"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ID="reqSerialNumber" ControlToValidate="txtSerialNumber" Display="Dynamic" ErrorMessage="Please enter Serial Number" ForeColor="Red" ValidationGroup="combination" SetFocusOnError="True" />
                        </div>
                    </div>
                    <div class="col-md-8">
                        <div class="form-group">
                            <label>Category Name :</label>
                            <asp:TextBox class="form-control" ID="txtCategoryName" runat="server" placeholder="Name"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ID="rqrCategoryName" ControlToValidate="txtCategoryName" Display="Dynamic" ErrorMessage="Please enter CategoryName" ForeColor="Red" ValidationGroup="combination" SetFocusOnError="True" />                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                       <div class="form-group">
                            <label>Show On Homepage :</label>
                            <asp:DropDownList class="form-control" ID="ddl_ShowOnHompage" runat="server" placeholder="ShowOnHomepage"></asp:DropDownList>
                             <asp:RequiredFieldValidator runat="server" ID="rqrShowOnHomepage" ControlToValidate="ddl_ShowOnHompage" ForeColor="Red" ErrorMessage="Please Select The Options" Display="Dynamic" SetFocusOnError="True" ValidationGroup="combination" />
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <label>Category IconImage URL</label>
                            <asp:FileUpload class="form-control" ID="CategoryIconImageURL" runat="server" placeholder="IconImage"></asp:FileUpload>
                            <asp:RequiredFieldValidator runat="server" ID="reqCategoryIconImageURL" ControlToValidate="CategoryIconImageURL" Display="Dynamic" ErrorMessage="Please enter  Icon Image URL" ForeColor="Red" ValidationGroup="combination" SetFocusOnError="True" />
                        </div>
                    </div>
                </div>
               
                <center>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <asp:Button ID="btnSubmit" class="btn_1 medium" runat="server"
                                    Text="Save"
                                    ValidationGroup="combination" UseSubmitBehavior="False"></asp:Button>
                            </div>
                        </div>
                        <div style="margin-left: 20px; margin-bottom: 10px;">
                            <asp:Label runat="server" Text="" ForeColor="Red" ID="lblMessage" Visible="false"></asp:Label>
                        </div>
                    </div>
                </center>

                <!-- /.row -->
            </div>

            <div class="box_general padding_bottom">
                <div class="header_box version_2">
                    <h2><i class="fa fa-file-text"></i>Category List</h2>
                </div>
                <div class="row">
                    <div class="col-md-12">
                    </div>
                </div>

            </div>
            <!-- /.container-fluid -->
        </div>
    </div>
</asp:Content>
