<?php
echo "Digite uma string: ";
$entrada = trim(fgets(STDIN));

$invertida = '';
for ($i = strlen($entrada) - 1; $i >= 0; $i--) {
  $invertida .= $entrada[$i];
}

echo "String invertida: $invertida\n";
