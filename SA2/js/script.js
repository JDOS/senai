function cadastrarNewsletter(){
    let email = document.getElementById("cadastro-email").value;
    alert("Email foi cadastrado: " + email);
    console.log("Email cadastrado" + email);
}

$(document).ready(function() {
    
    let slideAtual = 3;
    let listaSlides = ["img/jogo1.png", "img/jogo2.png", "img/jogo3.png"]

    setInterval(mudarSlide, 3000) //1500 ms milesegundos

    function mudarSlide() {
        console.log("Slide atual:", slideAtual);

        // Remove o slide anterior
        let img = document.getElementById("banner-img")
        if (listaSlides.length > 0) {
            $("#banner-img").attr("src",(listaSlides[--slideAtual]))
        } 
        if (slideAtual == 0) {
            $("#banner-img").attr("src",(listaSlides[slideAtual]))
            slideAtual = 3
        }



        
    }

})