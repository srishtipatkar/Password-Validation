<?php 
$input = readline();
$specials = array('!', '@', '#', '$', '%', '&', '*');
$num = 0;
$spec = 0;
if (strlen($input) < 7){
    echo "Weak";
    exit;
}
for ($i = 0; $i < strlen($input); $i++){
    if (ctype_digit($input[$i]))
        $num++;
    elseif(in_array($input[$i], $specials))
        $spec++;
}
if ($spec >= 2 && $num >= 2)
    echo "Strong";
else
    echo "Weak";
?>
