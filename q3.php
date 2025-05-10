<?php
$arquivo = 'dados.json';
if (!file_exists($arquivo)) {
  echo "Arquivo 'dados.json' não encontrado.\n";
  exit;
}

$dados = json_decode(file_get_contents($arquivo), true);
$valores = array_filter(array_column($dados, 'valor'), fn($v) => $v > 0);

$menor = min($valores);
$maior = max($valores);
$media = array_sum($valores) / count($valores);
$acimaDaMedia = count(array_filter($valores, fn($v) => $v > $media));

echo "Menor faturamento: R$ " . number_format($menor, 2, ',', '.') . "\n";
echo "Maior faturamento: R$ " . number_format($maior, 2, ',', '.') . "\n";
echo "Dias acima da média: $acimaDaMedia\n";
