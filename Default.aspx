<%@ Page Title="" Language="C#" MasterPageFile="~/darshan.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project_Ayodhya_Darshan.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">  
<section class="">
   <div class="mt-1 pt-5 col-md-12 col-lg-12 col-sm-12" style="flex:auto">
       <div class="row">
        <div id ="Img-Carousel" class="carousel slide carousel-fade pt-3" data-bs-ride="carousel" style="transition-duration:6s">
            <div class="carousel-indicators">
                <button type="button" data-bs-target="#Img-Carousel" data-bs-slide-to="0" class="active" aria-current="true" aria-label="slide1"></button>
                <button type="button" data-bs-target="#Img-Carousel" data-bs-slide-to="1"  aria-label="slide2"></button>
                <button type="button" data-bs-target="#Img-Carousel" data-bs-slide-to="2"  aria-label="slide3"></button>
                <button type="button" data-bs-target="#Img-Carousel" data-bs-slide-to="3" aria-label="slide4"></button>
                <button type="button" data-bs-target="#Img-Carousel" data-bs-slide-to="4" aria-label="slide5"></button>
            </div>
            <div class="carousel-inner">
                <div class="carousel-item active" >
                    <img src="Assets/Images/69e9d146353d630c31ec92cadfc2572c copy.jpg" class="d-block w-100" style="object-position:center"  alt="Kanak Vigrah" />
                    <div class="carousel-caption">
                        <h1 class="text-center mb-4 animated fadeInDown" style="animation-duration:1s;">Welcome To Ayodhya Darshnam</h1>
                        <p>Your Guide To Ayodhya</p>
                    </div>
                </div>
                <div class="carousel-item" >
                    <img src="Assets/Images/WhatsApp-Image-2020-08-21-at-3.34.21-AM.jpeg" class="d-block w-100" style="object-position:center" alt="Guptarghat" />
                    <div class="carousel-caption d-none d-md-block">
                        <h5 class="animate bounceInLeft" style="animation-duration:1s">Guptar Ghat</h5>
                        <p class="animate fadeInUp" style="animation-duration:1s">One of the most beautiful Ghats of ayodhya </p>
                    </div>
                </div>
                <div class="carousel-item  ">
                    <img src="Assets/Images/Shiva_Nathnageshwar-Temples.jpeg" class="d-block w-100" style="object-position:center" alt="Nageshwar Nath Temple" />
                    <div class="carousel-caption d-none d-md-block">
                        <h5>Nageshwar Nath Temple</h5>
                        <p>It is one of 12 jyotirlingya of Lord Shiva</p>
                    </div>
                </div>
                <div class="carousel-item " > 
                    <img src="Assets/Images/copy of deep.jpg" class="d-block w-100" style="object-position:center" alt="Ayodhya main" />
                    <div class="carousel-caption d-none d-md-block">
                        <h5>Ayodhya In Deepotsava</h5>
                        <p>This is the image of Ayodhya in Deepotsava</p>
                    </div>
                </div>
                <div class="carousel-item">
                    <img src="Assets/Images/South-Korea-Princess copy2.jpg" class="d-block w-100" style="object-position:center"  alt="Korean princess Tomb" />
                    <div class="carousel-caption d-none d-md-block">
                        <h5>Memorial Of Korean Princess</h5>
                        <p>There is also a memorial of korean princess in Ayodhya</p>
                    </div>
                </div>
            </div>
          <button class="carousel-control-prev" type="button" data-bs-target="#Img-Carousel" data-bs-slide="prev">
              <span class="carousel-control-prev-icon" aria-hidden="true"></span>
              <span class="visually-hidden">Previous</span>
          </button>
            <button class="carousel-control-next" type="button" data-bs-target="#Img-Carousel" data-bs-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Next</span>
            </button>
       </div>
      </div>
   </div>
