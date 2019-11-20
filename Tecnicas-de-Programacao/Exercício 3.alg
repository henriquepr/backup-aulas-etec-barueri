algoritmo "semnome"

var
  i, num, soma, cont: inteiro
inicio
 cont <- 0
   num <- 1
   enquanto (cont <= 4) faca
      soma <- 0
      para i de 1 ate num-1 faca
         se (num%i = 0) entao
            soma <- soma + i
         fimse
      fimpara
      se (soma = num) entao
         escreval(num)
         cont <- cont + 1
      fimse
      num <- num + 1
   fimenquanto
fimalgoritmo
