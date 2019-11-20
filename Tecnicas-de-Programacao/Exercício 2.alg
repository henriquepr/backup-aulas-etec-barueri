Algoritmo "semnome"
// Execício 2
Var
nome, sexo, nome_alto : caractere
   alt, peso, media_peso, perc_homens, perc_mulheres, total_peso, mais_alta : real
   n, homens, mulheres : inteiro

Inicio
para n de 1 ate 250 faca
      escreval("NÚMERO DE CADASTRO", n)
      escreval()
      escreva("NOME: ")
      leia(nome)
      escreval()
      escreva("ALTURA: ")
      leia(alt)
      escreval()
      escreva("PESO: ")
      leia(peso)
      escreval()
      escreva("SEXO (M) MASCULINO (F) FEMININO :")
      leia(sexo)
      escreval()

      se sexo = "M" então
         homens <- homens + 1
      senao
         se sexo = "F" então
            mulheres <- mulheres + 1
         fimse
      fimse

      total_peso <- total_peso + peso

      se (alt > mais_alta) então
         mais_alta <- alt
         nome_alto <- nome
      fimse
   fimpara
   media_peso <- total_peso / 250
   perc_homens <- homens / 250 * 100
   perc_mulheres <- mulheres / 250 * 100

   escreval("HOMENS: ", homens, perc_homens:3:2, "%")
   escreval("MULHERES: ", mulheres, perc_mulheres:3:2, "%")
   escreval("MÉDIA DE PESO DOS CADASTRADOS: ", media_peso:3:2)
   escreval("CADASTRADO MAIS ALTO(A): ", nome_alto)
Fimalgoritmo