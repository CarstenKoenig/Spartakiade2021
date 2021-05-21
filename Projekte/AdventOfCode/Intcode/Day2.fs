module Day2.Intcode

/// Ein Wert/Zahl im Programm oder Speicher
type Value =
    int
    
/// Ein Programm ist eine Auflistung von Values
type Program =
    Program of Value seq

/// liest einen String von, durch ',' getrennte Values in ein Programm
let parse (input : string) : Program =
    failwith "todo"

/// Addresse/Index für den Speicher (0-basierend)
type Address =
    int
    
/// addressierbarer Speicher
type Memory =
    | Memory of Map<Address, Value>
    /// liefert gleiches Format wie aus der Puzzlebeschreibung
    /// ("Value,Value,Value,...,Value")
    override this.ToString() =
        match this with
        | Memory m ->
            m
            |> Seq.map (fun kvp -> kvp.Value)
            |> Seq.map string
            |> fun s -> System.String.Join(",", s)
    
/// initialisiert Speicher aus einem Program
// let initMemory (Program value) : Memory =
let initMemory program : Memory =
    failwith "todo"

/// liest den Inhalt des Speichers an der gegebenen Addresse
/// wirft eine Exception falls die Addresse ungültig ist
let readAt adr memory =
    failwith "todo"
    
/// liefert eine Speicher-Kopie die an 'adr' den Wert 'value' enthält
let writeTo adr value memory =
    failwith "todo"
 
/// unterstützes Befehlsset
type OpCode =
    | OpAdd of addressFirstOperand:Address * addressSecondOperand:Address * addressOutput:Address
    | OpMul of addressFirstOperand:Address * addressSecondOperand:Address * addressOutput:Address
    | OpHalt

/// liest einen Opcode ab 'adr' aus dem Speicher
/// wirft Exceptions wenn das nicht möglich ist
let getOpCodeAt (adr : Address) (memory : Memory) : OpCode =
    failwith "todo"

/// wieviel Speicher-Zellen besetzt der übergebene 'opcode'?
let opCodeLen (opcode : OpCode) : int =
    failwith "todo"
        
/// verarbeitet 'opcode'
/// bei 'OpHalt' wird einfach 'None' geliefert sonst
/// wird eine Kopie von 'memory' geliefert die durch das Ausführen von 'opcode' entsteht
let executeOpcode (opcode : OpCode) (memory : Memory) : Memory option =
    failwith "todo"
        
/// an welcher Stelle im Speicher soll der nächste Opcode/Befehl gelesen werden
type InstructionPointer =
    Address

/// ein Verarbeitungsschritt:
/// liest den OpCode an Addresse 'ip' und wendet
/// diesen auf 'memory' an - liefert 'None' falls
/// es ein 'Halt' war oder 'Some (neueIp, neuerMemory)'
/// fertig für den nächsten Step
let step (ip : InstructionPointer, memory : Memory)
    : (InstructionPointer * Memory) option =
    failwith "todo"

/// führt 'step' bis zum halt durch und liefert
/// den letzten Speicher-Zustand davor
let eval (memory : Memory) : Memory =
    failwith "todo"
