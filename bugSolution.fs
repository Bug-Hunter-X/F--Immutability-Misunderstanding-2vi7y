let x = 10

let addOne x = x + 1

let y = addOne x

printfn "%d" y // Output: 11

//Alternatively, using mutable variables:

let mutable xMutable = 10

let addOneMutable x = x <- x + 1

let mutable yMutable = xMutable

addOneMutable xMutable

printfn "%d" xMutable // Output: 11
printfn "%d" yMutable // Output: 10