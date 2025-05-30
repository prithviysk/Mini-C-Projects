namespace DesignPatterns.Behavioural.Memento;

public class History
{
    private List<EditorState>  _states = new List<EditorState>();
    
    private Editor _editor;

    public History(Editor editor)
    {
        _editor = editor;
    }

    public void Backup()
    {
        _states.Add(_editor.CreateState());
    }

    public void Undo()
    {
        if (_states.Count > 0)
        {
            EditorState prevState = _states.Last();
            _states.Remove(prevState);
            _editor.Restore(prevState);
        }
    }

    public void ShowHistory()
    {
        Console.WriteLine("----History----");
        foreach (var state in _states)
        {
            Console.WriteLine(state.GetName());
        }
    }
}