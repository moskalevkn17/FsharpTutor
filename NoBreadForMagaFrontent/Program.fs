// For more information see https://aka.ms/fsharp-console-apps


let giveBags(b1, b2, b3) =
    let sum = b1 + b2 + b3
    if sum % 2 <> 0 then failwith "Sum should be even!"
    printfn "Given a 3 bags (%d, %d, %d) with a sum of %d;" b1 b2 b3 sum
    (b1, b2, b3, sum)

let findOdds(b1, b2, b3 : int) = 
    if b1 % 2 <> 0 then (b1+1, b2, b3)
    elif b2 % 2 <> 0 then (b1, b2+1, b3)
    else (b1, b2, b3)

let splitCandies(b1, b2, b3) = (b1/2, b2/2, b3/2)

let sum3(a, b, c) = a+b+c

let aliceTakeCandies(b1, b2, b3, sum) =
    let took = findOdds (b1, b2, b3) |> splitCandies 
    let tookSum = sum3 took
    if tookSum * 2 <> sum then failwith "You aint took the half of candies!"
    let bt1, bt2, bt3 = took
    printfn "Alice took a %d (half) of candies (%d, %d, %d)" tookSum bt1 bt2 bt3

let candyDiv = giveBags >> aliceTakeCandies

candyDiv (30, 5, 7)
candyDiv (10, 10, 10)
candyDiv (5, 11, 24)
candyDiv (1, 2, 19)

let r = 162
let g = 147
let b = 142


//printfn "%A" (Array.filter (fun elem -> elem % 2 = 0) [| 1 .. 10|])


//let sortByColor (colors:string, numbers, color) = Array.filter (fun (_,i) -> colors[i] = color) numbers

//let sortCards (colors:string, numbers) =
//    let reds = sortByColor (colors, numbers, 'r')
//    let greens = sortByColor (colors, numbers, 'g')
//    let blues = sortByColor (colors, numbers, 'b')
//    Array.concat [reds; greens; blues]
//let swap (a: char byref) (b: char byref) =
//    let c = a
//    a <- b
//    b <- c

//let sertCards (colors:string) (numbers:int[]) =
//    let mutable r = 0
//    let mutable b = numbers.Length - 1
//    for i = 0 to numbers.Length - 1 do
        
//        if colors[i] = 'r' then 
//            swap (ref colors[r]) colors[i]
//        elif colors[i] = 'b' then swap 2 1

        

//let cardsSorting (colors:string) (numbers:int[]) :int[] =
//    if colors.Length <> numbers.Length then failwith "They have different length!"
//    printfn "Given cards with colors %s and numbers %s" colors (numbers.ToString ())
//    let output = sortCards (colors, numbers)
//    printfn "After sort, numbers are %s" (output.ToString ())

//cardsSorting "rgbgbbggrbbr" [|3; 5; 7; 8; 1; 6; 3; 5; 17; 1; -1; 29;|]
        
        
        

        

