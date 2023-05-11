public class Entry
{
    public string _write;
    public string _display;
    public string _load;
    public string _string;

    //Defining the behaviour or the method for each member variable or attribute in the class

    //Saving the users answer in a list
    public void SavedAnswer()
    {
        List<string> saveAnswerInList = new List<string>();

        saveAnswerInList.Add(_write);
    }
}