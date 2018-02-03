function WorkingWithKeyValuePairs(arr) {
    arr = arr.filter(e => String(e).trim());

    let result = [];

    for(let i = 0; i < arr.length; i++) {
        let currentElement = arr[i].split(" ");

        let key = currentElement[0];

        if(currentElement.length > 1) {
            let value = currentElement[1];

            result[key] = value;
        } else {
            var keyToPrint = key;
        }
    }

    if(result[keyToPrint] != undefined) {
        console.log(result[keyToPrint]);
    } else {
        console.log("None");
    }
}