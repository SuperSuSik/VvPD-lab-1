student_name_ru = "Илья Сучков"
student_name_en = "Ilya Suchkov"
student_number = 21
group_name = "МЗО-119БВ-26"
language_name = "Python"

control_value = 304 * student_number
student_id = f"{group_name}/{student_number:02d}"

print(f"Hello to {control_value} from {student_name_en}, number {student_number}, group {group_name}!")
print(f"Привет, {control_value}! Это {student_name_ru}, номер {student_number}, группа {group_name}!")
print(f"Student ID: {student_id} | Language: {language_name} | Control: {control_value}")

# Визитная карточка Python (f-строки и встроенные функции)
print(f"Words in student_name_en: {len(student_name_en.split())}")