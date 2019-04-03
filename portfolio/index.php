<html>
<head>
    <link rel="stylesheet" href="portfoliostylesheet.css">
    <style>
        ul
        {
            list-style-type: none;
            margin: 1px;
            padding: 3px;
            width: 200px;
            background-color: transparent;
        }

        li a
        {
            display: block;
            color: #000;
            padding: 8px 16px;
            text-decoration: none;
        }

        li a:hover
        {
            background-color: #555;
            color: white;
        }
        .columnright
        {
            float: right;
            width: 16%;
            background-color: steelblue;
            padding-left: 45px;
        }
        .columnleft
        {
            float left;
            width 75%;
            padding-left: 45px;
        }
        .card
        {
            padding: 20px;
            margin-top: 0px;
            background-color: steelblue;
        }
    </style>
</head>
<body>

<div class="topnav">
    <a class="active" href="portfoliohome.php">Homepagina</a>
    <a href="portfoliocv.php">CV</a>
    <a href="portfolioprojects.php">Projecten</a>
    <a href="portfoliocontact.php">Contact</a>
    <a href="portfolioabout.php">Over mij</a>
    <a href="portfoliodailytip.php">Tip van de dag</a>
</div>

<div class="header">
    <h1>Portfolio Tristan Goossens</h1>
    <p>IB 1A</p>
</div>

<link rel="stylesheet" href="portfoliostylesheet.css">

<div class="columnright">
<h1>Homepagina</h1>
<h3>Inhoudsopgave</h3>
<ul>
    <li><a href="portfoliocv.php">CV</a></li>
    <li><a href="portfolioprojects.php">Projecten</a></li>
    <li><a href="portfoliocontact.php">Contact</a></li>
    <li><a href="portfolioabout.php">Over mij</a></li>
    <li><a href="portfoliodailytip.php">Tip van de dag</a></li>
</ul>
</div>
<div class="columnleft">
    <div class="card">
    <h2>Mijn School</h2>
    <h5>Geschreven op 7-2-2019</h5>
    <img src="school.jpg" height="250">
    <p><a href="https://www.zoomvliet.nl" target="_blank">Zoomvliet Rooosendaal</a></p>
    <p>School waar ik de opleiding Applicatie ontwikkelaar en beheer studeer.<br>Ik zit hier al sinds september op school.</p>
</div>
</div>
</body>
</html>