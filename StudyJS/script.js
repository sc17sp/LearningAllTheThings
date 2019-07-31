"use strict";
/* modern mode activated */


/*Infinite loop forces the user to keep inputting an answer until break condition is met */
function getSideLength(sideName){

    let sideValue;
    sideValue = document.getElementById(sideName).value;
    return sideValue;
}

/* This function checks if the 3 lengths make a triangle or not by checking if the sum of 2 sides is greater than the third */
function triangleCheck(sideA, sideB, sideC){
    if(sideA + sideB < sideC){
        return false;
    }

    if(sideB + sideC < sideA){
        return false;
    }

    if(sideC + sideA < sideB){
        return false;
    }

    return true;
}

function getperimeter(sideA, sideB, sideC){
    let perimeter = sideA + sideB + sideC;

    return perimeter;
}

function getArea(sideA,sideB,sideC){
    let halfperimeter = getperimeter(sideA,sideB,sideC)/2;

    /*Area calculated using herons formula */
    let area = (halfperimeter*(halfperimeter - sideA) * (halfperimeter-sideB) * (halfperimeter-sideC)) ** 0.5;

    return area;
}

/* This function simply checks what type of traingle is inputted by checking each sides against one another*/ 
function triangleType(sideA,sideB,sideC){
    if (sideA == sideB == sideC){
        return "Equilateral";
    }

    if (sideA != sideB && sideB != sideC && sideC != sideA){
        return "Scalene";
    }

    return "Isosceles";
}

function clearResults(){
    
}



function main(){
    
    let sideA = getSideLength("sideA");
    let sideB = getSideLength("sideB");
    let sideC = getSideLength("sideC");

    let checkResult = triangleCheck(sideA, sideB, sideC);
    let perimeter = getperimeter(sideA, sideB, sideC);
    let area = getArea(sideA,sideB,sideC);
    let typeOfTriangle = triangleType(sideA,sideB,sideC);


    if(checkResult){
        document.getElementById("type").innerHTML = typeOfTriangle;
        document.getElementById("area").innerHTML = area;
        document.getElementById("perimeter").innerHTML = perimeter;
        
        
    }else{
        document.getElementById("fail").innerHTML = "Input Is Not A Triangle";
    }
}

