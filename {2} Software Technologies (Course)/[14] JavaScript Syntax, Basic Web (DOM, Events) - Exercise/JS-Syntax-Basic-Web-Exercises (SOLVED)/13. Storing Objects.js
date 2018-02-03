function sortingObjects(arr) {
    function parseStudent(str) {
        let tokens = str.split(' -> ');

        let [name, age, grade] = tokens.map(a => !isNaN(a) ? Number(a) : a);

        let obj = {name: name, age: age, grade: grade};
        return obj;
    }

    let students = arr.map(parseStudent);

    students.forEach(student => {
        let studentStr =
            `Name: ${student.name}\n` +
            `Age: ${student.age}\n` +
            `Grade: ${student.grade.toFixed(2)}`;

        console.log(studentStr);
    });
}