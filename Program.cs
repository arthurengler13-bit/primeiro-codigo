// Escreva a mensagem "imforme um numero: "
Console.Write("Informe um numero: ");
// Crie a variavel variavelQueSalvaUmNumero, 
// leia o que o usuario digitar 
// e transformar o valor lido de texto para interiro(int.Parse)
int variavelQueSalvaUmNumero = int.Parse(Console.ReadLine());

// verificar se o valor lido de variavelQueSakvaUmNumero é par
if (variavelQueSalvaUmNumero % 2 == 0 ) {
    Console.WriteLine($"Número {variavelQueSalvaUmNumero} é par");
}
else {
    Console.WriteLine($"Número {variavelQueSalvaUmNumero} é ímpar");
}
