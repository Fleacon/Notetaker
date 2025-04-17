using System.Windows.Input;

namespace Notetaker.Models;

public class Note
{
    public string Content { get; set; }
    public bool IsCompleted { get; set; }
    public ICommand? DeleteCommand { get; set; }

    public Note(string content)
    {
        Content = content;
        IsCompleted = false;
        DeleteCommand = null;
    }
}