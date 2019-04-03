<?php
include "portfoliodb.php";
?>

<html>
<body>

<link rel="stylesheet" href="portfoliostylesheet.css">

<div class="topnav">
    <a href="portfoliohome.php">Homepagina</a>
    <a href="portfoliocv.php">CV</a>
    <a href="portfolioprojects.php">Projecten</a>
    <a href="portfoliocontact.php">Contact</a>
    <a href="portfolioabout.php">Over mij</a>
    <a class="active" href="portfoliodailytip.php">Tip van de dag</a>
</div>

<div class="header">
    <h1>Tip van de dag</h1>
    <p>De tip van de dag!</p>
</div>

<link rel="stylesheet" href="portfoliostylesheet.css">
<h1>Tip van de dag</h1>
<?php
$vdg = date("l");

if($vdg == "Monday")
{
    $query = "SELECT tip FROM dailytip WHERE day = 'Monday' ";
    $stm = $con->prepare($query);
    if($stm->execute())
    {
        $result = $stm->fetchAll (PDO::FETCH_OBJ);
        foreach($result as $tip)
        {
            echo $tip->tip;
        }
    }
    else echo "Mislukt";
}
else

    if($vdg == "Tuesday")
    {
        $query = "SELECT tip FROM dailytip WHERE day = 'Tuesday' ";
        $stm = $con->prepare($query);
        if($stm->execute())
        {
            $result = $stm->fetchAll (PDO::FETCH_OBJ);
            foreach($result as $tip)
            {
                echo $tip->tip;
            }
        }
        else echo "Mislukt";
    }
    else
        if($vdg == "Wednesday")
        {
            $query = "SELECT tip FROM dailytip WHERE day = 'Wednesday' ";
            $stm = $con->prepare($query);
            if($stm->execute())
            {
                $result = $stm->fetchAll (PDO::FETCH_OBJ);
                foreach($result as $tip)
                {
                    echo $tip->tip;
                }
            }
            else echo "Mislukt";
        }
    else
        if($vdg == "Thursday")
        {
            $query = "SELECT tip FROM dailytip WHERE day = 'Thursday' ";
            $stm = $con->prepare($query);
            if($stm->execute())
            {
                $result = $stm->fetchAll (PDO::FETCH_OBJ);
                foreach($result as $tip)
                {
                    echo $tip->tip;
                }
            }
            else echo "Mislukt";
        }
    else
        if($vdg == "Friday")
        {
            $query = "SELECT tip FROM dailytip WHERE day = 'Friday' ";
            $stm = $con->prepare($query);
            if($stm->execute())
            {
                $result = $stm->fetchAll (PDO::FETCH_OBJ);
                foreach($result as $tip)
                {
                    echo $tip->tip;
                }
            }
            else echo "Mislukt";
        }
    else
        if($vdg == "Saturday")
        {
            $query = "SELECT tip FROM dailytip WHERE day = 'Saturday' ";
            $stm = $con->prepare($query);
            if($stm->execute())
            {
                $result = $stm->fetchAll (PDO::FETCH_OBJ);
                foreach($result as $tip)
                {
                    echo $tip->tip;
                }
            }
            else echo "Mislukt";
        }
    else
        if($vdg == "Sunday")
        {
            $query = "SELECT tip FROM dailytip WHERE day = 'Sunday' ";
            $stm = $con->prepare($query);
            if($stm->execute())
            {
                $result = $stm->fetchAll (PDO::FETCH_OBJ);
                foreach($result as $tip)
                {
                    echo $tip->tip;
                }
            }
            else echo "Mislukt";
        }
?>
</body>
</html>