<?php
include "ontheflydb.php"
?>
<!DOCTYPE html>
<html>
<head>
    <link rel="stylesheet" href="stylesheet.css">
    <style>
        table, th, td
        {
            border: 1px solid black;
            text-align: left;
            background-color: transparent;
            vertical-align: center;
        }
        .column
        {
            margin-left: 37%;
            background-color: lightblue;
            text-align: left;
            width: 28%;
        }
    </style>
</head>
<body>

<div class="topnav">

    <a href="ontheflyhome.php">Homepagina</a>
    <a href="ontheflyplane.php">Vliegtuigen</a>
    <a class="active" href="ontheflyoverview.php">Overzicht</a>
    <a href="ontheflyplanning.php">Planning</a>

</div>

<div class="header">
    <h1>On the fly!</h1>
    <p>Tristan Goossens</p>
</div>

<div class="column">
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
    </tr>";
    }
    } else echo "Het tonen van de vliegtuigen is mislukt!";

    echo "</table>";
?>
</div>
</body>
</html>