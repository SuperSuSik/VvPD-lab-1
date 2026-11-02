student('Илья Сучков', 'Ilya Suchkov', 21, 'М3О-119БВ-26').

base_value(304).

control_value(Control) :- student(_, _, N, _), Control is 304 * N.

main :-
    student(NameRu, NameEn, Number, Group),
    base_value(Base),
    control_value(Control),
    ( Number < 10 -> format(atom(IdNum), "0~w", [Number])
    ; format(atom(IdNum), "~w", [Number]) ),
    format(atom(StudentId), "~w/~w", [Group, IdNum]),
    format("Hello to ~w from ~w, number ~w, group ~w!~n", [Base, NameEn, Number, Group]),
    format("Привет, ~w! Это ~w, номер ~w, группа ~w!~n", [Base, NameRu, Number, Group]),
    format("Student ID: ~w | Language: Prolog | Control: ~w~n", [StudentId, Control]).