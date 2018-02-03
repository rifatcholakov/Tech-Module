function capitalCaseWords(arr) {
    let firstPattern = new RegExp("[^\\w]+");
    let secondPattern = new RegExp("\\b[A-Z]+\\b");

    arr = arr.join(" ").split(firstPattern);

    let result = [];

    for(let i = 0; i < arr.length; i++) {
        if(arr[i].match(secondPattern)) {
            result.push(arr[i]);
        }
    }

    console.log(result.join(", "));
}