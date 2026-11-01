package main

import "fmt"

func main() {
	studentNameRu := "Илья Сучков"
	studentNameEn := "Ilya Suchkov"
	studentNumber := 21
	groupName := "М3О-119БВ-26"
	languageName := "Go"

	controlValue := 304 * studentNumber
	studentID := fmt.Sprintf("%s/%02d", groupName, studentNumber)

	fmt.Printf("Hello to %d from %s, number %d, group %s!\n", controlValue, studentNameEn, studentNumber, groupName)
	fmt.Printf("Привет, %d! Это %s, номер %d, группа %s!\n", controlValue, studentNameRu, studentNumber, groupName)
	fmt.Printf("Student ID: %s | Language: %s | Control: %d\n", studentID, languageName, controlValue)
}
