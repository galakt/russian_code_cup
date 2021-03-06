## Task 1

http://www.russiancodecup.ru/ru/championship/round/57/problem/A/

Ограничение по времени	2 секунды

Ограничение по памяти	256 мегабайт

Космический рейнджер оказался на инопланетном космическом корабле в окружении врагов. Чтобы освободиться, ему необходимо уничтожить всех врагов в определенном порядке.

Вокруг рейнджера n врагов, i-й из них обладает силой fi. Чтобы выбраться, рейнджеру необходимо уничтожить всех врагов, причем в таком порядке, чтобы сила последнего уничтоженного врага была равна сумме всех остальных врагов.

В запасе у рейнджера мало времени, так что он не успевает понять, как это сделать. Ему необходима ваша помощь. Восстановите порядок, в котором необходимо уничтожать врагов, чтобы выбраться.

Формат входных данных	
В первой строке ввода находится натуральное число n — количество врагов (2 ≤ n ≤ 105).

Во второй строке находятся n целых чисел fi, задающих силу каждого врага ( - 109 ≤ fi ≤ 109).

Формат выходных данных	
Выведите числа fi в порядке, в котором необходимо уничтожать соответствующих им врагов. Если существует несколько подходящих вариантов, выведите любой. Гарантируется, что хотя бы один подходящий порядок уничтожения существует.

Примеры	

Входные данные | Выходные данные
--- | ---
3<br>2 5 3| 2 3 5


Входные данные | Выходные данные
--- | ---
5<br>-1 1 0 1 -1 | -1 1 1 -1 0



## Task 3

http://www.russiancodecup.ru/ru/championship/round/57/problem/C/

Ограничение по времени	2 секунды

Ограничение по памяти	256 мегабайт

Для сборки волшебного оружия необходимо соединить три фрагмента: зеленый, красный и синий.

Зеленому, красному и синему рейнджеру стало интересно, сколько у них есть различных способов собрать волшебное оружие. Для каждого рейнджера известен набор фрагментов, которыми он обладает. У зеленого рейнджера есть зеленые фрагменты, у красного рейнджера — красные, а у синего — синие.

При сборке оружия необходимо соблюдать три правила:

Первая цифра номера модели красного фрагмента должна быть равна последней цифре модели зеленого.
Последняя цифра номера модели красного фрагмента должна быть равна первой цифре модели синего.
Все три использованных фрагмента должны иметь разные номера моделей.
Два способа собрать оружие считаются различными, если хотя бы один из рейнджеров использует при сборке другой фрагмент, возможно той же модели.

Для каждого рейнджера вам известны номера моделей его фрагментов. У одного рейнджера могут быть несколько фрагментов одной модели.

Помогите рейнджерам понять, сколько у них есть различных способов собрать оружие.

 
Формат входных данных	
В первой строке ввода заданы числа g, r и b — количество фрагментов у зеленого, красного и синего рейнджера соответственно (1 ≤ g, r, b ≤ 105).

В следующей строке находится g чисел xi — номера моделей, которые есть у зеленого рейнджера (0 ≤ xi ≤ 109).

В следующей строке находится r чисел yi — номера моделей, которые есть у красного рейнджера (0 ≤ yi ≤ 109).

В следующей строке находится b чисел zi — номера моделей, которые есть у синего рейнджера (0 ≤ zi ≤ 109).

Формат выходных данных	
Выведите одно число — количество способов собрать оружие.

Примеры	

Входные данные | Выходные данные
--- | ---
3 3 2<br>101 11 52<br>11 23 23<br>31 13 | 3
