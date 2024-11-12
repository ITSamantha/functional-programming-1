# Лабораторная работа №1

Выполнила: Савельева Диана Александровна, P34082, 388291

Вариант: 7, 26

## Задание
Цель: освоить базовые приёмы и абстракции функционального программирования: функции, поток управления и поток данных, сопоставление с образцом, рекурсия, свёртка, отображение, работа с функциями как с данными, списки.

## Вариант

Задача №7
```
By listing the first six prime numbers: 2, 3, 5, 7, 11 and 13 we can see that the 6th prime is 13.

What is the 10001st prime number?
```


Задача №26
```
A unit fraction contains in the numerator. The decimal representation of the unit fractions with denominators 2 to 10
are given:

1/2 = 0.5
1/3 = 0.(3)
1/4 = 0.25
1/5 = 0.2
1/6 = 0.1(6)
1/7 = 0.(142857)
1/8 = 0.125
1/9 = 0.(1)
1/10 = 0.1

Where 0.1(6) means 0.166666... and has a 1-digit recurring cycle. It can be seen that 1/7 has a 6-digit recurring cycle.

Find the value of d < 1000 for which 1/d contains the longest recurring cycle in its decimal fraction part.
```



# Заключение
В процессе выполнения лабораторной работы были освоены ключевые принципы функционального программирования. Удалось поработать с рекурсией, ленивыми коллекциями, а также освоить базово тестирование в F#. Эти принципы оказались очень полезными при решении задач, связанных с вычислением циклов в дробях и поиском простых чисел (соответстующее моим задачам).

Было интересно поработать с множеством разных методов решения одной и той же проблемы, а также понаблюдать за изменением времени исполнения программы. 

Особенности, которые я отметила для себя:
- В F# понравилось работать с модулем Seq, предоставляющим методы для работы с последовательностями. Хотелось бы выделить initInfinite (генерация бесконечной последовательности), а также функцию filter.
- Удобная работа с рекурсией (даже есть ключевое слово rec).
- Довольно простая реализация тестирования для функций (NUnit).
- Довольно сложная настройка и сборка у dotnet платформы. В том числе и для тестов.

