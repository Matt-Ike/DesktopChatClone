using DesktopChatClone.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopChatClone.MVVM.ViewModel
{
	class MainViewModel
	{
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }
		public MainViewModel()
		{
			Messages = new ObservableCollection<MessageModel>();
			Contacts = new ObservableCollection<ContactModel>();

			for(int i = 0; i < 3; i++)
			{
				Messages.Add(new MessageModel
				{
					Username = "Allison",
					UsernameColor = "#409aff",
					ImageSource = "https://unsplash.com/photos/0Zx1bDv5BNY",
					Message = $"Test-{i}",
					Time = DateTime.Now,
					IsNativeOrigin = false,
					FirstMessage = true
				});
			}

			for (int i = 0; i < 3; i++)
			{
				Messages.Add(new MessageModel
				{
					Username = "Tommy",
					UsernameColor = "#409aff",
					ImageSource = "https://unsplash.com/photos/7YVZYZeITc8",
					Message = $"Test-{i}",
					Time = DateTime.Now,
					IsNativeOrigin = false
				});
			}

			Messages.Add(new MessageModel
			{
				Username = "Tommy",
				UsernameColor = "#409aff",
				ImageSource = "https://unsplash.com/photos/7YVZYZeITc8",
				Message = $"Testing",
				Time = DateTime.Now,
				IsNativeOrigin = false
			});

			for (int i = 0; i < 5; i++)
			{
				Contacts.Add(new ContactModel
				{
					Username = $"Genevieve {i}",
					ImageSource = "https://unsplash.com/photos/Fyl8sMC2j2Q",
					Messages = Messages
				});
			}
		}
	}
}
