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
public class Conta {
    
    /*
    DECLARAÇÃO DO ATRIBUTO DA CLASS:
    */
    public String nro_conta;
    public String agencia;
    public double saldo; 
    
    
    /*
    DECLAÇÃO DO METODO CONSTRUTOR:
    TEM QUE SER O MESMO NOME DA CLASSE;
    NÃO POSSUI RETORNO, INCLUSIVE VOID
    */
    
    public Conta(double valor){
        this.saldo = valor;
        //this serve para referenciar um valor que vem de fora
    }
    
    /*
    DECLARAÇÃO DE METÓDOS:
    */
    
    public double verificarSaldo(){
        /*double saldo = 1000;*/
        return this.saldo;
        //this serve para referenciar um valor que vem de fora
    }
    
    public void realizarDeposito(double valor){
        this.saldo += valor;
    }
    
    public void realizarSaque(double valor){
        this.saldo -= valor;
    }
    
}