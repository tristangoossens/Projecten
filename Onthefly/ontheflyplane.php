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
        }
        form
        {

            border 3px solid black;
            text-align: center;
        }
        .column
        {
            float: left;
            background-color: powderblue;
            opacity: 0.8;
            text-align: center;
            width: 75%;
            border: 3px solid black;
        }
        .columnright
        {
            text-align: center;
            float: right;
            border: 3px solid black;
            width: 23%;
            background-color: powderblue;
            opacity: 0.8;
            height: 356px;
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
        p
        {
            color: red;
            margin-right: 75%;
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
        <h1>Vliegtuigeninvoer</h1>
        <h4>On the fly</h4>
    </div>


    <div class="column">
        <h2>Vliegtuigeninvoer</h2>
    <form method = "POST">
                Nummer:<br>
                <input type="text" id="txtNumber" name="txtNumber"><br><br>

                Vliegtuigtype:<br>
                <input type="text" id="txtType" name="txtType"><br><br>

                Bedrijf:<br>
                <input type="text" id="txtAirline" name="txtAirline"><br><br>

                Status:<br>
                <input type="text" id="txtStatus" name="txtStatus"><br><br>

                <input type="submit" value="Doorsturen!" name="btnSubmit"><br><br>

    </form>
    </div>

    <div class="columnright">
        <h3>Keuzemenu</h3>
        <a href="ontheflyplane.php">Vliegtuigeninvoer</a>
        <a href="ontheflychangeplane.php">Wijzig Vliegtuigen</a>
    </div>
<?php

    if(isset($_POST['btnSubmit'])) {
        if (empty($_POST["txtNumber"])) {
            echo "<p>Vul eerst alle vakken in</p>";
        } else {
            if (empty($_POST["txtType"])) {
                echo "<p>Vul eerst alle vakken in</p>";
            } else {
                if (empty($_POST["txtAirline"])) {
                    echo "<p>Vul eerst alle vakken in</p>";
                } else {
                    if (empty($_POST["txtStatus"])) {
                        echo "<p>Vul eerst alle vakken in</p>";
                    } else {
                        $number = $_POST["txtNumber"];
                        $type = $_POST["txtType"];
                        $airline = $_POST["txtAirline"];
                        $status = $_POST["txtStatus"];


                        $query = "INSERT INTO airplane (number, type, airline, status) " .
                            "VALUES('$number','$type','$airline','$status')";

                        $stm = $con->prepare($query);
                        if ($stm->execute()) {
                            echo "Het vliegtuig is succesvol toegevoegd aan de database";
                        } else {
                            echo "Er is iets fout gegaan, probeer het later opnieuw";
                        }

                    }
                }
            }
        }
    }
?>
</body>
</html>