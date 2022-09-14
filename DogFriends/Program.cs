int count = 0;
int distance = 1000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;

while (distance>10)
{
    if (friend == 1)
    {
        int time = distance/(firstFriendSpeed+dogSpeed);
        friend = 2;
        distance = distance - (firstFriendSpeed+secondFriendSpeed) * time;
        count++;
    }
    if (friend == 2)
    {
        int time = distance/(secondFriendSpeed+dogSpeed);
        friend = 1;
        distance = distance - (firstFriendSpeed+secondFriendSpeed) * time;
        count++;
        
    }
}
Console.Write("Собака пробежит ");
Console.Write(count+" раз.");