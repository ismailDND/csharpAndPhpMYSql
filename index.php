<?php 


include "db.php";


session_start();
ob_start();


if(isset($_POST["gon"])){

$eposta=htmlspecialchars(trim($_POST["eposta"]));

$sifre=htmlspecialchars(trim($_POST["sifre"]));


$check=$db->prepare("SELECT * from uye where email=:email and sifre=:sifre");
$check->execute(array(

	'email'=>$eposta,
	'sifre'=>$sifre


));


if($er=$check->rowCount())

echo "GiriOk";


}


 ?>





 <!DOCTYPE html>
 <html>
 <head>
 	<title>
C# ve PHP Aynı DB Kullanımı Üzerinden Giriş İşlemi
 	</title>
 </head>
 <body>
 



	<div style="padding-top: 200px;">
<center>
<form method="POST">
	
Eposta <input type="text" name="eposta" required="">
Şifre <input type="password" name="sifre" required>
<br>
<br>
<button type="subbmit" name="gon" style="border-radius: 50px;"> GÖNDER </button>

</form>
</center>
</div>








 </body>
 </html>