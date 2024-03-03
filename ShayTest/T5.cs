using ShayTest;

public class T5
{


    List<Person> verifiedPeople = new List<Person>();
    List<Person> peopleData = new List<Person>();
    public T5()
    {
        peopleData = new List<Person>();
        peopleData.Add(new Person(5, "Maor", "Cohen"));
        peopleData.Add(new Person(5, "Maor", "Levi"));
        peopleData.Add(new Person(5, "Maor", "XX"));
        peopleData.Add(new Person(5, "Maor", "YY"));
        peopleData.Add(new Person(5, "Maor", "TT"));
        peopleData.Add(new Person(5, "Sharon", "RR"));
        peopleData.Add(new Person(5, "ShiShi", "UU"));
        peopleData.Add(new Person(5, "Shay", "NN"));
        peopleData.Add(new Person(5, "Noa", "UU"));
        peopleData.Add(new Person(5, "Lina", "ff"));

       
    }

    public  List<Person> FindFive()
    {
        List<Person> verifiedPeople = new List<Person>();
        object lockObj = new object();

        Parallel.ForEach(peopleData, (person, loopState) =>
        {
            if (Verify(person.FirstName))
            {
                lock (lockObj)
                {
                    verifiedPeople.Add(person);
                    if (verifiedPeople.Count == 5)
                    {
                        loopState.Break();
                    }
                }
            }
        });

        return verifiedPeople;
    }
    public  bool Verify(string firstName)
    {
        //not implemented for now this will allways be true somehow
        return true;
        
    }

}