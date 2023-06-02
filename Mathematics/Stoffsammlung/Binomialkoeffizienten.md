# Binomialkoeffizienten
## Einführung
Betrachten wir ein kleines Experiment: Ein Besucher eines Volksfests versucht sich im Dosenwerfen. Ihm sind zehn Versuche erlaubt. Wenn er dreimal trifft, bekommt er einen schönen Preis.

Er möchte nun wissen: "Wieviele Möglichkeiten habe ich, dreimal zu treffen?"

Okay...
Beim ersten Wurf könnte er die Dosen mit einer Wahrscheinlichkeit von...? haben wir doch gar nicht???

Stopp. Die Wahrscheinlichkeit ist egal. Gefragt ist doch nur, wieviele Möglichkeiten es gibt.

1. Möglichkeit: TTTTTTTNNN
2. Möglichkeit: TTTTTNTTNN
usw.

Puh, da wird einem schnell der Bleistift stumpf&hellip;

Lasst es uns anders angehen.
Auf dem Zettel für seinen Wurfverlauf steht zu Beginn:

![10 Striche](https://github.com/DGrothe-PhD/lerntools/blob/main/Mathematics/Stoffsammlung/assets/10Striche.png)

Und am Ende der Runde hat das erste N auf einem der zehn Striche zu stehen, das zweite N auf einem der übrigen neun, das dritte N auf einem der restlichen acht.
Das ergibt dann:
$$10\cdot 9\cdot 8$$
Und wenn nun das erste N auf dem zweiten Strich steht und das zweite N auf dem ersten, woher weiß ich dann, welches wo steht, ich meine, es könnte doch glatt so gewesen sein, dass das zweite N auf dem zweiten Strich steht und das erste N auf dem ersten?

Okay.  Wir müssen also sechs verschiedene Ausgänge als identisch bewerten.
$$\tag{1}\frac{10\cdot 9\cdot 8}{6}$$
Und, ja, was, fragt Fritz aus der hintersten Reihe, der Streber... Die übrigen sieben Treffer könnten ja auch ihre Plätze getauscht haben...

$$\tag{2}\LARGE\ \ \ \frac{10\cdot 9\cdot 8}{6}\cdot \frac{7\cdot 6\cdot 5\cdot 4\cdot 3\cdot 2\cdot 1}{7\cdot 6\cdot 5\cdot 4\cdot 3\cdot 2\cdot 1}$$


Ist doch egal&hellip; kürzt sich sowieso wieder raus.

Wir haben hier die gleiche Situation wie beim abgeänderten Lottospiel:

Wir haben zehn Zahlenfelder und kreuzen drei davon an. Dann wird gelost und man bekommt zu erfahren, ob man richtig getippt hat.

Wir dürfen unsere Formel von da oben, die ich nun mit Nummer 2 kennzeichnete, etwas anders schreiben: Mit der *Fakultät*. Schreibt man hinter eine natürliche Zahl ein Ausrufezeichen, so spricht man das als "n Fakultät"... und das bedeutet: Multipliziere die Zahl n mit all ihren Vorgängern (n-1), (n-2) usw. bis herunter zur Eins. Damit schreibt sich jetzt Formel (1) als:
$$\tag{3} \frac{10!}{3! \cdot 7!}  = {10 \choose 3} = {10 \choose 7}$$

So findet sich diese Formel in der Kurzschreibweise in grafischen Taschenrechnern oder auch hinter einer Taste mit einer Beschreibung wie `nCr`.
Man spricht es aus als **"zehn über sieben"**.

Befrage ich nun meinen Taschenrechner nach der Antwort `10 nCr 7`, so erhalte ich die Antwort: 120.

Es gibt also 120 verschiedene Möglichkeiten, beim zehnfachen Dosenwurf dreimal zu treffen.
