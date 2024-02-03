<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddSpots.aspx.cs" Inherits="Project_Ayodhya_Darshan.Admin.AddSpots" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MedPart" runat="server">
    <div id="page-wrapper">


        <div class="container-fluid">
            <!-- Page Heading -->
            <div class="box_general padding_bottom">
                <div class="header_box version_2">
                    <h2><i class="fa fa-file"></i>Add Spots</h2>
                </div>

                <div class="row">
                    <div class="col-md-4">
                        <div class="form-group">
                            <label>Serial Number: </label>
                            <asp:TextBox class="form-control" ID="txt_SerialNumber" placeholder="serialNumber" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ID="reqSerialNumber" ControlToValidate="txt_SerialNumber" Display="Dynamic" ErrorMessage="Please enter Serial Number" ForeColor="Red" ValidationGroup="combination" SetFocusOnError="True" />
                        </div>
                    </div>
                    <div class="col-md-8">
                        <div class="form-group">
                            <label>Category Name :</label>
                            <asp:DropDownList class="form-control" ID="ddlCategoryName" runat="server" placeholder="CategoryName"></asp:DropDownList>
                            <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator" ControlToValidate="ddlCategoryName" ForeColor="Red" ErrorMessage="Please Select Category Name" Display="Dynamic" SetFocusOnError="True" ValidationGroup="combination" />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <label>Spot Name :</label>
                            <asp:TextBox class="form-control" ID="txtSpotName" runat="server" placeholder="Spot Name"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <label>IconImage URL</label>
                            <asp:FileUpload class="form-control" ID="IconImageURL" runat="server" placeholder="IconImage"></asp:FileUpload>
                            <%--<asp:RequiredFieldValidator runat="server" ID="reqIconImageURL" ControlToValidate="IconImageURL" Display="Dynamic" ErrorMessage="Please enter  Icon Image URL" ForeColor="Red" ValidationGroup="combination" SetFocusOnError="True" />--%>
                        </div>
                    </div>
                </div>
                 <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <label>Longitude:</label>
                            <asp:TextBox class="form-control" ID="txt_Longitude" runat="server" placeholder="Longitude"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <label>Lattitude:</label>
                            <asp:TextBox class="form-control" ID="txt_Lattitude" runat="server" placeholder="Lattiitude"></asp:TextBox>
                        </div>
                    </div>
                </div>
                 <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <label>Short Description:</label>
                            <asp:TextBox class="form-control" ID="txt_ShortDescription" runat="server" placeholder="Short Description"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <label>Full Description:</label>
                            <asp:TextBox class="form-control" TextMode="MultiLine" ID="txt_FullDescription" runat="server" placeholder="Full Description"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <label>Show On Homepage :</label>
                           <asp:RadioButtonList ID="rdHomePage" runat="server" CssClass="form-group">
                               <asp:ListItem  Value="True">Yes</asp:ListItem>
                               <asp:ListItem  Value="False">No</asp:ListItem>
                           </asp:RadioButtonList> 
                             <asp:RequiredFieldValidator runat="server" ID="rqrShowOnHomepage" ControlToValidate="rdHomePage" ForeColor="Red" ErrorMessage="Please Select The Options" Display="Dynamic" SetFocusOnError="True" ValidationGroup="combination" />
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <label>BannerImage URL</label>
                            <asp:FileUpload class="form-control" ID="BannerImageURL" runat="server" placeholder="BannerImage"></asp:FileUpload>
                           <%-- <asp:RequiredFieldValidator runat="server" ID="rqrBannerImageUrl" ControlToValidate="UploadBannerImageURL" Display="Dynamic" ErrorMessage="Please enter  Banner Image" ForeColor="Red" ValidationGroup="combination" SetFocusOnError="True" />--%>
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
                    <h2><i class="fa fa-file-text"></i>Spot List</h2>
                </div>
                <div class="row">
                    <div class="col-md-12">
                       <div class="form-group">
                           <asp:GridView ID="GridSpot" runat="server" GridLines="None" CssClass="table table-bordered table-striped table-hover" AutoGenerateColumns="False" EmptyDataText="No More Record" AllowPaging="True">
                              
                               <Columns>
                                   <asp:TemplateField HeaderText="SerialNumber">
                                       
                                       <ItemTemplate>
                                           <asp:Label ID="Label1" runat="server" Text='<%# Bind("SerialNumber") %>'></asp:Label>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                   
                                   <asp:TemplateField HeaderText="SpotName">
                                      
                                       <ItemTemplate>
                                           <asp:Label ID="Label3" runat="server" Text='<%# Bind("SpotName") %>'></asp:Label>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                   <asp:TemplateField HeaderText="BannerImage">
                                       
                                       <ItemTemplate>
                                           <asp:Image ID="Label4" runat="server" ImageUrl='<%# Bind("BannerImage") %>' Height="90" Width="120"></asp:Image>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                   <asp:TemplateField HeaderText="IconImage">
                                       
                                       <ItemTemplate>
                                           <asp:Image ID="Label5" runat="server" ImageUrl='<%# Bind("IconImage") %>' Height="90" Width="120"></asp:Image>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                     <asp:TemplateField HeaderText="AddImages">
                                       <ItemTemplate>
                                          <asp:HyperLink ID="Hyp_Images" runat="server" NavigateUrl='<%#"AddSpotImages.aspx?Id="+Eval("SpotId")%>'  Text='Add MoreImages'></asp:HyperLink>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                   <asp:TemplateField HeaderText="AddVedios">
                                       <ItemTemplate>
                                           <asp:HyperLink ID="Hyp_Vedios" runat="server" NavigateUrl='<%#"AddSpotVedios.aspx?Id="+Eval("SpotId") %>' Text="Add Vedios"></asp:HyperLink>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                   <asp:TemplateField HeaderText="Action">
                                       <ItemTemplate>
                                           <asp:LinkButton ID="btnUpdate" runat="server" CommandArgument='<%#Bind("SpotId") %>' CssClass="btn btn-sm btn-warning" OnClick="btnUpdate_Click"><i class="fa fa-edit"></i></asp:LinkButton>
                                           <asp:LinkButton ID="btnDelete" runat="server" CommandArgument='<%#Bind("SpotId") %>' CssClass="btn btn-sm btn-danger" OnClick="btnDelete_Click"><i class="fa fa-trash"></i></asp:LinkButton>
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
