class InfoEventArgs : EventArgs
{
    public string PropertyName { get; }
    public string TextError { get; }
    public DateTime ChangedDate { get; }

    public InfoEventArgs(string propertyName, string textError)
    {
        PropertyName = propertyName;
        TextError = textError;
        ChangedDate = DateTime.Now;
    }
}
