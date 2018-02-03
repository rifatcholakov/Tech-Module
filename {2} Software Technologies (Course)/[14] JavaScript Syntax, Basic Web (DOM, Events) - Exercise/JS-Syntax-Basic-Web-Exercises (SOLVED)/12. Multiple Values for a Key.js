function multiplleValuesForAKey(arr) {
    arr = arr.filter(e => String(e).trim());

    let result = [];

    let searchKey = arr[arr.length - 1];

    for(let i = 0; i < arr.length - 1; i++) {
        let currentElement = arr[i].split(" ");

        if(currentElement[0] === searchKey) {
            result.push(currentElement[1]);

            var keyExist = true;
        }
    }

    if(keyExist) {
        result.forEach(value => console.log(value))
    } else {
        console.log("None");
    }
}