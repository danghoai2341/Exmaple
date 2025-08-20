public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Mang ban dau la ");
        PrintArray(arr);
        //nhap phan tu can chen
        //nhap vi tri can chen
        Console.WriteLine("Nhap phan tu can chen");
        int number = Convert.ToInt32(Console.ReadLine());
        //
        Console.WriteLine("Nhap vi tri can chen");
        int position = Convert.ToInt32(Console.ReadLine());
        //kiem tra vi tri
        if (position < 0 || position > arr.Length)
        {
            Console.WriteLine("Vi tri chen khong hop le");
            return;
        }
        int[] newArr = new int[arr.Length + 1];
        int i = 0, j = 0;
        for (i = 0, j = 0; i < newArr.Length; i++)
        {
            if (i == position)
            {
                newArr[i] = number;
            }
            else
            {
                newArr[i] = arr[j];
                j++;
            }
        }
        PrintArray(newArr);
    }
    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }


}
