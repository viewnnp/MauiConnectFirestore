using MauiConnectFirestore.Services;
using MauiConnectFirestore.ViewModels;

namespace MauiConnectFirestore;

public partial class StudentPage : ContentPage
{
	public StudentPage()
	{
		InitializeComponent();
		var firestoreService = new FirestoreService();
		BindingContext = new StudentViewModel(firestoreService);
	}
}