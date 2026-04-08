namespace ZitApp.UI.Recipe;

[RegisterToIOC(LifetimeType.Singleton)]
public partial class RecipeView : UiView
{
	public RecipeView()
	{
		InitializeComponent();
	}
}