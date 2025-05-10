<?php
echo "Digite um número: ";
$numero = (int)trim(fgets(STDIN));

function pertenceFibonacci($numero)
{
  $a = 0;
  $b = 1;

  while ($a <= $numero) {
    if ($a == $numero) {
      return true;
    }
    $temp = $a;
    $a = $b;
    $b = $temp + $b;
  }

  return false;
}

if (pertenceFibonacci($numero)) {
  echo "$numero pertence à sequência de Fibonacci.\n";
} else {
  echo "$numero NÃO pertence à sequência de Fibonacci.\n";
}
