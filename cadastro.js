const DATAFINAL = new Date(2022,7,15);
let listaParticipantes = [];
let listaPalestrantes = [];
let idadeEntrada = 0 ;

const prompt = require("prompt-sync")();


console.log(DATAFINAL);

function data(){
    //var agora = new Date(20023,7,15);
    var agora = new Date();
    if(agora<DATAFINAL){
        return true;
    }
    else{
        console.log("Não é possivel o cadastro. Data inválida.");
        return false;
    }
}

function idade(){

    idadeEntrada = prompt("Digite sua idade: ");

    if (parseInt(idadeEntrada)>=18){
        return true;
    }
    else{
        console.log("Não é possivel o cadastro. Idade não permitida.");
        return false
    }

}

function formatLista(value, index, array){
    
}

function listar(){
    var lista = "";
    var palestrantes = listaPalestrantes.forEach(value => {
        lista += value.cpf +" "+ value.nome + " " + value.sobrenome + "\n";
    });
    var participantes = listaParticipantes.forEach(value => {
        lista += value.cpf +" "+ value.nome + " " + value.sobrenome + "\n";
    });

    console.log(lista);
}

function cadastro(){
    if (listaParticipantes.length <= 100){
        console.log("## CADASTRO ##");
        var nome = prompt("Nome: ");
        var sobrenome = prompt("Sobrenome: ");
        var cpf = prompt("Digite seu CPF: ");
        var palestrante = prompt("É um palestrante (s/n)");


        pessoa = {
            nome: nome,
            sobrenome: sobrenome,
            cpf: cpf,
            idade:idadeEntrada,
        }

        if (palestrante == 's'){
            listaPalestrantes.push(pessoa);
        }
        else{
            listaParticipantes.push(pessoa);
        }

        console.log(pessoa);
    }
    else{
        console.log("Não é possivel o cadastro. Quantidade excedida de participantes.");
    }
}


function main(){
    if (data()== false){
        info = "q";
    };

    if (idade()){
        listar();
        cadastro();
    }

    info = "";

}

var info = "c";

while(info!="q"){

    
    if (info=="c"){
        main();
    }
    else{
        console.log("## MENU ##");
        info = prompt("Escolha uma das opções abaixo: \n c) Cadastrar \n q) Sair \n ");
    }
 
}
