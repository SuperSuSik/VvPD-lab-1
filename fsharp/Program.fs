let studentNameRu = "Илья Сучков"
let studentNameEn = "Ilya Suchkov"
let studentNumber = 21
let groupName = "МЗО-119БВ-26"
let languageName = "F#"

let controlValue = 304 * studentNumber
let studentId = sprintf "%s/%02d" groupName studentNumber

printfn "Hello to %d from %s, number %d, group %s!" controlValue studentNameEn studentNumber groupName
printfn "Привет, %d! Это %s, номер %d, группа %s!" controlValue studentNameRu studentNumber groupName
printfn "Student ID: %s | Language: %s | Control: %d" studentId languageName controlValue

let totalLetters =
    studentNameEn.Split(' ')
    |> Array.map (fun w -> w.Length)
    |> Array.sum
printfn "Total letters in student_name_en: %d" totalLetters