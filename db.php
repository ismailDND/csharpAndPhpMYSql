

<?php 



try{


$db = new pdo("mysql:host=localhost;dbname=test;charset=utf8",'root','12345678');


}

catch(PDOException $hataMesaj){


echo $hataMesaj->getMessage();



}




 ?>