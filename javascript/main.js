const student_name_ru = "Илья Сучков";
const student_name_en = "Ilya Suchkov";
const student_number = 21;
const group_name = "МЗО-119БВ-26";
const language_name = "JavaScript";

const control_value = 304 * student_number;
const student_id = `${group_name}/${String(student_number).padStart(2, '0')}`;

console.log(`Hello to ${control_value} from ${student_name_en}, number ${student_number}, group ${group_name}!`);
console.log(`Привет, ${control_value}! Это ${student_name_ru}, номер ${student_number}, группа ${group_name}!`);
console.log(`Student ID: ${student_id} | Language: ${language_name} | Control: ${control_value}`);

console.log(`Length of student_name_en: ${student_name_en.length}`);