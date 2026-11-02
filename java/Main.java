public class Main {
    public static void main(String[] args) {
        String studentNameRu = "Илья Сучков";
        String studentNameEn = "Ilya Suchkov";
        int studentNumber = 21;
        String groupName = "М3О-119БВ-26";
        String languageName = "Java";

        int baseValue = 304;
        int controlValue = baseValue * studentNumber;
        String studentId = String.format("%s/%02d", groupName, studentNumber);

        System.out.printf("Hello to %d from %s, number %d, group %s!%n",
                baseValue, studentNameEn, studentNumber, groupName);
        System.out.printf("Привет, %d! Это %s, номер %d, группа %s!%n",
                baseValue, studentNameRu, studentNumber, groupName);
        System.out.printf("Student ID: %s | Language: %s | Control: %d%n",
                studentId, languageName, controlValue);
    }
}