<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="BannerImage.aspx.cs" Inherits="Project_Ayodhya_Darshan.Admin.BannerImage" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MedPart" runat="server">
    <div id="page-wrapper">


        <div class="container-fluid">
            <!-- Page Heading -->
            <div class="box_general padding_bottom">
                <div class="header_box version_2">
                    <h2><i class="fa fa-file"></i>Add BannerImage</h2>
                </div>

                <div class="row">
                    <div class="col-md-4">
                        <div class="form-group">
                            <label>Serial Number: </label>
                            <asp:TextBox class="form-control" ID="txtSerialNumber" runat="server" placeholder="SerialNumber"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ID="reqSerialNumber" ControlToValidate="txtSerialNumber" Display="Dynamic" ErrorMessage="Please enter Serial Number" ForeColor="Red" ValidationGroup="combination" SetFocusOnError="True" />
                        </div>
                    </div>
                    <div class="col-md-8">
                        <div class="form-group">
                            <label>BannerImage Name :</label>
                            <asp:TextBox class="form-control" ID="txtbannerName" runat="server" placeholder="Name"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                   <div class="col-md-6">
                        <div class="form-group">
                            <label>BannerImage URL</label>
                            <asp:FileUpload class="form-control" ID="UploadBannerImageURL" runat="server" placeholder="BannerImage"></asp:FileUpload>
                            <asp:RequiredFieldValidator runat="server" ID="rqrBannerImageUrl" ControlToValidate="UploadBannerImageURL" Display="Dynamic" ErrorMessage="Please enter  Banner Image" ForeColor="Red" ValidationGroup="combination" SetFocusOnError="True" />
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
                    <h2><i class="fa fa-file-text"></i>BannerImage List</h2>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <div class="form-group">
                           <asp:GridView ID="GridBanner" runat="server" GridLines="None" CssClass="table table-bordered table-striped table-hover" AutoGenerateColumns="False" EmptyDataText="No More Record" AllowPaging="True">
                               <Columns>
                                   <asp:TemplateField HeaderText="SerialNumber">
                                       <ItemTemplate>
                                           <asp:Label ID="lblSerialNumber" runat="server" Text='<%#Eval("SerialNumber") %>'></asp:Label>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                   <asp:TemplateField HeaderText="Title">
                                       <ItemTemplate>
                                           <asp:Label ID="lblName" runat="server" Text='<%#Eval("BannerImageName") %>'></asp:Label>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                    <asp:TemplateField HeaderText="BannerImage">
                                       <ItemTemplate>
                                           <asp:Image ID="BannerImage" runat="server" ImageUrl='<%#Eval("BannerImageUrl") %>' Height="90" Width="100"></asp:Image>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Actions">
                                       <ItemTemplate>
                                           <asp:LinkButton ID="btnUpdate" CommandArgument='<%#Eval("BannerImageId")%>' runat="server" CssClass="btn btn-warning" OnClick="btnUpdate_Click"><i class="fa fa-edit"></i></asp:LinkButton>
                                           <asp:LinkButton ID="btnDelete" CommandArgument='<%#Eval("BannerImageId")%>' runat="server" CssClass="btn btn-danger" OnClick="btnDelete_Click"><i class="fa fa-trash"></i></asp:LinkButton>
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