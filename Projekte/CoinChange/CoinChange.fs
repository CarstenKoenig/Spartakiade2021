module CoinChange.Solution

type Coin = int

let coins =
    [1; 2; 5; 10; 20; 50; 100; 200]
    |> List.rev
    
let rec wechsle (rueckgabe : Coin list) (muenzVorrat : Coin list) (restBetrag : int) : Coin list =
    // TODO
    List.empty
        

let change (amount : int) : Coin seq =
  wechsle [] coins amount
  |> List.toSeq

