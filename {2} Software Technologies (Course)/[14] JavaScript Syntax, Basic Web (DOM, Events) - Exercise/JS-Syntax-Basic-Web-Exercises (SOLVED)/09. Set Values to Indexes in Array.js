function setValuesToIndexesInArray(arr) {
    arr = arr.filter(Boolean);

    let arrLenght = Number(arr[0]);

    let result = [];

    for(let i = 0; i < arr.length - 1; i++) {
        result[i] = 0;
    }

    for(let i = 1; i < arr.length; i++) {
        let currentElement = arr[i].toString();

        let currentArray = currentElement.split(' ');

        let arrayIndex = Number(currentArray[0]);
        let arrayValue = Number(currentArray[2]);

        result[arrayIndex] = arrayValue;
    }

    for(let i = 0; i < arrLenght; i++) {
        console.log(result[i]);
    }
}