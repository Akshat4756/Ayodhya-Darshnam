<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project_Ayodhya_Darshan.Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="BannerPart" runat="server">
    <!-- Slideshow container -->
    <div class="container-fluid">
        <asp:Repeater ID="rptCarousel" runat="server">
            <ItemTemplate>
                <!-- Full-width images with number and caption text -->
                <div class="mySlides fade">
                    <div class="numbertext"><%#Eval("SerialNumber") %></div>
                    <center><img src='<%#Eval("BannerImageUrl") %>' class="w-100 d-block"></center>
                    <div class="text text-center"><%#Eval("BannerImageName") %></div>
                </div>
            </ItemTemplate>
        </asp:Repeater>

        <!-- Next and previous buttons -->
        <a class="prev" onclick="plusSlides(-1)">&#10094;</a>
        <a class="next" onclick="plusSlides(1)">&#10095;</a>
   
    <br>

    <!-- The dots/circles -->
    <div style="text-align: center">
        <span class="dot" onclick="currentSlide(1)"></span>
        <span class="dot" onclick="currentSlide(2)"></span>
        <span class="dot" onclick="currentSlide(3)"></span>
        <span class="dot" onclick="currentSlide(4)"></span>
        <span class="dot" onclick="currentSlide(5)"></span>
    </div>
         </div>
    <script>
        let slideIndex = 0;
        showSlides();
        function plusSlides(n) {
            showSlides(slideIndex += n);
        }

        function currentSlide(n) {
            showSlides(slideIndex = n);
        }

        function showSlides() {
            let i;
            let slides = document.getElementsByClassName("mySlides");
            let dots = document.getElementsByClassName("dot");
            for (i = 0; i < slides.length; i++) {
                slides[i].style.display = "none";
            }
            slideIndex++;
            if (slideIndex > slides.length) { slideIndex = 1 }
            for (i = 0; i < dots.length; i++) {
                dots[i].className = dots[i].className.replace(" active", "");
            }
            slides[slideIndex - 1].style.display = "block";
            dots[slideIndex - 1].className += " active";
            setTimeout(showSlides, 2000); // Change image every 2 seconds
        }
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MedPart" runat="server">
    <div class="container-fluid py-5">
        <div class="container">
            <p class="fontstyle psize text-danger">
                "Ayodhya, also known as Saketa, is an ancient city of India, is the birthplace of Rama and setting of the great epic Ramayana. Since 5 years the Ayodhya gained a lot of popularity due to the hard work of up's current cm Yogi Adityanath and the UP government, and there is also a slight increasement in the number of travelers coming to ayodhya. So our purpose is to guide them and give them the best experience of the divine city Ayodhya"
            </p>
        </div>
    </div>
    <div class="container-fluid py-5 bg-temple">
        <div class="container">
            <h3 class="fontstyle fw-bold text-center mb-3 text-danger">Places To Visit</h3>
        </div>
        <div class="row row-cols-1 row-cols-md-3 g-4">
            <asp:Repeater ID="rptPlace" runat="server">
                <ItemTemplate>
                    <div class="col">
                        <div class="card h-100 p-1" style="box-shadow:5px 10px 8px #888888">
                            <img src='<%#Eval("IconImage") %>' class="card-img-top" alt="card">
                            <div class="card-body text-center">
                                <h5 class="card-title bg-warning text-danger">
                                    <%#Eval("SpotName") %></h5>
                                <p class="card-text text-danger"><%#Eval("ShortDescription") %></p>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <center>
            <div class="btnview mt-4">
                <asp:LinkButton ID="btnViewPlaces" runat="server" class="btn btn-primary btnstyle" CommandArgument='<%#Eval("CategoryId")%>' OnClick="btnViewPlaces_Click">View more</asp:LinkButton>
            </div>
        </center>
    </div>

    <div class="container-fluid py-5">
        <div class="container">
            <h3 class="fontstyle fw-bold text-center mb-3 text-danger">Temples To Visit</h3>
        </div>
        <div class="row row-cols-1 row-cols-md-3 g-4">
             <asp:Repeater ID="rptTemple" runat="server">
                    <ItemTemplate>
                        <div class="col">
                            <div class="card h-100 p-1" style="box-shadow:5px 10px 8px #888888">
                                <img src='<%#Eval("IconImage") %>' class="card-img-top" alt="card">
                                <div class="card-body text-center">
                                    <h5 class="card-title bg-warning text-danger">
                                        <%#Eval("SpotName") %></h5>
                                    <p class="card-text text-danger"><%#Eval("ShortDescription") %></p>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
        </div>
        <center>
            <div class="btnview mt-4">
                <asp:LinkButton ID="LinkButton1" runat="server" class="btn btn-primary btnstyle" CommandArgument='<%#Eval("CategoryId")%>' OnClick="btnViewPlaces_Click">View more</asp:LinkButton>
            </div>
        </center>
    </div>

</asp:Content>

