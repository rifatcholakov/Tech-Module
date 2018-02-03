function AddAndRemoveElements(arr) {

    result = [];

    for(let i = 0; i < arr.length; i++) {
        let currentElement = arr[i].split(" ");

        switch (currentElement[0]) {
            case "add":
                result.push(currentElement[1]);
                break;

            case "remove":
                result.splice(currentElement[1], 1);
                break;
        }
    }

    for (let i = 0; i < result.length; i++) {
        console.log(result[i]);
    }
}