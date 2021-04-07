<?php include "configs/db.php"?>
<?php 
    if(isset($_POST["email"])  && isset($_POST["password"])){
        $sql = "SELECT * FROM users WHERE email='".$_POST["email"]."' AND password='".$_POST["password"]."'";
        $result=mysqli_query($connect, $sql);
        $num_rows = mysqli_num_rows($result);
        if($num_rows==0){
            $message1 = 'Вы ввели неверные данные! Проверьте еще раз.';
        }elseif($num_rows==1){
            $user = mysqli_fetch_assoc($result);
            setcookie("user_id", $user["user_id"], time()+60*60);
            header("Location: /");
        }
    }
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Авторизация</title>
    <link href="css/index.css" rel="stylesheet" text="text/css">
    <link href="css/logIn.css" rel="stylesheet" text="text/css">
</head>
<body>
<div class="flex_box">
        <?php include "pages/header.php"?>
        <hr>
        <div class="login">
            
            <div class="div">
                <form action="" method="post">
                <img src="images/logo.jpg" alt="">
                <input type="email" placeholder="Введите логин" name="email" required>
                    <br><input type="password" placeholder="Введите пароль" name="password" required>
                    <br><input id="sub" type="submit" value="Войти">
                    <?php 
                        if(isset($message1)){
                            ?>
                            <br><center><p><?php echo $message1?></p></center>
                            <?php
                        }
                    ?>
                </form>
            </div>
        </div>
        
        <?php include "pages/footer.php"?>
        
    </div>
</body>
</html>