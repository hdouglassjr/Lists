let cards = [ 1..5 ]
List.iter (fun i -> printf "%i " i) cards
printfn ""

for i in cards do
    printfn "%i " i

type person = { FirstName: string; LastName: string }

let people =
    [ { FirstName = "Albert"
        LastName = "Einstein" }
      { FirstName = "Marie"
        LastName = "Curie" } ]

let noblePrizeWinners =
    List.map (fun person -> person.FirstName + " " + person.LastName) people

printfn "%A" noblePrizeWinners

let cards2 = [ 1..5 ]
let filteredList = List.filter (fun i -> i % 2 = 0) cards2
List.iter (fun x -> printfn "%i" x) filteredList

let list = [ 2; 1; 5; 3 ]
let sortedList = List.sort list // or List.sort(list)
List.iter (fun x -> printfn "%i" x) sortedList

