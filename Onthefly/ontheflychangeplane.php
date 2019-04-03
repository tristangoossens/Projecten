<?php
include "ontheflydb.php";
?>
<!DOCTYPE html>
<html>
<head>
    <title>On The Fly</title>
    <link rel="stylesheet" href="stylesheet.css">
    <style>
        body
        {
            font-family: Verdana, sans-serif;
            margin: 0;
        }

        form
        {

            border 3px solid black;
            text-align: center;
        }

        .column
        {
            float: left;
            padding: 10px;
            height: 500px;
            background-color: powderblue;
            opacity: 0.8;
            text-align: center;
        }

        .column.left
        {
            width: 40%;
            border: 2px solid black;
        }

        .column.middle
        {
            width: 32.5%;
            margin-left: 1.5%;
            border: 2px solid black;
        }

        .column.right
        {
            width: 20%;
            border: 2px solid black;
        }

        a
        {
            display: block;
            text-align: center;
            padding: 8px 16px;
            text-decoration: none;
        }
        a:hover
        {
            background-color: white;
        }
        table
        {
            float: left;
            margin-left: 2%;
        }

    </style>
</head>

<body>

<div class="topnav">

    <a href="ontheflyhome.php">Homepagina</a>
    <a class="active" href="ontheflyplane.php">Vliegtuigen</a>
    <a href="ontheflyoverview.php">Overzicht</a>
    <a href="ontheflyplanning.php">Planning</a>

</div>

<div class="header">
    <h1>Wijzig vliegtuigen</h1>
    <p>On the fly</p>
</div>

<div class="column left">
    <h2>Overzicht</h2>

    <?php

    $query = "SELECT * FROM airplane";
    $stm = $con->prepare($query);

    if($stm->execute())
    {
        echo"<table align='center'>
        <tr>
            <th>Nummer</th>
            <th>Type</th>
            <th>Airline</th>
            <th>Status</th>
            <th>Wijzig</th>
        </tr>";
        $result = $stm->fetchall(PDO::FETCH_OBJ);
        foreach($result as $airplane)
        {

        echo "
                <tr>
                    <td>$airplane->number</td>
                    <td>$airplane->type</td>
                    <td>$airplane->airline</td>
                    <td>$airplane->status</td>
                    <td><a href='ontheflychangeplane.php?id=$airplane->id&number=$airplane->number&type=$airplane->type&airline=$airplane->airline&status=$airplane->status'>Wijzigen</a></td>
                </tr>";
        }
    } else echo "Het tonen van de vliegtuigen is mislukt!";

    echo "</table>";

    ?>

</div>

<div class="column middle">
    <h3>Wijzig vliegtuigen</h3>

    <form method="POST">
        Nummer:<br>
        <input type="text" id="txtNumber" name="txtNumber" value="<?php echo $_GET["number"]?>"><br><br>

        Vliegtuigtype:<br>
        <input type="text" id="txtType" name="txtType" value="<?php echo $_GET["type"]?>"><br><br>

        Bedrijf:<br>
        <input type="text" id="txtAirline" name="txtAirline" value="<?php echo $_GET["airline"]?>"><br><br>

        Status:<br>
        <input type="text" id="txtStatus" name="txtStatus" value="<?php echo $_GET["status"]?>"><br><br>

        <input type="submit" value="Doorsturen!" name="btnSubmit"><br><br>

    </form>

</div>

<?php
if (isset($_POST["btnSubmit"]))
{
    $number = $_POST["number"];
    $type = $_POST["type"];
    $airline = $_POST["airline"];
    $status = $_POST["status"];

    $query = "UPDATE airplane SET number = '$number' , type = '$type' , airline = '$airline' , status = '$status' WHERE id  = $airplane->id";

    $stm = $con->prepare($query);
    if ($stm->execute())
    {
        echo "Vliegtuig is succesvol ge-update";
    } else
    {
        echo "Er is iets misgegaan met het uodaten van het vliegtuig";
    }
}
?>

    <div class="column right">
        <h3>Keuzemenu</h3>
        <a href="ontheflyplane.php">Vliegtuigeninvoer</a>
        <a href="ontheflychangeplane.php">Wijzig Vliegtuigen</a>
    </div>
</body>
</html>