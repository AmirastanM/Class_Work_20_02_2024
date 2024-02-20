

//string[] names = { "Hacixan", "Reshad", "Kamran", "Ilgar", "Fatime", "Afide", "Fexriyye" };

//string[] arr2 = new string[8];

//string[] arr3 = new string[3] { "Ismayil", "Nesir", "Ayxan" };

//Console.WriteLine((names[names.Length - 1]));

//Console.WriteLine((names[3]));

//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(i);
//}

//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(names[i]);
//}

//foreach (var item in names)
//{
//    Console.WriteLine(item);
//}


//int[,] nums = { { 1, 2, 3 }, { 5, 6, 8 }, { 11, 22, 55 } };

////Console.WriteLine(nums.Rank);

//Console.WriteLine(nums[1,2]);

//string[] names = { "Hacixan", "Reshad", "Kamran", "Ilgar", "Fatime", "Afide", "Fexriyye" };

////Console.WriteLine(names.Contains("Reshad"));

//var datas = names.Reverse().ToArray();

/*Console.WriteLine(datas[datas.Length - 1]);*/ // axrincini deishir birincisine (tersine chevirme)

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}

//int[] nums = { 3, 5, 7, 8 };

//Array.Sort(nums);

//var datas = nums.Reverse().ToArray();

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}



//int[] arr1 = { 1, 2, 3 };

//int[] arr2 = { 4, 5 };

//arr1.CopyTo(arr2, 2);


//int[] arr = { 1, 2, 3 };

//Array.Resize (ref arr, 5);

//arr[3] = 4;

//Console.WriteLine(arr[3]);

//string[] arr = { "sd", "sd" };

//Array.Resize(ref arr, 3);

//Console.WriteLine(arr[2]);




//int[] arr1 = { 1, 2, 3 };

//int[] arr2 = { 4, 5 };

//Array.Resize(ref arr2, 5);

//arr1.CopyTo(arr2, 2);

//foreach (int item in arr2)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(arr2[3]);


//int[] arr1 = { 1, 2, 3 };

//Array.Resize(ref arr1, 1);


//string[] names = { "Hacixan", "Reshad", "Kamran", "Ilgar", "Reshad", "Fatime", "Afide", "Kamran", "Fexriyye" };

//var data = Array.FindAll(names, m => m == "Reshad");

//var data = Array.FindIndex(names, m => m == "Kamran");

//var data = Array.FindLastIndex(names, m => m == "Kamran");

//foreach (var item in data)
//{
//    Console.WriteLine(item);
//}

//var data = names.FirstOrDefault();

//var data = names.LastOrDefault();

//var data = names.FirstOrDefault(m => m == "Kamran");

//var data = names.All(m => m == "Reshad");

//var data = names.Any(m => m == "Reshad");

//var data = Array.Exists(names, m => m == "Reshad");

//Console.WriteLine(data);

//var data = names.Where(m => m == "Reshad").ToArray();

//foreach (var item in data)


//Console.WriteLine(item);


//string[] names = { "Hacixan", "Reshad", "Kamran", "Ilgar", "Reshad", "Fatime", "Afide", "Kamran", "Fexriyye" };

//var data = names.OrderBy(m => m);

//foreach (var item in data)
//{
//    Console.WriteLine(item);
//}

//string[] names = { "Hacixan", "Reshad", "Kamran", "Ilgar", "Reshad", "Fatime", "Afide", "Kamran", "Fexriyye" };

//var data = names.OrderByDescending(m => m);

//foreach (var item in data)
//{
//    Console.WriteLine(item);
//}

//int count = 0;

//for (int i = 0; names.Length > i; i++)
//{
//    if (names[i] == "Reshad")
//    {
//        count++;
//    }
//}
//if (count == names.Length)
//{
//    Console.WriteLine(true);
//}
//else
//{
//    Console.WriteLine(false);
//}

//bool CheckAllData(string[] data, string str)
//{
//    int count = 0;

//    for (int i = 0; names.Length > i; i++)
//    {
//        if (names[i] == str)
//        {
//            count++;
//        }
//    }
//    if (count == names.Length)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}
//Console.WriteLine(CheckAllData(names, "Reshad"));



//DateTime date = DateTime.Now;

//Console.WriteLine(date);


//DateTime date = DateTime.Now.AddDays(10);


//DateTime birthday = new DateTime(2002,05,25);

//Console.WriteLine(birthday);



//DateTime birthday = new DateTime(2002, 05, 25);

//Console.WriteLine(birthday.Year + birthday.Day);

//DateOnly date = new DateOnly(2002, 05, 25);

//Console.WriteLine(date);

//var currentYear = DateTime.Now.Year;

//DateTime birthday = new DateTime(2002, 05, 25);

//var birthdayYear = birthday.Year;


//Console.WriteLine(currentYear - birthdayYear);


