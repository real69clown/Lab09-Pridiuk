// int totalExercises = 1;

// for (int number = 8; number >= totalExercises; number--)
// {
//     Console.WriteLine($"Упражнение {number}");
// }

// Console.WriteLine("Домашнее задание готово");

// for (int room = 5; room <= 50; room += 5) {
//     Console.WriteLine($"Кабинет {room}");
// }

// int totalWeeks = 3;

// for (int week = 1; week <= totalWeeks; week++)
// {
//     for (int day = 1; day <= 5; day++)
//     {
//         Console.WriteLine($"Неделя {week}, день {day}");
//     }
//     Console.WriteLine("_");
// }

// int count = 0;
// for (int ticket = 1; ticket <= 30; ticket++) {
//     if (ticket == 4 || ticket == 12 || ticket == 19)
//     {
//         count++;
//         continue;
//     }

//     Console.WriteLine($"Первый доступный билет: {ticket}, Пропущенно билетов {count}");
//     break;
// }

// for (; ; )
// {
//     Console.WriteLine("Введите код группы (для выхода - <<выход>>)");
//     string groupCode = Console.ReadLine();

//     if (groupCode == "выход")
//     {
//         break;
//     }

//     Console.WriteLine($"Записать код группы: {groupCode}");
// }

// Console.WriteLine("Работа с журналом завершена");

// Задача Б

// for (int i = 100; i >= 0; i -= 10) {
//     Console.WriteLine(i);
// }

// Задача Г

// for (int i = 1; i <= 50; i++) {
//     if (i % 3 == 0) {
//         continue;
//     }
    
//     if (i % 7 == 0) {
//         break;
//     }
    
//     Console.WriteLine(i);
// }