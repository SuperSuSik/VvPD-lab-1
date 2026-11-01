public class Main {
    public static void main(String[] args) {
        String studentNameRu = "Илья Сучков";
        String studentNameEn = "Ilya Suchkov";
        int studentNumber = 21;
        String groupName = "М3О-119БВ-26";
        String languageName = "Java";

        int controlValue = 304 * studentNumber;
        String studentId = String.format("%s/%02d", groupName, studentNumber);

        System.out.printf("Hello to %d from %s, number %d, group %s!%n",
                controlValue, studentNameEn, studentNumber, groupName);
        System.out.printf("Привет, %d! Это %s, номер %d, группа %s!%n",
                controlValue, studentNameRu, studentNumber, groupName);
        System.out.printf("Student ID: %s | Language: %s | Control: %d%n",
                studentId, languageName, controlValue);
    }
}