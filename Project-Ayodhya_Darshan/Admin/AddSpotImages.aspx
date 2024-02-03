<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddSpotImages.aspx.cs" Inherits="Project_Ayodhya_Darshan.Admin.AddSpotImages" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MedPart" runat="server">
    <div id="page-wrapper">


        <div class="container-fluid">
            <!-- Page Heading -->
            <div class="box_general padding_bottom">
                <div class="header_box version_2">
                    <h2><i class="fa fa-file"></i>Add Spot Image</h2>
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
                            <label>Image Iitle :</label>
                            <asp:TextBox class="form-control" ID="txtImageIitle" runat="server" placeholder="Name"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ID="rqrImageIitle" ControlToValidate="txtImageIitle" Display="Dynamic" ErrorMessage="Please enter Image title" ForeColor="Red" ValidationGroup="combination" SetFocusOnError="True" />                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <div class="form-group">
                            <label>Spot Image URL</label>
                            <asp:FileUpload class="form-control" ID="SpotImageURL" runat="server" placeholder="SpotImage"></asp:FileUpload>
                            <asp:RequiredFieldValidator runat="server" ID="reqSpotImageURL" ControlToValidate="SpotImageURL" Display="Dynamic" ErrorMessage="Please enter Image URL" ForeColor="Red" ValidationGroup="combination" SetFocusOnError="True" />
                        </div>
                    </div>
                </div>
               
                <center>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <asp:Button ID="btnSubmit" class="btn_1 medium" runat="server"
                                    Text="Save"
                                    ValidationGroup="combination" UseSubmitBehavior="False" OnClick="btnSubmit_Click"></asp:Button>
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
                    <h2><i class="fa fa-file-text"></i>Spots Image List</h2>
                </div>
                <div class="row">
                    <div class="col-md-12">
                       <div class="form-group">
                            <asp:GridView ID="GridSpotImages" runat="server" GridLines="None" CssClass="table table-bordered table-striped table-hover" AutoGenerateColumns="False" EmptyDataText="No More Record" AllowPaging="True">
                                 <Columns>
                                     <asp:TemplateField HeaderText="SpotImageId">
                                        
                                         <ItemTemplate>
                                             <asp:Label ID="Label1" runat="server" Text='<%# Bind("SpotImageId") %>'></asp:Label>
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="ImageTitle">
                                        
                                         <ItemTemplate>
                                             <asp:Label ID="Label3" runat="server" Text='<%# Bind("ImageTitle") %>' ></asp:Label>
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="ImageLink">
                                        
                                         <ItemTemplate>
                                             <asp:Image ID="Label4" runat="server" ImageUrl='<%# Bind("ImageLink") %>' Height="90" Width="110"></asp:Image>
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Action">
                                        
                                        <ItemTemplate>
                                            <asp:LinkButton ID="btnUpdate" runat="server" CommandArgument='<%#Bind("SpotImageId") %>' CssClass="btn btn-sm btn-warning" OnClick="btnUpdate_Click"><i class="fa fa-edit"></i></asp:LinkButton>
                                             <asp:LinkButton ID="btnDelete" runat="server" CommandArgument='<%#Bind("SpotImageId") %>' CssClass="btn btn-sm btn-danger" OnClick="btnDelete_Click"><i class="fa fa-trash"></i></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                     
                                 </Columns>
                                 <PagerSettings PageButtonCount="5" Position="Bottom" Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" />
                                <PagerStyle CssClass="pagination-ys" />
                            </asp:GridView>
                       </div>
                    </div>
                </div>

            </div>
            <!-- /.container-fluid -->
        </div>
    </div>
</asp:Content>
