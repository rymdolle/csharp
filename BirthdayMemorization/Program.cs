using System;
using System.Collections;
using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        string? line = Console.ReadLine();
        if (line == null) return;
        int count = int.Parse(line);
        Hashtable friends = [];
        for (int i = 0; i < count; i++)
        {
            line = Console.ReadLine();
            if (line == null) return;
            string[] parts = line.Split(' ');
            string name = parts[0];
            int likes = int.Parse(parts[1]);
            string date = parts[2];
            if (friends.Contains(date))
            {
                Friend f = (Friend)friends[date]!;
                if (likes > f.Likes)
                {
                    friends[date] = new Friend(name, likes);
                }
            }
            else
            {
                friends.Add(date, new Friend(name, likes));
            }
        }

        List<string> friendList = [];
        foreach (DictionaryEntry entry in friends)
        {
            Friend f = (Friend)entry.Value!;
            friendList.Add(f.Name);
        }
        friendList.Sort();
        Console.WriteLine(friendList.Count);
        foreach (string friend in friendList)
        {
            Console.WriteLine(friend);
        }
    }

    class Friend
    {
        public string Name;
        public int Likes;
        public Friend(string name, int likes)
        {
            Name = name;
            Likes = likes;
        }
    }
}
