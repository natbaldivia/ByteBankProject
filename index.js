import {Cliente} from "./Cliente.js"
import { Conta } from "./Conta.js";
import {ContaCorrente} from "./ContaCorrente.js"
import {ContaPoupanca} from "./ContaPoupanca.js"
import {ContaSalario} from "./ContaSalario.js"

const cliente1 = new Cliente("Ricardo", 11122233309);


const contaCorrenteRicardo = new ContaCorrente(1001, cliente1);
const contaPoupanca = new ContaPoupanca(50, cliente1, 1001);
const contaSalario = new ContaSalario(cliente1);
contaSalario.depositar(100);
contaSalario.sacar(10);

console.log(contaSalario);