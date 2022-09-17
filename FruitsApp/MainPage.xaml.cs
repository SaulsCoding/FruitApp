namespace FruitsApp;

public partial class MainPage : ContentPage
{
	List<Fruit> fruitsList = new List<Fruit>()
	{
		new Fruit(){Name = "Apple",ImageName ="apple.png",Sentence="Did you taste my mother's apple cookie? This is the best cookie you can eat in the world!"},

        new Fruit(){Name= "Apricot", ImageName="apricot.png",Sentence="Did you taste my mother's apple cookie? This is the best cookie you can eat in the world!"},

        new Fruit(){Name= "Banana", ImageName="banana.png",Sentence="Did you taste my mother's apple cookie? This is the best cookie you can eat in the world!"},

        new Fruit(){Name= "Coconut", ImageName="coconut.png",Sentence="Did you taste my mother's apple cookie? This is the best cookie you can eat in the world!"},

        new Fruit(){Name= "Grape", ImageName="grape.png",Sentence="Did you taste my mother's apple cookie? This is the best cookie you can eat in the world!"},

        new Fruit(){Name= "Guava", ImageName="guava.png",Sentence="Did you taste my mother's apple cookie? This is the best cookie you can eat in the world!"},

        new Fruit(){Name= "Kiwi", ImageName="kiwi.png",Sentence="Did you taste my mother's apple cookie? This is the best cookie you can eat in the world!"},

        new Fruit(){Name= "Mango", ImageName="mango.png",Sentence="Did you taste my mother's apple cookie? This is the best cookie you can eat in the world!"},

        new Fruit(){Name= "Melon", ImageName="melon.png",Sentence="Did you taste my mother's apple cookie? This is the best cookie you can eat in the world!"},

        new Fruit(){Name= "Orange", ImageName="orange.png",Sentence="Did you taste my mother's apple cookie? This is the best cookie you can eat in the world!"}
    };
	public MainPage()
	{
		InitializeComponent();
		LvFruits.ItemsSource = fruitsList;
	}

    private void LvFruits_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
       var selectedItem = e.CurrentSelection.FirstOrDefault() as Fruit;
        if (selectedItem == null) return;
        Navigation.PushAsync(new FruitDetailPage(selectedItem));
        ((CollectionView)sender).SelectedItem = null;// clear selection view highlight issue
    }

    /*private void LvFruits_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var selectedItem = e.SelectedItem as Fruit;
        if (selectedItem == null) return;
        Navigation.PushAsync(new FruitDetailPage(selectedItem));
        ((ListView)sender).SelectedItem = null;
        
    }*/
}

