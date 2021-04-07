<div class="header">
            <div class="one">
            <img src="images/logo.jpg" alt="">
            <p><a href="https://hypalgesic-splint.000webhostapp.com/">Главная</a></p>
            </div>
            <div class="two">
            <p><a href="https://www.youtube.com/watch?v=dQw4w9WgXcQ">О нас</a></p>
            </div>
            <div class="three">
            <?php 
                if(isset($_COOKIE["user_id"])){
                    ?>
                    <p left="4px"><a href="#"><font size="5">Профиль</font></a></p>
                    <?php
                }else{
                    ?>
                    <p><a href="/logIn.php">Войти</a></p>
                    <?php
                    //     font-size: 27px; margin-left: 4px;
                }
            ?>
            
            </div>
        </div>