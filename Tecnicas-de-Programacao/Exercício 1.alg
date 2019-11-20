algoritmo "Exercicio 1"

var
aux : caracter
i, n, z25, z50, z75, z100 : inteiro
Num : vetor [1..100] de inteiro

inicio
aux := "S"

para i de 1 ate 1000 faca
   enquanto aux = "S" faca
      limpatela
      escreva("Digite um numero: ")
      leia(Num[i])
      se Num[i] >= 0 entao
         se Num[i] < 25 entao
            z25 := z25 + 1
         fimse
      fimse
      se Num[i] > 24 entao
         se Num[i] < 50 entao
            z50 := z50 + 1
         fimse
      fimse
      se Num[i] > 49 entao
         se Num[i] < 75 entao
            z75 := z75 + 1
         fimse
      fimse
      se Num[i] > 74 entao
         se Num[i] < 101 entao
            z100 := z100 + 1
         fimse
      fimse
      escreva("Deseja continuar[S/N]?")
      leia(aux)
   fimenquanto
fimpara
escreval("O total de numeros no intervalo de 0 ate 24 é: ",z25)
escreval("O total de numeros no intervalo de 25 ate 49 é: ",z50)
escreval("O total de numeros no intervalo de 50 ate 74 é: ",z75)
escreval("O total de numeros no intervalo de 75 ate 100 é: ",z100)
// Seção de Comandos
fimalgoritmo
inicio
// Seção de Comandos 
fimalgoritmo
