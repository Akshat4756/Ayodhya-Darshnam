<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.Master" AutoEventWireup="true" CodeBehind="MainEvents.aspx.cs" Inherits="Project_Ayodhya_Darshan.MainEvents" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MedPart" runat="server">
    <div class="container-fluid py-5">
        <h3 class="fontstyle fw-bold text-center mb-3 text-danger">Main Events</h3>
       

                <div class="container">


                    <div class="row row-cols-1 row-cols-md-3 g-4">

                         <asp:Repeater ID="rptEvents" runat="server">
            <ItemTemplate>
                        <div class="col">
                            <div class="card h-100 p-1" style="border-style:none">
                                <img src='<%#Eval("IconImage") %>' class="card-img-top" alt="card">
                                <div class="card-body text-center">
                                    <h5 class="card-title bg-warning text-danger">
                                        <%#Eval("EventName") %></h5>
                                    <p class="card-text text-danger"><%#Eval("ShortDescription") %></p>
                                </div>
                                <center>
                                    <div class="btnview mt-4 mb-2">
                                        <asp:LinkButton ID="btnViewTemple" runat="server" class="btn btn-primary btnstyle" OnClick="btnViewTemple_Click" CommandArgument='<%#Eval("EventId") %>'>View more</asp:LinkButton>
                                    </div>
                                </center>
                            </div>
                        </div>

                 </ItemTemplate>
        </asp:Repeater>
                    </div>

                </div>

           
    </div>
</asp:Content>

