<?php
$faturamento = [];

echo "Digite o faturamento por estado (ex: SP 67836.43). Digite 'fim' para encerrar:\n";
while (true) {
  $linha = trim(fgets(STDIN));
  if (strtolower($linha) === 'fim') break;

  $partes = explode(' ', $linha);
  if (count($partes) === 2) {
    $estado = strtoupper($partes[0]);
    $valor = floatval($partes[1]);
    $faturamento[$estado] = $valor;
  }
}

$total = array_sum($faturamento);

echo "\nPercentual de representação:\n";
foreach ($faturamento as $estado => $valor) {
  $percentual = ($valor / $total) * 100;
  echo "$estado: " . number_format($percentual, 2, ',', '.') . "%\n";
}
