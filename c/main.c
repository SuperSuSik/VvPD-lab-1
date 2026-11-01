#include <stdio.h>

int main(void) {
    const char *student_name_ru = "Илья Сучков";
    const char *student_name_en = "Ilya Suchkov";
    int student_number = 21;
    const char *group_name = "МЗО-119БВ-26"; 
    const char *language_name = "C";

    int control_value = 304 * student_number;

    printf("Hello to %d from %s, number %d, group %s!\n",
           control_value, student_name_en, student_number, group_name);
    printf("Привет, %d! Это %s, номер %d, группа %s!\n",
           control_value, student_name_ru, student_number, group_name);
    printf("Student ID: %s/%02d | Language: %s | Control: %d\n",
           group_name, student_number, language_name, control_value);
    return 0;
}