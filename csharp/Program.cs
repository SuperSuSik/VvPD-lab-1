var studentNameRu = "Илья Сучков";
var studentNameEn = "Ilya Suchkov";
var studentNumber = 21;
var groupName = "М3О-119БВ-26";
var languageName = "C#";

var controlValue = 304 * studentNumber;
var studentId = $"{groupName}/{studentNumber:D2}";

Console.WriteLine($"Hello to {controlValue} from {studentNameEn}, number {studentNumber}, group {groupName}!");
Console.WriteLine($"Привет, {controlValue}! Это {studentNameRu}, номер {studentNumber}, группа {groupName}!");
Console.WriteLine($"Student ID: {studentId} | Language: {languageName} | Control: {controlValue}");