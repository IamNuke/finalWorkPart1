# Решение контрольного задания первого блока обучения

## Условие задачи

Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равно 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Описание решения

Ввод данных осуществляется пользователем с клавиатуры. Введенная строка разбивается в массив по разделителю (пробелу). 
В функцию передается исзодный массив и по его размеру создаем новый массив для заполнения по условиям задачи.
Далее во внешнем цикле идет обход элементов исходного массива и для каждого элемента генерируется случайное число от __*0 до 3*__ - это количество символов в элементе результирующего массива. Во внутреннем цикле идем по символам текущего элемента исходного массива и добавляем в элемент результирующего массива соответствующее количество раз. 
Результирущий массив возвращается из функции и выводится на экран.
