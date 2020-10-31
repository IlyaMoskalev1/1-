using System.Collections.Generic;
using System;

class Queue
{
    private List<int> queue;
    
    public Queue() {
        queue = new List<int>();
    }
    
    // Добавляем в конец
    public void Push(int newValue) {
        queue.Add(newValue);
    }
    
    // Извлекаем из начала
    public int Pop() {
        int result = queue[0];
        queue.RemoveAt(0);
        
        return result;
    }
    
    // Показываем значение первого элемента
    public int Show() {
        return queue[0];
    }
    
    // Получение элемента очереди по i-ой позиции
    public int Get(int pos) {
        for(int i = 0; i < pos; ++i)
            Push(Pop());
            
        int result = Show();
        
        for(int i = pos; i < queue.Count; ++i)
            Push(Pop());
            
        return result;
    }
    
    // Установка нового элемента на i-ую позицию
    public void Set(int pos, int newValue) {
        for(int i = 0; i < pos; ++i)
            Push(Pop());
            
        queue[0] = newValue;
        
        for(int i = pos; i < queue.Count; ++i)
            Push(Pop());
    }
    
    // Отображение очереди в консоли
    public void Print() {
        foreach (int item in queue)
            Console.WriteLine(item);
        Console.WriteLine("---------");
    }
}

class Program
{
    static void Main()
    {
        
        Queue tmp = new Queue();
        tmp.Push(1);
        tmp.Push(2);
        tmp.Push(3);
        tmp.Push(4);
        
        tmp.Print();
        
        Console.WriteLine(tmp.Get(3));
        Console.WriteLine("---------");
        
        tmp.Print();
        
        Console.WriteLine("----------------------");
        
        tmp.Set(2, 5);
        tmp.Print();
    }
}