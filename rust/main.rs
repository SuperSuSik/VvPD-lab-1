fn main() {
    let student_name_ru = "Илья Сучков";
    let student_name_en = "Ilya Suchkov";
    let student_number: i32 = 21;
    let group_name = "М3О-119БВ-26";
    let language_name = "Rust";

    let base_value = 304;
    let control_value = base_value * student_number;
    let student_id = format!("{}/{:02}", group_name, student_number);

    println!("Hello to {} from {}, number {}, group {}!", base_value, student_name_en, student_number, group_name);
    println!("Привет, {}! Это {}, номер {}, группа {}!", base_value, student_name_ru, student_number, group_name);
    println!("Student ID: {} | Language: {} | Control: {}", student_id, language_name, control_value);
    
    println!("Student ID (separate line): {}", student_id);
}