using System;

class Program
{
    // namespace videodemo
    
    
    #pragma warning restore format
    static void Main(string[] args)
    {
                
        Video v1 = new Video ();
        v1._title = "World's Largest Explosion";
        v1._author = "Mr. Beast";
        v1._length = 500;

        Comment comment1 = new Comment();
        comment1._name = "Hayden O";
        comment1._comments = "That was the coolest thing I've ever seen! ";
        v1._comments.Add(comment1);

        Comment comment2 = new Comment();
        comment2._name = "Hunter D.";
        comment2._comments = "I want to see you do that again!";
        v1._comments.Add(comment2);

        Comment comment3 = new Comment();
        comment3._name = "William S";
        comment3._comments = "That's sooo cool! ";
        v1._comments.Add(comment3);   


        Video v2 = new Video ();
        v2._title = "Mutton Buston Highlights ";
        v2._author = "KENS 5";
        v2._length = 250;

        Comment comment4 = new Comment();
        comment4._name = "Megan C";
        comment4._comments = "I loved it. ";
        v2._comments.Add(comment4);

        Comment comment5 = new Comment();
        comment5._name = "Garrett J";
        comment5._comments = "That was awesome!";
        v2._comments.Add(comment5);

        Comment comment6 = new Comment();
        comment6._name = "Locke A";
        comment6._comments = "I want to do that one day. ";
        v2._comments.Add(comment6);


        Video v3 = new Video ();
        v3._title = "NFL Best catches";
        v3._author = "Ding Productions";
        v3._length = 100;

        Comment comment7 = new Comment();
        comment7._name = "David O";
        comment7._comments = "I loved it! Upload more! ";
        v3._comments.Add(comment7);

        Comment comment8 = new Comment();
        comment8._name = "James H";
        comment8._comments = "That was fantastic!";
        v3._comments.Add(comment8);

        Comment comment9 = new Comment();
        comment9._name = "Hunter H";
        comment9._comments = "So cool! ";
        v3._comments.Add(comment9);

        // put them in a list
        List <Video> l1 = new List<Video> ();
        l1.Add(v1);
        l1.Add(v2);
        l1.Add(v3);

        foreach (Video v in l1)
        {
            v.VideoDisplay();
            

        }
    }
    
}