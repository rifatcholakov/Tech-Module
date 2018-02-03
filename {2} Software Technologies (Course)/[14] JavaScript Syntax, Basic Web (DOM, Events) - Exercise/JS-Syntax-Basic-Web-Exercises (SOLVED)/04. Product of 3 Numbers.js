function productOfThreeNumbers(arr) {
    arr = arr
        .filter(entry => entry.trim() != '')
        .map(Number)
        .filter(num => num > 0)
        .length;

    if(arr === 2) {
        console.log("Negative");
    } else {
        console.log("Positive");
    }
}