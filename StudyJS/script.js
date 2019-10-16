"use strict";
/* modern mode activated */


/*Infinite loop forces the user to keep inputting an answer until break condition is met */
function getSideLength(sideName)
{

    let sideValue;
    sideValue = document.getElementById(sideName).value;
    sideValue = Number(sideValue);
    return sideValue;
}

/* This function checks if the 3 lengths make a triangle or not by checking if the sum of 2 sides is greater than the third */
function triangleCheck(sideA, sideB, sideC)
{
    sideA = Number(sideA);
    sideB = Number(sideB);
    sideC = Number(sideC);

    if(sideA + sideB <= sideC)
    {
        return false;
    }

    if(sideB + sideC <= sideA)
    {
        return false;
    }

    if(sideC + sideA <= sideB)
    {
        return false;
    }

    return true;
}

function getPerimeter(sideA, sideB, sideC)
{
    let perimeter = sideA + sideB + sideC;

    return perimeter;
}

function getArea(sideA,sideB,sideC)
{
    let halfperimeter = getPerimeter(sideA,sideB,sideC)/2;

    /*Area calculated using herons formula */
    let area = (halfperimeter*(halfperimeter - sideA) * (halfperimeter-sideB) * (halfperimeter-sideC)) ** 0.5;

    return area;
}

/* This function simply checks what type of traingle is inputted by checking each sides against one another*/ 
function triangleType(sideA,sideB,sideC)
{
    if (sideA == sideB && sideA == sideC && sideC == sideB)
    {
        return "Equilateral";
    }

    if (sideA != sideB && sideB != sideC && sideC != sideA)
    {
        return "Scalene";
    }

    return "Isosceles";
}

function clearResults()
{
    // this clears the input fields and results from any previous uses of application
    document.getElementById("sideA").value = 0;
    document.getElementById("sideB").value =0;
    document.getElementById("sideC").value = 0;
    document.getElementById("type").innerHTML = "";
    document.getElementById("area").innerHTML = "";
    document.getElementById("perimeter").innerHTML = "";
    document.getElementById("fail").innerHTML = "";
}



function main()
{
    /* Get the length of each side */ 
    let sideA = getSideLength("sideA");
    let sideB = getSideLength("sideB");
    let sideC = getSideLength("sideC");

    /* this calculates each bit of information needed */
    let checkResult = triangleCheck(sideA, sideB, sideC);
    let perimeter = getPerimeter(sideA, sideB, sideC);
    let area = getArea(sideA,sideB,sideC);
    let typeOfTriangle = triangleType(sideA,sideB,sideC);

    /* This updates the labels in the html file to display the area, type and perimeter*/
    if(checkResult)
    {
        clearResults();
        document.getElementById("type").innerHTML = typeOfTriangle;
        document.getElementById("area").innerHTML = area;
        document.getElementById("perimeter").innerHTML = perimeter;
        
        
    }else
    {
        clearResults();
        document.getElementById("fail").innerHTML = "Input Is Not A Triangle";
    }
}

