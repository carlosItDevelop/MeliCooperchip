<%@ Page Title="" Language="C#" MasterPageFile="~/frontend.Master" AutoEventWireup="true" CodeBehind="centrodecusto.aspx.cs" Inherits="SimpleMembershipLocalDatabase.centrodecusto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="frontendContent" runat="server">
    
    
    
    
    <div role="main" class="main">
        
        


	    <section class="page-top">
		    <div class="container">
			    <div class="row">
				    <div class="col-md-12">
					    <ul class="breadcrumb">
						    <li><a href="#">Home</a></li>
						    <li class="active">Centro de Custo</li>
					    </ul>
				    </div>
			    </div>
			    <div class="row">
				    <div class="col-md-12">
					    <h1>Centro de Distribuição e Storage API</h1>
				    </div>
			    </div>
		    </div>
	    </section>
        
        




	    <div class="container">

		    <div class="row">
			    <div class="col-md-12">
				    <div class="owl-carousel" data-plugin-options='{"items": 1, "animateOut": "fadeOut", "autoplay": true, "autoplayTimeout": 3000}'>
					    <div>
						    <img alt="" class="img-responsive img-rounded" src="/img/our-office-1.jpg">
					    </div>
					    <div>
						    <img alt="" class="img-responsive img-rounded" src="/img/our-office-3.jpg">
					    </div>
				    </div>
			    </div>
		    </div>

		    <hr class="tall">

		    <div class="row">
			    <div class="col-md-7">
				    <h4>A place where amazing things <strong>Get Done!</strong></h4>
				    <p class="lead">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut feugiat urna arcu, vel molestie nunc commodo non. Nullam vestibulum odio vitae fermentum rutrum.</p>

				    <p>Mauris lobortis nulla ut aliquet interdum. Donec commodo ac elit sed placerat. Mauris rhoncus est ac sodales gravida. In eros felis, elementum aliquam nisi vel, pellentesque faucibus nulla.</p>

				    <hr class="invisible">

				    <div class="row">
					    <div class="col-md-6">
						    <div class="feature-box secundary">
							    <div class="feature-box-icon">
								    <i class="fa fa-star"></i>
							    </div>
							    <div class="feature-box-info">
								    <h4 class="shorter">12 years in business</h4>
								    <p class="tall">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut feugiat urna arcu, vel molestie nunc commodo non.</p>
							    </div>
						    </div>
					    </div>
					    <div class="col-md-6">
						    <div class="feature-box secundary">
							    <div class="feature-box-icon">
								    <i class="fa fa-heart"></i>
							    </div>
							    <div class="feature-box-info">
								    <h4 class="shorter">Loved by customers</h4>
								    <p class="tall">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vestibulum odio vitae fermentum rutrum.</p>
							    </div>
						    </div>
					    </div>
				    </div>

				    <hr class="invisible">

				    <h4>Work <strong>Space</strong></h4>

				    <div class="row lightbox" data-plugin-options='{"delegate": "a", "type": "image", "gallery": {"enabled": true}}'>
					    <div class="col-md-4">
						    <a class="img-thumbnail push-bottom" href="/img/our-office-1.jpg" data-plugin-options='{"type":"image"}'>
							    <img class="img-responsive" src="/img/our-office-1.jpg">
							    <span class="zoom">
								    <i class="fa fa-search"></i>
							    </span>
						    </a>
					    </div>
					    <div class="col-md-4">
						    <a class="img-thumbnail push-bottom" href="/img/our-office-2.jpg" data-plugin-options='{"type":"image"}'>
							    <img class="img-responsive" src="/img/our-office-2.jpg">
							    <span class="zoom">
								    <i class="fa fa-search"></i>
							    </span>
						    </a>
					    </div>
					    <div class="col-md-4">
						    <a class="img-thumbnail push-bottom" href="/img/our-office-3.jpg" data-plugin-options='{"type":"image"}'>
							    <img class="img-responsive" src="/img/our-office-3.jpg">
							    <span class="zoom">
								    <i class="fa fa-search"></i>
							    </span>
						    </a>
					    </div>
				    </div>

			    </div>

                
                <!--  Accordion /-->
				<div class="col-md-5">
					<h2>API Features</h2>

					<div class="panel-group" id="accordion">
                        
                        
						<div class="panel panel-default">
							<div class="panel-heading">
								<h4 class="panel-title">
									<a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseFour">
										<i class="fa fa-laptop"></i>
										Stoage API
									</a>
								</h4>
							</div>
							<div id="collapseFour" class="accordion-body collapse in">
								<div class="panel-body">
								    Esta é a melhor solução para desenvolvedores e Softhouse's, pois trata-se do compartilhamento de todos os nossos produtos e serviços, via API. 
                                    <br/>Estas API's representam todos os recursos do APIML | Tools - Management, disponíveis para que lojistas e desenvolvedores de todoso os portes consumam e desenvolvam suas próprias soluções.
								</div>
							</div>
						</div>                          

						<div class="panel panel-default">
							<div class="panel-heading">
								<h4 class="panel-title">
									<a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseOne">
										<i class="fa fa-usd"></i>
										Pricing Tables
									</a>
								</h4>
							</div>
							<div id="collapseOne" class="accordion-body collapse">
								<div class="panel-body">
									Donec tellus massa, tristique sit amet condim vel, facilisis quis sapien. Praesent id enim sit amet odio vulputate eleifend in in tortor.
								</div>
							</div>
						</div>
						<div class="panel panel-default">
							<div class="panel-heading">
								<h4 class="panel-title">
									<a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo">
										<i class="fa fa-comment"></i>
										Contact Forms
									</a>
								</h4>
							</div>
							<div id="collapseTwo" class="accordion-body collapse">
								<div class="panel-body">
									Donec tellus massa, tristique sit amet condimentum vel, facilisis quis sapien.
								</div>
							</div>
						</div>
						<div class="panel panel-default">
							<div class="panel-heading">
								<h4 class="panel-title">
									<a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseThree">
										<i class="fa fa-laptop"></i>
										Portfolio Pages
									</a>
								</h4>
							</div>
							<div id="collapseThree" class="accordion-body collapse">
								<div class="panel-body">
									Donec tellus massa, tristique sit amet condimentum vel, facilisis quis sapien.
								</div>
							</div>
						</div>
                        
                        
                      

					</div>
				</div>                
                <!-- FIM DE Accordion /-->
                

		    </div>

	    </div>
        
        
                                
        
        
        
        
		<div class="container">

			<h2 class="word-rotator-title">
				The New Way to <strong>
					<span class="word-rotate" data-plugin-options='{"delay": 2000}'>
						<span class="word-rotate-items">
							<span>success.</span>
							<span>advance.</span>
							<span>progress.</span>
						</span>
					</span>
				</strong>
			</h2>

			<div class="row">
				<div class="col-md-10">
					<p class="lead">
						Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque rutrum pellentesque imperdiet. Nulla lacinia iaculis nulla non <span class="alternative-font">metus.</span> pulvinar. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Ut eu risus enim, ut pulvinar lectus. Sed hendrerit nibh.
					</p>
				</div>
				<div class="col-md-2">
					<a href="#" class="btn btn-lg btn-primary push-top">Join Our Team!</a>
				</div>
			</div>

			<hr class="tall">

			<div class="row">
				<div class="col-md-8">
					<h3><strong>Who</strong> We Are</h3>
					<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur pellentesque neque eget diam posuere porta. Quisque ut nulla at nunc <a href="#">vehicula</a> lacinia. Proin adipiscing porta tellus, ut feugiat nibh adipiscing sit amet. In eu justo a felis faucibus ornare vel id metus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; In eu libero ligula. Fusce eget metus lorem, ac viverra leo. Nullam convallis, arcu vel pellentesque sodales, nisi est varius diam, ac ultrices sem ante quis sem. Proin ultricies volutpat sapien, nec scelerisque ligula mollis lobortis.</p>
					<p>Curabitur pellentesque neque eget diam posuere porta. Quisque ut nulla at nunc vehicula lacinia. Proin adipiscing porta tellus, ut feugiat nibh adipiscing <span class="alternative-font">metus</span> sit amet. In eu justo a felis faucibus ornare vel id metus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; In eu libero ligula. Fusce eget metus lorem, ac viverra leo. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; In eu libero ligula. Fusce eget metus lorem, ac viverra leo. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; In eu libero ligula.</p>
				</div>
				<div class="col-md-4">
					<div class="featured-box featured-box-secundary">
						<div class="box-content">
							<h4>Behind the scenes</h4>
							<ul class="thumbnail-gallery flickr-feed" data-plugin-flickr data-plugin-options='{"qstrings": { "id": "93691989@N03" }, "limit": 6}'></ul>
						</div>
					</div>
				</div>
			</div>

			<hr class="tall">

			<div class="row">
				<div class="col-md-12">
					<h3 class="push-top">Pareceiros <strong>- Estoques Virtuais</strong></h3>
				</div>
			</div>

			<div class="row">
				<div class="col-md-12">

					<ul class="history">
						<li data-appear-animation="fadeInUp">
							<div class="thumb">
								<img src="img/office-4.jpg" alt="" />
							</div>
							<div class="featured-box">
								<div class="box-content">
									<h4><strong>EvoluSom Atacadista</strong></h4><hr />
									<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur pellentesque neque eget diam posuere porta. Quisque ut nulla at nunc vehicula lacinia. Proin adipiscing porta tellus, Curabitur pellentesque neque eget diam posuere porta. Quisque ut nulla at nunc vehicula lacinia. Proin adipiscing porta tellus,</p>
								</div>
							</div>
						</li>
						<li data-appear-animation="fadeInUp">
							<div class="thumb">
								<img src="img/office-3.jpg" alt="" />
							</div>
							<div class="featured-box">
								<div class="box-content">
									<h4><strong>Hayamax - Hayonic</strong></h4><hr />
									<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur pellentesque neque eget diam posuere porta. Quisque ut nulla at nunc vehicula lacinia. Proin adipiscing porta tellus, Curabitur pellentesque neque eget diam posuere porta. Quisque ut nulla at nunc vehicula lacinia.</p>
								</div>
							</div>
						</li>
						<li data-appear-animation="fadeInUp">
							<div class="thumb">
								<img src="img/office-2.jpg" alt="" />
							</div>
							<div class="featured-box">
								<div class="box-content">
									<h4><strong>Aldo Componentes</strong></h4><hr />
									<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur pellentesque neque eget diam posuere porta. Quisque ut nulla at nunc vehicula lacinia. Proin adipiscing porta tellus, Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur pellentesque neque eget diam posuere porta. Quisque ut nulla at nunc vehicula lacinia. Proin adipiscing porta tellus, Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur pellentesque neque eget diam posuere porta. Quisque ut nulla at nunc vehicula lacinia. Proin adipiscing porta tellus,</p>
								</div>
							</div>
						</li>
						<li data-appear-animation="fadeInUp">
							<div class="thumb">
								<img src="img/office-1.jpg" alt="" />
							</div>
							<div class="featured-box">
								<div class="box-content">
									<h4><strong>Oderço Distribuição</strong></h4><hr />
									<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur pellentesque neque eget diam posuere porta. Quisque ut nulla at nunc vehicula lacinia. Proin adipiscing porta tellus, Curabitur pellentesque neque eget diam posuere porta. Quisque ut nulla at nunc vehicula lacinia. Proin adipiscing porta tellus, Curabitur pellentesque neque eget diam posuere porta. Quisque ut nulla at nunc vehicula lacinia. Proin adipiscing porta tellus,</p>
								</div>
							</div>
						</li>
                        
                        
                        
						<li data-appear-animation="fadeInUp">
							<div class="thumb">
								<img src="img/office-1.jpg" alt="" />
							</div>
							<div class="featured-box">
								<div class="box-content">
									<h4><strong>Gazin Atacados</strong></h4><hr />
									<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur pellentesque neque eget diam posuere porta. Quisque ut nulla at nunc vehicula lacinia. Proin adipiscing porta tellus, Curabitur pellentesque neque eget diam posuere porta. Quisque ut nulla at nunc vehicula lacinia. Proin adipiscing porta tellus, Curabitur pellentesque neque eget diam posuere porta. Quisque ut nulla at nunc vehicula lacinia. Proin adipiscing porta tellus,</p>
								</div>
							</div>
						</li>                        

					</ul>

				</div>
			</div>

		</div>


                
        


    </div>
    
    



	<!-- Specific Page Vendor and Views -->
	<script src="js/views/view.contact.js"></script>
				

	<script src="http://maps.google.com/maps/api/js?sensor=false"></script>

	<script>

		/*
		Map Settings

			Find the Latitude and Longitude of your address:
				- http://universimmedia.pagesperso-orange.fr/geo/loc.htm
				- http://www.findlatitudeandlongitude.com/find-address-from-latitude-and-longitude/

		*/

		// Map Markers
		var mapMarkers = [{
			address: "New York, NY 10017",
			html: "<strong>New York Office</strong><br>New York, NY 10017",
			icon: {
				image: "img/pin.png",
				iconsize: [26, 46],
				iconanchor: [12, 46]
			},
			popup: true
		}];

		// Map Initial Location
		var initLatitude = 40.75198;
		var initLongitude = -73.96978;

		// Map Extended Settings
		var mapSettings = {
			controls: {
				draggable: true,
				panControl: true,
				zoomControl: true,
				mapTypeControl: true,
				scaleControl: true,
				streetViewControl: true,
				overviewMapControl: true
			},
			scrollwheel: false,
			markers: mapMarkers,
			latitude: initLatitude,
			longitude: initLongitude,
			zoom: 16
		};

		var map = $("#googlemaps").gMap(mapSettings),
			mapRef = $("#googlemaps").data("gMap.reference");

		// Create an array of styles.
		var mapColor = "#0088cc";

		var styles = [{
			stylers: [{
				hue: mapColor
			}]
		}, {
			featureType: "road",
			elementType: "geometry",
			stylers: [{
				lightness: 0
			}, {
				visibility: "simplified"
			}]
		}, {
			featureType: "road",
			elementType: "labels",
			stylers: [{
				visibility: "off"
			}]
		}];

		var styledMap = new google.maps.StyledMapType(styles, {
			name: "Styled Map"
		});

		mapRef.mapTypes.set("map_style", styledMap);
		mapRef.setMapTypeId("map_style");

	</script>
            

</asp:Content>
