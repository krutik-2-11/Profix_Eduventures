<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Profix.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>

    <nav class="navbar navbar-inverse navbar-fixed-top">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand" href="#">Profix</a>
            </div>
            <ul class="nav navbar-nav navbar-right">
                <li><a href="#"><span class="glyphicon glyphicon-user"></span>Sign Up</a></li>
                <li><a href="#"><span class="glyphicon glyphicon-log-in"></span>Login</a></li>
            </ul>
        </div>
    </nav>

    <div class="container" style="width: 100%;">
        <h2>Carousel Example</h2>
        <div id="myCarousel" class="carousel slide" data-ride="carousel">
            <!-- Indicators -->
            <ol class="carousel-indicators">
                <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                <li data-target="#myCarousel" data-slide-to="1"></li>
                <li data-target="#myCarousel" data-slide-to="2"></li>
            </ol>

            <!-- Wrapper for slides -->
            <div class="carousel-inner">
                <div class="item active">
                    <img src="Images/refrigerator.jpg" alt="Los Angeles" style="width: 100%; height: 400px;">
                </div>

                <div class="item">
                    <img src="Images/television.jpg" alt="Chicago" style="width: 100%; height: 400px;">
                </div>

                <div class="item">
                    <img src="Images/smartphone.jpg" alt="New york" style="width: 100%; height: 400px;">
                </div>
            </div>

            <!-- Left and right controls -->
            <a class="left carousel-control" href="#myCarousel" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="right carousel-control" href="#myCarousel" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>
    </div>


    <div class="container-fluid">
        
        <div class="row">
            <div class="col-sm-2  col-xs-4" style="background-color: lavender;"><img src="Images/television.jpg" /></div>
            <div class="col-sm-2 col-xs-4" style="background-color: lavenderblush;"><img src="Images/television.jpg" /></div>
            <div class="col-sm-2 col-xs-4" style="background-color: lavender;"><img src="Images/television.jpg" /></div>
            <div class="col-sm-2 col-xs-4" style="background-color: lavender;"><img src="Images/television.jpg" /></div>
            <div class="col-sm-2 col-xs-4" style="background-color: lavenderblush;"><img src="Images/television.jpg" /></div>
            <div class="col-sm-2 col-xs-4" style="background-color: lavender;"><img src="Images/television.jpg" /></div>
        </div>
    </div>



</body>
</html>
