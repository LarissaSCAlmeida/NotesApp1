namespace NotesApp;
public partial class NotePage : ContentPage
{
    string fileName = Path.Combine(FileSystem.AppDataDirectory, "config.DAT");
    public NotePage()
	{
		InitializeComponent();
	}
    private void SalvarButton_Clicked(object sender, EventArgs e)
    {         
        File.WriteAllText(fileName, TextoEditor.Text);
    }
    private void DeletarButton_Clicked(object sender, EventArgs e)
    {
        File.Delete(fileName);
    }
}