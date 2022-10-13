// See https://aka.ms/new-console-template for more information

int count = 0,
distance = 1000,
firstFriendSpeed = 1,
secondFriendSpeed = 2,
dogSpeed = 5,
friend = 2,
time;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count = count + 1;
}
Console.WriteLine("Собака пробежит " + count + " раз.");
