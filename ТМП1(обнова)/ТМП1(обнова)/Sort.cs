using System;

public class Sort
{
    public object tmp { get; private set; }

    public void sort(int[]Queue)
    {
        int n = Queue.Length;

        // Построение кучи (перегруппируем массив)
        for (int i = n / 2 - 1; i >= 0; i--)
            heapify(Queue, n, i);

        // Один за другим извлекаем элементы из кучи
        for (int i = n - 1; i >= 0; i--)
        {
            // Перемещаем текущий корень в конец
            int tmp = Queue[0];
            Queue[0] = Queue[i];
            Queue[i] = tmp;

            // вызываем процедуру heapify на уменьшенной куче
            heapify(Queue, i, 0);
        }
    }

    // Процедура для преобразования в двоичную кучу поддерева с корневым узлом i, что является
    // индексом в Queue[]. n - размер кучи

    void heapify(int[] Queue, int n, int i)
    {
        int largest = i;
        // Инициализируем наибольший элемент как корень
        int l = 2 * i + 1; // left = 2*i + 1
        int r = 2 * i + 2; // right = 2*i + 2

        // Если левый дочерний элемент больше корня
        if (l < n && Queue[l] > Queue[largest])
            largest = l;

        // Если правый дочерний элемент больше, чем самый большой элемент на данный момент
        if (r < n && Queue[r] > Queue[largest])
            largest = r;

        // Если самый большой элемент не корень
        if (largest != i)
        {
            int swap = Queue[i];
            Queue[i] = Queue[largest];
            Queue[largest] = swap;

            // Рекурсивно преобразуем в двоичную кучу затронутое поддерево
            heapify(Queue, n, largest);
        }
    }

    /* Вспомогательная функция для вывода на экран массива размера n */
    public void Print(int n)
    {
        
        for (int i = 0; i < n; ++i)
            Console.WriteLine(tmp[i]);
        Console.Read();
    }

}

