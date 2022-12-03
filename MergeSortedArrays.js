function mergeSortedArrays(arr1, arr2) {
    let arr1Length = arr1?.length
    let arr2Length = arr2?.length

    if(!arr1 || !arr2 || (arr1Length === 0 && arr2Length === 0))
        return 'Error: Paramenters invalid'
    if(arr1Length === 0)
        return arr2
    if(arr2Length === 0)
        return arr1

    let i = 0
    let j = 0
    let arr1Item = arr1[i]
    let arr2Item = arr2[j]
    const newArr = []

    while(arr1Item || arr2Item) {
        if(arr1Item < arr2Item || !arr2Item) {
            newArr.push(arr1Item)
            i++
            arr1Item = arr1[i]
        } else {
            newArr.push(arr2Item)
            j++
            arr2Item = arr2[j]
        }
    }

    return newArr  
}

console.log(mergeSortedArrays([1, 3, 8], [-5, 8, 17, 26, 34, 48]))
