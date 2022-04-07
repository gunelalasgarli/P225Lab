//task1

//===============================



//===============================

//task2

//===============================

function myCombination(str1) {
    var array1 = [];

    for (var x = 0, y = 1; x < str1.length; x++, y++) {
        array1[x] = str1.substring(x, y);
    }

    var combinations = [];
    var temp = "";
    var power = Math.pow(2, array1.length);

    for (var i = 0; i < power; i++) {
        temp = "";
        for (var j = 0; j < array1.length; j++) {

            if ((i & Math.pow(2, j))) {
                temp += array1[j];
            }

        }
        if (temp !== "") {
            combinations.push(temp);
        }
    }
    console.log(combinations.join("\n"));
}
myCombination("dog");


//#region Task1
// function myReverse(n) {
//     n = n + "";
//     return n.split("").reverse().join("");
// }
// console.log(Number(myReverse(71189)));
//#endregion

//===============================

//#region task 3
// function myAlphabet(str) {
//     return str.split('').sort().join('');
// }
// console.log(myAlphabet("webmaster"));

//#endregion    

//===============================

//#region task4
// function uppercase(str) {
//     var arr = str.split(' ');
//     var newarray = [];

//     for (var x = 0; x < arr.length; x++) {
//         newarray.push(arr[x].charAt(0).toUpperCase() + arr[x].slice(1));
//     }
//     return newarray.join(' ');
// }
// console.log(uppercase("code academy students"));
//#endregion    

//===============================


//#region task5
// function myChecker(a) {
//     if (a === 1) {
//         return false;
//     } else if (a === 2) {
//         return true;
//     } else {
//         for (var x = 2; x < a; x++) {
//             if (a % x === 0) {
//                 return false;
//             }
//         }
//         return true;
//     }
// }
// console.log(myChecker(38));
//#endregion    

//=======================================

//#region  by Eltac
//task2 
// const for4 = (x) => {
//     let arr = [];
//     for (let i = 0; i < x.length; i++) {
//         for (let j = 0; j < x.length + 1; j++) {
//             arr.push(x.slice(i, j));
//             console.log(arr);
//         }
//     }
// }
// for4("dog");
//#endregion