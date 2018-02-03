function printLines(arr) {

    for(i = 0; i < arr.length - 1; i++) {
        if (arr[i] == "Stop") {
            return;
        } else {
            console.log(arr[i]);
        }
    }
}