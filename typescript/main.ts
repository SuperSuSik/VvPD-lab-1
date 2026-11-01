interface Student {
    nameRu: string;
    nameEn: string;
    number: number;
    group: string;
    language: string;
}

const student: Student = {
    nameRu: "Илья Сучков",
    nameEn: "Ilya Suchkov",
    number: 21,
    group: "М3О-119БВ-26",
    language: "TypeScript"
};

const controlValue: number = 304 * student.number;
const studentId: string = `${student.group}/${String(student.number).padStart(2, '0')}`;

console.log(`Hello to ${controlValue} from ${student.nameEn}, number ${student.number}, group ${student.group}!`);
console.log(`Привет, ${controlValue}! Это ${student.nameRu}, номер ${student.number}, группа ${student.group}!`);
console.log(`Student ID: ${studentId} | Language: ${student.language} | Control: ${controlValue}`);