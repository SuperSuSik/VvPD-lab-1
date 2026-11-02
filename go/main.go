package main

import "fmt"

func main() {
	studentNameRu := "Илья Сучков"
	studentNameEn := "Ilya Suchkov"
	studentNumber := 21
	groupName := "М3О-119БВ-26"
	languageName := "Go"

	baseValue := 304
	controlValue := baseValue * studentNumber
	studentID := fmt.Sprintf("%s/%02d", groupName, studentNumber)

	fmt.Printf("Hello to %d from %s, number %d, group %s!\n", baseValue, studentNameEn, studentNumber, groupName)
	fmt.Printf("Привет, %d! Это %s, номер %d, группа %s!\n", baseValue, studentNameRu, studentNumber, groupName)
	fmt.Printf("Student ID: %s | Language: %s | Control: %d\n", studentID, languageName, controlValue)
}
