<?php
//FOR
for ($x=1; $x<5; $x++) {
echo " FOR<br>";
}
?><br>
<?php
//FOREACH
$osoba = array();
$osoba['firstName'] = 'Imię';
$osoba['lastName'] = 'Nazwisko';
$osoba['birthday'] = '19-05-1989';
foreach ($osoba as $data)
{
    echo "Wartość atrybutu: $data<br>";
}
?><br>
<?php
//DO...WHILE
$i=0;
do {
echo "DO...WHILE<br>";
$i++;
if ($i==5) {break;}
} while ($i<=9)
?><br>
<?php
//WHILE
$zmienna = 95;
while($zmienna < 101)
{
  echo $zmienna."<br>";
  $zmienna++;
}
?>