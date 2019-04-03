<?php
include "portfoliodb.php"
?>
<html>
<head>

    <link rel="stylesheet" href="portfoliostylesheet.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">

    <style>
        .column
        {
            float: left;
            width: 33.3%;
            background-color: steelblue;
            font-family: Verdana, sans-serif;
            opacity: 0.8;
            border: 2px solid black;
        }
        .columnright
        {
            float: left;
            width: 50%;
            margin-left: 2%;
            background-color: steelblue;
            font-family: Verdana, sans-serif;
            text-align: center;
            opacity: 0.8;
            border: 2px solid black;
        }
        .fa {
            padding: 20px;
            font-size: 30px;
            width: 30px;
            text-align: center;
            text-decoration: none;
            margin: 5px 2px;
            border-radius: 50%;
        }
        .fa-facebook {
            background: #3B5998;
            color: white;
        }
        .fa-twitter {
            background: #55ACEE;
            color: white;
        }
        .fa-instagram {
            background: orangered;
            color: white;
        }
        .fa-snapchat-ghost {
            background: #fffc00;
            color: white;
            text-shadow: -1px 0 black, 0 1px black, 1px 0 black, 0 -1px black;
        }
    </style>
</head>
<body>


<div class="topnav">
    <a href="portfoliohome.php">Homepagina</a>
    <a href="portfoliocv.php">CV</a>
    <a href="portfolioprojects.php">Projecten</a>
    <a class="active" href="portfoliocontact.php">Contact</a>
    <a href="portfolioabout.php">Over mij</a>
    <a href="portfoliodailytip.php">Tip van de dag</a>
</div>

<div class="header">
    <h1>Contactpagina Tristan Goossens</h1>
    <p>IB 1A</p>
</div>

<link rel="stylesheet" href="portfoliostylesheet.css">
<h1>Contactpagina</h1>
<br><br>

<div class="column">
    <h2>Gegevens</h2>
    <p>
        <b>Naam:</b> Tristan Goossens<BR>
        <b>Adres:</b> Oostplaat 11<BR>
        <b>Woonplaats:</b> Bergen op Zoom<BR>
        <b>Telefoon:</b> +31 06 39658371<BR>
        <b>E-Mail</b> d267316@edu.rocwb.nl<BR>
    </p>

        <br>
        <hr>
    <h2>Social media</h2>
    <p>
        <a class="fa fa-instagram"></a> <b>Instagram</b> - tristangoossens<BR>
        <a class="fa fa-snapchat-ghost"></a> <b>Snapchat</b> - tristangoossens<BR>
        <a class="fa fa-twitter"></a> <b>Twitter</b> - Ik heb geen Twitter<BR>
        <a class="fa fa-facebook"></a><b>Facebook</b> - Ik heb geen Facebook<BR>
    </p>
</div>
<div class="columnright">
    <h2>Contactformulier</h2>
    <form method="post">
        Naam:<BR>
        <input type="text" name="txtName" required/><BR>

        <BR>

        Adres:<BR>
        <input type="text" name="txtAdress" required/><BR>

        <BR>

        E-Mail:<BR>
        <input type="text" name="txtEmail" required/><BR>

        <BR>

        Bericht:<BR>
        <textarea rows="8" cols="60" type="text" name="txtMessage"></textarea><BR>

        <BR>

        <input type="submit" name="btnSubmit" value="Versturen"/>
    </form>
</div>

<?php
if(isset($_POST["btnSubmit"]))
{
    $name = $_POST["txtName"];
    $adress = $_POST["txtAdress"];
    $email = $_POST["txtEmail"];
    $message = $_POST["txtMessage"];

    require 'PHPMailer.php';
    require 'SMTP.php';

    $mail = new PHPMailer(true);
    try {
        //Server settings
        $mail->SMTPDebug = 0;
        $mail->IsSMTP();
        $mail->Host = 'smtp.gmail.com';
        $mail->SMTPAuth = true;
        $mail->Username = ;
        $mail->Password = ;
        $mail->SMTPSecure = 'tls';
        $mail->Port = 587;


        $mail->setFrom('tristanportfoliomail@gmail.com' , 'Tristan Goossens');
        $mail->addAddress('tristanportfoliomail@gmail.com' , 'Tristan Goossens');
//        $mail->addAddress($email , $name);


        $mail->isHTML(true);
        $mail->Subject = 'Portfolio Contactformulier';
        $mail->Body = '<h4><b>Naam:</b></h4>'. $name .'<br>
                       <h4><b>Adres:</b></h4>'. $adress.'<br>
                       <h4><b>Bericht:<br><br></b></h4>'. $message.'<br>';


        $mail->send();
        echo 'Message has been sent';
    } catch (Exception $e) {
        echo 'Message could not be sent. Mailer Error: ', $mail->ErrorInfo;
    }

    $query = "INSERT INTO contact (name, adress, email, message) " .
             "VALUES('$name','$adress','$email','$message')";

    $stm = $con->prepare($query);
    if ($stm->execute())
    {
    }
    else
    {
        echo "Er is iets fout gegaan, probeer het later opnieuw";
    }
}

?>

</body>
</html>