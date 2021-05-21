(*

                                      WW
                                    WW  WW                                      
                                  WNO0WNXKKNW                                   
                                WNOdlkWNKOdkKNW                                 
                              WNOdlclkWNKOdddk0NW                               
                            WNOdlccclkWNKOdddddk0NW                             
                          WXOdlccccclkWNKkdddddddx0NW                           
                        WNOdlccccccclkNNKOdddddddddx0XW                         
                       NOdlccccccccclkNNKOdddddddddddx0XW                       
                    WNOdlccccccccccclkWNKOdddddddddddddxOXW                     
                  WNOdlcccccccccccccoOWNX0dddddddddddddddxOXW                   
                WNOdlccccccccccccclxKW  WNKkdddddddddddddddxOXW                 
              WNOdlccccccccccccclxKW       WKkdddddddddddddddxOXW               
            WNOdlccccccccccccclxKW WKXW      NKkdddddddddddddddxOKW             
          WXOdlccccccccccccclxKW WKxokW        NKkdddddddddddddddxkKN           
        WNOdlccccccccccccclxKW WKxlclkW          NKkddddddddddddddddkKN         
      WNOdlccccccccccccclxKW WKxlccclkW            NKkddddddddddddddddkKN       
    WNOdlccccccccccccclxKW WKxlccccclkW              WKkddddddddddddddddkKN     
  WXOdlccccccccccccclxKW WKxlccccccclkW                NKkddddddddddddddddk0NW  
  NOlcccccccccccccclxX  WKdlcccccccclkW                 WXkddddddddddddddddx0W  
   N0dlcccccccccccccld0N WXkoccccccclkW               WN0kddddddddddddddddkKN
     N0dlcccccccccccccld0N WXkoccccclkW              N0kdddddddddddddddxOKW
       N0dlcccccccccccccld0N WXkoccclkW            N0kdddddddddddddddxOXW
         N0dlcccccccccccccld0N WXkoclkW          N0kdddddddddddddddxOXW
           N0dlcccccccccccccld0NWWXkokW        N0kdddddddddddddddxOXW
            WN0dlcccccccccccccld0N WXXW     WN0kdddddddddddddddxOXW
               N0dlccccccccccccclx0N      WN0kdddddddddddddddx0XW
                 N0dlcccccccccccccld0N  WN0kdddddddddddddddx0XW
                   N0dlccccccccccccclOWNXOdddddddddddddddx0NW
                     N0dlccccccccccclkWNKOdddddddddddddk0NW
                       N0dlccccccccclkWNKOdddddddddddk0NW
                         N0dlccccccclkNNKOdddddddddkKNW
                           N0dlccccclkWNKOdddddddkKN
                            WN0dlccclkWNKOdddddkKNW
                               N0dlclkWNXOdddkKW
                                 N0dlkWNKOxOKW
                                   N0KWWXKXW
                                     WwW

## Organisatorisches

- Dauer **9:00** bis **17:00**
- Mittagspause **12:30** bis **13:30**
- Bitte keine Screenshots/Bilder der Teilnehmer auf Social Media teilen - danke!

## Agenda

- Tools / Editor
- Werte, Typen und Funktionen
- Strukturen und Patternmatching
- Projekt "wir schreiben einen IntCode Interpreter" ([AoC 2019 - Tag 2 ff](https://adventofcode.com/2019/day/2))
- Klassen und Interfaces (optional)

*)

1+1

let zahl = 1

// veränderliche Variable
let mutable variable = 1
variable <- 2

let text = "String"
let zeichen = 'c'
let dezimal = 2.3
let fliesskomma = 2.2

// Typ - Synonym
type Name = string
// using Name = System.String

type Mit<'a> = 'a
type 'a Mit2 = 'a

// Unit
let unitWert = ()
// entspricht C# void
// oder Funktion ohne Parmeter

let sagNameLambda = fun name -> "Hallo " + name

let sagName (name : Name) : string = 
  "Hallo " + name

let verdopple x = x + x

verdopple 5 + 5

let jetztIst = sagName (System.DateTime.Now.ToString())

let f x =
  let plus5 y = y+5
  verdopple (plus5 x)

// Equational Reasoning
(*
  f x
  = { Definition von f }
  verdopple (plus5 x)
  = { Defition von plus 5}
  verdopple (x + 5)
  = { Definition von verdopple }
  let y = x+5 in y+y
  = { einsetzen }
  (x+5) + (x+5)
  = { Mathe }
  = 2*x + 10
*)

// : int -> int -> int = int -> (int -> int)
let plus x y = x + y

let plusAlt (x,y) = x + y

// partial application
let plus5 = plus 5

// Pipe-Operator
13
|> plus 7
|> plus5

// Funktions-Komposition
let plus10 x = x |> plus5 |> plus5
let plus10comp = plus5 >> plus5
// Varianten
// <|, <<, <<|

// 4! = 4*3*2*1
// | n <= 1 = 1
// | sonst = n * (n-1)!

let rec fact n =
  if n <= 1 then 1 else
  n * fact (n-1)

// TUPEL

// : int * string * float
// warum *:
// Bool * Bool = (false, false), (false, true), (true, false), (true, true)
let tupel = 5, "Hallo", 4.4

let (x, y, z) = tupel

match tupel with
| (5, y, _) -> "Ok"
| _ -> "nicht Ok"

let textVonTupel tupel =
  match tupel with
  | (0, _, _) -> "war null"
  | (_, text, _) -> text

let textVonTupel' =
  function
  | (0, _, _) -> "war null"
  | (_, text, _) -> text


// first = fst / first (a,b) = a
let first (a,_) = a

// : ('a*'b -> 'c) -> ('a -> 'b -> 'c)
// (curry (fun (a,b) -> a+b)) 5 6 = 11
let curry (f : 'a * 'b -> 'c) a b =
  f (a, b)

let join (trenner, elemente : string seq) = System.String.Join (trenner, elemente)

let joinWithKomma x = (curry join) ", " x
   
// LISTEN

let liste1 = [1; 2; 5; 10]
let liste2 = [1..2..5]

let leereListe = [] // List.empty
let liste1Cons = 1 :: (2 :: (5 :: (10 :: [])))
let neueListe = 0 :: liste1Cons
// Einfach Verkette List (Element, Zeiger auf Restliste) oder []

let tail ls =
  match ls with
  | [] -> failwith "Tail von leere Liste geht nicht"
  | (_::tl) -> tl

// List.map : ('a -> 'b) -> ('a list -> 'b list)

let rec map (f : 'a -> 'b) (xs : 'a list) =
  match xs with
  | [] -> []
  | (h::tl) -> f h :: map f tl

// List.filter : ('a -> bool) -> 'a list -> 'a list
let rec filter (p : 'a -> bool) (xs : 'a list) =
  match xs with
  | []               -> []
  | (h::tl) when p h -> h :: filter p tl
  | (_::tl)          -> filter p tl

let summe xs = List.fold (fun acc x -> acc+x) 0 xs

// Mittagspause bis ca. 13:20 - Mahlzeit ;)

type Tuple1 = int * bool

// Union-Types / algebraische Datentypen
type Farbe = Rot | Gruen | Blau | Gelb

let blau = Blau

let farbName farbe =
  match farbe with
  | Rot -> "rot"
  | Blau -> "blau"
  | Gruen -> "grün"
  | Gelb -> "gelb"

type UnionT =
  | Zahl of int
  | Bruch of nenner:int * zaehler:int
  | Text of string

let beispiel = Zahl 5
let beispiel2 = Text "Hallo"

let unionName wert =
  match wert with
  | Zahl n -> string n
  | Text s -> s
  | Bruch (n, z) -> string z + "/" + string n

// Erinnerung
// type Name = string
// Value-Type ganz einfach:
type Name2 = Name2 of string

type MeineListe<'a> =
  | Nil // []
  | Cons of h:'a * t:MeineListe<'a> // h :: t

type MeineOption<'a> =
  | MeinNone
  | MeinSome of 'a

// in F#
// 'a option

let option1 = Some 5
let option2 : int option = None

// Map
let test1 = option1 |> Option.map (fun x -> x*2)
let test2 = option2 |> Option.map (fun x -> x*2)

// Defauft
let test3 = option2 |> Option.defaultValue 0

// Result
// Railroad - oriented - Programming
let ok1 : Result<string, exn> = Ok "passt"
let err1 : Result<string, exn> = Error (exn "Fehler")

// 3 * (4+5)
// Mal (Zahl 3, Plus (Zahl 4, Zahl 5))

type Expr =
  | Zahl of int
  | Mal of Expr * Expr
  | Plus of Expr * Expr
  member this.Value =
    match this with
    | Zahl n -> n
    | Mal (links, rechts) -> links.Value * rechts.Value
    | Plus (links, rechts) -> links.Value + rechts.Value
  override this.ToString() =
    match this with
    | Zahl n -> string n
    | Mal (links, rechts) -> "(" + links.ToString() + ") * (" + rechts.ToString() + ")"
    | Plus (links, rechts) -> "(" + links.ToString() + ") + (" + rechts.ToString() + ")"


// eval (Zahl 3, Plus (Zahl 4, Zahl 5)) = 27
let rec eval (expr : Expr) : int =
  match expr with
  | Zahl n -> n
  | Mal (links, rechts) -> eval links * eval rechts
  | Plus (links, rechts) -> eval links + eval rechts

// Einschub gegenseitig-rekursiv
let rec isEven n =
  if n = 0 then true else isOdd (n-1)
and isOdd n =
  if n = 0 then false else isEven (n-1)

// Records

type Person =
  { 
    name : string
    alter : int
  }
  override this.ToString() =
    sprintf "%s ist %d Jahre alt" this.name this.alter
  member this.SetzeAlter neuesAlter =
    { this with alter = neuesAlter }

type Person2 =
  { 
    name : string
    vorname : string
    alter : int
  }

let carsten =
  {
    name = "Carsten"
    alter = 41
  }

let c2 : Person = carsten

let setzeAlter person neuesAlter =
  // Record-Update Syntax
  { person with alter = neuesAlter }

// Klassen und Interfaces

type ISchnittstelle =
  abstract AddTo : zahl:int -> int

//                  v argumente für Primär-Konstruktor
type PersonenKlasse(name : string, alter : int) = // optional as this =
  // Vererbung:
  // inherit BasisKlasse ()
  // ... Code für Konstruktor
  // let / do
  let begruessung = sprintf "Hallo %s" name
  let mutable zahl = 0

  do
    System.Console.WriteLine begruessung

  // Member-Bereich
  
  // alternativ Konstruktor
  new (name) =
    System.Console.WriteLine "Alt. Konstruktor"
    new PersonenKlasse (name, 21)

  override this.ToString() = this.Name
  member _.Name = name
  member _.Alter = alter
  member _.Begruesse() = 
    System.Console.WriteLine begruessung
  // Getter/Setter
  member _.Zahl 
    with get () = zahl
    and set value = zahl <- value
  
  member this.AddTo zahl = zahl + this.Zahl 

  // Interface ISchnittstelle implementiert
  interface ISchnittstelle with
    member this.AddTo zahl = this.AddTo zahl

// gibt annonymes Objekt zurück das die Schnittstelle implementiert
let beispielSchnittstelle delta =
  { new ISchnittstelle with
    member _.AddTo zahl = zahl + delta
  }

let sleep (dauer : int) =
  async {
    System.Console.WriteLine "1"
    do! Async.Sleep dauer
    let! result = async { return 5 }
    System.Console.WriteLine "2"
    return 5
  }

// F#-Plus - fortgeschrittenes FP mit F#
// https://github.com/fsprojects/FSharpPlus/


// poor mans Dependency Injection
type MitDependency (dep) =
  member _.f x = dep x

// Größeres Projekt?
// https://write-yourself-a-scheme.pangwa.com/#/

