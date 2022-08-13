
const prompt = require("prompt-sync")();

nAlunos = prompt("Digite o número de alunos: ");

for( var contador = 0; contador<=nAlunos; contador++){

    if ( contador == 0){
        console.log(contador + " é zero")
    }
    if (contador %2 ==0) {
        console.log(contador + " é Par");
    } 
        
    else{
        console.log(contador+ " é Impar");
    }
}

