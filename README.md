# Введение в профессиональную деятельность — Лабораторная работа №1

**ФИО:** Илья Сучков  
**Группа:** М3О-119БВ-26  
**Номер в списке:** 21

## Окружение

- ОС: macOS (Darwin), Apple Silicon
- Архитектура: `arm64` (AArch64)
- Git: `2.50.1`
- Кодировка исходных файлов: UTF-8

## Цель проекта

Продемонстрировать одну и ту же программу на 13 языках, показать разницу моделей выполнения и освоить базовый Git-процесс.

## Используемые языки

- C
- C++
- Python
- JavaScript
- TypeScript
- Java
- C#
- F#
- Go
- Rust
- Bash
- Prolog
- Assembler (AArch64)

## Инструменты и команды сборки/запуска

Все команды выполняются из корня репозитория.

| Язык | Версия инструмента | Команда сборки/запуска | Тип результата |
|---|---|---|---|
| C | Apple clang 21.0.0 (`gcc`) | `gcc -Wall -Wextra -pedantic c/main.c -o c/main && ./c/main` | native executable |
| C++ | Apple clang 21.0.0 (`g++`) | `g++ -Wall -Wextra -pedantic cpp/main.cpp -o cpp/main && ./cpp/main` | native executable |
| Python | Python 3.15.0 | `python3 python/main.py` | interpreted script |
| JavaScript | Node.js 26.12.1 | `node javascript/main.js` | interpreted script |
| TypeScript | TypeScript 7.0.2 | `tsc typescript/main.ts --outDir typescript/dist && node typescript/dist/main.js` | transpiled JavaScript |
| Java | javac 27.0.1.0.2 | `javac -d java java/Main.java && java -cp java Main` | JVM bytecode (`.class`) |
| C# | .NET SDK 10.0.403 | `dotnet run --project csharp/csharp.csproj` | .NET IL |
| F# | .NET SDK 10.0.403 | `dotnet run --project fsharp/fsharp.fsproj` | .NET IL |
| Go | Go 1.27.3 | `cd go && go run main.go` | native executable |
| Rust | rustc 1.99.1 | `rustc rust/main.rs -o rust/main && ./rust/main` | native executable |
| Bash | GNU bash 3.2.57 | `bash bash/main.sh` | interpreted script |
| Prolog | SWI-Prolog 10.0.2 | `swipl -q -s prolog/main.pl -g main -t halt` | interpreted script |
| Assembler | Apple clang 21.0.0 | `clang -c asm/assembler.s -o asm/assembler.o && clang asm/assembler.o -o asm/assembler && ./asm/assembler` | native executable |

## Пример ожидаемого вывода

Для всех реализаций, кроме assembler, вывод состоит из трёх строк. Поле `Language` меняется в зависимости от языка, остальные значения одинаковы.

```text
Hello to 304 from Ilya Suchkov, number 21, group М3О-119БВ-26!
Привет, 304! Это Илья Сучков, номер 21, группа М3О-119БВ-26!
Student ID: М3О-119БВ-26/21 | Language: C | Control: 6384
```

Assembler выводит только первую английскую строку:

```text
Hello to 304 from Ilya Suchkov, number 21, group M3O-119BV-26!
```

## Кириллица в C/C++

Исходные файлы `c/main.c` и `cpp/main.cpp` сохранены в UTF-8. На macOS терминал и используемые компиляторы работают с UTF-8 по умолчанию, поэтому дополнительных действий не требуется: строки `"Илья Сучков"` и `"М3О-119БВ-26"` выводятся корректно. В Windows при необходимости нужно включить UTF-8 в консоли: вызвать `SetConsoleCP(CP_UTF8)` и `SetConsoleOutputCP(CP_UTF8)` либо выполнить `chcp 65001`.

## Assembler

- ОС: macOS (Darwin)
- Архитектура: `arm64` (Apple Silicon, AArch64)
- Toolchain: Apple Clang 21.0.0, нативный AArch64 assembler
- Исходный файл: `asm/assembler.s`
- Сборка и запуск:

```bash
clang -c asm/assembler.s -o asm/assembler.o
clang asm/assembler.o -o asm/assembler
./asm/assembler
```

В соответствии с заданием assembler выводит только одну персонализированную английскую строку. Группа в ассемблерной строке записана латиницей: `M3O-119BV-26`.

## Структура проекта

```text
VPD_Lab01/
├── README.md
├── CHANGELOG.md
├── .gitignore
├── .gitattributes
├── asm/
├── bash/
├── c/
├── cpp/
├── csharp/
├── fsharp/
├── go/
├── java/
├── javascript/
├── prolog/
├── python/
├── rust/
└── typescript/
```

## Статус

Готово к сдаче.
Проверено коллегой.
