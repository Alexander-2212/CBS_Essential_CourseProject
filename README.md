# CBS_Essential_CourseProject

**Завдання 10**

Створіть консольний застосунок «Гірлянда».

**Умова задачі**

Створити абстрактний клас Garland та спеціалізувати його класами-нащадками TSimpleGarland і TColorGarland, що є абстракціями одноколірної та кольорової гірлянд відповідно. Як елементи першої гірлянди використовувати клас TLight. Як елементи кольорової гірлянди використовувати екземпляри класу TColorLight, які є розширенням класу TLight, завдяки введенню одного поля FColor типу TLightColor (може приймати значення: lcGreen, lcRed, lcYellow, lcBlue), методу кольору лампочки через тип TLightColor та методу GetColorAsString, який повертає колір лампочки у вигляді малого типу. Для зберігання об'єктів-лампочок в обох гірляндах використовувати екземпляр класу TList (оголошений у модулі classes). Кількість лампочок в обох класах фіксована і дорівнює 12. Для обох гірлянд створити метод PrintStateOfLights, який виводить у консоль стан лампочок: увімкнена-вимкнена для обох випадків і колір лампочки для випадку кольорової гірлянди. Під час створення кольорової гірлянди встановити колір лампочки залежно від кратності її порядкового номера в гірлянді: зелена, червона, жовта, блакитна.


**Завдання 11**

Створіть консольний застосунок «Квадратне рівняння».

**Умова задачі**

Засобами ООП створити класи на розв'язок квадратного рівняння. Необхідно виконати реалізацію, використовуючи такі класи:

• «Завдання» – зберігає ці завдання (коефіцієнти a, b і c). Ініціалізує їх через конструктор.

• «Вирішувач» – містить набір методів для розв'язку. Водночас не всі методи мають бути публічними.

• «Рішення» – зберігає дані про знайдений корінь рівняння x1 і x2 і, можливо, ознаку: одне рішення, два рішення, немає рішень.

**Завдання 13**

Створіть консольний застосунок «Dot».

**Умова задачі**

Створити клас Dot для опису точки у двовимірній декартовій системі координат. Створити клас «Прямокутник», полями якого будуть 2 точки (2 точки, що не лежать на одній прямій, цілком достатні для однозначного визначення прямокутника). Написати методи для знаходження його периметра та площі. Створити екземпляр класу «Прямокутник», викликати йому реалізовані методи.