</section> 
<section class="">
    <div class="col-md-12 col-sm-12 mt-4 mx-auto mb-1" data-aos="fade-up">
        <div class="row">
            <p class="text-center text-cs animated bounceIn" style="font-size:16pt;font-family:'Lucida Calligraphy';text-align:justify">"Ayodhya, also known as Saketa, is an ancient city of India, is the birthplace of Rama and setting of the great epic Ramayana. Since 5 years the Ayodhya gained a lot of popularity due to the hard work of up's current cm Yogi Adityanath and the UP government, and there is also a slight increasement in the number of travelers coming to ayodhya. So our purpose is to guide them and give them the best experience of the divine city Ayodhya"</p>
        </div>
         <h2 class="text-center mt-3 pt-3 text-cs" style="font-family:'Matura MT Script Capitals'"><u class="fa-fa-check-double"><b>Places To Visit</b></u></h2>
        <div class="container mt-4 col-md-12 col-sm-12 col-lg-12 col-xl-12 " style="border-top-style:double;border-bottom-style:double;border-color:#ff5708">
            <div class="row">
            <div class="col-md-4 col-sm-12 mb-4 mx-auto mt-3" >
                <div class="card card_1 h-100">
                    <img src="Assets/Images/kanak bhawan 2 copy.jpg" class="card-img-top" height:240 width:500 style="width:100%" />
                    <div class="card-body">
                        <center>
                        <h5 class="card-title text-center bg-warning text-cs">Kanak Bhawan</h5>
                        <p class="card-text text-cs">Kanak Bhawan is to the north-east of Ram Janam Bhumi, Ramkot, in Ayodhya. Kanak Bhawan is one of the finest and famous temples in Ayodhya and is a must visit. It is believed that this Bhawan was gifted to Devi Sita by Kaikei immediately after her marriage to Lord Ram. This is private palace of Devi Sita and Lord Rama.</p>
                        </center>
                    </div>
                </div>
            </div>
            <div class="col-md-4 col-sm-12 mx-auto mb-4 mt-3">
                <div class="card card_1 h-100">
                    <img src="Assets/Images/peoples copy 3.jpg" class="card-img-top" height:200 width:500 style="width:100%"; />
                    <div class="card-body">
                        <center>
                            <h5 class="text-center card-title bg-warning text-cs">Karyashala</h5>
                            <p class="text-cs card-text text-center">This Karyashala was set-up during the Ram mandir movement in 1990s for carving of stones for construction of the temple.Here all the stones that will be used in construction of lord Rama's Mandir are stored. This is the picture of People watching the stones and admiring their beauty.</p>
                           
                        </center>
                    </div>
                </div>
            </div>
            <div class="col-md-4 col-sm-12 mx-auto mb-4 mt-3">
                <div class="card card_1 h-100">
                    <img src="Assets/Images/new-ram-mandir-full-hd-image-Photo-3d-Wallpaper.jpg" class="card-img-top" style="width:100%"; />
                    <div class="card-body">
                        <center>
                            <h5 class="text-center card-title bg-warning text-cs">Shree Ram Janmbhoomi Mandir</h5>
                            <p class="text-cs card-text text-center">Ram Mandir is a Hindu temple that is being built in Ayodhya, Uttar Pradesh, India, at the site of Ram Janmabhoomi, according to the Ramayana the birthplace of Rama, a principal deity of Hinduism. The temple is in under construction after Supreme Court's Decision.</p>
                            
                        </center>
                    </div>
                </div>
            </div>
         </div>
            <center>
                 <div class="col-12 btn-">
                            <asp:LinkButton ID="btn_2_MorePlaces" runat="server" CssClass="btn btn-grad mt-auto" OnClick="btn_2_MorePlaces_Click">View More</asp:LinkButton>
                </div>
            </center>
            
       </div>
     </div>     
</section>
<section class="" data-aos="fade-up">
         <h2 class="text-center text-cs mt-5 pt-3" style="font-family:'Matura MT Script Capitals'"><u class="fa-fa-check-double"><b>Temples To Visit</b></u></h2>
         <div class="container mt-4 col-md-12 col-sm-12 col-lg-12 col-xl-12 " style="border-top-style:double;border-bottom-style:double;border-color:#ff5708">
            <div class="row">
            <div class="col-md-4 col-sm-12 mb-4 mx-auto mt-3" >
                <div class="card card_1 h-100">
                    <img src="Assets/Images/hanuman 2.jpg" class="card-img-top" height:240 width:500 style="width:100%" />
                    <div class="card-body">
                        <center>
                        <h5 class="card-title text-center bg-warning text-cs">Hanuman Garahi</h5>
                        <p class="card-text text-cs">Hanuman Garhi is a 10th century temple of lord Hanuman in Uttar Pradesh, India. Located in Ayodhya, it is one of the most important temples in the city along with other temples such as Nageshwar Nath and the in-construction Ram Temple.[1] Located in the middle of Ayodhya, 76 steps lead to the Hanumangarhi which is one of the most popular temple complexes of Hanuman in North India. It is a custom that before visiting Ram temple one should first pay visit to Lord Hanuman temple.[2][3][4] The temple houses Hanuman's mother, Anjani, with a young Hanuman sitting on her lap.[5] This shrine is under the charge of Bairagi Mahants of Ramanandi Sampradaya and Nirvani ani akhara.</p>
                        </center>
                    </div>
                </div>
            </div>
            <div class="col-md-4 col-sm-12 mx-auto mb-4 mt-3">
                <div class="card card_1 h-100">
                    <img src="Assets/Images/images of birla mandir.jpg" class="card-img-top" height:200 width:500 style="width:100%"; />
                    <div class="card-body">
                        <center>
                            <h5 class="text-center card-title bg-warning text-cs">Birla Temple</h5>
                            <p class="text-cs card-text text-center">Shri Ram Janaki Birla Temple is a newly made temple. It is located opposite to the Ayodhya Bus stop on the way of Ayodhya-Faizabad. This temple is dedicated to Lord Ram and Devi Sita.</p>
                        </center>
                    </div>
                </div>
            </div>
            <div class="col-md-4 col-sm-12 mx-auto mb-4 mt-3">
                <div class="card card_1 h-100">
                    <img src="Assets/Images/images of nageshwar.jpg" class="card-img-top" style="width:100%"; />
                    <div class="card-body">
                        <center>
                            <h5 class="text-center card-title bg-warning text-cs">Nageshwar Nath Temple</h5>
                            <p class="text-cs card-text text-center">This temple is at Ram Ki Paidi in Ayodhya. The temple of Nageshwarnath is said to have been established by Kush, the son of Rama. Legend is that Kush lost his armlet, while bathing in the Saryu, which was picked up by a Nag-Kanya, who fell in love with him. As she was a devotee of Shiva, Kush erected this temple for her. Even till the times of Vikramaditya the temple was in good shape. The present temple was built in 1750 by the minister of Safdar Jung, named Naval Rai. The festival of Shivratri is celebrated here in a big way, and Shiv Barat procession is taken out during these celebrations which is particularly significant. During the festival time of Mahashivratri the temple receive thousands of devotees.</p>
                        </center>
                    </div>
                </div>
            </div>
         </div>
            <center>
                 <div class="col-12">
                            <asp:LinkButton ID="btn2MoreTemple" runat="server" CssClass="btn btn-grad mt-auto" OnClick="btn2MoreTemple_Click">View More</asp:LinkButton>
                </div>
            </center>
            
       </div>    
</section>
</asp:Content>
