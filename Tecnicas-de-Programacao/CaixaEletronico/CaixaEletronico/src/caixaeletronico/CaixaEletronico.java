/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package caixaeletronico;

/**
 *
 * @author Henrique
 */
public class CaixaEletronico {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        // CRIAÇÃO DO OBJETO
        Conta objConta = new Conta(5000);
        System.out.println("Saldo: R$" + objConta.verificarSaldo());
        objConta.realizarDeposito(2500);
        System.out.println("Saldo: R$" + objConta.verificarSaldo());
        objConta.realizarSaque(1000);
        System.out.println("Saldo: R$" + objConta.verificarSaldo());
    }
    
}
