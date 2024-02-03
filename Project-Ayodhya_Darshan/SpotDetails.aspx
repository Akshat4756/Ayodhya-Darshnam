<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.Master" AutoEventWireup="true" CodeBehind="SpotDetails.aspx.cs" Inherits="Project_Ayodhya_Darshan.SpotDetails" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MedPart" runat="server">
    <div class="container-fluid py-5">
        
                <div class="container">
                    <div class="row justify-content-center g-2">
                        <div class="col-sm-9">
                            <div class="p-2">
                                <asp:Image ID="BannerImage" runat="server" class="img-fluid rounded-top" alt="blog page" />
                            </div>
                            <div class="p-2">
                                <h3><asp:label ID="lblSpotName" runat="server" CssClass="text-warning fontstyle "></asp:label></h3>
                            </div>
                            <div class="p-2">
                                <p><asp:Label ID="lblShortDescription" CssClass="fs-5 text-align-justify text-danger fontstyle" runat="server" style="text-align: justify;"></asp:Label></p>
                            </div>

                            <div class="p-2 text-center">
                                <asp:Image ID="IconImage" runat="server" class="img-fluid rounded w-75" alt="blog page" />
                            </div>
                            <div class="p-2">
                                <p ><asp:Label ID="lblFullDescription" CssClass="fs-5 text-danger fontstyle" style="text-align: justify;" runat="server"></asp:Label></p>
                            </div>
                        </div>
                        <div class="col-sm-3">
                           <%-- <div class="p-4">
                                <h4>Top List</h4>
                                <p class="lh-1"><i class="bi bi-arrow-right-circle-fill"></i><a href="#" class="text-decoration-none text-dark">A second item</a></p>
                                <p class="lh-1"><i class="bi bi-arrow-right-circle-fill"></i><a href="#" class="text-decoration-none text-dark">A third item</a></p>
                                <p class="lh-1"><i class="bi bi-arrow-right-circle-fill"></i><a href="#" class="text-decoration-none text-dark">A fourth item</a></p>
                                <p class="lh-1"><i class="bi bi-arrow-right-circle-fill"></i><a href="#" class="text-decoration-none text-dark">And a fifth one</a></p>

                            </div>--%>

                            <div class="p-2">
                                <img src="img/hanuman 2.jpg" class="img-fluid rounded" alt="blog page">
                            </div>
                        </div>
                    </div>
                </div>
         
    </div>
</asp:Content>

