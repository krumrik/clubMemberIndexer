using System;

class ClubMembers
{
    public const int Size = 15;

    private string[] Members = new string[Size];
    public string ClubType { get; set; }
    public string ClubLocation { get; set; }
    public string MeetingDate { get; set; }

    public ClubMembers()
    {
        for (int i = 0; i < Members.Length; i++)
        {
            Members[i] = "";
        }
    }

    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < Members.Length)
            {
                return Members[index];
            }
            else
            {
                throw new IndexOutOfRangeException($"Index {index} is out of bounds.");
            }
        }
        set
        {
            if (index >= 0 && index < Members.Length)
            {
                Members[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException($"Index {index} is out of bounds.");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        ClubMembers club = new ClubMembers();

        club[0] = "Kayden";
        club[1] = "Tyler";
        club[3] = "Simon";
        club[4] = "Bob";
        club[5] = "Jerry";
        club[6] = "Michael";
        club[7] = "Rocky";
        club[8] = "Lexi";
        club[9] = "Toni";
        club[10] = "Sean";
        club[11] = "Patrick";
        club[12] = "Charles";
        club[13] = "Trey";
        club[14] = "Jack";

        club.ClubType = "Gaming Club";
        club.ClubLocation = "Esports Lab";
        club.MeetingDate = "Every Monday, and Friday";

        Console.WriteLine($"Club Type: {club.ClubType}");
        Console.WriteLine($"Club Location: {club.ClubLocation}");
        Console.WriteLine($"Meeting Date: {club.MeetingDate}");
        Console.WriteLine("\nMembers:");
        for (int i = 0; i < ClubMembers.Size; i++)
        {
            Console.WriteLine($"Member {i + 1}: {club[i]}");
        }
    }
}
