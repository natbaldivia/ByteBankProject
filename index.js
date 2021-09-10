import {Cliente} from "./Cliente.js"
import {ContaCorrente} from "./ContaCorrente.js"
import {Conta} from "./Conta.js"

const cliente1 = new Cliente("Ricardo", 11122233309);


const contaCorrenteRicardo = new Conta(1001, cliente1, 1001);
contaCorrenteRicardo.depositar(500);
contaCorrenteRicardo.sacar(100);

const ContaPoupanca = new Conta(50, cliente1, 1001);

console.log(ContaPoupanca);
console.log(contaCorrenteRicardo);