﻿int count = 0, distance = 10000, firstFriendSpeed = 1, secondFriendSpeed = 2, DogSpeed = 5, friend = 2, time = 0;
while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + DogSpeed);
        friend = 2;
        }
    else
     {
         time = distance / (secondFriendSpeed + DogSpeed);
         friend = 1;
    }
distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
count = count + 1;
}
Console.Write ("Собака пробежит = ");
Console.Write (count);
Console.WriteLine (" раз.");