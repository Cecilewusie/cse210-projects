public class Resume
{
    public string _name = "";

    // Make sure to initialize your list to a new List before you use it.
    public List<Job> _resumeJobs= new List<Job>();

    //Add a Display method to the Resume class
    public void DisplayJobsWithResume()
    {   
        //In the method body, you should display the person's name and then iterate through each Job instance in the list of jobs and display them.
        Console.WriteLine($"Name: {_name}");

        Console.WriteLine("Jobs:");   

        foreach (Job j in _resumeJobs)
        {

            //Hint: remember that you can call each job's DisplayJobDetails method that you created earlier
            j.DisplayJobDetails();
        }
    } 
}