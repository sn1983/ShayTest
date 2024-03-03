using ShayTest;

public class T5
{


    List<Person> verifiedPeople = new List<Person>();
    List<Person> peopleData = new List<Person>();
    public T5(List<Person> _peopleData)
    {
        peopleData = _peopleData;
    }

    public  List<Person> FindFive(List<Person> peopleData)
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
        return true;
        
    }

}