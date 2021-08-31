//simple Calculator

var e = document.getElementById("opList");
var firstNum;
var secondNum;
var opp;

function handleClick() {
    firstNum = parseInt(simpleCalc.num1.value);
    opp = simpleCalc.oparator.value;
    secondNum = parseInt(simpleCalc.num2.value);
    var result;
    switch (opp) {
        case "+":
            result = firstNum + secondNum;
            break;
        case "-":
            result = firstNum - secondNum;
            break;
        case "/":
            result = firstNum / secondNum;
            break;
        case "*":
            result = firstNum * secondNum;
            break;
        case "%":
            result = firstNum % secondNum;
            break;
        default:
            result = "error"
    }
    simpleCalc.display.value = result;
    document.getElementById("display").change();
}


function calculate(num1,operator, num2) {
    var result = 0;
    switch (operator) {
        case "+":
            result = num1 + num2;
            break;
        case "-":
            result = num1 - num2;
            break;
        case "/":
            result = num1 / num2;
            break;
        case "*":
            result = num1 * num2;
            break;
        case "%":
            result = num1 % num2;
            break;
        default:
            result = "error"
    }
    return result + "";
}

    function setValue() {
        console.log("Changing options...");
        selectValue = document.getElementById("opList").value;
        console.log("selectValue :" + selectValue);
    }

//function init() {
//    var button = document.getElementById("button");
//    button.onclick = handleClick;
//}

//window.onload = init;