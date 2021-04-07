<?php
//данные для подкючения я БД
$server = 'localhost';
$username = 'id15404895_root';
$password = 'Q^N9XaWK81|\jWdn';
$dbname = 'id15404895_skk';
//подключение
$connect = mysqli_connect($server, $username, $password,$dbname);
//кодировка
mysqli_set_charset($connect, 'utf8');
?>
