﻿class Program
{
    public static void Main(string[] args)
    {
        string gradle = "B";
        string result = gradle switch
        {
            "A" => "Xuat sac",
            "B" => "Gioi",
            "C" => "Trung binh",
            "D" => "Yeu",
            _ => "Khong hop le"
        };
        Console.WriteLine(result);
    }
}