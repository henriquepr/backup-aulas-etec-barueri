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
public class ContaEspecial extends Conta{
    private double Limite;
    public ContaEspecial(double saldo, double Limite) {
        super(saldo);
        this.Limite = Limite;
    }
    public String verificarSaldoEspecial(){
        return "Saldo: " + super.verificarSaldo() + " Limite " + this.Limite;
    }
}
