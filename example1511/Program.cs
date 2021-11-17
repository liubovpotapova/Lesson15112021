// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. 
// Найти сумму положительных/отрицательных элементов массива
//задаем массив
// int[] arrayTwelve = new int[12];
// for (int i = 0; i < 12; i++)
// {
//     arrayTwelve[i] = new Random().Next(-9, 10);
// }
// //распечатываем массив
// for (int i = 0; i < 12; i++)
// {
//     System.Console.Write(" "+arrayTwelve[i]+" ");
// }
// //задаем переменные для сумм и задаем цикл 
// int sumOtr = 0;
// int sumPol =0;
// for (int index=0; index<12; index++)
// if (arrayTwelve[index]<0)
//     {
//          sumOtr = sumOtr + arrayTwelve[index];
//      }
// else
//     {
//     sumPol = sumPol + arrayTwelve[index];
//     }
// //печатаем
// System.Console.WriteLine(" ");
// System.Console.WriteLine("сумма отрицательных = "+sumOtr);
// System.Console.WriteLine("сумма отрицательных = "+sumPol);

// 34. Написать программу замены элементов массива на противоположные
// int [] arrayThirtyFour= new int[10];
// int i = 0;
// for (i=0; i<10; i++)
// {
//     arrayThirtyFour[i]= new Random().Next(-10,10);
//     System.Console.Write(arrayThirtyFour[i]+" ");
// }

// i=0;
// System.Console.WriteLine(" ");
// for (i=0; i<10; i++)
// {
//     if (arrayThirtyFour[i]>0)
//     {
//         System.Console.Write((arrayThirtyFour[i])-(2*arrayThirtyFour[i])+" ");
//     }
//     if (arrayThirtyFour[i]<0)
//     {
//         System.Console.Write(Math.Abs(arrayThirtyFour[i])+" ");

//     }
//     if(arrayThirtyFour[i]==0)
//     {
//         System.Console.Write(arrayThirtyFour[i]+" ");
//     }
// }
// System.Console.WriteLine(" ");


// 35. Определить, присутствует ли в заданном массиве, некоторое число 

//заполняем массив
// int [] arrayThirtyFive= new int[10];
// for (int i=0; i<10; i++)
// {
//     arrayThirtyFive[i]= new Random().Next(-10,10);
//     System.Console.Write(arrayThirtyFive[i]+" ");
// }

// //вводим и считываем число
// System.Console.WriteLine(" ");
// System.Console.WriteLine("Введите число");
// int yourNumber = Convert.ToInt32(Console.ReadLine());

// //цикл для сравнения
// int countCircles = 0;

// for (int index35 =0; index35 <10; index35++)
// {
//     if(arrayThirtyFive[index35]==yourNumber)
//     {
//         System.Console.WriteLine("число есть");
//         break;
//     }
//     else
//     {
//         countCircles = countCircles+1;
//     if(countCircles == 9)
//     {
//             System.Console.WriteLine("числа нет в массиве");
//     }
//     }

// }

//для решения методом "найти где-то", то есть ему скармливать массив, 
// должен вернуть да/нет
//метод есть или нет bool
//верни индекс
//bool EstLiNumberTut()

// 36. Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел
// int[] arrayThreeDigitsPositive = new int[15];
// int i = 0;
// int countPos = 0;
// int countNeg = 0;
// for (i = 0; i < 15; i++)
// {
//     arrayThreeDigitsPositive[i] = new Random().Next(0, 1000);
//     System.Console.Write(" " + arrayThreeDigitsPositive[i] + " ");
// }
// System.Console.WriteLine(" ");

// for (i = 0; i < 15; i++)
// {
//     if (arrayThreeDigitsPositive[i] % 2 == 0)
//     {
//         countPos = countPos + 1;
//     }
//     else
//     {
//         countNeg = countNeg + 1;
//     }

// }
// System.Console.WriteLine("количество четных="+countPos);
// System.Console.WriteLine("количество нечетных="+countNeg);

// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// int[] array123 = new int[123];

// for (int i = 0; i < 123; i++)
// {
//     array123[i] = new Random().Next(-10, 500);
//     System.Console.Write(" " + array123[i] + " ");

// }

