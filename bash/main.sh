#!/usr/bin/env bash
student_name_ru="Илья Сучков"
student_name_en="Ilya Suchkov"
student_number=21
group_name="М3О-119БВ-26"
language_name="Bash"

control_value=$((304 * student_number))
student_id=$(printf "%s/%02d" "$group_name" "$student_number")

echo "Hello to $control_value from $student_name_en, number $student_number, group $group_name!"
echo "Привет, $control_value! Это $student_name_ru, номер $student_number, группа $group_name!"
echo "Student ID: $student_id | Language: $language_name | Control: $control_value"

words=$(echo "$student_name_en" | wc -w | tr -d ' ')
echo "Words in student_name_en: $words"