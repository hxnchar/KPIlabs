<?php include "configs/db.php"?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Система клімат контролю SKK</title>
    <link href="css/index.css" rel="stylesheet" text="text/css">
</head>
<body>
    <div class="flex_box">
        <?php include "pages/header.php"?>
        <hr>
        <div class="main_part">
        
            <div class="text">
                <p>Система контроля климата SKK это... </p>
                <br/>
                <p>
                    <ul>
                        <li>Постоянный контроль температуры и влажности в квартире</li>
                        <li>Возможность автоматической настройки климата</li>
                        <li>Возможность ручной настройки климата</li>
                        <li>Понятный и приятный интерфейс</li>
                        <li>Защита от испольования продукта посторонними и детьми</li>
                    </ul>
                </p>
                <button><a href="commerce.php"> Приобрести</a> </button>
                <button id="moreInfo"><a href="https://www.youtube.com/watch?v=dQw4w9WgXcQ">Подробности СКК</a></button>
            </div>

           <div class="imgSKK">
           <img src="images/KK.jpg" alt="">    
           </div>
            
        </div>
        
        <?php include "pages/footer.php"?>
    </div>
</body>
</html>