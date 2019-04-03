<?php
include 'portfoliodb.php';
?>
<html>
<head>
    <style>
        xmp
        {
            background-color: powderblue;
            border: 2px solid black;
            font-family: Verdana, sans-serif;
        }
    </style>
</head>
<body>

<link rel="stylesheet" href="portfoliostylesheet.css">

<div class="topnav">
    <a href="portfoliohome.php">Homepagina</a>
    <a href="portfoliocv.php">CV</a>
    <a class="active" href="portfolioprojects.php">Projecten</a>
    <a href="portfoliocontact.php">Contact</a>
    <a href="portfolioabout.php">Over mij</a>
    <a href="portfoliodailytip.php">Tip van de dag</a>
</div>

<div class="header">
    <h1>Mijn projecten</h1>
    <p>Tristan Goossens</p>
</div>

<link rel="stylesheet" href="portfoliostylesheet.css">
<h1>Projecten</h1>

<form method="post">
    <h2>Code Rekenspel:<br></h2>
    <input type="submit" value="Plussommen" name="btnPlussommen"><br>
    <input type="submit" value="Minsommen" name="btnMinsommen"><br>
    <input type="submit" value="Keersommen" name="btnKeersommen"><br>
    <input type="submit" value="Deelsommen" name="btnDeelsommen"><br>
</form>
<xmp>
<?php
if(isset($_POST['btnPlussommen']))
{
    $query = "SELECT name , date , code  FROM project WHERE name = 'Rekenspel plussommen'";

    $stm = $con->prepare($query);

    if($stm->execute())
    {
        $result = $stm->fetchAll(PDO::FETCH_OBJ);
        foreach($result as $code)
        {
            echo $code->code;
        }

    }
    else
    {
        echo 'Mislukt!';
    }
}

if(isset($_POST['btnMinsommen']))
{
    $query = "SELECT code FROM project WHERE name = 'Rekenspel minsommen'";

    $stm = $con->prepare($query);

    if($stm->execute())
    {
        $result = $stm->fetchAll(PDO::FETCH_OBJ);
        foreach($result as $code)
        {
            echo $code->code;
        }
    }
    else
    {
        echo 'Mislukt!';
    }
}
if(isset($_POST['btnKeersommen']))
{
    $query = "SELECT code FROM project WHERE name = 'Rekenspel keersommen'";

    $stm = $con->prepare($query);

    if($stm->execute())
    {
        $result = $stm->fetchAll(PDO::FETCH_OBJ);
        foreach($result as $code)
        {
            echo $code->code;
        }
    }
    else
    {
        echo 'Mislukt!';
    }
}
if(isset($_POST['btnDeelsommen']))
{
    $query = "SELECT code FROM project WHERE name = 'Rekenspel deelsommen'";

    $stm = $con->prepare($query);

    if($stm->execute())
    {
        $result = $stm->fetchAll(PDO::FETCH_OBJ);
        foreach($result as $code)
        {
            echo $code->code;
        }
    }
    else
    {
        echo 'Mislukt!';
    }
}
?>
</xmp>
</body>
</html>