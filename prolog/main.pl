student('Илья Сучков', 'Ilya Suchkov', 21, 'М3О-119БВ-26').

control_value(N) :- student(_, _, N, _).

main :-
    student(NameRu, NameEn, Number, Group),
    control_value(Control),
    ( Number < 10 -> format(atom(IdNum), "0~w", [Number])
    ; format(atom(IdNum), "~w", [Number]) ),
    format(atom(StudentId), "~w/~w", [Group, IdNum]),
    format("Hello to ~w from ~w, number ~w, group ~w!~n", [Control, NameEn, Number, Group]),
    format("Привет, ~w! Это ~w, номер ~w, группа ~w!~n", [Control, NameRu, Number, Group]),
    format("Student ID: ~w | Language: Prolog | Control: ~w~n", [StudentId, Control]).