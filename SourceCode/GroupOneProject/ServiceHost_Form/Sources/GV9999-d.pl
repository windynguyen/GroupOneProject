domains
    state=state(symbol,symbol,symbol,symbol)
    /*state=state(monkey horizontal             monkey vertical,            box location,            has/has not banana)    */

predicates
    move(state,symbol,state)
    canget(state)

clauses
    move(state(middle,onbox,middle,hasnot),
    grasp,state(middle,onbox,middle,has)).

    move(state(P,onfloor,P,hasnot),climb,
    state(P,onbox,P,hasnot)).

    move(state(P,onfloor,P,hasnot),push,
    state(P1,onfloor,P1,hasnot)).

    move(state(P1,onfloor,B,hasnot),walk,
    state(P2,onfloor,B,hasnot)).

    canget(state(_,_,_,has)) :-
        write("get").

    canget(State1) :-
        move(State1,Move,State2),
        canget(State2),
        write(State2),nl.

goal
    clearwindow,
    canget(state(door,onfloor,window,hasnot)).
