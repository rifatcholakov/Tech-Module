function largestThreeNumbers(arr) {
    arr = arr
        .filter(entry => entry.trim()!= '')
        .map(Number)
        .sort(function(a, b){return b-a});

    if (arr.length < 3) {
        for (let i = 0; i < arr.length; i++) {
            console.log(arr[i]);
        }
    } else {
        console.log(arr[0] + "\r\n" + arr[1] + "\r\n" + arr[2]);
    }
}