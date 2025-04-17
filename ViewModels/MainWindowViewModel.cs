using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Notetaker.Models;

namespace Notetaker.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<Note> Notes { get; } = [];

    [ObservableProperty] private string currentContent;
    
    public void AddNote()
    {
        if (!string.IsNullOrEmpty(CurrentContent))
        {
            Note newNote = new (CurrentContent);
            Notes.Add(newNote);
            newNote.DeleteCommand = new RelayCommand(() => DeleteNote(newNote));
            CurrentContent = string.Empty;
        }
    }

    public void DeleteNote(Note note)
    {
        Notes.Remove(note);
    }
    
}