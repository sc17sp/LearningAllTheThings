"use strict";
/* modern mode activated */


/*Infinite loop forces the user to keep inputting an answer until break condition is met */
function getSideLength(sideName){

    let value;

    for(let i=0; i<10;i--){
        let response = prompt(`Give length of side ${sideName}`);
        
         value = Number(response);
        
        if(value>0 && value !=NaN){
            break;
        }else{
            alert("That was not a valid numerical input");
        }
        
    }
    return value;
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

function triangleType(sideA,sideB,sideC){
    if (sideA == sideB == sideC){
        return "Equilateral";
    }

    if (sideA != sideB && sideB != sideC && sideC != sideA){
        return "Scalene";
    }

    return "Isosceles";
}

let sideA = getSideLength("A");
let sideB = getSideLength("B");
let sideC = getSideLength("C");

let checkResult = triangleCheck(sideA, sideB, sideC);

let perimeter = getperimeter(sideA, sideB, sideC);

let area = getArea(sideA,sideB,sideC);

let typeOfTriangle = triangleType(sideA,sideB,sideC);

alert(typeOfTriangle);

