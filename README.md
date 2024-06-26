# Задание 1. Площадь фигур
Решение первого задания про площадь фигур сохранено в блокноте [pyspark_test.ipynb](https://github.com/shpolelaote/vacancy_id94391819/blob/main/One2Many/pyspark_test.ipynb), который находится в папке One2Many.
> One2Many
> > pyspark_test.ipynb

Для него были созданы небольшие csv таблицы для демонстрации примера решения. Данные таблицы описаны в [блокноте](https://github.com/shpolelaote/vacancy_id94391819/blob/main/One2Many/pyspark_test.ipynb) соотвествующего решения и находятся в общей директории вместе с блокнотом.

# Задание 2. Продукт-категория
В папке TestTriangle находится файл [triangleArea.cs](https://github.com/shpolelaote/vacancy_id94391819/blob/main/TestTriangle/triangleArea.cs), который имеет метод ShapeArea, выполняющий вычисление площади на основе входящего массива вещественных чисел. Данный метод:
+ Выводит ошибку, если среди элементов массива есть отрицательное или бесконечное значение;
+ Вычисляет площадь круга, если размер массива равен единице, и треугольника, если три, но выводит ошибку NotImplementedException при остальных размерах. Таким образом можно расширить множество поддерживаемых фигур путем добавления участков кода для различных значений размера входящего массива;
+ При размере входящего массива, равным трем, метод выполняет проверку неравенства треугольника. Если оно не выполнено, выводится ошибка, иначе - площадь прямоугольного или произвольного трегольника. Во втором случае применяется формула Герона.

Для unit тестов создан [проект](https://github.com/shpolelaote/vacancy_id94391819/blob/main/TestTriangle/TestTriangle.csproj) MSTest под названием TestTriangle. Тесты выполняют проверку на:
+ Верное вычисление площади при правильных входных данных;
+ Вывод ошибки на непредусмотренную размерность (не 1 или 3) и наличие отрицательных или бесконечно больших значений элементов.
> TestTriangle
> > triangleArea.cs
> > 
> > TestTriangle.csproj
