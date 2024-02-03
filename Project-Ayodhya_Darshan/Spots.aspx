<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.Master" AutoEventWireup="true" CodeBehind="Spots.aspx.cs" Inherits="Project_Ayodhya_Darshan.Spots" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MedPart" runat="server">
    
    <asp:Repeater ID="rptTemples" runat="server">
        <ItemTemplate>

            <div class="container-fluid">
                <div class="container py-5">
                    <div class="row justify-content-center align-items-center g-4 py-5">
                        <div class="col-sm-6 textcolor">
                            <h3><%#Eval("SpotName") %></h3>
                            <p><%#Eval("ShortDescription") %></p>
                           <p><asp:HyperLink CssClass="btn btn-sm btn-primary btnstyle" NavigateUrl='<%#("~/SpotDetails.aspx?SpotId="+Eval("SpotId")) %>' runat="server">View more</asp:HyperLink> </p>
                        </div>
                        <div class="col-sm-6">
                            <img src='<%#Eval("IconImage") %>' alt="" class="img-fluid " style="border-radius:4rem 4rem 4rem 4rem;box-shadow:8px 10px 8px #888888">
                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>
        <AlternatingItemTemplate>
            <div class="container-fluid bg-light">
                <div class="container py-5 ">
                    <div class="row justify-content-center align-items-center g-4 py-5">
                        <div class="col-sm-6" >
                            <img src='<%#Eval("IconImage") %>' alt="" class="img-fluid " style="border-radius:4rem 4rem 4rem 4rem;box-shadow:-8px 10px 8px #888888">
                        </div>
                        <div class="col-sm-6 textcolor">
                            <h3><%#Eval("SpotName")%></h3>
                            <p><%#Eval("ShortDescription") %></p>
                            <p><asp:HyperLink CssClass="btn btn-sm btn-primary btnstyle float-end" NavigateUrl='<%#("~/SpotDetails.aspx?SpotId="+Eval("SpotId")) %>' runat="server">View more</asp:HyperLink> </p>
                        </div>
                    </div>
                </div>
            </div>
        </AlternatingItemTemplate>
    </asp:Repeater>
</asp:Content>
