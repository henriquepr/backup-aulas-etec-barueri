Algoritmo "Exerc�cio 4"

Var
i, m, x, d, f, c : inteiro
Inicio
 i <- 1
   enquanto i <> 2 faca
      escreval ("Digite um numero: ")
      leia (m)
      se m <= 0 entao
         escreval ("Numero invalido!")
      senao
         se m % 2 = 0 entao
            para x de 1 ate m faca
               se m % x = 0 entao
                  d <- d+1
               fimse
            fimpara
            escreval ("Quantidade de divisores de ",m," �",d)
         senao
            se m < 12 entao
               f <- 1
               para x de 1 ate m faca
                  f <- x*f
               fimpara
               escreval ("Fatorial de ",m," � ",f)
            senao
               para x de 1 ate m faca
                  c <- c+x
               fimpara
               escreval ("Soma de 1 at� ",m," � ",c)
            fimse
         fimse
      fimse
      escreval (" ")
      escreval ("Deseja continuar? 1- Sim ou 2-N�o")
      leia (i)
   fimenquanto
Fimalgoritmo