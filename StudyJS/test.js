// getSideLength()


describe("getSideLength", function(){
    it("Get the numerical value of the side from user", function(){
        assert.typeOf(getSideLength('sideA'), 'number');
        assert.typeOf(getSideLength('sideB'), 'number');
        assert.typeOf(getSideLength('sideC'), 'number');
            assert
    });
});

// traingleCheck()

describe("triangleCheck", function(){
    it("Checks input values are a traingle or not", function(){
        assert.isTrue( triangleCheck(3, 3, 3), "traingle is an equailateral");
        assert.isTrue( triangleCheck(18, 30, 24), "Triangle is a scalene");
        assert.isFalse( triangleCheck(1, 23, 50000), "This does not work");
    });
});
// getPerimeter()

describe("perimeterCheck", function(){
    it("Adds each side together to form perimeter", function(){
        assert.equal( getPerimeter(2, 2, 2), 6);
        assert.equal( getPerimeter(3, 5, 2), 10);
        assert.equal( getPerimeter(60, 20, 20), 100);
    });
});
// getArea()

describe("areaCheck", function(){
    it("Adds each side together to form perimeter", function(){
        assert.equal( getArea(4, 5, 3), 6);
        assert.equal( getArea(5, 12, 13), 30);
        assert.equal( getArea(8, 15, 17), 60);
    });
});
// traingleType()
// clearResults()
// 