// int Count(int[] array)
// {
//     int count = 0;
//     for (int index123 = 0; index123 < 123; index123++)
//     {
//         if (array123[index123] > 10 && array123[index123] < 99)
//         {
//             count = count + 1;
//         }
//     }
//     return count;
// }

// System.Console.WriteLine(" ");
// System.Console.WriteLine("Количество элементов в отрезке (10;99) равно " + Count(array123));


// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// int[] arrayForSumUnevenPosition = new int[10];
// int i = 0;
// for (i = 0; i < 10; i++)
// {
//     arrayForSumUnevenPosition[i] = new Random().Next(-100, 101);
//     System.Console.Write(" "+arrayForSumUnevenPosition[i]+" ");
// }
// System.Console.WriteLine(" ");
// int sumUnevenPosition=0;
// for (i=0; i<10; i++)
// {
//     if ((i+1)%2!=0)
//     {
//     sumUnevenPosition = sumUnevenPosition+ arrayForSumUnevenPosition[i];
//     }
// }
// System.Console.WriteLine("Сумма чисел стоящих на нечетной позиции="+sumUnevenPosition);

// 39. Найти произведение пар чисел в одномерном массиве. 
// // Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// //не получилось решить
// int[] arrayThirtyNine = new int[10];
// int i = 0;
// for (i = 0; i < 10; i++)
// {
//     arrayThirtyNine[i] = new Random().Next(-10, 10);
//     System.Console.Write(" " + arrayThirtyNine[i] + " ");
// }
// int arrayThirtyNineAll=arrayThirtyNine.Length;
// System.Console.WriteLine(arrayThirtyNineAll);

// i=0;
// int leftBound = arrayThirtyNine[i];
// // int indexRightBound = (arrayThirtyNineAll-i);
// int rightBound = arrayThirtyNine[arrayThirtyNineAll];
// float arrayThirtyNineSeredina = arrayThirtyNine.Length/2;
// System.Console.WriteLine(arrayThirtyNineSeredina);
// // for (i=0; i<; i++) //; leftBound<rightBound && leftBound!=rightBound)
// // {
// //     int count = i+1;
// //     System.Console.WriteLine("произведение пары #"+count+" = "+(leftBound*rightBound));
// // }

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
// не работает, не могу найти ошибку
//задали массив
// int[] arrayFourty = new int[5];
// int i = 0;
// for (i = 0; i < 5; i++)
// {
//     arrayFourty[i] = new Random().Next(-100, 100);
//     System.Console.Write(" " + arrayFourty[i] + " ");
// }
// System.Console.WriteLine(" ");
// //поиск максимального
// i = 0;
// int indexMax = i + 1;
// int arrayFourtyMax = arrayFourty[i];
// while (indexMax < 5)//циклом for не получается((((
//     {
//     if (arrayFourtyMax > arrayFourty[indexMax])
//     {
//         arrayFourtyMax = arrayFourty[i];
//         indexMax++;

//     }
//     else
//     {
//         arrayFourtyMax = arrayFourty[indexMax];
//         arrayFourty[i] = arrayFourty[indexMax];
//         i++;
//         indexMax++;
//     }
// }
// System.Console.WriteLine("маx=" + arrayFourtyMax);

// //поиск минимального
// i = 0;
// int arrayFourtyMin = arrayFourty[i];
// int indexMin = i + 1;
// while (indexMin < 5)                            //0     //1     //2         //3
//     {
//     if (arrayFourtyMin < arrayFourty[indexMin]) //-2<6  //-2<-3 //-3<-7     //-7<4
//     {
//         arrayFourtyMin = arrayFourty[i];        //      //      //  //-7
//         indexMin++;                             //      //      //  //5

//     }
//     else
//     {
//         arrayFourtyMin = arrayFourty[indexMin]; //-2  //-3  //-7
//         arrayFourty[i] = arrayFourty[indexMin]; //6  //-2   //-3
//         i++;                                    //1 //2     //3
//         indexMin++;                             //2  //3    //4
//     }
// }
// System.Console.WriteLine("мin="+arrayFourtyMin);
// System.Console.WriteLine("разница между максимальным и минимальным="+(arrayFourtyMax-arrayFourtyMin));

