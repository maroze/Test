int MinToZero(int x, int[] nums)
{
    //Общая сумма массива
    int totalSum = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        totalSum += nums[i];
    }

    //Если сумма массива совпадает с числом х,
    //то мин кол-во операция состовляет кол-во эл-ов в массиве
    if (totalSum == x)
    {
        return nums.Length;
    }

    //Сумма эл-ов подмассива
    int sum = totalSum - x;
    //Первые эл-ты массива
    int left = 0;
    //Последние эл-ты массива
    int right = 0;
    int currSum = 0;
    int maxLength = 0;

    //Перебор массива 
    while (right < nums.Length)
    {
        //Считаем текущую сумму массива
        currSum += nums[right];

        //Заходим в массив и отнимаем левые эл-ты пока текущая сумма не станет меньше
        //сумме подмассива, возвращаемся к предыдущему действию

        while (left < right && currSum > sum)
        {
            currSum -= nums[left];
            left++;
        }

        //Если текущая сумма будет равна сумме подмассива
        if (currSum == sum)
        {
            if (maxLength > right - left + 1)
            {
                maxLength = maxLength;
            }
            else
                maxLength = right - left + 1;
        }
        right++;
    }
    return maxLength == 0 ? -1 : nums.Length - maxLength;
}

int x = 17;
int[] nums = { 5,2,6,1,8,2,4 };

Console.WriteLine(MinToZero(x, nums));
Console.ReadLine();
