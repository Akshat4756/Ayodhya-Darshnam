<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddMainEvents.aspx.cs" Inherits="Project_Ayodhya_Darshan.Admin.AddMainEvents" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MedPart" runat="server">
    <div id="page-wrapper">


        <div class="container-fluid">
            <!-- Page Heading -->
            <div class="box_general padding_bottom">
                <div class="header_box version_2">
                    <h2><i class="fa fa-file"></i>Add Events</h2>
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
                            <label>Event Name :</label>
                            <asp:TextBox class="form-control" ID="txtEventName" runat="server" placeholder="Name"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ID="rqrEventName" ControlToValidate="txtEventName" Display="Dynamic" ErrorMessage="Please enter CategoryName" ForeColor="Red" ValidationGroup="combination" SetFocusOnError="True" />                        </div>
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
                    <div class="col-md-6">
                        <div class="form-group">
                            <label>Event IconImage URL</label>
                            <asp:FileUpload class="form-control" ID="IconImageURL" runat="server" placeholder="IconImage"></asp:FileUpload>
                            <asp:RequiredFieldValidator runat="server" ID="reqIconImageURL" ControlToValidate="IconImageURL" Display="Dynamic" ErrorMessage="Please enter  Icon Image URL" ForeColor="Red" ValidationGroup="combination" SetFocusOnError="True" />
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
                            <asp:TextBox class="form-control" ID="txt_FullDescription" runat="server" placeholder="Full Description"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                       <div class="form-group">
                            <label>Show On Homepage :</label>
                            <asp:RadioButtonList CssClass="form-group" ID="Rbl_ShowOnHompage" runat="server" placeholder="ShowOnHomepage">
                                <asp:ListItem Value="True">Yes</asp:ListItem>
                                <asp:ListItem Value="False">No</asp:ListItem>
                            </asp:RadioButtonList>
                             <asp:RequiredFieldValidator runat="server" ID="rqrShowOnHomepage" ControlToValidate="Rbl_ShowOnHompage" ForeColor="Red" ErrorMessage="Please Select The Options" Display="Dynamic" SetFocusOnError="True" ValidationGroup="combination" />
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
                    <h2><i class="fa fa-file-text"></i>Events List</h2>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <div class="form-group">
                           <asp:GridView ID="GridEvent" runat="server" GridLines="None" CssClass="table table-bordered table-striped table-hover" AutoGenerateColumns="False" EmptyDataText="No More Record" AllowPaging="True">
                              
                               <Columns>
                                   <asp:TemplateField HeaderText="SerialNumber">
                                       
                                       <ItemTemplate>
                                           <asp:Label ID="Label1" runat="server" Text='<%# Bind("SerialNumber") %>'></asp:Label>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                                   
                                   <asp:TemplateField HeaderText="EventName">
                                      
                                       <ItemTemplate>
                                           <asp:Label ID="Label3" runat="server" Text='<%# Bind("EventName") %>'></asp:Label>
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
                                    
                                   <asp:TemplateField HeaderText="Action">
                                       <ItemTemplate>
                                           <asp:LinkButton ID="btnUpdate" runat="server" CommandArgument='<%#Bind("EventId") %>' CssClass="btn btn-sm btn-warning" OnClick="btnUpdate_Click"><i class="fa fa-edit"></i></asp:LinkButton>
                                           <asp:LinkButton ID="btnDelete" runat="server" CommandArgument='<%#Bind("EventId") %>' CssClass="btn btn-sm btn-danger" OnClick="btnDelete_Click"><i class="fa fa-trash"></i></asp:LinkButton>
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
