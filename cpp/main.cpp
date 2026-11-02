#include <iostream>
#include <iomanip>
#include <string>

//добавляем std
using namespace std;

int main() {
    const string student_name_ru = "Илья Сучков";
    const string student_name_en = "Ilya Suchkov";
    int student_number = 21;
    const string group_name = "М3О-119БВ-26"; 
    const string language_name = "C++";

    const int base_value = 304;
    int control_value = base_value * student_number;

cout << "Hello to " << base_value << " from " << student_name_en
              << ", number " << student_number
              << ", group " << group_name << "!\n";
cout << "Привет, " << base_value << "! Это " << student_name_ru
              << ", номер " << student_number
              << ", группа " << group_name << "!\n";
cout << "Student ID: " << group_name << "/"
              << std::setw(2) << std::setfill('0') << student_number
              << " | Language: " << language_name
              << " | Control: " << control_value << "\n";
    return 0;
}