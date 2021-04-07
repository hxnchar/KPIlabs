<?php include "configs/db.php"?>
<?php 

    if(isset($_POST["email"])){
       header("Location: /");
    }
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Система клімат контролю SKK</title>
    <link href="css/index.css" rel="stylesheet" text="text/css">
    <link href="css/commerce.css" rel="stylesheet" text="text/css">
    
</head>
<body>
    <div class="flex_box">
        <?php include "pages/header.php"?>
        <hr>
        <div class="commerce_part">
        
        <?php
        
            if(isset($_POST["email"])){
                $sql = "SELECT * FROM passwords";
                $result = mysqli_query($connect, $sql);
                $num_accs = mysqli_num_rows($result);
                if($num_accs>0){
                    $account = mysqli_fetch_assoc($result);
                    $password = $account["password"];
                    $sql_delete = "DELETE FROM `passwords` WHERE password = '" . $password . "'";
                    $result_delete = mysqli_query($connect, $sql_delete);
                    $sql_insert = "INSERT INTO users (email, password) VALUES ('" . $_POST["email"] . "', '" . $password . "')";
                    $result_insert = mysqli_query($connect, $sql_insert);
                    
                                    
                require('PHPMailerAutoload.php');
                
                $mail = new PHPMailer();
                $mail->IsSMTP();
                $mail->Mailer = "smtp";
                
                $mail->SMTPDebug  = 1;  
                $mail->SMTPAuth   = TRUE;
                $mail->SMTPSecure = "tls";
                $mail->Port       = 587;
                $mail->Host       = "smtp.gmail.com";
                $mail->Username   = "pasha.vass1488@gmail.com";
                $mail->Password   = "poll07112003";
                
                $mail->IsHTML(true);
                $mail->AddAddress(trim($_POST["email"]), "Client");
                $mail->SetFrom("pasha.vass1488@gmail.com", "SKK inc");
                $mail->AddReplyTo("pasha.vass1488@gmail.com", "SKK inc");
                $mail->Subject = "SKK Order -- success!";
                $content = "<h1 align=center> Покупка успешна! </h1><br><p>Спасибо за покупку!<br>Ваш логин:".$_POST["email"]."<br>Ваш пароль:".$password."<br><br><hr><br><p>Ни в коем случае не потеряйте свой логин и пароль! Востановить будет очень тяжело!<br> Также немедленно проверьте логин и пароль на подлинность, авторизируйтесь на сайте.</p></p>";
                
                $mail->Body=$content; 
                if(!$mail->Send()) {
                  echo "Error while sending Email.";
                  
                } else {
                  echo "Email sent successfully";
                }
                
                
                //$mail->SMTPDebug = SMTP::DEBUG_SERVER;
                //$mail->SMTPSecure = PHPMailer::ENCRYPTION_STARTTLS;
                }
                
            }
        ?>
            <div class="client_part">
                <form action="" method="POST">
                <input required name="email" type="email" placeholder="Введите ваш email" id="emailInput" size="50" maxlength="36">
                <p id="info">Нажимая «Перейти к оплате», я соглашаюсь с тем, что Группа компаний SKK может информировать меня о продуктах и услугах с помощью персонализированных электронных писем. Чтобы узнать больше или отказаться от этих сообщений в любое время, см. нашу Политику конфиденциальности.</p>
                    <input type="checkbox" id="checkbox">Связываться со мной по электронной почте<br>
                    <input type="submit" value="Перейти к оплате" id="submit">
                </form>
            </div>

            <div class="order">
                <p>Ваш заказ:</p>
                <ul>
                    <li>
                        Физический интерфейс системы климат контроля SKK
                    </li>
                    <li>
                        Обогреватель, кондиционер, датчики температуры, влажности, 
                    </li>
                    <li>
                        Логин и пароль для работы системы <i>(будут отправлены вам на почту)</i>
                    </li>
                    <li>
                        Гарантия работы в 1.5 года с момента доставки
                    </li>
                    <li>
                        Доставка к вам в дом <b><strike>24.99$</strike></b><b><i>13.99$</i><b>
                    </li>
                    
                    
                </ul>
                <p id="price"><ins>Цена: 349.99$</ins><i>из них 13.99$ &ndash; доставка</i></p>
                <p id="cancel">Отмените заказ до <span id="date"></span> чтобы получить полный возврат и избежать оплаты. <a href="https://www.youtube.com/watch?v=dQw4w9WgXcQ">Подробнее</a></p>
            </div>
        </div>
        
        <?php include "pages/footer.php"?>
    </div>
    <script src="js/commerce.js"></script>
</body>
</html>