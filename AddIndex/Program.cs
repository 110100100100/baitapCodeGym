﻿int[] array = { 1, 2, 3, 4, 5 };
        
        
        Console.WriteLine("Nhập số bạn muốn thêm:");
        int X = int.Parse(Console.ReadLine());
        
        
        Console.WriteLine("Nhập phần tử bạn muốn chèn:");
        int index = int.Parse(Console.ReadLine());
        
        
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Không thể chèn phần tử vào mảng tại vị trí bạn muốn.");
            return;
        }
        
       
        int[] newArray = new int[array.Length + 1];
        
      
        for (int i = 0, j = 0; i < newArray.Length; i++)
        {
            if (i == index)
            {
                newArray[i] = X;
            }
            else
            {
                newArray[i] = array[j];
                j++;
            }
        }
        
       
        Console.WriteLine("Mảng sau khi chèn phần tử:");
        foreach (int num in newArray)
        {
            Console.Write(num + " ");
        }