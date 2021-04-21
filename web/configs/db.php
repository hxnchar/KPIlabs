<?php
//данные для подкючения я БД
$server = 'localhost';
$username = 'root';
$password = '';
$dbname = 'skk';
//подключение
$connect = mysqli_connect($server, $username, $password,$dbname);
//кодировка
mysqli_set_charset($connect, 'utf8');
?>
