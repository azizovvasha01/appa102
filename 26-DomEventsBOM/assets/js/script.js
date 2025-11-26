
function calc(operation){
    let n1 = document.getElementById("num1").value.trim();
    let n2 = document.getElementById("num2").value.trim();
    let resultBox = document.getElementById("result");

  
    if(n1 === "" || n2 === ""){
        resultBox.innerText = "Xeta: hər iki xana doldurulmalidi!";
        return;
    }

   
    let a = Number(n1);
    let b = Number(n2);

    
    if(isNaN(a) || isNaN(b)){
        resultBox.innerText = "Xeta: yalniz eded daxil edin!";
        return;
    }

    let result;

    switch(operation){
        case "plus":
            result = a + b;
            break;

        case "minus":
            result = a - b;
            break;

        case "mult":
            result = a * b;
            break;

        case "divide":
            if(b === 0){
                resultBox.innerText = "0 ola bilmez";
                return;
            }
            result = a / b;
            break;

        default:
            resultBox.innerText = "Error";
            return;
    }

    resultBox.innerText = "" + result;
}
