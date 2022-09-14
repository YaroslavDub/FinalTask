Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 0;
int j = 0;
string[] array = new string [n];
for (int i = 0; i < n; i++) {
    Console.WriteLine($"Введите {i + 1} элемент массива");
    array[i] = Console.ReadLine();
    if (array[i].Length <= 3) {
        m += 1;
    }
}
string[] array2 = new string [m];
Console.WriteLine (m);
Console.WriteLine (string.Join(", ", array));
for (int i = 0; i < n; i++) {
    if (array[i].Length < 4) {
        array2[j] = array[i];
        j += 1;
    }

}
Console.WriteLine (string.Join(", ", array2));
