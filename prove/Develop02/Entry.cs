public class Entry
{
    public string _date = DateTime.Now.ToShortDateString();
    public string _prompt;
    public string _response;

    public void Display()
    {
        Console.WriteLine($"\nDate: {_date} - Prompt: {_prompt}\n{_response}\n");
    }

}