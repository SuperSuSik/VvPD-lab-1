// Реализация F# выполнена в отдельной feature-ветке
let studentNameRu = "Илья Сучков"
let studentNameEn = "Ilya Suchkov"
let studentNumber = 21
let groupName = "М3О-119БВ-26"
let languageName = "F#"

let baseValue = 304
let controlValue = baseValue * studentNumber
let studentId = sprintf "%s/%02d" groupName studentNumber

printfn "Hello to %d from %s, number %d, group %s!" baseValue studentNameEn studentNumber groupName
printfn "Привет, %d! Это %s, номер %d, группа %s!" baseValue studentNameRu studentNumber groupName
printfn "Student ID: %s | Language: %s | Control: %d" studentId languageName controlValue

let totalLetters =
    studentNameEn.Split(' ')
    |> Array.map (fun w -> w.Length)
    |> Array.sum
printfn "Total letters in student_name_en: %d" totalLetters