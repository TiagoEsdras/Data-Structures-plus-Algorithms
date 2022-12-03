// O(n)
function reverse1(str) {
    if(!str || str.length < 2 || typeof str !== 'string') 
        return 'Error: Parameter should have typeof equals to string and at least 2 characters'
        
    var strReversed = [];
    for(let i = str.length - 1; i >= 0; i--) {
        strReversed.push(str[i])
    }
    return strReversed.join('')
}
console.log(reverse1('Hi, my name is Tiago and Im from Brazil'))

function reverse2(str) {
    return str.split('').reverse().join('')
}
console.log(reverse2('Hi, my name is Tiago and Im from Brazil'))

const reverse3 = (str) => [...str].reverse().join('')
console.log(reverse3('Hi, my name is Tiago and Im from Brazil'))