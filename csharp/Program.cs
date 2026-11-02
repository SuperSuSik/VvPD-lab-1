var studentNameRu = "Илья Сучков";
var studentNameEn = "Ilya Suchkov";
var studentNumber = 21;
var groupName = "М3О-119БВ-26";
var languageName = "C#";

var baseValue = 304;
var controlValue = baseValue * studentNumber;
var studentId = $"{groupName}/{studentNumber:D2}";

Console.WriteLine($"Hello to {baseValue} from {studentNameEn}, number {studentNumber}, group {groupName}!");
Console.WriteLine($"Привет, {baseValue}! Это {studentNameRu}, номер {studentNumber}, группа {groupName}!");
Console.WriteLine($"Student ID: {studentId} | Language: {languageName} | Control: {controlValue}");